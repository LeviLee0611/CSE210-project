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