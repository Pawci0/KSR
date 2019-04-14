package com.ksr.data_preparation;

import java.io.File;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Pattern;

public class TXTConverter {
    public static List<Article> convert(File input){
        List<Article> result = new ArrayList<>();
        Scanner scanner = null;
        try{
            scanner = new Scanner(input);
            String label = getLabel(scanner);
            while(true){
                String song = scanner.findWithinHorizon("\r\n", 10000);
                if(song == null || song.isEmpty()){
                    break;
                }
                String text = getText(scanner);
                result.add(new Article("", text, null, List.of(label)));
            }

        }catch(Exception e){
            e.printStackTrace();
        }finally {
            if(scanner != null){
                scanner.close();
            }
        }
        return result;
    }
    private static String getText(Scanner scanner) {
        scanner.findWithinHorizon(Pattern.compile("<song>(.+?)</song>", Pattern.DOTALL),10000000);
        return scanner.match().group(1).replace("&lt;","<");
    }

    private static String getLabel(Scanner scanner) {
        scanner.findWithinHorizon(Pattern.compile("<label>(.+?)</label>", Pattern.DOTALL),100);
        return scanner.match().group(1).replace("&lt;","<");
    }
}
