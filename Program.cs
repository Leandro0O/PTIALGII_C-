using System;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Quantos valores deseja armazenar?");
         int[] v = new int[Convert.ToInt32(Console.ReadLine())];
            for(int i = 0; i < v.Length;i++){
                Console.WriteLine($"Informe o {i + 1}° valor:");
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mDifereca(v));
            Console.WriteLine($"O vetor está na ordem crescente? {oCrescente(v)}");
    }
    public static String mDifereca(int[] v){
        int max, min;
        max = v.Max();
        min = v.Min();
        return $"A maior diferença possível dentro do vetor é {(max - min)}, entre os valores {max} e {min}";
    }
    public static Boolean oCrescente(int[] v){
        Boolean  res = false;
        foreach(int num in v){
            res = num < num -1 ? false : true;
        }
        return res;
    }
}