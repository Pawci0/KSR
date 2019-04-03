package com.ksr.data_preprocessing;

import org.tartarus.snowball.ext.PorterStemmer;

import java.util.List;
import java.util.stream.Collectors;

public class Stemmer {
    static PorterStemmer stemmer = new PorterStemmer();

    public static String stem(String input){
        stemmer.setCurrent(input);
        stemmer.stem();
        return stemmer.getCurrent();
    }

    public static List<String> stem(List<String> input){
        return input.stream().map(Stemmer::stem).collect(Collectors.toList());
    }

}
