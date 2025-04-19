using System.Collections.Generic;
public class FindPoint
{
     public static void Run()
    {
        Console.WriteLine("Digite o número de testes:");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            int px = int.Parse(parts[0]);
            int py = int.Parse(parts[1]);
            int qx = int.Parse(parts[2]);
            int qy = int.Parse(parts[3]);

            List<int> result = FindReflectedPoint(px, py, qx, qy);
            Console.WriteLine($"{result[0]} {result[1]}");
        }
    }

    public static List<int> FindReflectedPoint(int px, int py, int qx, int qy)
    {
        //Formula para o ponto medio, qx = (px+rx)/2 ; qy = (py+ry)/2
        //Isolando o rx e ry; rx = (2 * qx) - px; ry = (2 * qy) - py
        
        return new List<int> { (2 * qx) - px, (2 * qy) - py };
    }
    
}