package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.basic.UniqueWordCountExtractor;
import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class UniqueWordCountExtractorTest {

    @Test
    public void extract() {
        Article unique = new Article("title", "this is the text of that article", null, null);
        Article reapetead = new Article("title", "this this the text of that article", null, null);
        Extractor extractor = new UniqueWordCountExtractor();

        var outcomeUnique = extractor.extract(unique, ).get(0);
        var outcomeRepeated = extractor.extract(reapetead, ).get(0);

        assertThat(outcomeUnique).isEqualTo(7);
        assertThat(outcomeRepeated).isEqualTo(6);
    }
}
