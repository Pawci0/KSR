package com.ksr.data_preparation;

import org.junit.Test;

import java.util.Arrays;
import java.util.List;

import static com.ksr.data_preparation.TextTokenizer.*;
import static org.assertj.core.api.Assertions.assertThat;

public class TextTokenizerTest {

    @Test
    public void textShouldTokenize(){
        String text = "Sentence, one. Sentence two.";
        List<Object> expected = Arrays.asList("Sentence", "one", "Sentence", "two");
        var outcome = tokenize(text);
        assertThat(outcome).isEqualTo(expected);
    }

    @Test
    public void shouldLowercaseAllLetters(){
        String text = "Sentence, one. Sentence two.";
        List<Object> expected = Arrays.asList("sentence", "one", "sentence", "two");
        var outcome = tokenizeLowerCase(text);
        assertThat(outcome).isEqualTo(expected);
    }

    @Test
    public void shouldSaveProperNouns(){
        String text = "Sentence, One. Sentence two.";
        List<Object> expected = Arrays.asList("sentence", "One", "sentence", "two");
        var outcome = tokenizeLowerCaseWithProperNouns(text);
        assertThat(outcome).isEqualTo(expected);
    }

}
