package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.tfidf.Tfidf;
import com.ksr.tfidf.WordComparator;

import java.util.List;
import java.util.Map;

public class DatasetIDF {

    private static DatasetIDF instance = null;

    private static Map<String, Double> idfs;

    private DatasetIDF(List<Article> articleList) {
        idfs = Tfidf.idf(articleList);
    }

    private DatasetIDF(List<Article> articleList, WordComparator comparator) {
        idfs = Tfidf.idf(articleList, comparator);
    }

    public static DatasetIDF getInstance() {
        return instance;
    }

    public static void createInstance(List<Article> articleList){
        if(instance == null){
            instance = new DatasetIDF(articleList);
        }

    }

    public static void createInstance(List<Article> articleList, WordComparator comparator){
        if(instance == null){
            instance = new DatasetIDF(articleList, comparator);
        }
    }

    public static void clearIdf(){
        instance = null;
        idfs.clear();
    }

    public double getIdf(String word){
        return idfs.get(word);
    }
}
