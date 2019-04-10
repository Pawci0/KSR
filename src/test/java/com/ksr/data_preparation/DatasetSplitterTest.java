package com.ksr.data_preparation;

import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class DatasetSplitterTest {

    @Test
    public void split() {
        ArrayList<Article> list = new ArrayList<>();
        for(int i = 0; i < 100; i++){
            list.add(new Article());
        }
        List<List<Article>> result = DatasetSplitter.split(list, 0.7);
        assertThat(result.get(0).size()).isEqualTo(70);
        assertThat(result.get(1).size()).isEqualTo(30);
    }
}