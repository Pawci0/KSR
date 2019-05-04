package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import java.util.List;

public interface Extractor {
    List<Double> extract(Article article, List<String> keywords);
}
