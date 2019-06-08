package com.ksr.data_preprocessing;

import org.tartarus.snowball.ext.PorterStemmer;

import java.util.List;
import java.util.stream.Collectors;

public class Stemmer implements Trimmer {
    static PorterStemmer stemmer = new PorterStemmer();

    public String trim(String input){
        stemmer.setCurrent(input);
        stemmer.stem();
        return stemmer.getCurrent();
    }

    public List<String> trim(List<String> input){
        return input.stream()
                .map(this::trim)
                .collect(Collectors.toList());
    }

}
