package com.ksr.feature_extraction.basic;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class LabelOccurenceExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        double counter = article.getTextTokens().stream().filter(e -> e.equals(article.getPlaces().get(0))).count();
        return List.of(counter);
    }
}
