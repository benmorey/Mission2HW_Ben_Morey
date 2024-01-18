//STUDENT: David "Ben" Morey Jr
//SECTION: 003
//CLASS: IS 413

using Mission2HW_Ben_Morey;

public class Program
{
    private static void Main(string[] args)
    {
        //Creates the dice object
        Dice d = new Dice();

        //Creates the number of Roles needed
        string desiredRolls = " ";

        //Starts of the Program, the Dice Rolling Game
        System.Console.WriteLine("\U0001f0b1 Welcome to the Dice Rolling Game! \U0001f0b1"
            + "\n" + "How many dice do you want to roll?");

        //Takes in inputs for the number of roles
        desiredRolls = System.Console.ReadLine();

        //Gets the output array from the class for the percentages of die rolls
        string[] outputArray = (string[])d.RollDice(int.Parse(desiredRolls));

        // Generating the output
        string outputLine = "\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" " +
                "represents 1% of the total number of rolls.\n" +
                "Total number of rolls = " + desiredRolls + "\r";

        string closingLine = "Thank you for using the dice throwing simulator. Goodbye!";


        System.Console.WriteLine(outputLine);

        //Itterating through the Array
        for (int i = 0; i < outputArray.Length; i++) 
        {
            System.Console.WriteLine(outputArray[i]);
        }
        System.Console.WriteLine(closingLine);



    }
}