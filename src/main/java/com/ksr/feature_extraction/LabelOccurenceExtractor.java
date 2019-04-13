package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;

import java.util.List;

public class LabelOccurenceExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article) {
        double counter = article.getTextTokens().stream().filter(e -> e.equals(article.getPlaces().get(0))).count();
        return List.of(counter);
    }
}
