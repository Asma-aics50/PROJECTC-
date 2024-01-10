namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>()  ;
        
        
        char letter = '\0';
        do
        {
            Console.WriteLine("P - Print numbers ");
            Console.WriteLine("A - Add a  number ");
            Console.WriteLine("M - Display mean of numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("l - Display the largest numbers");
            Console.WriteLine("N - Search for number in list ");
            Console.WriteLine("C - Clear the list ");
            Console.WriteLine("Q - Quit");

            Console.Write("Enter your choice: ");
            letter = char.ToUpper(Convert.ToChar(Console.ReadLine()));


            if (letter == 'P')
            {

                if (myList.Count > 0)
                {
                    Console.Write("[ ");
                    for (int i = 0; i < myList.Count; i++)
                    {
                        Console.Write($"{myList[i]} ");
                    }
                    Console.WriteLine("] ");



                }

                else if (myList.Count == 0)
                {
                    Console.WriteLine("[] - the list is empty");

                }

            }


            else if (letter == 'A')
            {

                Console.Write("enter the intger number :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (!myList.Contains(num1)) //Addational  functional in my code
                {
                    myList.Add(num1);
                    Console.WriteLine($"{num1} added");
                }
                else
                {
                    Console.WriteLine("this number is dublicated, please enter new number");
                }



            }

            else if (letter == 'M')
            {
                int sum = 0;
                double mean = 0.0;


                if (myList.Count > 0)
                {
                    for (int i = 0; i <= myList.Count; i++)
                    {
                        sum = sum + i;
                        mean = (double)sum / myList.Count;


                    }

                    Console.WriteLine(mean);


                }

                else if (myList.Count == 0)
                {

                    Console.WriteLine("Uneble to calculate the mean - no data");
                }


            }



            else if (letter == 'S')
            {

                if (myList.Count > 0)
                {

                    int smallest = myList[0];
                    for (int i = 0; i <= myList.Count - 1; i++)
                    {

                        if (myList[i] < smallest)

                            smallest = myList[i];

                    }

                    Console.WriteLine($"the smallest number  is :{smallest}");
                }
                else if (myList.Count == 0)
                {

                    Console.WriteLine("Uneble to determine the smallest number  - list is empty");
                }

            }

            else if (letter == 'L')
            {

                if (myList.Count > 0)
                {
                    int largest = myList[0];
                    for (int i = 0; i <= myList.Count - 1; i++)
                    {

                        if (myList[i] > largest)
                            largest = myList[i];

                    }

                    Console.WriteLine($"the largest number  is :{largest}");
                }
                else if (myList.Count == 0)
                {

                    Console.WriteLine("Uneble to determine the largest number  - list is empty");
                }

            }


            else if (letter == 'N') //Addtional Function in my code
            {
                Console.Write("search number :");
                int numSearch = Convert.ToInt32(Console.ReadLine());
                if (myList.Contains(numSearch))
                {

                    Console.WriteLine($"the search number {numSearch} is exist");
                }
                else 
                {
                    string yes = "\0";
                    string no = "\0";
                    string result = "\0";
                   
                    Console.WriteLine("the search number not  exist in my list");
                    Console.WriteLine("Do you want to add number in my list ?");
                    Console.Write("enter yes/no :");
                    result = Console.ReadLine();
                    if (result == "yes") {

                        Console.WriteLine("enter the number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        myList.Add(num);
                        Console.WriteLine($"{num} addded");


                    } else if (result =="no") {

                        Console.WriteLine("As you like:)");

                    }





                }




            }
            else if (letter == 'C') //Additional Function in my code 
            {

                myList.Clear();

            }
            else if (letter == 'Q')
            {
                Console.WriteLine("Good bye");
            }

        } while (letter != 'Q');
        

        
        
    }
}

