package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.tfidf.ExactWord;
import com.ksr.tfidf.Tfidf;
import com.ksr.tfidf.WordComparator;
import org.apache.lucene.util.CollectionUtil;

import java.util.*;
import java.util.Map.Entry;
import java.util.function.Function;
import java.util.stream.Collector;
import java.util.stream.Collectors;
import org.apache.commons.collections4.CollectionUtils;

public class ClassKeywordOccurrenceExtractor implements Extractor {

    private final Integer keywordCount;
    private LinkedHashMap<String, List<String>> classKeywords;
    private WordComparator comparator;

    public ClassKeywordOccurrenceExtractor(List<Article> trainingSet, int keywordCount){
        this.keywordCount = keywordCount;
        comparator = new ExactWord();
        Map<String, List<Article>> articlesToPlace = groupByTopics(trainingSet);
        classKeywords = extractKeywords(articlesToPlace);
    }

    public ClassKeywordOccurrenceExtractor(List<Article> trainingSet, int keywordCount, WordComparator comparator){
        this.keywordCount = keywordCount;
        this.comparator =  comparator;
        Map<String, List<Article>> articlesToPlace = groupByTopics(trainingSet);
        classKeywords = extractKeywords(articlesToPlace);
    }

    @Override
    public List<Double> extract(Article article) {
        List<String> articleKeywords = getNBestKeywords(List.of(article));
        List<Double> result = new ArrayList<>();
        classKeywords.values().forEach((labelKeywords) -> {
            int sameWordCount = CollectionUtils.intersection(labelKeywords, articleKeywords).size();
            result.add((double)sameWordCount/keywordCount);
        });
        return result;
    }

    private Map<String, List<Article>> groupByTopics(List<Article> trainingSet) {
        Map<String, List<Article>> articlesToPlace = new HashMap<>();

        trainingSet.forEach(article -> {
            article.getTopics().forEach(topic -> {
                if(!articlesToPlace.containsKey(topic)){
                    articlesToPlace.put(topic, new ArrayList<>());
                }
                articlesToPlace.get(topic).add(article);
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
