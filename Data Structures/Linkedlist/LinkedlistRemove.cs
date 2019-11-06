 
using System;
using System.Collections;
using System.Collections.Generic;

class GFG
{

    // Driver code 
    public static void Main()
    {
        // Creating a LinkedList of Strings 
        LinkedList<String> myList = new LinkedList<String>();

        // Adding nodes in LinkedList 
        myList.AddLast("A");
        myList.AddLast("B");
        myList.AddLast("C");
        myList.AddLast("D");
        myList.AddLast("E");

        // To get the count of nodes in LinkedList 
        // before removing all the nodes 
        Console.WriteLine("Total nodes in myList are : " + myList.Count);

        // Displaying the nodes in LinkedList 
        foreach (string str in myList)
        {
            Console.WriteLine(str);
        }

        // Removing the specified node from the LinkedList 
        myList.Remove("D");

        // To get the count of nodes in LinkedList 
        // after removing all the nodes 
        Console.WriteLine("Total nodes in myList are : " + myList.Count);

        // Displaying the nodes in LinkedList 
        foreach (string str in myList)
        {
            Console.WriteLine(str);
        }
    }
}
