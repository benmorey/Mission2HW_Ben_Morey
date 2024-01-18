using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2HW_Ben_Morey
{
    internal class Dice
    {
        //Declaring Class Variables
        int[] rollCount;
        int rolls;
        string[] outputArray;
        Dictionary<int, int> totalCount;

        //Constructor
        public Dice() 
        {
            rolls = 0;
            totalCount = new Dictionary<int, int>();
            totalCount[2] = 0;
            totalCount[3] = 0;
            totalCount[4] = 0;
            totalCount[5] = 0;
            totalCount[6] = 0;
            totalCount[7] = 0;
            totalCount[8] = 0;
            totalCount[9] = 0;
            totalCount[10] = 0;
            totalCount[11] = 0;
            totalCount[12] = 0;
        }

        //Rolling the dice in said number of rolls
        public Array RollDice(int numRolls)
        {
            //Populates the class' variables
            rollCount = new int[numRolls];
            rolls = numRolls;

            //Rolling two dice
            for (int i = 0; i <= numRolls - 1; i++) 
            {
                int diceA = 0;
                int diceB = 0;
                int diceTotal = 0;
                Random r = new Random();

                diceA = r.Next(1,7);
                diceB = r.Next(1, 7);
                diceTotal = diceA + diceB;

                rollCount[i] = diceTotal;
            }

            //Generating from the rolls array the sum of each number's apperances with the rolls
            for (int i = 0; i < rollCount.Length; i++)
            {
                for (int j = 2; j <= 12; j++)
                {
                    if (rollCount[i] == j)
                    {
                        totalCount[j] = totalCount[j] + 1;
                    }
                }
            }
            
            //Generating the percentage a roll total makes up
            for (int j = 2; j <= 12; j++)
            {
                totalCount[j]  = (totalCount[j] * 100) / rolls;
            }

            //Making the array to return
            outputArray = new string[13];

            //Generating the String Output
            string outputLine = "";

            //Making a Dynamic '*' graph, based on percentage
            for (int i = 2; i <= 12; i++)
            {

                outputLine = i + ": "; //It should look like '4: '
                for (int j = 0; j < totalCount[i]; j++)
                {
                    outputLine += "*"; //Adding stars
                }
                outputArray[i] = outputLine;
            }

            return outputArray; // Returning the string

        }
    }
}
