﻿using System;
using System.Linq;

namespace TommyTools
{
    public abstract class BaseExercise
    {
        public abstract string Name { get; set; }

        public abstract int Number { get; set; }

        public abstract void Exec();

        public int GetNumber()
        {
            return Number;
        }

        sealed public override string ToString()
        {
            return string.Format("Oefening: {0, 3} - {1} ", Number, Name);
        }

        public void NeedsExecution(int[] exerciseNumbersThatNeedExecution)
        {
            if (exerciseNumbersThatNeedExecution.Contains(Number))
            {
                ConsoleTools.Devider();
                Console.WriteLine("Ready to execute exercise {0}. Press ENTER to continue... ", Number);
                ConsoleTools.Devider('-', 60);
                Console.ReadLine();
                Exec();
            }
        }
    }
}
