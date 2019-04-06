package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.tfidf.CaseComparator;
import com.ksr.tfidf.Tfidf;

import java.util.ArrayList;
import java.util.List;

public class CapitalExtractor implements Extractor {

    private List<Article> articleList;

    public CapitalExtractor(List<Article> articleList){
        this.articleList = articleList;
    }

    @Override
    public List<Double> extract(Article article) {
        ArrayList<Double> result = new ArrayList<>();

        double appearances = 0;
        for (String word : article.getTextTokens()) {
            if (word.toUpperCase().charAt(0) == word.charAt(0)) {
                appearances++;
            }
        }
        result.add(( appearances / article.getTextTokens().size()) * Tfidf.idf(articleList, new CaseComparator()).get("upper"));

        return result;
    }
}
