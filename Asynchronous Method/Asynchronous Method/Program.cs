﻿using System;
using System.Threading.Tasks;

class Slution
{

    static async Task Main(string[] args)
    {
        Task<int> result = LongProcess();

        ShortProcess();

        var val = await result; // wait untile get the return value

        Console.WriteLine("Result: {0}", val);

        Console.ReadKey();
    }

    static async Task<int> LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");

        return 10;
    }

    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }


}