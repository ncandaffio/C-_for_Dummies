﻿using System;

// InheritanceExample -- Provide the simplest possible
//    demonstration of inheritance.
namespace InheritanceExample
{
    public class BaseClass
    {
        public int _dataMember;
        public void SomeMethod()
        {
            Console.WriteLine("SomeMethod()");
        }
    }

    public class SubClass : BaseClass
    {
        public void SomeOtherMethod()
        {
            Console.WriteLine("SomeOtherMethod()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a base class object.
            Console.WriteLine("Exercising a base class object:");
            BaseClass bc = new BaseClass();
            bc._dataMember = 1;
            bc.SomeMethod();

            // Now create a subclass object.
            Console.WriteLine("Exercising a subclass object:");
            SubClass sc = new SubClass();
            sc._dataMember = 2;

            // Execute some subclass-specific code.
            sc.SomeMethod();
            sc.SomeOtherMethod();

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
