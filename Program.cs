namespace Assignment3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = { { 1, 2 } , { 3, 4 } };
            int[,] secondMatrix = { { 5, 6 } , { 7, 8 } };

          

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(0); j++)
                {
                    Console.Write("|");
                    Console.Write(firstMatrix[i, j] + secondMatrix[i, j]);

                   
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
