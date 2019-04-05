package com.ksr.data_processing;

import lombok.AllArgsConstructor;
import lombok.Getter;

@AllArgsConstructor
@Getter
public class NGram implements Comparer {

    private final int N;

    @Override
    public double compare(String one, String two) {
        int matchingGrams = countMatchingGrams(one, two);
        int numberOfGrams = countGrams(one, two);

        return (double)matchingGrams/numberOfGrams;
    }

    private int countGrams(String one, String two) {
        return Integer.max(one.length(), two.length()) - N + 1;
    }

    private int countMatchingGrams(String one, String two) {
        int oneGramCount = one.length() - N + 1;

        int gramCounter = 0;

        for(int i=0; i<oneGramCount; i++){
            String gram = one.substring(i, i + N);
            if(two.contains(gram)){
                gramCounter ++;
            }
        }
        
        return gramCounter;

    }
}
