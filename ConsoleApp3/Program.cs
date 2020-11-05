using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Person person1 = new Person()
            //    {
            //        Name = "Eli",
            //        Surname="Mamedov"
            //    };
            //    Person person2 = new Person()
            //    {
            //        Name = "Elik",
            //        Surname = "Mamedov"
            //    };
            //    Person person3 = new Person()
            //    {
            //        Name = "Elis",
            //        Surname = "Mamedov"
            //    };
            //    Person person4 = new Person()
            //    {
            //        Name = "Elim",
            //        Surname = "Mamedov"
            //    };
            //    Person person5 = new Person()
            //    {
            //        Name = "Elif",
            //        Surname = "Mamedov"
            //    };
            //    Person[] arr = { person1, person2, person3, person4, person5 };

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i].Name);
            //    }
            //    Console.WriteLine("=============================================");


            //    Person[] reversedPeople = ReversedArray(arr);
            //    for (int i = 0; i < reversedPeople.Length; i++)
            //    {
            //        Console.WriteLine(reversedPeople[i].Name);
            //    }



            //}
            //public static Person[] ReversedArray(Person[] people)
            //{

            //    Person[] reversedArray = new Person[people.Length];

            //    for (int i = 0; i < people.Length; i++)
            //    {
            //        reversedArray[reversedArray.Length - (i + 1)] = people[i];
            //    }
            //    return reversedArray;


            Console.WriteLine("input size");

            int size = Convert.ToInt32(Console.ReadLine());



            string[] array = new string[size];

            Console.WriteLine("input names");


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();

            }

            bool wanttocontinue = true;

            while (wanttocontinue)
            {
                string wanttocontinueanswer;

                do
                {
                    Console.WriteLine("\n=============================");
                    Console.WriteLine("Davam etmek isteyirsinizmi? y/n");
                    wanttocontinueanswer = Console.ReadLine();





                } while (wanttocontinueanswer != "y" && wanttocontinueanswer != "n");

                //wanttocontinue = wanttocontinueanswer == "y" ? true : false;
                if (wanttocontinueanswer == "y" && wanttocontinueanswer != "n")
                {
                    wanttocontinue = true;
                    array[array.Length - 1] = Console.ReadLine();
                }
                else
                {
                    wanttocontinue = false;
                }
                Array.Resize(ref array, array.Length + 1);


                Console.WriteLine();



            }
            for (int j = 0; j < array.Length; j++)
            {

                Console.Write(array[j] + " ");

            }



        }



    }
}
