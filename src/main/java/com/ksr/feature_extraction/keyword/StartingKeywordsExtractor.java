package com.ksr.feature_extraction.keyword;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class StartingKeywordsExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        double total = article.getTextTokens().stream()
                .filter(keywords::contains)
                .count();
        if(article.getTextTokens().size() < 20)
            return List.of(0.0);
        double atStart = article.getTextTokens().subList(0, 20).stream()
                .filter(keywords::contains)
                .count();
        return List.of(atStart/total);
    }
}
