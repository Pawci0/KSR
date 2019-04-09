package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.Assert.*;

public class MostCommonBigLetterExtractorTest {

    @Test
    public void extract() {
        Article manyProperNouns = new Article("title", "this is The Text of the article", null, null);
        Article oneProperNouns = new Article("title", "this is The text of the article", null, null);
        Article noProperNouns = new Article("title", "this is the text of the article", null, null);
        Extractor extractor = new MostCommonBigLetterExtractor();

        var outcomeMany = extractor.extract(manyProperNouns).get(0);
        var outcomeOne = extractor.extract(oneProperNouns).get(0);
        var outcomeNo = extractor.extract(noProperNouns).get(0);

        assertThat(outcomeMany).isEqualTo((int)'T');
        assertThat(outcomeOne).isEqualTo((int)'T');
        assertThat(outcomeNo).isEqualTo(0);
    }
}
