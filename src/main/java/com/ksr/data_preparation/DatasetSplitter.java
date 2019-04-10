package com.ksr.data_preparation;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class DatasetSplitter {
    public static  List<List<Article>> split(List<Article> list, double trainingSetPercentage){
        int splitPoint = (int)(list.size() * trainingSetPercentage);
        Collections.shuffle(list);
        List<List<Article>> result = new ArrayList<>();
        result.add(list.subList(0, splitPoint));
        result.add(list.subList(splitPoint, list.size()));
        return result;
    }
}
