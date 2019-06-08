package com.ksr.data_processing;

public class StringKernel implements Similarity {
    @Override
    public double compare(String a, String b) {
        cc.mallet.types.StringKernel kernel = new cc.mallet.types.StringKernel();
        return kernel.K(a, b);
    }
}
