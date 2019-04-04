package com.ksr.data_processing.knn;

import lombok.AllArgsConstructor;

import java.util.*;
import java.util.function.Function;
import java.util.stream.Collectors;
import java.util.stream.Stream;

@AllArgsConstructor
public class KNNClassifier {
    final int count;
    final List<ClassificationObject> dataSet;
    final Metric metric;

    public String classify(ClassificationObject object){
        Map<ClassificationObject, Double> distances = new HashMap<>();

        for (ClassificationObject data: dataSet) {
            Double distance = metric.distance(object.getValues(), data.getValues());
            distances.put(data, distance);
        }

        Map<String, Long> x = distances.entrySet().stream()
                                        .sorted(Map.Entry.comparingByValue())
                                        .map(Map.Entry::getKey)
                                        .limit(count)
                                        .map(ClassificationObject::getLabel)
                                        .collect(Collectors.groupingBy(Function.identity(), Collectors.counting()));

        return Collections.max(x.entrySet(), Map.Entry.comparingByValue()).getKey();
    }
}
