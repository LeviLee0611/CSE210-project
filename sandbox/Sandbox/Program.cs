using System;

namespace game
{    
    class Program
    {
        static void Main(string[] args)
        {
            // object
            // instance
            var Layne= new Person("Layne", "Moseley");
            var David= new Person("David", "Hasselhoff");

            Layne.Talk();
            David.Talk();
        }
    }
}

// classification (keyword)
class Person {

    // attributes
    // properties
    string firstName;
    string lastName;

    //  constructor
    public Person(string fn, string ln) {
        firstName = fn;
        lastName = ln;
    }

    // behaviors
    // method
    public void Breathe() {
        Console.WriteLine("Breating");
    }

    public void Walk() {
        Console.WriteLine("Walking");
    }

    public void Talk() {
        Console.WriteLine($"Hi! my name is {firstName} {lastName}");
    }

    public string FullName() {
        // return $"{firstName} {lastName}";
        
        // string full = String.Concat(firstName, lastName);
        // return full;

        return firstName + " " + lastName;
    }

}


using System;

class Program
{
    static void Main(string[] args)
    {
        var savings = new Account();
        savings.Deposit(500);
        savings.Deposit(1000);

        savings._transactions.Add(400);
    }
}

public class Account{
    private List<int> _transactions = new List<int>();

    public void Deposit(int amount){
        _transactions.Add(amount);
    }

    public int Balance(){
        var balance = 0;
        foreach (var transaction in _transactions){
            balance += transaction;
        }

        return balance;
    }
}