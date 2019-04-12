package com.ksr;

import com.ksr.data_preparation.Article;
import com.ksr.data_preparation.Dataset;
import com.ksr.data_preparation.DatasetSplitter;
import com.ksr.data_preprocessing.Stemmer;
import com.ksr.data_processing.knn.ClassificationObject;
import com.ksr.data_processing.knn.KNNClassifier;
import com.ksr.data_processing.knn.KNNStatistics;
import com.ksr.feature_extraction.*;
import org.apache.commons.lang3.tuple.ImmutablePair;
import org.apache.commons.math3.ml.distance.EuclideanDistance;

import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.stream.Collectors;

/**
 * Hello world!
 *
 */
public class App
{
    private static List<String> properLabels = List.of("west-germany", "usa", "france", "uk",
            "canada", "japan");

    public static void main( String[] args ) throws FileNotFoundException {
        System.out.println("Read articles test:");
        Dataset dataset = new Dataset("src/main/resources");
        Stemmer stemmer = new Stemmer();

        List<Article> articles = getArticles(dataset, stemmer);

        List<List<Article>> sets = DatasetSplitter.split(articles, 0.1);
        Extractor extractor = new MixedExtractor(new ArticleLengthExtractor(), new AvgWordLengthExtractor(),
                new MostCommonBigLetterExtractor(), new UniqueWordCountExtractor(), new UpperCaseExtractor());

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

        KNNClassifier knnClassifier = new KNNClassifier(5, classificationObjects.get(0), new EuclideanDistance());

        ArrayList<ImmutablePair<ClassificationObject, String>> results = new ArrayList<>();
        for(ClassificationObject classificationObject : classificationObjects.get(1)){
            results.add(new ImmutablePair<>(classificationObject, knnClassifier.classify(classificationObject)));
        }
        KNNStatistics knnStatistics = new KNNStatistics(results);
        System.out.println("Accuracy: " + knnStatistics.getAcuracy());

    }

    private static List<Article> getArticles(Dataset dataset, Stemmer stemmer) {
        List<Article> articles = dataset.getArticles().stream()
                .filter(App::validateArticle)
                .collect(Collectors.toList());

        articles.forEach(a->{
            a.filter();
            a.trim(stemmer);
        });
        return articles;
    }

    private static boolean validateArticle(Article a) {
        return a.getPlaces().size() == 1 && properLabels.contains(a.getPlaces().get(0));
    }
}
