package com.ksr.data_processing.knn;

import lombok.AllArgsConstructor;
import org.apache.commons.math3.ml.distance.DistanceMeasure;

import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.function.Function;
import java.util.stream.Collectors;

@AllArgsConstructor
public class KNNClassifier {
    final int count;
    final List<ClassificationObject> dataSet;
    final DistanceMeasure metric;

    public String classify(ClassificationObject object){
        Map<ClassificationObject, Double> distances = new HashMap<>();

        for (ClassificationObject data: dataSet) {
            Double distance = metric.compute(object.getValues(), data.getValues());
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
