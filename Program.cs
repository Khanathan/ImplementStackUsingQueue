namespace ImplementStackUsingQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack testStack = new MyStack();
            int? inputInt = 0;

            //Welcome message that prompts the user for input
            Console.WriteLine("Welcome to my stack. Please enter a real number to add to the Stack.");

            //Loop repeats until an empty input is entered.
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "") { break; }
                //Check for invalid input (only works for real numbers)
                while (!input.All(Char.IsDigit))
                {
                    Console.WriteLine("You have entered an invalid real number, please try again.");
                    input = Console.ReadLine();
                }

                inputInt = Convert.ToInt32(input);                
                
                testStack.Push((int)inputInt);
                Console.WriteLine("Enter another number to add to the stack or hit enter with no input to stop adding.");
            }
       
            Console.WriteLine("The Stack currently has " + testStack.Count + " items.");

            while (testStack.Count != 0)
            {
                Console.WriteLine(testStack.Pop());
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
            
        }
    }
}