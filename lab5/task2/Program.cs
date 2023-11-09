using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class MathOperations
    {
      
        public static int Add(int a, int b)
        {
            return a + b;
        }


        public static int[] Add(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }
        public static int[,] Add(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions");
            }

            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

 



        public static int[,,] Add(int[,,] tensor1, int[,,] tensor2)
        {
            if (tensor1.GetLength(0) != tensor2.GetLength(0) || tensor1.GetLength(1) != tensor2.GetLength(1) || tensor1.GetLength(2) != tensor2.GetLength(2))
            {
                throw new ArgumentException("Tensors must have the same dimensions");
            }

            int depth = tensor1.GetLength(0);
            int rows = tensor1.GetLength(1);
            int columns = tensor1.GetLength(2);

            int[,,] result = new int[depth, rows, columns];
            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        result[i, j, k] = tensor1[i, j, k] + tensor2[i, j, k];
                    }
                }
            }



            return result;
        }

       




    }



    class Program
    {
        static void Main()
        {
           
            int sum1 = MathOperations.Add(5, 10);
            Console.WriteLine($"Sum of two numbers: {sum1}");
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] sum2 = MathOperations.Add(array1, array2);
            Console.WriteLine($"Sum of two arrays: [{string.Join(", ", sum2)}]");
            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] sum3 = MathOperations.Add(matrix1, matrix2);
            Console.WriteLine("Sum of two matrices:");
            PrintMatrix(sum3);
            int[,,] tensor1 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
            int[,,] tensor2 = { { { 9, 10 }, { 11, 12 } }, { { 13, 14 }, { 15, 16 } } };
            int[,,] sum4 = MathOperations.Add(tensor1, tensor2);
            Console.WriteLine("Sum of two tensors:");
            PrintTensor(sum4);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTensor(int[,,] tensor)
        {
            int depth = tensor.GetLength(0);
            int rows = tensor.GetLength(1);
            int columns = tensor.GetLength(2);

            for (int i = 0; i < depth; i++)
            {
                Console.WriteLine($"Tensor at depth {i}:");
                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        Console.Write($"{tensor[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
