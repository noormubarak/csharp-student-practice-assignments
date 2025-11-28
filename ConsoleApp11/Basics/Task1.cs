using System;

class Program
{
    static void Main()
    {
        // Basic 1
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Hello {name}, you are {age} years old.");

        // Basic 2
        Console.Write("Enter temperature in Celsius: ");
        double c = double.Parse(Console.ReadLine());
        double f = c * 9 / 5 + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {f}");

        // Basic 3
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area: {length * width}, Perimeter: {2 * (length + width)}");

        // Conditionals 1
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int n3 = int.Parse(Console.ReadLine());
        int largest = n1;
        if (n2 > largest) largest = n2;
        if (n3 > largest) largest = n3;
        Console.WriteLine($"The largest number is: {largest}");

        // Conditionals 2
        string storedUser = "admin";
        string storedPass = "1234";
        Console.Write("Username: ");
        string u = Console.ReadLine();
        Console.Write("Password: ");
        string p = Console.ReadLine();
        Console.WriteLine(u == storedUser && p == storedPass ? "Login successful" : "Login failed");

        // Loops 1
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        int sumN = 0;
        for (int i = 1; i <= N; i++) sumN += i;
        Console.WriteLine($"Sum = {sumN}");

        // Arrays 1
        int[] arr5 = new int[5];
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < 5; i++) arr5[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("You entered:");
        foreach (int val in arr5) Console.Write(val + " ");
        Console.WriteLine();

        // Arrays 2
        int sumArr5 = 0;
        foreach (int v in arr5) sumArr5 += v;
        Console.WriteLine($"Sum of elements = {sumArr5}");

        // Arrays 3
        int[] arr6 = new int[6];
        Console.WriteLine("Enter 6 integers:");
        for (int i = 0; i < 6; i++) arr6[i] = int.Parse(Console.ReadLine());
        int max6 = arr6[0];
        foreach (int v in arr6) if (v > max6) max6 = v;
        Console.WriteLine($"Largest value = {max6}");

        // Arrays 4
        int[] arr10 = new int[10];
        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++) arr10[i] = int.Parse(Console.ReadLine());
        int evenCount = 0;
        foreach (int val in arr10) if (val % 2 == 0) evenCount++;
        Console.WriteLine($"Even numbers count = {evenCount}");

        // Square
        Console.Write("Enter a number to square: ");
        int sq = int.Parse(Console.ReadLine());
        Console.WriteLine($"Square = {sq * sq}");

        // Average
        Console.WriteLine("Enter three numbers for average:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Average = {(a + b + c2) / 3}");

        // Factorial
        Console.Write("Enter a number for factorial: ");
        int fIn = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= fIn; i++) fact *= i;
        Console.WriteLine($"Factorial = {fact}");

        // Even/Odd
        Console.Write("Enter a number to check even/odd: ");
        int eo = int.Parse(Console.ReadLine());
        Console.WriteLine(eo % 2 == 0 ? "Even" : "Odd");
    }
}
