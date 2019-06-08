package com.ksr.data_preparation;

import com.ksr.data_preprocessing.StopWordsUtil;
import com.ksr.data_preprocessing.Trimmer;
import lombok.Getter;
import lombok.NoArgsConstructor;

import java.util.List;

@Getter
@NoArgsConstructor
public class Article {
    private String title;
    private String originalText;
    private List<String> topics;
    private List<String> places;
    private List<String> textTokens;
    private List<String> titleTokens;

    public Article(String title, String originalText, List<String> topics, List<String> places) {
        this.title = title;
        titleTokens = TextTokenizer.tokenizeLowerCaseWithProperNouns(title);
        this.originalText = originalText;
        textTokens = TextTokenizer.tokenizeLowerCaseWithProperNouns(originalText);
        this.topics = places;
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

    public void trim(Trimmer trimmer){
        textTokens = trimmer.trim(textTokens);
        titleTokens= trimmer.trim(titleTokens);
    }

    public void filter(){
        textTokens = StopWordsUtil.filter(textTokens, StopWordsUtil.english());
        titleTokens = StopWordsUtil.filter(titleTokens, StopWordsUtil.english());
    }
}
