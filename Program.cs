﻿using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name},сегодня {DateTime.Now:dd.MM.yyyy}");
            Console.ReadLine();
        }
    }
}
