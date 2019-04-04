package com.ksr.data_processing.knn;

import lombok.Data;

import java.util.Vector;

@Data
public class ClassificationObject {
    private final String label;
    private final Vector<Double> values;
}
