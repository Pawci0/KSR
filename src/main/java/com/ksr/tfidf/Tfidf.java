package com.ksr.tfidf;

import com.ksr.data_preparation.Article;

import java.util.*;
import java.util.stream.Collectors;

public class Tfidf {

    public static Map<String, Double> idf(List<Article> articleList){
        return idf(articleList, new WordComparator());
    }

    public static Map<String, Double> idf(List<Article> articleList, int results){
        return getNTopValues(articleList, new WordComparator(), results);
    }

    public static Map<String, Double> idf(List<Article> articleList, WordComparator comparator){
        TreeMap<String, Double> idfMap = new TreeMap<String, Double>(comparator);
        int documentCount = 0;
        for(Article article : articleList){
            documentCount++;
            for(String word : article.getTextTokens()){
                double count = idfMap.getOrDefault(word, 0.);
                count = Double.min(count + 1, documentCount);
                idfMap.put(word, count);
            }
        }

        for(Map.Entry<String, Double> wordCount : idfMap.entrySet()){
            idfMap.replace(wordCount.getKey(), Math.log(documentCount/wordCount.getValue()));
        }
        return idfMap;
    }

    public static Map<String, Double> idf(List<Article> articleList, WordComparator comparator, int results){
        return getNTopValues(articleList, comparator, results);
    }

    public static Map<String, Double> idf(List<Article> articleList, CaseComparator comparator){
        TreeMap<String, Double> idfMap = new TreeMap<>(comparator);
        int documentCount = 0;
        for (Article article : articleList) {
            documentCount++;

            for (String word : article.getTextTokens()) {
                String letterCase = word.toUpperCase().charAt(0) == word.charAt(0) ? "upper" : "lower";
                double count = idfMap.getOrDefault(letterCase, 0.);
                count = Double.min(count + 1, documentCount);
                idfMap.put(letterCase, count);
            }
        }

        for (Map.Entry<String, Double> wordCount : idfMap.entrySet()) {
            idfMap.replace(wordCount.getKey(), Math.log(documentCount / wordCount.getValue()));
        }
        return idfMap;
    }

    private static Map<String, Double> getNTopValues(List<Article> articles, WordComparator comparator, int results) {
        Map<String, Double> idfs = idf(articles, comparator);
        SortedSet<Map.Entry<String, Double>> sortedIdfs = new TreeSet<>(Comparator.comparing(Map.Entry::getValue));
        sortedIdfs.addAll(idfs.entrySet());
        final Map<String, Double> result = sortedIdfs.stream().skip(sortedIdfs.size() - results).collect(Collectors.toMap(Map.Entry::getKey, Map.Entry::getValue));
        return result;
    }
}
