package com.ksr.data_preparation;

import edu.stanford.nlp.simple.Document;
import edu.stanford.nlp.simple.Sentence;
import org.apache.commons.lang3.StringUtils;

import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class TextTokenizer {

    public static List<String> tokenize(String documentText) {
        var stripped = documentText.replaceAll("[^a-zA-Z \n]", "").split("\\s+");
        return Arrays.asList(stripped);
    }

    public static List<String> tokenizeLowerCase(String documentText){
        return tokenize(documentText).stream()
                .map(String::toLowerCase)
                .collect(Collectors.toList());
    }

    public static List<String> tokenizeLowerCaseWithProperNouns(String documentText){
        Document document = new Document(documentText);
        return document.sentences().stream()
                .map(Sentence::toString)
                .map(StringUtils::uncapitalize)
                .flatMap(sentence -> tokenize(sentence).stream())
                .collect(Collectors.toList());
    }
}
