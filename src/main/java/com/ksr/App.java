package com.ksr;

import com.ksr.data_preparation.Article;
import com.ksr.data_preparation.Dataset;
import com.ksr.data_preparation.DatasetSplitter;
import com.ksr.data_preprocessing.Lemmatizer;
import com.ksr.data_preprocessing.Stemmer;
import com.ksr.data_preprocessing.Trimmer;
import com.ksr.data_processing.knn.ClassificationObject;
import com.ksr.data_processing.knn.KNNClassifier;
import com.ksr.data_processing.knn.KNNStatistics;
import com.ksr.feature_extraction.*;
import org.apache.commons.lang3.tuple.ImmutablePair;
import org.apache.commons.math3.ml.distance.EuclideanDistance;

import java.io.FileNotFoundException;
import java.util.*;

/**
 * Hello world!
 *
 */
public class App
{

    public static void main( String[] args ) throws FileNotFoundException {
        System.out.println("Read articles test:");
        Dataset dataset = new Dataset("src/main/resources");
        Trimmer stemmer = new Stemmer();

        List<Article> articles = Utils.validateAndPrepareArticles(dataset, stemmer);
        articles = Utils.normalizeData(articles);

        List<List<Article>> sets = DatasetSplitter.split(articles, 0.8);
        Extractor extractor = ExtractorFactory.GeneralExtractors();

        List<List<ClassificationObject>> classificationObjects = new ArrayList<>();
        for(List<Article> set : sets){
            ArrayList<ClassificationObject> temp = new ArrayList<>();
            for(Article article : set){
                List<Double> featureList = extractor.extract(article);
                double[] featureArray = new double[featureList.size()];
                for(int i = 0; i < featureList.size(); i++){
                    featureArray[i] = featureList.get(i);
                }
                temp.add(new ClassificationObject(article.getPlaces().get(0), featureArray));
            }
            classificationObjects.add(temp);
        }

        KNNClassifier knnClassifier = new KNNClassifier(11, classificationObjects.get(0), new EuclideanDistance());

        ArrayList<ImmutablePair<ClassificationObject, String>> results = new ArrayList<>();
        for(ClassificationObject classificationObject : classificationObjects.get(1)){
            results.add(new ImmutablePair<>(classificationObject, knnClassifier.classify(classificationObject)));
        }
        KNNStatistics knnStatistics = new KNNStatistics(results);
        System.out.println("Accuracy: " + knnStatistics.getAcuracy());

    }

}
