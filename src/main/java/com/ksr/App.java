package com.ksr;

import com.ksr.data_preparation.Article;
import com.ksr.data_preparation.Dataset;
import com.ksr.data_preparation.SGMConverter;
import com.ksr.data_preparation.TextTokenizer;
import com.ksr.data_preprocessing.Lemmatizer;
import com.ksr.data_preprocessing.Stemmer;
import com.ksr.data_preprocessing.StopWordsUtil;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Arrays;

import static com.ksr.data_preprocessing.StopWordsUtil.*;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws FileNotFoundException {
        System.out.println("Read articles test:");
        Dataset dataset = new Dataset("src/test/resources");
        Stemmer stemmer = new Stemmer();
        for (Article article :
                dataset.getArticles()) {
            filter(article.getTextTokens(), english());
            filter(article.getTitleTokens(), english());
            stemmer.trim(article.getTextTokens());
            stemmer.trim(article.getTitleTokens());
        }
        // wyznacz wektor cech
    }
}
