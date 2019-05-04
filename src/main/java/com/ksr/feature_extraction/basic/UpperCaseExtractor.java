package com.ksr.feature_extraction.basic;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class UpperCaseExtractor implements Extractor {

    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        double ret = 0;
        for(String word : article.getTextTokens()){
            if(word.isEmpty()){
                continue;
            }
            if(word.toUpperCase().charAt(0) == word.charAt(0))
                ++ret;
        }
        return List.of(ret);
    }
}
