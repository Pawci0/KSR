package com.ksr.data_preprocessing;

import edu.stanford.nlp.simple.Sentence;

import java.util.List;
import java.util.stream.Collectors;

public class Lemmatizer
{
    public static String lemma(String word){
        return new Sentence(word).lemma(0);
    }

    public static List<String> lemma(List<String> words){
        return words.stream().map(Lemmatizer::lemma).collect(Collectors.toList());
    }
}
