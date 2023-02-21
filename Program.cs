using System;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Quantos valores deseja armazenar?");
         int[] values = new int[Convert.ToInt32(Console.ReadLine())];
            for(int i = 0; i < values.Length;i++){
                Console.WriteLine($"Informe o {i + 1}° valor:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mDifereca(values));
            Console.WriteLine($"O vetor está na ordem crescente? {oCrescente(values)}");
    }
    public static String mDifereca(int[] values){
        Random r = new Random();
        int n1, n2, res;
        n1 = values[r.Next(values.Length)];
        n2 = values[r.Next(values.Length)];
        res = n1 > n2 ? n1 - n2 : n1 == n2 ? n1 - n1 : n2 - n1;
        return $"A diferença entre os valores {n1} e { n2} é {res} ";
    }
    public static Boolean oCrescente(int[] values){
        Boolean  res = false;
        foreach(int num in values){
            res = num < num -1 ? false : true;
        }
        return res;
    }
}