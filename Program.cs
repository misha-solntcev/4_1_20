using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 20
Дана целочисленная прямоугольная матрица. Определить:
1.количество строк, содержащих хотя бы один нулевой элемент;
2.номер столбца, в котором находится самая длинная серия одинаковых элементов.*/

namespace _4_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {   
                { 2, 1, 5, 4, 8, 8, 7 },
                { 2, 0, 6, 1, 5, 6, 8 },
                { 3, 8, 1, 5, 2, 4, 3 },
                { 5, 3, 1, 4, 5, 5, 5 },
                { 5, 2, 1, 6, 4, 6, 8 },
                { 5, 3, 1, 5, 3, 5, 1 },
                { 6, 8, 1, 1, 2, 1, 7 },
            };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            // Количество строк, содержащих хотя бы один нулевой элемент;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] == 0)
                        flag = true;
                }
                if (flag)
                    count++;
            }
            Console.WriteLine(count);

            // Номер столбца, в котором находится самая длинная серия одинаковых элементов
            int maxAmount = 0;
            int maxJ = 0;
            for (int j = 0; j < m; j++)                
            {
                int amount = 1;                
                for (int i = 1; i < n; i++)
                {
                    if (arr[i, j] == arr[i - 1, j])
                    {
                        amount++;
                        if (amount > maxAmount)
                        {
                            maxAmount = amount;
                            maxJ = j;
                        }
                    }
                    else
                        amount = 1;                    
                }                
            }
            Console.WriteLine($"Самая длинная серия: maxJ = {maxJ}, maxAmount = {maxAmount}");
            Console.ReadKey();                
        }
    }
}
