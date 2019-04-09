package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;

import java.util.HashSet;
import java.util.List;

public class UniqueWordCountExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article) {
        var set = new HashSet<>(article.getTextTokens());
        return List.of((double)set.size());
    }
}
