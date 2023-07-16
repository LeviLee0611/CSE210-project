using System;

class Program
{
    static void Main(string[] args)
    {

int duration = 27;
int breatheInDuration = 4;
int breatheOutDuration = 6;

DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(5);

while (futureTime > DateTime.Now){
    Console.WriteLine("Breat In");
    Countdown(breatheInDuration);
    Thread.Sleep(breatheInDuration * 1000);
    // Thread.Sleep(breatheInDuration * 1000);

    Console.WriteLine("Breat out");
    Countdown(breatheOutDuration);
    Thread.Sleep(breatheOutDuration * 1000);

    // show end message   

    
Thread.Sleep(3000);

DateTime currentTime = DateTime.Now;
if (currentTime < futureTime)
{
    Console.WriteLine("We have not arrived at our future time yet...")
}
}
    }
static void CountDown(int duration) {
    int currnetValue = duration;

    while (currnetValue > 0) {
        Console.WriteLine(currentValue);
        Thread.Sleep(1000);
        currnetValue--;
    }   
}
}