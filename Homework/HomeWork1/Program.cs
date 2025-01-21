using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

// Lendo uma string
Console.WriteLine("Type something:");
string fullName = Console.ReadLine()!;
Console.WriteLine($"You typed: {fullName}");

// Lendo string e tentando converter em int
Console.WriteLine("Type a number:");
string numberString = Console.ReadLine()!;

// Colocou na variavel number
int.TryParse(numberString, out int number);
Console.WriteLine($"You typed: {number}");

// Le uma string e tenta converter em uma data do formato americano
Console.WriteLine("Enter a date:");
string dateTimeString = Console.ReadLine()!;
if (!DateTime.TryParseExact(dateTimeString,"M/d/yyyy HH:mm",new CultureInfo("en-US"),DateTimeStyles.None,out DateTime dateTime)){
    dateTime = DateTime.Now;
}
Console.WriteLine($"The date is: {dateTime}");

// Lendo teclas especificas
ConsoleKeyInfo pressedKey = Console.ReadKey();
switch (pressedKey.Key)
{
    case ConsoleKey.S: 
        Console.WriteLine("S key pressed");
        break;
    case ConsoleKey.F1:
        Console.WriteLine("F1 key pressed");
        break;
    case ConsoleKey.Escape:
        Console.WriteLine("Escape key pressed");
        break;
}

// Escrevendo saida
Console.Write("Enter a name: ");
string name = Console.ReadLine()!;
Console.WriteLine("Hello, {0}!", name);


string tableNumber = "A100";
int peopleCount = 4;
DateTime reservationDateTime = new DateTime(2017, 10, 28, 11, 0, 0);
CultureInfo cultureInfo = new CultureInfo("en-US");
Console.WriteLine("Table {0} has been booked for {1} people on {2} at {3}",tableNumber,peopleCount, reservationDateTime.ToString("M/d/yyyy",
 cultureInfo),reservationDateTime.ToString("HH:mm", cultureInfo) );