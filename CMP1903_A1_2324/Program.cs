using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */


            Game play = new Game();  //creates a game object

            play.game_start();  //runs the method to start teh game in the game class

            Testing test = new Testing();   //creates a testing object

            test.test();   //runts the test method in the test object





        }
    }
}
