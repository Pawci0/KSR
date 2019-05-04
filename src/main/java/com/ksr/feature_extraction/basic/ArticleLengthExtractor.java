package com.ksr.feature_extraction.basic;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class ArticleLengthExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        return List.of((double)article.getTextTokens().size());
    }
}
