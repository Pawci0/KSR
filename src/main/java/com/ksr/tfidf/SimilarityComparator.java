package com.ksr.tfidf;

import com.ksr.data_processing.Similarity;

public class SimilarityComparator extends WordComparator {

    private Similarity similarity;
    private double similarityValue;

    public SimilarityComparator(Similarity similarity, double similarityValue){
        this.similarity = similarity;
        this.similarityValue = similarityValue;
    }


    @Override
    public int compare(String o1, String o2) {
        return test(o1, o2) ? 1 : 0;
    }

    @Override
    public boolean test(String s, String s2) {
        return similarity.compare(s, s2) >= similarityValue;
    }
}
