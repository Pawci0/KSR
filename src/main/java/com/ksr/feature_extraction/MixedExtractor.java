package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class MixedExtractor implements Extractor {

    private List<Extractor> extractors;

    public MixedExtractor(Extractor... extractors){
        this.extractors = Arrays.stream(extractors).collect(Collectors.toList());
    }

    public MixedExtractor(List<Extractor> extractors){
        this.extractors = extractors;
    }

    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        ArrayList<Double> result = new ArrayList<>();
        for (Extractor extractor : extractors) {
            result.addAll(extractor.extract(article, ));
        }
        return result;
    }
}
