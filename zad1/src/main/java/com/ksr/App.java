package com.ksr;

import com.ksr.data_preparation.Article;
import com.ksr.data_preparation.Dataset;
import com.ksr.data_preparation.DatasetSplitter;
import com.ksr.data_preprocessing.Stemmer;
import com.ksr.data_preprocessing.Trimmer;
import com.ksr.data_processing.knn.ClassificationObject;
import com.ksr.data_processing.knn.KNNClassifier;
import com.ksr.data_processing.knn.KNNStatistics;
import com.ksr.feature_extraction.*;
import com.ksr.feature_extraction.keyword.*;
import com.ksr.tfidf.Tfidf;
import org.apache.commons.lang3.tuple.ImmutablePair;
import org.apache.commons.math3.ml.distance.ChebyshevDistance;
import org.apache.commons.math3.ml.distance.DistanceMeasure;
import org.apache.commons.math3.ml.distance.EuclideanDistance;
import org.apache.commons.math3.ml.distance.ManhattanDistance;

import java.io.FileNotFoundException;
import java.util.*;

/**
 * Hello world!
 *
 */
public class App
{

    public static double SPLIT = 0.2;
    public static int KNEIGH = 3;
    static DistanceMeasure metric = new EuclideanDistance();

    public static void main(String[] args ) throws FileNotFoundException {
        Dataset dataset = new Dataset("src/main/resources/custom_dataset");
        Trimmer stemmer = new Stemmer();
        while(SPLIT < 1){
            KNEIGH = 3;
            while (KNEIGH < 20) {
                List<Article> articles = Utils.validateAndPrepareArticles(dataset, stemmer);
                if(dataset.getDirectoryPath().equals("src/main/resources/reuters_dataset"))
                    articles = Utils.normalizeData(articles);

                List<List<Article>> sets = DatasetSplitter.split(articles, SPLIT);
//                Extractor extractor = ExtractorFactory.KeywordExtractor(sets.get(0), 10);
//            Extractor extractor = ExtractorFactory.GeneralExtractors();
        Extractor extractor = new MixedExtractor(new AnyKeywordAppeared(), new AverageKeywordAppearance(),
                new HowManyKeywordsAppeared(), new HowManyTimesKeywordsAppeared(), new MostCommonKeywordOccurences(),
                new StartingKeywordsExtractor(), new WeightedKeywordAppearance());
        List<String> keywords = new ArrayList<>(Utils.sortByValue(Tfidf.idf(sets.get(0))).keySet());
        keywords = keywords.subList(0, 10);
                List<List<ClassificationObject>> classificationObjects = new ArrayList<>();
                for(List<Article> set : sets){
                    ArrayList<ClassificationObject> temp = new ArrayList<>();
                    for(Article article : set){
                        //todo change null
                        List<Double> featureList = extractor.extract(article, keywords);
                        double[] featureArray = new double[featureList.size()];
                        for(int i = 0; i < featureList.size(); i++){
                            featureArray[i] = featureList.get(i);
                        }
                        article.getPlaces().forEach(p->temp.add(new ClassificationObject(p, featureArray)));
//                temp.add(new ClassificationObject(article.getPlaces().get(0), featureArray));
                    }
                    classificationObjects.add(temp);
                }

                KNNClassifier knnClassifier = new KNNClassifier(KNEIGH, classificationObjects.get(0), metric);

                ArrayList<ImmutablePair<ClassificationObject, String>> results = new ArrayList<>();
                for(ClassificationObject classificationObject : classificationObjects.get(1)){
                    results.add(new ImmutablePair<>(classificationObject, knnClassifier.classify(classificationObject)));
                }
                KNNStatistics knnStatistics = new KNNStatistics(results);
                System.out.println(KNEIGH + "; " + String.format("%.2f", knnStatistics.getAcuracy()) + "; " + SPLIT);
                KNEIGH +=2;
            }
            SPLIT += 0.2;
        }
    }

}
