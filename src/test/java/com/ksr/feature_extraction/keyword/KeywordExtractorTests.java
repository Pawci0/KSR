package com.ksr.feature_extraction.keyword;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.Extractor;
import org.junit.Before;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;
import static org.assertj.core.api.Assertions.assertThat;

public class KeywordExtractorTests {

    private List<String> keywords;
    private Article containing;
    private Article notContaining;

    @Before
    public void setup(){
        keywords = List.of("a", "b", "c");
        containing = new Article("title", "a b d", null, null);
        notContaining = new Article("title", "x d e", null, null);
    }

    @Test
    public void AnyKeywordAppearedTest() {
        Extractor extractor = new AnyKeywordAppeared();
        List<Double> resultTrue = extractor.extract(containing, keywords);
        List<Double> resultFalse = extractor.extract(notContaining, keywords);

        assertThat(resultTrue).isEqualTo(List.of(1.0));
        assertThat(resultFalse).isEqualTo(List.of(0.0));
    }

    @Test
    public void HowManyKeywordsAppearedTest() {
        Extractor extractor = new HowManyKeywordsAppeared();
        List<Double> resultTrue = extractor.extract(containing, keywords);
        List<Double> resultFalse = extractor.extract(notContaining, keywords);

        assertThat(resultTrue).isEqualTo(List.of(2.0));
        assertThat(resultFalse).isEqualTo(List.of(0.0));
    }
}
