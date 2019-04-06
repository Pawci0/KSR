package com.ksr.data_processing.metrics;

import java.util.List;

public class CzebyszewMetric implements Metric {
    @Override
    public double calculate(List<Double> vector1, List<Double> vector2) {
        double ret = 0;
        double distance = 0;
        for (int i = 0; i < vector1.size(); i++){
            distance = Math.abs(vector1.get(i) - vector2.get(i));
            if(distance > ret)
                ret = distance;
        }
        return ret;
    }
}
