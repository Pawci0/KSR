package com.ksr;

import com.ksr.data_preparation.Article;
import com.ksr.data_preparation.Dataset;
import com.ksr.data_preprocessing.Trimmer;

import java.util.*;
import java.util.stream.Collectors;

public class Utils {
    public static List<String> properLabels = List.of("west-germany", "usa", "france", "uk",
            "canada", "japan", "elvis", "eminem", "queen", "sinatra", "viper");

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
        boolean ret = true;
        if(a.getPlaces().size() == 0){
            return false;
        }
        for (String place: a.getPlaces()) {
            if(!properLabels.contains(place)){
                return false;
            }
        }
        return true;
    }

    public static <K, V extends Comparable<? super V>> Map<K, V> sortByValue(Map<K, V> map) {
        List<Map.Entry<K, V>> list = new ArrayList<>(map.entrySet());
        list.sort(Map.Entry.comparingByValue());

        Map<K, V> result = new LinkedHashMap<>();
        for (Map.Entry<K, V> entry : list) {
            result.put(entry.getKey(), entry.getValue());
        }

        return result;
    }
}
