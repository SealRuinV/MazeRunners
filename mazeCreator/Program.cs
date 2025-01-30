// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;
using mazeCreator;

namespace MazeEscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maze Runner by Uni!");

            string[,] MazeEscape= MazeGenerate(11,10);
            Piece Rook1 = new Piece("Rook", 1, "R1", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");
            Piece Rook2 = new Piece("Rook", 2, "R2", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");
            Piece Knight1 = new Piece("Knight", 1, "K1", 0, "None", "This piece can destroy an obstacle or trap adjacent to it.");
            Piece Knight2 = new Piece("Knight", 2, "K2", 0, "None", "This piece can destroy an obstacle or trap adjacent to it.");
            Piece pece1 = new Piece("Rook", 1, "P1", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");
            Piece pece2 = new Piece("Rook", 1, "P2", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");
            Piece asd1 = new Piece("Rook", 1, "A1", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");
            Piece asd2 = new Piece("Rook", 1, "A1", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");
            Piece rtv1 = new Piece("Rook", 1, "T1", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");
            Piece rtv2 = new Piece("Rook", 1, "T2", 3, "None", "Once this piece reaches the portal, this player's remaining pieces gain a +1 movement bonus.");

            MazeEscape[0, 1] = Rook1.pieceSym;
            MazeEscape[10, 1] = Rook2.pieceSym;
            MazeEscape[0, 3] = Knight1.pieceSym;
            MazeEscape[10, 3] = Knight2.pieceSym;
            MazeEscape[0, 5] = pece1.pieceSym;
            MazeEscape[10, 5] = pece2.pieceSym;
            MazeEscape[0, 7] = asd1.pieceSym;
            MazeEscape[10, 7] = asd2.pieceSym;
            MazeEscape[0, 9] = rtv1.pieceSym;
            MazeEscape[10, 9] = rtv2.pieceSym;

            ShowMaze(MazeEscape);
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
            

        public static string[,] MazeGenerate(int n, int m)
        {
            string[,] maze = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    int seed = new Random().Next(0, 70);
                    int cell = 0;
                    if(seed>25 && seed<40)
                        cell = 1;
                    else if (seed>=40 && seed<50)
                        cell = 2;
                    else if (seed >= 50 && seed < 60)
                        cell = 3;
                    else if (seed >= 60)
                        cell = 4;
                    maze[i, j] = cell.ToString();
                }
            }

            
            
            return maze;
        }

       /* public static void MazeCheck(ref string[,] maze)
        {
            int[,] ob = new int[]
            for (int i = 0;i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    int[,]tempObst = new int[]

                }
            }
        }*/
        public static void ShowMaze(string[,] maze)
        {
            Console.WriteLine("------------------------------");
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    switch(maze[i,j])
                    {
                        case "0":
                            Console.Write("|  ");
                            break;
                        case "1":
                            Console.Write("|# "); 
                            break;
                        case "2":
                            Console.Write("|` ");
                            break;
                        case "3":
                            Console.Write("|- ");
                            break;
                        case "4":
                            Console.Write("|^ ");
                            break;
                        default:
                            Console.Write("|"+maze[i,j]);
                            break;
                    }                     
                }
                Console.WriteLine("|");
                // Console.WriteLine("------------------------------");
            }
            Console.WriteLine("------------------------------");
        }


    }
}
