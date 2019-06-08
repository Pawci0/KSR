package com.ksr;

import com.ksr.data_preparation.Article;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;
import static org.assertj.core.api.Assertions.assertThat;


public class UtilsTest {

    @Test
    public void normalizeData() {
        List<Article> articleList = new ArrayList<>();
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("usa")));
        articleList.add(new Article("", "", null, List.of("japan")));
        articleList.add(new Article("", "", null, List.of("japan")));
        articleList.add(new Article("", "", null, List.of("japan")));
        articleList.add(new Article("", "", null, List.of("japan")));
        articleList.add(new Article("", "", null, List.of("japan")));
        articleList.add(new Article("", "", null, List.of("france")));
        articleList.add(new Article("", "", null, List.of("france")));
        articleList.add(new Article("", "", null, List.of("france")));
        articleList.add(new Article("", "", null, List.of("uk")));
        articleList.add(new Article("", "", null, List.of("uk")));
        articleList.add(new Article("", "", null, List.of("canada")));

        articleList = Utils.normalizeData(articleList);

        assertThat(articleList.size()).isEqualTo(16);
    }
}