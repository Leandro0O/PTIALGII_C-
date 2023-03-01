using System;
using System.Linq;
class Program {
    public static void Main(string[] args) {
        Console.Clear();
        Console.WriteLine("Quantos valores deseja armazenar?");
        try{
            int[] v = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < v.Length; i++) {
                Console.WriteLine($"Informe o {i + 1}° valor:");
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mDifereca(v));
            Console.WriteLine($"O vetor está na ordem crescente? {oCrescente(v)}");
        }catch( FormatException e) {
            Console.WriteLine("Valor invalido, informe um número inteiro.");
        }   
    }
    public static String mDifereca(int[] v) {
        int max = v.Max(), min = v.Min();
        return $"A maior diferença possível dentro do vetor é {(max - min)}, entre os valores {max} e {min}";
    }
    public static Boolean oCrescente(int[] v) {
        Boolean res = false;
        for(int i = 1; i < v.Length;i++) {
            res = v[i] > v[i - 1] ? true : false;
        }
        return res;
    }
}