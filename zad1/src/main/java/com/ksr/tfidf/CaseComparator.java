package com.ksr.tfidf;

import java.util.Comparator;
import java.util.function.BiPredicate;

public class CaseComparator implements BiPredicate<String, String>, Comparator<String> {
    @Override
    public boolean test(String s, String s2) {
        return (s.toUpperCase().charAt(0) == s.charAt(0) && s2.toUpperCase().charAt(0) == s2.charAt(0)) ||
                (s.toLowerCase().charAt(0) == s.charAt(0) && s2.toLowerCase().charAt(0) == s2.charAt(0));
    }

    @Override
    public int compare(String o1, String o2) {
        return test(o1, o2) ? 0 : 1;
    }
}
