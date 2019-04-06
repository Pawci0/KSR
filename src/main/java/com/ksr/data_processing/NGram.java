package com.ksr.data_processing;

public class NGram implements Similarity {

    public NGram(int n){
        this.n = n;
    }

    @Override
    public double compare(String a, String b) {
        return (double)countMatchingNGrams(a, b)/countNGrams(a, b);
    }

    protected int countMatchingNGrams(String a, String b){
        int maxI = a.length() - n + 1;
        int maxJ = b.length() - n + 1;
        int count = 0;
        for(int i=0; i<maxI; i++){
            String nGram = a.substring(i, i+n);
            for (int j=0; j<maxJ; j++){
                if(nGram.equals(b.substring(j, j+n))){
                    count++;
                    break;
                }
            }
        }
        return count;
    }

    protected int countNGrams(String a, String b){
        return Integer.max(a.length(), b.length()) - n + 1;
    }

    public int getN() {
        return n;
    }

    public void setN(int n) {
        this.n = n;
    }

    private int n;
}
