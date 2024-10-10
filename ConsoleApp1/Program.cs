using ConsoleApp1;
using System.Runtime.CompilerServices;


Console.WriteLine("start Suma");
SumNumberEven sumNumbers = new SumNumberEven();
int[] arrayNumeros = { 2,4,5 };
int total = sumNumbers.SumNumber(arrayNumeros);
Console.WriteLine($"Suma total: { total } ");
Console.WriteLine("end Suma");



Console.WriteLine("start circunferencia");
CircleWrapper circle = new CircleWrapper(5); //Instance the circle wrapper
double circumference = circle.CalculateCircumference(); //calculate circle usin wrapper
Console.WriteLine($"La circunferencia del círculo es: {circumference}");
Console.WriteLine("end circunferencia");


