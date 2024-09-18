Console.WriteLine("Jämförelser:");
int a = 5;
int b = 4;
Console.WriteLine(a >= b);  // True
Console.WriteLine(a != b);  // True
Console.WriteLine(a == b);  // False
Console.WriteLine(a == a);  // True
Console.WriteLine(a != ++b); // False
Console.WriteLine(a > b);   // False

Console.WriteLine("Tilldelning:");
int x = 6;
int y = 4;
Console.WriteLine(y *= 2);      // 8
int z = y = 3;          // y=3 and z=3  
Console.WriteLine(z);       // 3

Console.WriteLine("\nTest av /= på heltal:");
Console.WriteLine(x += 3);      // 9
//x += 3;
//Console.WriteLine(x);
Console.WriteLine(x /= 2);      // 4


//HEllo everybody
Console.Write("\nTryck på en tangent för att avsluta . . .");
Console.ReadKey();
