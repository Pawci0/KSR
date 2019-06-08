package com.ksr.data_processing.metrics;

import java.util.List;

public interface Metric {

        double calculate(List<Double> vector1, List<Double> vector2);
}
