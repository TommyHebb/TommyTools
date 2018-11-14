using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TommyTools
{
    public class ConsoleTools
    {
        public object[] GetObjectArrayOfClasses(string nmspace, string classesStartingWith)
        {
            var exercisesArray = from target in Assembly.GetCallingAssembly().GetTypes()
                                 where target.IsClass && target.Namespace == nmspace && target.Name.StartsWith(classesStartingWith)
                                 orderby target.Name
                                 select target;
            exercisesArray.ToArray();

            object[] myClassesArray = new Object[exercisesArray.Count()];
            object myExercise;
            int index = 0;

            foreach (var clss in exercisesArray)
            {
                myExercise = Activator.CreateInstance(clss);
                Console.WriteLine("myExercise: '{0}' ", myExercise.GetType());
                myClassesArray[index] = myExercise;
                index++;
                Console.WriteLine(myExercise.ToString());
            }
            Console.WriteLine();

            return myClassesArray;
        }
        public int[] AddExerciseNumberToGivenArrayAndGiveBackNewArray(int exerciseNumber, int[] givenArray)
        {
            int arrayLength = givenArray.Length;
            int[] newArray = new int[arrayLength + 1];

            for (int index = 0; index < arrayLength; index++)
            {
                newArray[index] = givenArray[index];
            }
            newArray[arrayLength] = exerciseNumber;

            return newArray;
            /* NEEDS FOLLOWING CODE IN IMPLEMENTATION CLASS TO BE USED:
            ConsoleTools consoleTools = new ConsoleTools();
            int[] exercisesToRun = new int[0];
            bool isNumber;
            
            do
            {
                Console.WriteLine("Please enter the exercise you wish to run... (0 is not valid) ");
                isNumber = int.TryParse(Console.ReadLine(), out int result);
                if (isNumber && result != 0)
                {
                    exercisesToRun = consoleTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(result, exercisesToRun);
                    Console.Write("Exercise {0} added to list. ", result);
                }
            }
            while (isNumber);
            
            Console.WriteLine();
            
            foreach (Exercise exercise in exercises)
            {
                exercise.NeedsExecution(exercisesToRun);
            }
            */
        }
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
