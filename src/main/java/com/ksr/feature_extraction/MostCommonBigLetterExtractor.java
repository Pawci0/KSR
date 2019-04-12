package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;

import java.util.List;
import java.util.stream.Collectors;

import org.jooq.lambda.*;

public class MostCommonBigLetterExtractor implements Extractor {
    @Override
    public List<Double> extract(Article article) {
        List<Double> asciiValueList = article.getTextTokens().stream()
                                    .filter(word -> !word.isEmpty() && Character.isUpperCase(word.charAt(0)))
                                    .map(word -> word.charAt(0))
                                    .map(y->(double)y)
                                    .collect(Collectors.toList());


        return List.of(getMode(asciiValueList));
    }

    private Double getMode(List<Double> asciiValueList) {
        if(asciiValueList.size() == 1){
            return asciiValueList.get(0);
        }
        var seq = Seq.of((Double) null).concat(asciiValueList);
        return seq.mode().orElse(0.0);
    }
}
