package com.ksr.data_processing;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;
import lombok.experimental.Accessors;

@AllArgsConstructor
@Getter
@Setter
public class NGram implements Comparer {

    private int N;

    @Override
    public double compare(String one, String two) {
        int matchingGrams = countMatchingGrams(one, two);
        int numberOfGrams = countGrams(one, two);

        return (double)matchingGrams/numberOfGrams;
    }

    public int countGrams(String one, String two) {
        return Integer.max(one.length(), two.length()) - N + 1;
    }

    public int countMatchingGrams(String one, String two) {
        int oneGramCount = one.length() - N + 1;

        int matchCounter = 0;

        for(int i=0; i<oneGramCount; i++){
            String gram = one.substring(i, i + N);
            if(two.contains(gram)){
                matchCounter ++;
            }
        }
        
        return matchCounter;

    }
}
