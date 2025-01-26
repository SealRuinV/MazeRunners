// See https://aka.ms/new-console-template for more information
using System;

namespace MazeEscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maze Runner by Eduardo!");

            int[,] MazeEscape= MazeGenerate(10,10);
            // MazeCheck(ref MazeEscape);
            ShowMaze(MazeEscape);
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine(); // Keeps the console open
        }

        public static int[,] MazeGenerate(int n, int m)
        {
            int[,]maze = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    int seed = new Random().Next(0, 70);
                    int cell = 0;
                    if(seed>25&&seed<40)
                        cell = 1;
                    else if (seed>=40&& seed<50)
                        cell = 2;
                    else if (seed >= 50 && seed < 60)
                        cell = 3;
                    else if (seed >= 60)
                        cell = 4;
                    maze[i, j] = cell;
                }

            }
            return maze;
        }
        public static void MazeCheck(ref int[,] maze)
        {
        }
        public static void ShowMaze(int[,] maze)
        {
            Console.WriteLine("---------------------");
            for (int i = 0;i < maze.GetLength(0); i++)
            {
                for (int j=0 ; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == 0){
                        Console.Write("| ");
                    }
                    else if (maze[i, j] == 1){
                        Console.Write("|#");
                    }
                    else if (maze[i,j]==2)
                    {
                        Console.Write("|`");

                    }
                    else if (maze[i, j] == 3)
                    {
                        Console.Write("|-");

                    }
                    else if (maze[i, j] == 4)
                    {
                        Console.Write("|^");

                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("---------------------");
        }


    }
}
