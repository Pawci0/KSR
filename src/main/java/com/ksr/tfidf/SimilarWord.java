package com.ksr.tfidf;

import com.ksr.data_processing.Similarity;

public class SimilarWord implements WordComparator {

    private Similarity similarity;
    private double similarityValue;

    public SimilarWord(Similarity similarity, double similarityValue){
        this.similarity = similarity;
        this.similarityValue = similarityValue;
    }


    @Override
    public boolean test(String word1, String word2) {
        return similarity.compare(word1, word1) > similarityValue;
    }

    @Override
    public int compare(String word1, String word2) {
        if(test(word1, word2)){
            return 0;
        }
        return word1.compareTo(word2);
    }
}
