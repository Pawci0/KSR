package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import java.util.List;

public interface Extractor {
    Double extract(Article article);
    List<Double> extract(List<Article> articles);
}
