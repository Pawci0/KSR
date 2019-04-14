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
            var files = directory.listFiles();
            if(files != null){
                articles = Arrays.stream(files)
                                    .map(this::convert)
                                    .flatMap(Collection::stream)
                                    .collect(Collectors.toList());
            }

        }catch(Exception e){
            e.printStackTrace();
        }
    }

    private List<Article> convert(File input){
        if(input.getName().endsWith(".sgm"))
            return SGMConverter.convert(input);
        else if(input.getName().endsWith(".txt"))
            return TXTConverter.convert(input);
        return null;
    }
}
