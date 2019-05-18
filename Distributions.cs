using System;
using UnityEngine;

public static class Distributions{
    public static double normalGeneator(double miu, double sigma){
        System.Random random = new System.Random();
        int i = 0, r = 0;
        double sum = 0.0, z;
        for (; i < 12; i++){
            r = random.Next(0,10000);
            sum += r / 10000.0;
        }
        z = sum - 6;
        return (z * sigma) + miu;
    }

    public static int PoissonGenenrator(double lamda){
        System.Random random = new System.Random();
        int i = 0;
        double p = Math.Exp(-lamda);
        double f = p;
        int r = random.Next(0, 10000);
        double u = r / 10000.0;
        while (u >= f)
        {
            p = (lamda * p) / (i + 1);
            f += p;
            i++;
        }
        return i;
    }

    public static double exponentialGenenrator(double lamda){
        System.Random random = new System.Random();
        int r = random.Next(0, 10000);
        double y = r / 10000.0;
        return -(Math.Log(y / lamda)/lamda);
    }

    public static Boolean BernoulliGenerator(double p){
        System.Random random = new System.Random();
        int r = random.Next(0, 10000);
        double y = r / 10000.0;
        return r <= p;
    }
    
}
