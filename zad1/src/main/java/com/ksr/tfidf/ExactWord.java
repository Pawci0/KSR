package com.ksr.tfidf;

public class ExactWord implements WordComparator {

    @Override
    public boolean test(String s, String s2) {
        return s.equals(s2);
    }

    @Override
    public int compare(String word1, String word2) {
        return word1.compareTo(word2);    }
}
