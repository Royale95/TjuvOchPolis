using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvOchPolis
{
    class World
    {
        private string[,] SizeOfTown;
        private int XHorizontal;
        private int YVertical;

        public World(string[,] sizeOfTown)
        {
            SizeOfTown = sizeOfTown;
            XHorizontal = SizeOfTown.GetLength(0);
            YVertical = SizeOfTown.GetLength(1);
        }

        public void Draw() // Rita världen
        {
            for (int y = 0; y < XHorizontal; y++)
            {
                for (int x = 0; x < YVertical; x++)
                {
                    string world = SizeOfTown[y, x];
                    Console.SetCursorPosition(x, y);
                    Console.Write(world);


                }
            }
        }


        //public string Interactions(int x, int y) // ingår interaktioner men funkar ej och har en bugg
        //{
        //    return SizeOfTown[y, x];
        //}


    }
}
