using System;

namespace TjuvOchPolis
{
    class Person
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Character;
        public ConsoleColor CharacterColor;
        public Random random = new Random();



    }

    class Thief : Inventory
    {
        public Thief(int randomX, int randomY)
        {
            X = randomX;
            Y = randomY;
            Character = "T";
            CharacterColor = ConsoleColor.Red;

        }
        public void DrawThief()
        {
            Console.ForegroundColor = CharacterColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(Character);
            Console.ResetColor();
        }
    }

    class Police : Inventory
    {
        public Police(int randomX, int randomY)
        {
            X = randomX;
            Y = randomY;
            Character = "P";
            CharacterColor = ConsoleColor.Blue;

        }
        public void DrawPolice()
        {
            Console.ForegroundColor = CharacterColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(Character);
            Console.ResetColor();
        }
    }

    class Pedestrian : Inventory
    {
        public Pedestrian(int randomX, int randomY)
        {
            X = randomX;
            Y = randomY;
            Character = "M";
            CharacterColor = ConsoleColor.White;

        }
        public void DrawPedestrian()
        {
            Console.ForegroundColor = CharacterColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(Character);
            Console.ResetColor();
        }
    }
}
