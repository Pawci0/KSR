package com.ksr.data_processing;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;

@AllArgsConstructor
@Getter
@Setter
public class GeneralizedNGram implements Comparer {
    private int Min;
    private int Max;

    @Override
    public double compare(String one, String two) {
        int gramCount = 0;
        int matchCount = 0;
        NGram comparer = new NGram(0);

        for(int i=Min; i<Max; i++){
            comparer.setN(i);
            gramCount += comparer.countGrams(one, two);
            matchCount += comparer.countMatchingGrams(one, two);
        }

        return (double) matchCount/gramCount;
    }
}
