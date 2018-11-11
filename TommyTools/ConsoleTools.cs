using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TommyTools
{
    public class ConsoleTools
    {
        public int[] AddExerciseNumberToGivenArrayAndGiveBackNewArray(int exerciseNumber, int[] givenArray)
        {
            int[] newArray = new int[0];

            if (exerciseNumber != 0)
            {

            }
            else
            {
                if (givenArray.Length == 0)
                {
                    newArray = new int[1];
                    newArray[0] = 0;
                }
                else
                {
                    newArray = givenArray;
                }
            }

            return newArray;
        }
        public static int GetSpecificExerciseToRun()
        {
            Devider();
            Console.WriteLine("Execute specific exercise? (exercisenumber/other) ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int result);
            if (isNumber == false) result = 0;
            return result;
        }
        public static int[] GetSpecificExercisesToRun()
        {
            Devider();
            int count = 0;
            int[] exercisesArray = new int[0];
            int[] oldExercisesArray = new int[1];
            bool isNumber;
            do
            {
                Console.WriteLine("Execute specific exercises? (next exercisenumber/other) ");
                isNumber = int.TryParse(Console.ReadLine(), out int result);
                if (isNumber)
                {
                    count++;
                    exercisesArray = new int[count];
                    if (count == 1)
                    {
                        exercisesArray[0] = result;
                    }
                    else
                    {
                        for (int index = 0; index < oldExercisesArray.Count(); index++)
                        {
                            exercisesArray[index] = oldExercisesArray[index];
                        }
                        exercisesArray[count - 1] = result;
                    }
                    oldExercisesArray = new int[exercisesArray.Count()];
                    for (int index = 0; index < exercisesArray.Count(); index++)
                    {
                        oldExercisesArray[index] = exercisesArray[index];
                        if (exercisesArray[index] != 0)
                        {
                            Console.WriteLine("Exercise '{0}' will be executed", exercisesArray[index]);
                        }
                    }
                }
                else
                {
                    if (count <= 0)
                    {
                        exercisesArray = new int[1];
                        exercisesArray[0] = 0;
                        Console.WriteLine("All exercises will be presented for execution");
                    }
                    else if ((count == 1) && (exercisesArray[0] == 0))
                    {
                        Console.WriteLine("All exercises will be presented for execution");
                    }
                }
            }
            while (isNumber);

            return exercisesArray;
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
