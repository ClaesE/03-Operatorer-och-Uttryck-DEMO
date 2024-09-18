int a = 2 + 3;                                      // 5
int b = (a + 3) * (a - 4) + (2 * a + 7) / 4;        // 12
Console.WriteLine("a = {0}", a);
Console.WriteLine("b = {0}", b);

bool greater;
greater = (a > b) || ((a == 0) && (b == 0));

greater = (a > b) || !(!(a == 0) || !(b == 0));

Console.WriteLine("greater = {0}", greater);

//HEllo everybody
Console.Write("\nTryck på en tangent för att avsluta . . .");
Console.ReadKey();