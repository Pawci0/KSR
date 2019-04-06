package com.ksr.data_preparation;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.ToString;

import java.util.List;

@Getter
@NoArgsConstructor
public class Article {
    private String title;
    private String originalText;
    private List<String> topics;
    private List<String> places;
    private List<String> textTokens;

    public Article(String title, String originalText, List<String> topics, List<String> places) {
        this.title = title;
        this.originalText = originalText;
        textTokens = TextTokenizer.tokenizeLowerCaseWithProperNouns(originalText);
        this.topics = topics;
        this.places = places;
    }

    @Override
    public String toString() {
        return "Article{" +
                "\ntitle='" + title + '\'' +
                "\n topics=" + topics +
                "\n places=" + places +
                "\n}s";
    }
}
