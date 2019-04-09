package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.data_processing.knn.ClassificationObject;
import com.ksr.tfidf.Tfidf;

import java.util.*;
import java.util.Map.Entry;
import java.util.stream.Collectors;

public class ClassKeywordOccurrenceExtractor implements Extractor {

    private final Integer keywordCount;
    private Map<String, List<String>> keywordsToPlace;

    public ClassKeywordOccurrenceExtractor(List<Article> trainingSet, int keywordCount){
        this.keywordCount = keywordCount;
        Map<String, List<Article>> articlesToPlace = groupByTopics(trainingSet);
        keywordsToPlace = extractKeywords(articlesToPlace);
    }

    @Override
    public List<Double> extract(Article article) {
        return null;
    }

    private Map<String, List<Article>> groupByTopics(List<Article> trainingSet) {
        Map<String, List<Article>> articlesToPlace = new HashMap<>();

        trainingSet.forEach(article -> {
            article.getTopics().forEach(topic -> {
                if(!articlesToPlace.containsKey(topic)){
                    articlesToPlace.put(topic, new ArrayList<>());
                }else {
                    articlesToPlace.get(topic).add(article);
                }
            });
        });

        return articlesToPlace;
    }

    private Map<String, List<String>> extractKeywords(Map<String, List<Article>> articlesToPlace) {
        return articlesToPlace.entrySet().stream()
                .map(this::getKeywordsAsEntry)
                .collect(Collectors.toMap(Entry::getKey, Entry::getValue));

    }

    private Entry<String, List<String>> getKeywordsAsEntry(Entry<String, List<Article>> placeArticlesEntry) {
        String label = placeArticlesEntry.getKey();
        List<Article> articles = placeArticlesEntry.getValue();
        List<String> keywords = getNBestKeywords(articles);
        return new HashMap.SimpleEntry<>(label, keywords);
    }

    private List<String> getNBestKeywords(List<Article> articles) {
        var idf = Tfidf.idf(articles);
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
