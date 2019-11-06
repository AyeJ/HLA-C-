using System;
using System.Collections;
using System.Collections.Generic;

class LinkedList
{

    // Driver code 
    public static void Main()
    {

        // Creating a LinkedList of Strings 
        LinkedList<String> myList = new LinkedList<String>();

        // Adding nodes in LinkedList 
        myList.AddLast("'First node'");
        myList.AddLast("Second node");
        myList.AddLast("Third node");
        myList.AddLast("'Fourth node");


        Console.WriteLine("Total nodes in myList are : " + myList.Count);
        if (myList.Count > 0)
            Console.WriteLine("First value of the list is "+ myList.First.Value);
        else
            Console.WriteLine("LinkedList is empty");

       
        if (myList.Count > 0)
            Console.WriteLine("Last value of the list is " + myList.Last.Value);
        else
            Console.WriteLine("LinkedList is empty");

        Console.WriteLine("After Removing node from the list");

        myList.Remove("Fourth node");
        Console.WriteLine("Total nodes in myList are : " + myList.Count);

    }
}