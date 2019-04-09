package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;

import java.util.List;

public class AvgWordLengthExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article) {
        double average = article.getTextTokens().stream()
                        .mapToDouble(String::length)
                        .average()
                        .orElse(0);

        return List.of(average);
    }
}
