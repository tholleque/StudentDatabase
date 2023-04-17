namespace StudentDataBase
{
    public class Program
    {
        public static void Main()
        {
            string[] names = { "Tim", "Alec", "Martha", "Layla" }; //Layla is a cat
            string[] hometown = { "Kalamazoo", "Parchment", "Holland", "Jackson" };
            string[] food = { "Pho", "Pizza", "Chocolate", "Tuna - Layla is  Cat" };

            bool goOn = true;
            
            

            Console.WriteLine("Welcome to the Student DataBase.");
            Console.WriteLine();
            while (goOn = true)
            {
                Console.WriteLine("Type (A) to search by student name OR (B) to view the list:");
                string option = Console.ReadLine().ToLower();
                if(option == "a")
                {
                    Console.WriteLine("Enter student name (spelling and case sensitive: ");
                    string name = Console.ReadLine();
                    int output = LinearSearch(names, name);
                    if (output == -1)
                    {
                        Console.WriteLine("Student not found or misplelled. Try again.");
                    }
                    else
                    {
                    Console.WriteLine($"{names[output]}'s favorite food is {food[output]}.");
                    Console.WriteLine($"{names[output]}'s hometown is {hometown[output]}.");
                    }
                }                 
                else if(option == "b")
                {

                
                    Console.WriteLine();
                    Console.WriteLine("Please select a student from the list to learn about (enter the corresponding number):");
                    PrintArray(names);
                    Console.WriteLine();
                    int input = int.Parse(Console.ReadLine());

                    if (input >= names.Length + 1 || input < 1)
                    {
                        Console.WriteLine("That number is not listed, are your eyes okay? Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Student: " + names[input - 1]);
                        Console.WriteLine("What you you like to know about this student? Enter Hometown or Favortie Food?");
                        string choice = Console.ReadLine().ToLower().Trim();
                        if (choice == "hometown" || choice == "home")
                        {
                            Console.WriteLine("Hometown: " + hometown[input - 1]);
                        }
                        else if (choice == "favorite food" || choice == "food")
                        {
                            Console.WriteLine("Favorite Food: " + food[input - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Spelling isn't your strong suit, huh? Try again.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Select only A or B.");
                }


                goOn = Continue();
            }
        }
        public static string PickStudent(string[] names)
        {
            PrintArray(names);
            Console.WriteLine("Please select a student:");
            string input = Console.ReadLine();
            int pick = int.Parse(input);
            return names[pick];
        }
        public static void PrintArray(string[] arr)
        {
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine(i + " " + arr[i-1]);
            }
        }
        public static bool Continue()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to continue? y/n");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Enter y or n...it says it right there. :|");
                return Continue();
            }
        }
        public static int LinearSearch(string[] arr, string sel)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == sel)
                {
                    return i;
                   
                }
            }
            return -1;
        }
      

    }
}