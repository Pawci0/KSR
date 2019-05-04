package com.ksr.feature_extraction.basic;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class AvgWordLengthExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        double average = article.getTextTokens().stream()
                        .mapToDouble(String::length)
                        .average()
                        .orElse(0);

        return List.of(average);
    }
}
