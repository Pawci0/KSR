package com.ksr.data_processing.metrics;

import java.util.List;

public class EuclideanMetric implements Metric {
    @Override
    public double calculate(List<Double> vector1, List<Double> vector2) {
        double ret = 0.0;
        for (int i = 0; i < vector1.size(); i++) {
            ret += (vector1.get(i) - vector2.get(i)) * (vector1.get(i) - vector2.get(i));
        }
        return Math.sqrt(ret);
    }
}
