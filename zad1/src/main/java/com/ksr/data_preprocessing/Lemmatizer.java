package com.ksr.data_preprocessing;

import edu.stanford.nlp.simple.Sentence;

import java.util.List;
import java.util.stream.Collectors;

public class Lemmatizer implements Trimmer
{
    public String trim(String word){
        return new Sentence(word).lemma(0);
    }

    public List<String> trim(List<String> words){
        return words.stream()
                .map(this::trim)
                .collect(Collectors.toList());
    }
}
