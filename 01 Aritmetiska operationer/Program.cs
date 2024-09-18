// Koden bor i Github, på https://github.com/ClaesE/03-Operatorer-och-Uttryck-DEMO


int squareParameter = 17;
double squareSide = squareParameter / 4.0;
double squareArea = squareSide * squareSide;
Console.WriteLine(squareSide);
Console.WriteLine(squareArea);

int a = 5;
int b = 4;
Console.WriteLine(a + b);
Console.WriteLine(a + b++);
Console.WriteLine(a + b);
Console.WriteLine(a + (++b));   // Parentes runt ++b behövs inte, men det blir tydligare att läsa och förstå
Console.WriteLine(a + b );  // 11 (a = 5, b=6)

Console.WriteLine(a + b * 2);   // 17
Console.WriteLine((a + b) * 2);   // 22

Console.WriteLine(12 / 3);              // 4
Console.WriteLine(11 / 3); 				// 3

Console.WriteLine();
Console.WriteLine(11.0 / 3);        // 3.666666667
Console.WriteLine(11 / 3.0);        // 3.666666667
Console.WriteLine(11 % 3);          // 2
Console.WriteLine(11 % -3);         // 2
Console.WriteLine(-11 % 3);         // -2
Console.WriteLine(-11 % -3);        // -2
Console.WriteLine("3 % 10 = {0}", 3 % 10);
Console.WriteLine("10 % 3 = {0}", 10 % 3);

Console.WriteLine();
Console.WriteLine(1.5 / 0.0);       // Infinity
Console.WriteLine(-1.5 / 0.0);      // -Infinity
Console.WriteLine(0.0 / 0.0);       // NaN

int x = 0;
//Console.WriteLine(5 / x); 			// DivideByZeroException


Console.WriteLine("\nExempel på overflow:");
int bigNum = 2000000000;
int bigSum = 2 * bigNum;        // Integer overflow!
Console.WriteLine(bigSum);      // -294967296

bigNum = Int32.MaxValue;
bigNum = bigNum + 1;
Console.WriteLine(bigNum);      // -2147483648

checked
{
    bigSum = bigNum * 2;        // This will cause OverflowException
}



Console.ReadKey();





double squareArea = squareSide * squareSide;
Console.WriteLine(squareSide);
Console.WriteLine(squareArea);

int a = 5;
int b = 4;
Console.WriteLine(a + b);
Console.WriteLine(a + b++);
Console.WriteLine(a + b);
Console.WriteLine(a + (++b));   // Parentes runt ++b behövs inte, men det blir tydligare att läsa och förstå
Console.WriteLine(a + b );  // 11 (a = 5, b=6)

Console.WriteLine(a + b * 2);   // 17
Console.WriteLine((a + b) * 2);   // 22

Console.WriteLine(12 / 3);              // 4
Console.WriteLine(11 / 3); 				// 3

Console.WriteLine();
Console.WriteLine(11.0 / 3);        // 3.666666667
Console.WriteLine(11 / 3.0);        // 3.666666667
Console.WriteLine(11 % 3);          // 2
Console.WriteLine(11 % -3);         // 2
Console.WriteLine(-11 % 3);         // -2
Console.WriteLine(-11 % -3);        // -2
Console.WriteLine("3 % 10 = {0}", 3 % 10);
Console.WriteLine("10 % 3 = {0}", 10 % 3);

Console.WriteLine();
Console.WriteLine(1.5 / 0.0);       // Infinity
Console.WriteLine(-1.5 / 0.0);      // -Infinity
Console.WriteLine(0.0 / 0.0);       // NaN

int x = 0;
//Console.WriteLine(5 / x); 			// DivideByZeroException


Console.WriteLine("\nExempel på overflow:");
int bigNum = 2000000000;
int bigSum = 2 * bigNum;        // Integer overflow!
Console.WriteLine(bigSum);      // -294967296

bigNum = Int32.MaxValue;
bigNum = bigNum + 1;
Console.WriteLine(bigNum);      // -2147483648

checked
{
    bigSum = bigNum * 2;        // This will cause OverflowException
}



Console.ReadKey();





