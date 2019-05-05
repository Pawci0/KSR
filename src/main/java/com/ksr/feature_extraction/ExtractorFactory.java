package com.ksr.feature_extraction;

import com.ksr.data_preparation.Article;
import com.ksr.feature_extraction.basic.*;
import com.ksr.feature_extraction.keyword.*;

import java.util.List;

public class ExtractorFactory {

    public static Extractor AllGeneralExtractors(List<Article> trainingSet, int keywordCount){
        return new MixedExtractor(new ClassKeywordOccurrenceExtractor(trainingSet, keywordCount),
                new ArticleLengthExtractor(),
                new AvgWordLengthExtractor(),
                new MostCommonBigLetterExtractor(),
                new UniqueWordCountExtractor(),
                new UpperCaseExtractor(),
                new LabelOccurenceExtractor());
    }

    public static Extractor AllKeywordExtractors(List<Article> trainingSet, int keywordCount){
        return new MixedExtractor(new ClassKeywordOccurrenceExtractor(trainingSet, keywordCount),
                new AnyKeywordAppeared(),
                new AverageKeywordAppearance(),
                new HowManyKeywordsAppeared(),
                new HowManyTimesKeywordsAppeared(),
                new MostCommonKeywordOccurences(),
                new StartingKeywordsExtractor(),
                new WeightedKeywordAppearance()
                );
    }

    public static Extractor KeywordExtractors(){
        return new MixedExtractor(
                new AnyKeywordAppeared(),
                new AverageKeywordAppearance(),
                new HowManyKeywordsAppeared(),
                new HowManyTimesKeywordsAppeared(),
                new MostCommonKeywordOccurences(),
                new StartingKeywordsExtractor(),
                new WeightedKeywordAppearance()
        );
    }

    public static Extractor GeneralExtractors(){
        return new MixedExtractor(new ArticleLengthExtractor(), new AvgWordLengthExtractor(), new LabelOccurenceExtractor(),
                new MostCommonBigLetterExtractor(), new UniqueWordCountExtractor(), new UpperCaseExtractor());
    }

    public static Extractor ClassKeywordExtractor(List<Article> trainingSet, int keywordCount){
        return new ClassKeywordOccurrenceExtractor(trainingSet, keywordCount);
    }

    public static Extractor CustomExtractor(Extractor... extractors){
        return new MixedExtractor(extractors);
    }
}
