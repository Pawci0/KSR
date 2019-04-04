package com.ksr.data_processing.knn;

import java.util.Vector;

public interface Metric {
    double distance(Vector<Double> one, Vector<Double> two);
}
