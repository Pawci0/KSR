package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.basic.ArticleLengthExtractor;
import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;


public class ArticleLengthExtractorTest {

    @Test
    public void extract() {
        Article a = new Article("title", "this is the text of the article", null, null);
        Extractor extractor = new ArticleLengthExtractor();
        var outcome = extractor.extract(a, ).get(0);
        assertThat(outcome).isEqualTo(7);
    }
}
