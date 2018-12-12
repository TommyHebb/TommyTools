using System;
using System.Linq;
using System.Reflection;

namespace TommyTools
{
    public class ArrayTools
    {
        public static bool _isAConsolePresent = false;

        static ArrayTools()
        {
            _isAConsolePresent = Environment.UserInteractive && Console.Title.Length > 0;
        }

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
                myClassesArray[index] = myExercise;
                index++;
                if (_isAConsolePresent)
                {
                    Console.WriteLine(myExercise.ToString());
                }
            }
            if (_isAConsolePresent)
            {
                Console.WriteLine();
            }

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
        }
    }
}
