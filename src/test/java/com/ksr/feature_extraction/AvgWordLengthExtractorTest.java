package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import org.junit.Test;

import static org.junit.Assert.*;
import static org.assertj.core.api.Assertions.assertThat;

public class AvgWordLengthExtractorTest {

    @Test
    public void extract() {
        Article a = new Article("title", "this is the text of the article", null, null);
        Extractor extractor = new AvgWordLengthExtractor();
        Double outcome = extractor.extract(a).get(0);
        assertThat(outcome).isEqualTo(25.0/7);
    }
}
