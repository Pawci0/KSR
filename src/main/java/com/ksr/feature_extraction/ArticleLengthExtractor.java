package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;

import java.util.List;

public class ArticleLengthExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article) {
        return List.of((double)article.getTextTokens().size());
    }
}
