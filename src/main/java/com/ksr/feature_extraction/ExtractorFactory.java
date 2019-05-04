package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.basic.*;
import com.ksr.feature_extraction.keyword.ClassKeywordOccurrenceExtractor;

import java.util.List;

public class ExtractorFactory {

    public static Extractor AllExtractors(List<Article> trainingSet, int keywordCount){
        return new MixedExtractor(new ClassKeywordOccurrenceExtractor(trainingSet, keywordCount),
                new ArticleLengthExtractor(),
                new AvgWordLengthExtractor(),
                new MostCommonBigLetterExtractor(),
                new UniqueWordCountExtractor(),
                new UpperCaseExtractor(),
                new LabelOccurenceExtractor());
    }

    public static Extractor GeneralExtractors(){
        return new MixedExtractor(new ArticleLengthExtractor(), new AvgWordLengthExtractor(), new LabelOccurenceExtractor(),
                new MostCommonBigLetterExtractor(), new UniqueWordCountExtractor(), new UpperCaseExtractor());
    }

    public static Extractor KeywordExtractor(List<Article> trainingSet, int keywordCount){
        return new ClassKeywordOccurrenceExtractor(trainingSet, keywordCount);
    }

    public static Extractor CustomExtractor(Extractor... extractors){
        return new MixedExtractor(extractors);
    }
}
