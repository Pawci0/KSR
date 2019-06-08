package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.keyword.ClassKeywordOccurrenceExtractor;
import org.junit.Before;
import org.junit.Test;

import java.util.List;

public class ClassKeywordOccurrenceExtractorTest {

    Extractor extractor;
    @Before
    public void setUp() throws Exception {
        Article usa = new Article("title", "USA, USA, want more of USA, please let me in", List.of("usa"), null);
        Article canada = new Article("title", "canada, canada, want more of canada, please let me in", List.of("canada"), null);

        extractor = new ClassKeywordOccurrenceExtractor(List.of(usa, canada), 2);
    }

    @Test
    public void extract() {
        Article canada = new Article("title", "adore canada, but also love USA. If had to choose it would be USA", null, null);

        extractor.extract(canada, null);
    }
}
