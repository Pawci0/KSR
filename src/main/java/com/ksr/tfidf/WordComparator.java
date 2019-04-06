package com.ksr.tfidf;

import java.util.Comparator;
import java.util.function.BiPredicate;

public class WordComparator implements BiPredicate<String, String>, Comparator<String> {
    @Override
    public boolean test(String s, String s2) {
        return s.equals(s2);
    }

    @Override
    public int compare(String o1, String o2) {
        return test(o1, o2) ? 1 : 0;
    }
}
