package com.ksr.feature_extraction.keyword;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class AnyKeywordAppeared implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        boolean anyKeywordApperared = article.getTextTokens().stream().anyMatch(k->{
            if(keywords.contains(k)){
                return true;
            }
            return false;
        });
        return anyKeywordApperared ? List.of(1.0) : List.of(0.0);
    }
}
