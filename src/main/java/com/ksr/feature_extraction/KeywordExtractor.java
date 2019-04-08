package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.data_preparation.TextTokenizer;
import com.ksr.tfidf.Tfidf;
import com.ksr.tfidf.WordComparator;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;

public class KeywordExtractor implements Extractor {

    private HashSet<String> keywords;
    private List<Article> articleList;
    private WordComparator comparator;

    public KeywordExtractor(List<String> keywords, List<Article> articleList){
        this.keywords = new HashSet<>(keywords);
        this.articleList = articleList;
        comparator = new WordComparator();
    }

    public KeywordExtractor(List<String> keywords, List<Article> articleList, WordComparator comparator){
        this.keywords = new HashSet<>(keywords);
        this.articleList = articleList;
        this.comparator = comparator;
    }

    @Override
    public List<Double> extract(Article article) {
        ArrayList<Double> ret = new ArrayList<>();

        double count = 0;
        for (String keyword : keywords){
            for (String token : article.getTextTokens()){
                if(keyword.equals(token)){
                    ++count;
                }
            }
            ret.add( ( count / article.getTextTokens().size() ) * Tfidf.idf(articleList, comparator).get(keyword));
            count = 0;
        }
        return ret;
    }
}