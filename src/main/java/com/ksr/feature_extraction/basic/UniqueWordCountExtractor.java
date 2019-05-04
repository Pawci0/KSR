package com.ksr.feature_extraction.basic;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.HashSet;
import java.util.List;

public class UniqueWordCountExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        var set = new HashSet<>(article.getTextTokens());
        return List.of((double)set.size());
    }
}
