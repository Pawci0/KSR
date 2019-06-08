package com.ksr.feature_extraction.keyword;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.Collections;
import java.util.List;
import java.util.Map;
import java.util.function.Function;

import static java.util.stream.Collectors.groupingBy;
import static java.util.stream.Collectors.summingDouble;

public class MostCommonKeywordOccurences implements Extractor {
    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        Map<String, Double> collect =
                article.getTextTokens().stream().filter(keywords::contains).collect(groupingBy(Function.identity(), summingDouble(e -> 1)));
        if(collect.values().isEmpty())
            return List.of(0.0);
        return List.of(Collections.max(collect.values()));
    }
}
