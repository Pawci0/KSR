package com.ksr.data_processing.knn;

import org.apache.commons.lang3.tuple.ImmutablePair;
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;

import static org.assertj.core.api.Assertions.assertThat;

public class KNNStatisticsTest {

    private KNNStatistics statistics;

    @Before
    public void setUp() throws Exception {
        ArrayList<ImmutablePair<ClassificationObject, String>> list = new ArrayList<>();
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("positive", null),
                "positive"));
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("positive", null),
                "positive"));
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("positive", null),
                "positive"));
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("positive", null),
                "positive"));
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("positive", null),
                "negative"));
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("negative", null),
                "positive"));
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("negative", null),
                "negative"));
        list.add(new ImmutablePair<ClassificationObject, String>(new ClassificationObject("positive", null),
                "negative"));
        statistics = new KNNStatistics(list);
    }

    @Test
    public void getAcuracy() {

        assertThat(statistics.getAcuracy()).isEqualTo((double)5/8);
    }

    @Test
    public void getPrecision() {
        assertThat(statistics.getPrecision("positive")).isEqualTo((double)4/5);
    }

    @Test
    public void getRecall() {
        assertThat(statistics.getRecall("positive")).isEqualTo((double)4/6);
    }
}