using System;

namespace game
{    
    class Program
    {
        static void Main(string[] args)
        {
            var personOne = new Person("luke skywalker");

            var byuiPerson = new BYUIPerson("obi-wan", "1");

            var studnetOne = new Student("darth vader", "2", "the dark side of the force");
        }
    }
}

class Person {
    protected string _name;

    public Person(string name){
        _name = name;
    }
}

class BYUIPerson: Person {
    protected string _iNumber;

    public BYUIPerson(string name, string iNumber): base(name) {
        _iNumber =iNumber;
    }
}


class Student: BYUIPerson{
    private string _major;

    public Student (string name, string iNumber, string marjor): base(name, iNumber) {
        _major = marjor;
    }
}
class Teacher: BYUIPerson {
    private string _department;

    public Teacher(string name, string iNumber, string department): base(name, iNumber){
        _department = department;
    }
}