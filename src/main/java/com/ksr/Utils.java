package com.ksr;

import com.ksr.data_preparation.Article;
import com.ksr.data_preparation.Dataset;
import com.ksr.data_preprocessing.Stemmer;
import com.ksr.data_preprocessing.Trimmer;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

public class Utils {
    private static List<String> properLabels = List.of("west-germany", "usa", "france", "uk",
            "canada", "japan");

    static List<Article>  normalizeData(List<Article> articleList){
        HashMap<String, Integer> classCounter = new HashMap<>();
        List<Article> normalizedArticles = new ArrayList<>();
        articleList.forEach(a ->{
            if(!a.getPlaces().get(0).equals("usa")){
                classCounter.put(a.getPlaces().get(0), classCounter.getOrDefault(a.getPlaces().get(0), 0)+1);
                normalizedArticles.add(a);
            }
        });
        int maxClassValue = Collections.max(classCounter.values());
        int counter = 0, it = 0;
        while(counter < maxClassValue && it < articleList.size()){
            ++it;
            if(articleList.get(it).getPlaces().get(0).equals("usa")){
                normalizedArticles.add(articleList.get(it));
                ++counter;
            }
        }
        return normalizedArticles;
    }

    static List<Article> validateAndPrepareArticles(Dataset dataset, Trimmer trimmer) {
        List<Article> articles = dataset.getArticles().stream()
                .filter(Utils::validateArticle)
                .collect(Collectors.toList());

        articles.forEach(a->{
            a.filter();
            a.trim(trimmer);
        });
        return articles;
    }

    private static boolean validateArticle(Article a) {
        return a.getPlaces().size() == 1 && properLabels.contains(a.getPlaces().get(0));
    }
}
