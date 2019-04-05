package com.ksr.data_preparation;

import org.junit.Before;
import org.junit.Test;

import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;
import org.assertj.core.util.Lists;

public class DatasetTest {

    Dataset dataset;

    @Before
    public void setUp() throws Exception {
        dataset = new Dataset("src/test/resources");
    }

    @Test
    public void shouldCreateCorrectly(){
        assertThat(dataset.getArticles()).isNotEqualTo(Lists.emptyList());
        assertThat(dataset.getDirectoryPath()).isEqualTo("src/test/resources");
    }

    @Test
    public void shouldHaveEmptyListIfDirectoryBad(){
        dataset.setDirectoryPath("");
        assertThat(dataset.getArticles()).isEqualTo(Lists.emptyList());
    }
}
