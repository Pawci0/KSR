package com.ksr.data_processing;

import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;


public class NGramTest {

    @Test
    public void shouldCountNGrams() {
        String one = "rabin";
        String two = "karabin";

        NGram comparer = new NGram(3);

        Double outcome = comparer.compare(one, two);

        assertThat(outcome).isEqualTo(0.6);

    }
}
