﻿using System;
using System.Text;


namespace HuntTheWumpus
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Game game = new Game();
            game.Start();


        }


    }
}
