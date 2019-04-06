package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.tfidf.Tfidf;
import com.ksr.tfidf.WordComparator;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Map;

public class WeightKeywordExtractor implements Extractor {

    private Map<String, Double> keywords;
    private List<Article> articleList;
    private WordComparator comparator;

    public WeightKeywordExtractor(Map<String, Double> keywords, List<Article> articleList){
        this.keywords = keywords;
        this.articleList = articleList;
        comparator = new WordComparator();
    }

    public WeightKeywordExtractor(Map<String, Double> keywords, List<Article> articleList, WordComparator comparator){
        this.keywords = keywords;
        this.articleList = articleList;
        this.comparator = comparator;
    }

    @Override
    public List<Double> extract(Article article) {
        ArrayList<Double> ret = new ArrayList<>();

        double count = 0;
        for (String keyword : keywords.keySet()){
            for (String token : article.getTextTokens()){
                if(keyword.equals(token)){
                    ++count;
                }
            }
            ret.add( keywords.get(keyword)*( count / article.getTextTokens().size() ) * Tfidf.idf(articleList, comparator).get(keyword));
            count = 0;
        }
        return ret;
    }
}
