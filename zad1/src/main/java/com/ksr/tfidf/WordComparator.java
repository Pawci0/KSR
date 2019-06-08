package com.ksr.tfidf;

import java.util.Comparator;
import java.util.function.BiPredicate;

public interface WordComparator extends BiPredicate<String, String>, Comparator<String> {
    @Override
    boolean test(String s, String s2);

    @Override
    int compare(String o1, String o2);
}
