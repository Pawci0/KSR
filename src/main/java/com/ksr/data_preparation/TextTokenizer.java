package com.ksr.data_preparation;

import java.util.Arrays;
import java.util.List;

public class TextTokenizer {

    public static List<String> tokenize(String documentText) {
        var stripped = documentText.replaceAll("[^a-zA-Z \n]", "").toLowerCase().split("\\s+");
        return Arrays.asList(stripped);
    }
}
