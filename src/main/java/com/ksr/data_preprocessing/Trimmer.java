package com.ksr.data_preprocessing;

import java.util.List;

public interface Trimmer {
    String trim(String input);
    List<String> trim(List<String> input);
}
