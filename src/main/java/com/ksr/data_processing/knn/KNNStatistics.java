package com.ksr.data_processing.knn;

import lombok.AllArgsConstructor;
import org.apache.commons.lang3.tuple.ImmutablePair;

import java.util.List;

@AllArgsConstructor
public class KNNStatistics {

    private List<ImmutablePair<ClassificationObject, String>> classifiedObjects;

    public double getAcuracy(){
        double goodMatches = 0;
        for(ImmutablePair<ClassificationObject, String> pair : classifiedObjects){
            if(pair.left.getLabel().equals(pair.right))
                ++goodMatches;
        }
        return goodMatches/classifiedObjects.size();
    }

    public double getPrecision(String label){
        double goodMatches = 0;
        double totalLabel = 0;
        for(ImmutablePair<ClassificationObject, String> pair : classifiedObjects){
            if(pair.getRight().equals(label)){
                ++totalLabel;
                if(pair.getLeft().getLabel().equals(label))
                    ++goodMatches;
            }
        }
        return goodMatches/totalLabel;
    }

    public double getRecall(String label){
        double goodMatches = 0;
        double totalLabel = 0;
        for(ImmutablePair<ClassificationObject, String> pair : classifiedObjects){
            if(label.equals(pair.getLeft().getLabel())){
                ++totalLabel;
                if(label.equals(pair.getRight()))
                    ++goodMatches;
            }
        }
        return goodMatches/totalLabel;
    }
}
