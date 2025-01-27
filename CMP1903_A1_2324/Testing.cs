﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        //creates 2 objects to test the game and the dice
        Game test_game = new Game();

        Die test_die = new Die();  
        

        public void test()
        {
            for (int i = 0; i < 50; i++);     //runs it 50 times to ensure that it is always correct
            {
                int test_value1 = test_die.roll();     //assigning a variable to the rolled dice to see if it passes the debug checks

                Debug.Assert(test_value1 < 7 && test_value1 > 0);

                int test_value2 = test_game.game_start();  //assigning a variable to the sum of hte rolled dice to see if it passes the checks

                Debug.Assert(test_value2 < 19 && test_value2 > 2);
            }

        }

        
    }
}
