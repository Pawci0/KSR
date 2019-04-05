package com.ksr.data_processing.knn;

import org.apache.commons.math3.ml.distance.EuclideanDistance;
import org.assertj.core.util.Arrays;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.*;


public class KNNClassifierTest {

    @Test
    public void shouldClassifyCorrectly() {
        double[] one = {1, 1};
        double[] two = {-1, -1};
        double[] three = {0, -2};
        double[] toClassify = {1, 0};

        ClassificationObject objectOne = new ClassificationObject("one", one);
        ClassificationObject objectTwo = new ClassificationObject("two", two);
        ClassificationObject objectThree = new ClassificationObject("two", three);
        ClassificationObject objectToClassify = new ClassificationObject(toClassify);

        KNNClassifier classifier = new KNNClassifier(2, List.of(objectOne, objectTwo, objectThree), new EuclideanDistance());

        String result = classifier.classify(objectToClassify);

        assertThat(result).isEqualTo("one");
    }
}
