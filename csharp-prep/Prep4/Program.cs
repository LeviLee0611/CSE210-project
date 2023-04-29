using System;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        while(true) {
            Console.WriteLine("Please enter a number (enter 0 to stop): ");

            int number = int.Parse(Console.ReadLine());
            
            if (number ==0){
                break;
            }

            numbers.Add(number);
        }
            int sum = 0;
            foreach (var num in numbers){
                sum += num;
            }

            Console.WriteLine($"The sum is {sum}");

            float average = (float)sum / (float)numbers.Count;
            
            
            Console.WriteLine($"The average is {average}");

            int max = 0;
            
            foreach (int number in numbers)

            if (number > max){

                max = number;
                           
            Console.WriteLine($"The max is {max}");

            }
    }
}