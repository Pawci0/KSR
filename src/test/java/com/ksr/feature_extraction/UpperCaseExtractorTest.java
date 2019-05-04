package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.basic.UpperCaseExtractor;
import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class UpperCaseExtractorTest {

    @Test
    public void extract() {
        Article article = new Article("", "siema siema Siema Pozdrowienia z Podziemia", null, null);
        assertThat( new UpperCaseExtractor().extract(article, null).get(0) ).isEqualTo(3.0);
    }
}
