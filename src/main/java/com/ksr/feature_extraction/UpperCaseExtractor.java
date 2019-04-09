package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;

import java.util.List;

public class UpperCaseExtractor implements Extractor {

    @Override
    public List<Double> extract(Article article) {
        double ret = 0;
        for(String word : article.getTextTokens()){
            if(word.toUpperCase().charAt(0) == word.charAt(0))
                ++ret;
        }
        return List.of(ret);
    }
}
