package com.ksr.tfidf;

public class ExactWord implements WordComparator {

    @Override
    public boolean test(String s, String s2) {
        return s.equals(s2);
    }

    @Override
    public int compare(String o1, String o2) {
        return test(o1, o2) ? 1 : 0;
    }
}
