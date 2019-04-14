package com.ksr.data_preparation;

import lombok.Getter;
import lombok.NoArgsConstructor;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.List;
import java.util.stream.Collectors;

@Getter
@NoArgsConstructor
public class Dataset {

    private List<Article> articles;
    private String directoryPath;

    public Dataset(String directoryPath) {
        setDirectoryPath(directoryPath);
    }

    public void setDirectoryPath(String directoryPath) {
        this.directoryPath = directoryPath;
        articles = new ArrayList<>();
        try{
            File directory = new File(directoryPath);
            var files = directory.listFiles(file -> file.getName().endsWith(".sgm"));
            if(files != null){
                articles = Arrays.stream(files)
                                    .map(SGMConverter::convert)
                                    .flatMap(Collection::stream)
                                    .collect(Collectors.toList());
            }

        }catch(Exception e){
            e.printStackTrace();
        }
    }

    public void setCustomDatasetPath(String directoryPath){
        this.directoryPath = directoryPath;
        articles = new ArrayList<>();
        try{
            File directory = new File(directoryPath);
            var files = directory.listFiles(file -> file.getName().endsWith(".txt"));
            if(files != null){
                articles = Arrays.stream(files)
                        .map(TXTConverter::convert)
                        .flatMap(Collection::stream)
                        .collect(Collectors.toList());
            }

        }catch(Exception e){
            e.printStackTrace();
        }
    }
}
