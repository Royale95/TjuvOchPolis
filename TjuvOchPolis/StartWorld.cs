using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace TjuvOchPolis
{
    class StartWorld
    {
        private World ThisWorld;
        private List<Thief> thieves = new List<Thief>();
        private Thief thief;
        private List<Police> polices = new List<Police>();
        private Police police;
        private List<Pedestrian> pedestrians = new List<Pedestrian>();
        private Pedestrian pedestrian;
        private Random placement = new Random();

        public void Start()
        {
            Console.CursorVisible = false;
            string[,] sizeOfTown = new string[25, 100]; // Världen

            ThisWorld = new World(sizeOfTown);

            for (int i = 0; i <= 10; i++) // Lägga till T [Samma för de två for loopar där nere fast för P och M]
            {
                thief = new Thief(placement.Next(0, 100), placement.Next(0, 25));
                thieves.Add(thief);
            }

            for (int i = 0; i <= 20; i++)
            {
                police = new Police(placement.Next(0, 100), placement.Next(0, 25));
                polices.Add(police);
            }

            for (int i = 0; i <= 30; i++)
            {
                pedestrian = new Pedestrian(placement.Next(0, 100), placement.Next(0, 25));
                pedestrians.Add(pedestrian);
            }



            RunLoop();
        }


        private void FrameLoop()
        {
            Console.Clear();

            ThisWorld.Draw();
            foreach (Thief itemT in thieves) // Skriver ut alla T, P och M // [ser ut som att jag inte borde använt det sättet]
            {
                itemT.DrawThief();

            }

            foreach (Police itemP in polices)
            {
                itemP.DrawPolice();

            }

            foreach (Pedestrian itemM in pedestrians)
            {
                itemM.DrawPedestrian();

            }
        }

        private void RandomMovement()
        {

            foreach (Thief itemT in thieves) // Random rörelse för 'T'
            {
                switch (placement.Next(0, 6))
                {
                    case 0:

                        itemT.Y -= 1;


                        break;
                    case 1:

                        itemT.Y -= 1;
                        itemT.X += 1;


                        break;
                    case 2:


                        itemT.X += 1;

                        break;
                    case 3:

                        itemT.X += 1;
                        itemT.Y += 1;


                        break;
                    case 4:


                        itemT.Y += 1;

                        break;
                    case 5:

                        itemT.Y += 1;
                        itemT.X -= 1;


                        break;
                    case 6:

                        itemT.X -= 1;

                        break;
                    default:
                        break;
                }
                if (itemT.X > 100)
                {
                    itemT.X = 0;
                }
                else
                {
                    if (itemT.X == -1)
                    {
                        itemT.X = 100;
                    }
                }
                if (itemT.Y > 25)
                {
                    itemT.Y = 0;
                }
                else
                {
                    if (itemT.Y == -1)
                    {
                        itemT.Y = 25;
                    }
                }
            }
            foreach (Police itemP in polices) // Random rörelse för 'P'
            {
                switch (placement.Next(0, 6))
                {
                    case 0:

                        itemP.Y -= 1;


                        break;
                    case 1:

                        itemP.Y -= 1;
                        itemP.X += 1;


                        break;
                    case 2:


                        itemP.X += 1;

                        break;
                    case 3:

                        itemP.X += 1;
                        itemP.Y += 1;


                        break;
                    case 4:


                        itemP.Y += 1;

                        break;
                    case 5:

                        itemP.Y += 1;
                        itemP.X -= 1;


                        break;
                    case 6:

                        itemP.X -= 1;

                        break;
                    default:
                        break;
                }
                if (itemP.X > 100)
                {
                    itemP.X = 0;
                }
                else
                {
                    if (itemP.X == -1)
                    {
                        itemP.X = 100;
                    }
                }
                if (itemP.Y > 25)
                {
                    itemP.Y = 0;
                }
                else
                {
                    if (itemP.Y == -1)
                    {
                        itemP.Y = 25;
                    }
                }
            }
            foreach (Pedestrian itemM in pedestrians) // Random rörelse för 'M'
            {
                switch (placement.Next(0, 6))
                {
                    case 0:

                        itemM.Y -= 1;


                        break;
                    case 1:

                        itemM.Y -= 1;
                        itemM.X += 1;


                        break;
                    case 2:


                        itemM.X += 1;

                        break;
                    case 3:

                        itemM.X += 1;
                        itemM.Y += 1;


                        break;
                    case 4:


                        itemM.Y += 1;

                        break;
                    case 5:

                        itemM.Y += 1;
                        itemM.X -= 1;


                        break;
                    case 6:

                        itemM.X -= 1;

                        break;
                    default:
                        break;
                }
                if (itemM.X > 100)
                {
                    itemM.X = 0;
                }
                else
                {
                    if (itemM.X == -1)
                    {
                        itemM.X = 100;
                    }
                }
                if (itemM.Y > 25)
                {
                    itemM.Y = 0;
                }
                else
                {
                    if (itemM.Y == -1)
                    {
                        itemM.Y = 25;
                    }
                }
            }

        }

        private void RunLoop()
        {
            while (true)
            {
                FrameLoop();

                RandomMovement();

                //string populationLocationT = ThisWorld.Interactions(thief.X, thief.Y);
                //string populationLocationP = ThisWorld.Interactions(police.X, police.Y);
                //string populationLocationM = ThisWorld.Interactions(pedestrian.X, pedestrian.Y);
                //if (ThisWorld.Interactions(thief.X, thief.Y) == ThisWorld.Interactions(pedestrian.X, pedestrian.Y))  // Försökte ha interaktioner mellan karaktärerna men funkar ej... 
                //{
                //    Console.WriteLine("The thief stole something from a pedestrian");
                //    Thread.Sleep(2000);
                //}

                //string positionOfThief = ThisWorld.Interactions();
                //Interactions(positionOfThief);

                Thread.Sleep(200);
            }
        }

        public void Test(Person first, Person second)
        {
            if ((first is Thief && second is Pedestrian))
            {
                Console.WriteLine("Thief stole from Pedestrian!!!");
            }
        }


    }
}
