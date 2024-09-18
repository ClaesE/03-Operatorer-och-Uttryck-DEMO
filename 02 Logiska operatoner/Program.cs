bool a = true;
bool b = false;
Console.WriteLine(a && b);      // False
Console.WriteLine(a || b);      // True
Console.WriteLine(a ^ b);       // True
Console.WriteLine(!b);          // True
Console.WriteLine(b || true);       // True
Console.WriteLine(b && true);       // False
Console.WriteLine(a || true);       // True
Console.WriteLine(a && true);       // True
Console.WriteLine(!a);          // False

Console.WriteLine("true || true = " + (a || a));
Console.WriteLine("true ^ true = " + (a ^ a));

//HEllo everybody
Console.Write("Tryck på en tangent för att avsluta . . .");
Console.ReadKey();