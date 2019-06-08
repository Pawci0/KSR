package com.ksr.tfidf;

import com.ksr.data_preparation.Article;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Map;

import static org.junit.Assert.*;
import static org.assertj.core.api.Assertions.assertThat;

public class TfidfTest {

    @Test
    public void idf() {
        ArrayList<Article> articles = new ArrayList<>();
        articles.add(new Article("", "siema elo cool czesc", null, null));
        articles.add(new Article("", "siema elo cool gitara", null, null));
        articles.add(new Article("", "siema cool czesc", null, null));

        Map<String, Double> idfs = Tfidf.idf(articles);

        assertThat(idfs.get("siema")).isEqualTo(Math.log(1));
        assertThat(idfs.get("czesc")).isEqualTo(Math.log((double)3/2));
        assertThat(idfs.get("gitara")).isEqualTo(Math.log((double)3));
    }
}