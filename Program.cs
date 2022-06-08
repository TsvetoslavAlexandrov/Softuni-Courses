using System.Collections.Generic;
using System;
class MainClasdsss
{
    static void Main2(string[] args)
    {

        var str = Console.ReadLine();
        var Stack = new Stack<char>();

        foreach (var ch in str)
        {
            Stack.Push(ch);
        }
        while (Stack.Count > 0)
        {
            Console.Write(Stack.Pop());
        }
       


    }
}
