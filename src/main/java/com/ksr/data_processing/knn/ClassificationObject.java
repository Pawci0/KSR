package com.ksr.data_processing.knn;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class ClassificationObject {
    private String label;
    private double[] values;

    public ClassificationObject(double[] values) {
        this.values = values;
    }
}
