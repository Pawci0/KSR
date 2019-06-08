package com.ksr.feature_extraction.keyword;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class HowManyTimesKeywordsAppeared implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        double counter = article.getTextTokens().stream()
                .filter(keywords::contains)
                .count();
        return List.of(counter);
    }
}
