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
        containing = new Article("title", "a a d b e f g", null, null);
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

    @Test
    public void HowManyTimesKeywordsAppearedTest() {
        Extractor extractor = new HowManyTimesKeywordsAppeared();
        List<Double> resultTrue = extractor.extract(containing, keywords);
        List<Double> resultFalse = extractor.extract(notContaining, keywords);

        assertThat(resultTrue).isEqualTo(List.of(3.0));
        assertThat(resultFalse).isEqualTo(List.of(0.0));
    }

    @Test
    public void AverageKeywordAppearanceTest(){
        Extractor extractor = new AverageKeywordAppearance();
        List<Double> resultTrue = extractor.extract(containing, keywords);
        List<Double> resultFalse = extractor.extract(notContaining, keywords);

        assertThat(resultTrue).isEqualTo(List.of(3.0/3));
        assertThat(resultFalse).isEqualTo(List.of(0.0));
    }

    @Test
    public void MostCommonKeywordOccurencesTest() {
        Extractor extractor = new MostCommonKeywordOccurences();
        List<Double> resultTrue = extractor.extract(containing, keywords);
        List<Double> resultFalse = extractor.extract(notContaining, keywords);

        assertThat(resultTrue).isEqualTo(List.of(2.0));
        assertThat(resultFalse).isEqualTo(List.of(0.0));
    }

    @Test
    public void WeightedKeywordAppearanTest(){
        Extractor extractor = new WeightedKeywordAppearance();
        List<Double> resultTrue = extractor.extract(containing, keywords);
        List<Double> resultFalse = extractor.extract(notContaining, keywords);

        assertThat(resultTrue).isEqualTo(List.of(2.6));
        assertThat(resultFalse).isEqualTo(List.of(0.0));
    }

    @Test
    public void StartingKeywordsExtractorTest(){
        Extractor extractor = new StartingKeywordsExtractor();
        Article article = new Article("title", "a h g d c b a b c c k j l y t s v p o a b c e a b c a d e t q n m k z g a c b a h f",
                null, null);

        List<Double> result = extractor.extract(article, keywords);
        assertThat(result).isEqualTo(List.of(8.0/18.0));
    }
}
