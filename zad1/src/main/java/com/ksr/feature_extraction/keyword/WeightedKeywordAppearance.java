package com.ksr.feature_extraction.keyword;

import com.google.common.collect.Lists;
import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;

import java.util.List;

public class WeightedKeywordAppearance implements Extractor {

    final static double FIRST_WEIGHT = 1;
    final static double SECOND_WEIGHT = 0.6;
    final static double THIRD_WEIGHT = 0.3;


    @Override
    public List<Double> extract(Article article, List<String> keywords) {
        List<String> words = article.getTextTokens();
        List<List<String>> partitionedList = Lists.partition(words, words.size() / 3 + 1);
        double value = 0;

        if(partitionedList.size() == 3){
            value += getKeywordCount(partitionedList.get(0), keywords) * FIRST_WEIGHT;
            value += getKeywordCount(partitionedList.get(1), keywords) * SECOND_WEIGHT;
            value += getKeywordCount(partitionedList.get(2), keywords) * THIRD_WEIGHT;
        }else{
            value = getKeywordCount(words, keywords);
        }

        return List.of(value);
    }

    private long getKeywordCount(List<String> words, List<String> keywords){
        return words.stream()
                .filter(keywords::contains)
                .count();
    }
}
