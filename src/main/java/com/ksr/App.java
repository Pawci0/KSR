package com.ksr;

import com.ksr.data_preprocessing.Lemmatizer;

import java.util.Arrays;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        System.out.println( Lemmatizer.lemma(Arrays.asList("studying", "studies", "demanding")) );
    }
}
