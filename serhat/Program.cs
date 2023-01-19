using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    class Program
    {
        public static void Matrix()
        {
            Console.WriteLine("Matrisin satır sayısını giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Matrisin sütun sayısını giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());


            int[,] matrixA = new int[a, b];
            int[,] matrixB = new int[a, b];

            //Matrisleri random sayılarla doldurma
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrixA[i, j] = rnd.Next(1, 10);
                    matrixB[i, j] = rnd.Next(1, 10);
                }
            }
            //Matrisleri print etme
            Console.WriteLine("Matris A:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(matrixA[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatris B:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(matrixB[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] result_sum = new int[a, b];

            int calculate_matrix;

            while (true)
            {
                Console.WriteLine("İşlem seçiniz...");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bölme");
                Console.WriteLine("0 - Çıkış");

                calculate_matrix = Convert.ToInt32(Console.ReadLine());
                switch (calculate_matrix)
                {
                    case 1:
                        //Matris toplama işlemi
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                result_sum[i, j] = matrixA[i, j] + matrixB[i, j];
                            }
                        }
                        //Matris toplamının yazdırma işlemi
                        Console.WriteLine("\n Toplama:");
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                Console.Write(result_sum[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\n");
                        continue;
                    case 2:
                        //Matris çıkarma işlemi
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                result_sum[i, j] = matrixA[i, j] - matrixB[i, j];
                            }
                        }
                        //Matris farkının yazdırma işlemi
                        Console.WriteLine("\n Çıkarma:");
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                Console.Write(result_sum[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        continue;
                    case 3:
                        //Matris çarpma işlemi
                        int[,] result_multiply = new int[a, b];
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                result_multiply[i, j] = matrixA[i, j] * matrixB[i, j];
                            }
                        }

                        //Matris çarpımının yazdırma işlemi
                        Console.WriteLine("\n Çarpma:");
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                Console.Write(result_multiply[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\n");
                        continue;
                    case 4:
                        //Matris bölme işlemi
                        int[,] result_divide = new int[a, b];
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                result_divide[i, j] = matrixA[i, j] / matrixB[i, j];
                            }
                        }
                        //Matris bölümünün yazdırma işlemi
                        Console.WriteLine("\n Bölme:");
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                Console.Write(result_divide[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\n");
                        continue;
                    default:
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("Çıkış yapılıyor . . .");
                        }
                        break;
                }
                break;
            }
        }
        static void Main(string[] args)
        {
            Matrix();
        }
    }
}
