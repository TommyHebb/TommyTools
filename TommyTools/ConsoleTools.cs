﻿using System;
using System.Linq;
using System.Reflection;

namespace TommyTools
{
    public class ConsoleTools
    {
        public static int GetSpecificExerciseToRun()
        {
            Devider();
            Console.WriteLine("Execute specific exercise? (exercisenumber/other) ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int result);
            if (isNumber == false) result = 0;
            return result;
        }
        public static bool Run(string exercise)
        {
            Devider();
            bool result = false;
            Console.WriteLine("Execute exercise '{0}'? (y/other) ", exercise);
            if (Console.ReadLine() == "y") result = true;
            return result;
        }
        public static void Devider(char sign = '=', int length = 120)
        {
            for (int increment = 1; increment < length - 1; increment++)
            {
                Console.Write(sign);
            }
            Console.WriteLine(sign);
        }
    }
}
