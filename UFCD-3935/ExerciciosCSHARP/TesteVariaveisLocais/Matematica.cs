using System;
public class Matematica
{
    public Matematica() { }
    public int Soma(int a, int b)
    {
        return a + b;
    }
    public static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }

    public static int Max(int[] valores)
    {
        int max = valores[0];
        foreach (int i in valores)
        {
            if (i > max)
                max = i;
        }
        return max;
    }
}

