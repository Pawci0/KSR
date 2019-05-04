package com.ksr.feature_extraction.keyword;

import com.ksr.data_preparation.Article;
import com.ksr.data_processing.GeneralizedNGram;
import com.ksr.feature_extraction.Extractor;
import com.ksr.tfidf.SimilarWord;
import com.ksr.tfidf.Tfidf;
import com.ksr.tfidf.WordComparator;

import java.util.*;
import java.util.Map.Entry;
import java.util.stream.Collector;
import java.util.stream.Collectors;
import org.apache.commons.collections4.CollectionUtils;

public class ClassKeywordOccurrenceExtractor implements Extractor {

    private final Integer keywordCount;
    private LinkedHashMap<String, List<String>> classKeywords;
    private WordComparator comparator;

    public ClassKeywordOccurrenceExtractor(List<Article> trainingSet, int keywordCount){
        this.keywordCount = keywordCount;
//        comparator = new SimilarWord(new GeneralizedNGram(2,4), 0.7);
        comparator = new SimilarWord(new GeneralizedNGram(2,5), 0.7);
        Map<String, List<Article>> articlesToPlace = groupByPlaces(trainingSet);
        classKeywords = extractKeywords(articlesToPlace);
    }

    public ClassKeywordOccurrenceExtractor(List<Article> trainingSet, int keywordCount, WordComparator comparator){
        this.keywordCount = keywordCount;
        this.comparator =  comparator;
        Map<String, List<Article>> articlesToPlace = groupByPlaces(trainingSet);
        classKeywords = extractKeywords(articlesToPlace);
    }

    @Override
    public List<Double> extract(Article article, List<String> keywords) {
//        List<String> articleKeywords = getNBestKeywords(List.of(article));
        List<Double> result = new ArrayList<>();
        classKeywords.values().forEach((labelKeywords) -> {
            int sameWordCount = CollectionUtils.intersection(labelKeywords, article.getTextTokens()).size();
            result.add((double)sameWordCount/keywordCount);
        });
        return result;
    }

    private Map<String, List<Article>> groupByPlaces(List<Article> trainingSet) {
        Map<String, List<Article>> articlesToPlace = new HashMap<>();

        trainingSet.forEach(article -> {
            article.getPlaces().forEach(place -> {
                if(!articlesToPlace.containsKey(place)){
                    articlesToPlace.put(place, new ArrayList<>());
                }
                articlesToPlace.get(place).add(article);
            });
        });

        return articlesToPlace;
    }

    private LinkedHashMap<String, List<String>> extractKeywords(Map<String, List<Article>> articlesToPlace) {
        return articlesToPlace.entrySet().stream()
                .map(this::getKeywordsAsEntry)
                .collect(toLinkedHashMap());
    }

    private Collector<Entry<String, List<String>>, ?, LinkedHashMap<String, List<String>>> toLinkedHashMap() {
        return Collectors.toMap(Entry::getKey,
                                Entry::getValue,
                                (u, v) -> {
                                    throw new IllegalStateException(String.format("Duplicate key %s", u));
                                },
                                LinkedHashMap::new);
    }

    private Entry<String, List<String>> getKeywordsAsEntry(Entry<String, List<Article>> placeArticlesEntry) {
        String label = placeArticlesEntry.getKey();
        List<Article> articles = placeArticlesEntry.getValue();
        List<String> keywords = getNBestKeywords(articles);
        return new HashMap.SimpleEntry<>(label, keywords);
    }

    private List<String> getNBestKeywords(List<Article> articles) {
        var idf = Tfidf.idf(articles, comparator);
        if (idf != null) {
            return idf.entrySet().stream()
                                        .sorted(Entry.comparingByValue())
                                        .map(Entry::getKey)
                                        .limit(keywordCount)
                                        .collect(Collectors.toList());
        }
        return Collections.emptyList();
    }
}
