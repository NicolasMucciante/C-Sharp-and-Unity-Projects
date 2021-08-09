using System;
using System.Collections.Generic;



    class Program
    {
    static void Main()
    {
        //One-dimensional Array of strings
        string[] fruitsArray = new string[] { "Apple", "Banana", "Kiwi", "Orange" };
        Console.WriteLine("Please select an index for the array.") ;
        int fruitChoiceNum = Convert.ToInt32(Console.ReadLine());

        while (fruitChoiceNum > fruitsArray.Length) //This loop is incase the user selects an index that doesnt exist
        {
            Console.WriteLine("Sorry that index does not exist. Try again.");
            fruitChoiceNum = Convert.ToInt32(Console.ReadLine());
        }
        string fruitUserChoice = fruitsArray[fruitChoiceNum];
        Console.WriteLine(fruitUserChoice);
        //END One-dimensional Array of strings

        //one-dimensional array of integers
        int[] intArray = new int[] { 1, 5, 7, 4, 10, 50 };
        Console.WriteLine("Please select an index for the integer array");
        int intChoiceNum = Convert.ToInt32(Console.ReadLine());

        if (intChoiceNum > intArray.Length)
        {
            Console.WriteLine("Sorry that index is to large. Please choose another number.");
            intChoiceNum = Convert.ToInt32(Console.ReadLine());
        }

        int intChoice = intArray[intChoiceNum];
        Console.WriteLine(intChoice);

        //List of strings
        List<string> states = new List<string>();
        states.Add("Oregon");
        states.Add("Washington");
        states.Add("California");
        states.Add("Texas");
        states.Add("Nevada");

        Console.WriteLine("Please select an item from the array");
        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice > states.Count - 1)
        {
                       
            Console.WriteLine("Sorry, that doesnt exist, Pick a number 0-4");
            choice = Convert.ToInt32(Console.ReadLine());
                        
        }
            string userChoice = states[choice];
            Console.WriteLine(userChoice);
            Console.ReadLine();
        // END List of strings

    }
}

