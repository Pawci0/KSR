package com.ksr.data_processing;

public class GeneralisedNGram implements Similarity {

    private int min;
    private int max;
    private NGram nGram;

    public GeneralisedNGram(int min, int max){
        this.min = min;
        this.max = max;
        this.nGram = new NGram(-1);
    }

    @Override
    public double compare(String a, String b) {
        int nGramsCount = 0;
        int matchingCount = 0;
        for(int n = min; n <= max; n++){
            nGram.setN(n);
            nGramsCount += nGram.countNGrams(a, b);
            matchingCount += nGram.countMatchingNGrams(a, b);
        }
        return (double)matchingCount/nGramsCount;
    }

    public void setLimits(int min, int max){
        this.min = min;
        this.max = max;
    }
}
