package com.ksr.data_preparation;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;
import java.util.regex.MatchResult;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SGMConverter{

    public static List<Article> convert(File input) throws FileNotFoundException {
        List<Article> result = new ArrayList<>();
        Scanner scanner = null;
        try{
            scanner = new Scanner(input);
            while(true){
                String reuters = scanner.findWithinHorizon("<REUTERS", 10000);
                if(reuters == null || reuters.isEmpty()){
                    break;
                }
                List<String> topics = getTopics(scanner);
                List<String> places = getPlaces(scanner);
                String title = getTitle(scanner);
                String text = getText(scanner);
                result.add(new Article(title, text, topics, places));
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
        scanner.findWithinHorizon(Pattern.compile("<BODY>(.+?)</BODY>", Pattern.DOTALL),10000000);
        return scanner.match().group(1).replace("&lt;","<");
    }

    private static String getTitle(Scanner scanner) {
        scanner.findWithinHorizon("<TITLE>(.+?)</TITLE>",10000);
        return scanner.match().group(1).replace("&lt;","<");
    }

    private static List<String> getTopics(Scanner scanner) {
        String outcome = scanner.findWithinHorizon("<TOPICS>(.+?)</TOPICS>",1000);
        if(outcome == null){
            return Collections.emptyList();
        }
        return getStrings(scanner.match());
    }

    private static List<String> getPlaces(Scanner scanner) {
        String outcome = scanner.findWithinHorizon("<PLACES>(.+?)</PLACES>",1000);
        if(outcome == null){
            return Collections.emptyList();
        }
        return getStrings(scanner.match());
    }

    private static List<String> getStrings(MatchResult match) {
        List<String> result = new ArrayList<>();
        if(match.groupCount() < 1){
            return Collections.emptyList();
        }
        String string = match.group(1);
        Matcher m = Pattern.compile("<D>(.+?)</D>").matcher(string);
        while(m.find()){
            result.add(m.group(1).replace("&lt;","<"));
        }
        return result;
    }


}
