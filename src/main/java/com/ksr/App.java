package com.ksr;

import com.ksr.data_preparation.SGMConverter;
import com.ksr.data_preprocessing.Lemmatizer;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Arrays;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws FileNotFoundException {
        System.out.println("Read articles test:");
        File file = new File("src/main/resources/reut2-000.sgm");
        SGMConverter.convert(file);
    }
}
