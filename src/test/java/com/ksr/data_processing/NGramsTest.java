package com.ksr.data_processing;

import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;


public class NGramsTest {

    @Test
    public void shouldCountNGrams() {
        String one = "rabin";
        String two = "karabin";

        Similarity comparer = new NGram(3);

        Double outcome = comparer.compare(one, two);

        assertThat(outcome).isEqualTo(0.6);
    }

    @Test
    public void shouldCountAllNGrams(){
        String one = "rabin";
        String two = "karabin";

        Similarity comparer = new GeneralizedNGram(3, 5);

        Double outcome = comparer.compare(one, two);

        assertThat(outcome).isEqualTo(5.0/9);
    }
}
