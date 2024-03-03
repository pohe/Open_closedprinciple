using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Open_closedprinciple
{
    public static class OCP1
    {
        

        //The Open-Closed Principle (OCP) states that software entities
        //(classes, modules, functions, etc.) should be open for extension
        //but closed for modification. In other words, once a class is
        //implemented and tested, it should not be modified to add new
        //functionality.Instead, new functionality should be added by
        //extending the class.
        //In the provided code, the implementation of the OCP can be observed.
        //The Shape class is an abstract base class that defines a common
        //interface for all shapes. It has an abstract method Area() that
        //calculates the area of a shape. This allows for different shapes
        //to implement their own logic for calculating the area.
        //The Rectangle and Circle classes are concrete implementations of
        //the Shape class. They extend the Shape class and provide their own
        //implementation of the Area() method. This demonstrates the open
        //part of the OCP, as new shapes can be added by creating new classes
        //that extend the Shape class without modifying the existing code.
        //The AreaCalculator class is responsible for calculating the total
        //area of an array of shapes.It takes an array of Shape objects as
        //a parameter in its CalculateTotalArea() method.It then iterates
        //over each shape in the array and calls its Area() method to calculate
        //the area.This class does not need to be modified when new shapes are
        //added, as long as they implement the Shape interface. This demonstrates
        //the closed part of the OCP, as the AreaCalculator class is closed
        //for modification and can be reused without changes.
        //Overall, the code adheres to the Open - Closed Principle by allowing
        //for the extension of functionality through inheritance and avoiding
        //the need for modifications to existing code when new shapes are added.

        //      Opgave: Tilføjelse af en trekant (class Triangle)
        //      Du er blevet bedt om at tilføje funktionalitet til det eksisterende
        //      kodeeksempel, så det også kan håndtere beregningen af arealet for en
        //      trekant.Følg disse trin for at løse opgaven:

        //1.	Tilføj en ny klasse kaldet Triangle under OCP1-klassen.
        //      Denne klasse skal også arve fra Shape-klassen.
        //2.	I Triangle-klassen skal du tilføje to egenskaber:
        //      Base og Height, der repræsenterer længden af grundlinjen og højden
        //      af trekanten.
        //3.	Implementer Area()-metoden i Triangle-klassen ved at multiplicere
        //      grundlinjen (Base) med højden (Height) og dividere resultatet med 2.
        //4.	I OCP1.Run()-metoden skal du oprette en ny instans af Triangle og
        //      tilføje den til arrayet af Shape-objekter.
        //5.	Kør programmet og kontroller, om det korrekt beregner arealet
        //      for trekanten sammen med rektanglet og cirklen.

        //      Opgave del 2
        //      Kan du udvide klassen Triangle med en metode til at beregne
        //      omkredsen (Perimeter)?
        //      Implementer metoden i klassen Triangle
        //      Bryder den med Open Closed principle?

        public abstract class Shape
        {
            public abstract double Area();
        }
        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area()
            {
                return Width * Height;
            }
        }
        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }
        public class AreaCalculator
        {
            public double CalculateTotalArea(Shape[] shapes)
            {
                double totalArea = 0;
                foreach (Shape shape in shapes)
                {
                    totalArea += shape.Area();
                }
                return totalArea;
            }
        }

        public static void Run()
        {
            Shape[] shapes = new Shape[]
            {
            new Rectangle { Width = 5, Height = 10 },
            new Circle { Radius = 7 }
            };
            AreaCalculator calculator = new AreaCalculator();
            double totalArea = calculator.CalculateTotalArea(shapes);

            Console.WriteLine($"Total area: {totalArea}");
        }
    }
}
