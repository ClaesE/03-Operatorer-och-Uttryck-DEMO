int i = 5;
long l = i;
Console.WriteLine("l = {0}", l);

long l2 = 5;
int i2 = (int)l2;
Console.WriteLine("i2 = {0}", i2);

float heightInMeters = 1.74F;
double maxHeight = heightInMeters;
double minHeight = (double)heightInMeters;  // Litet mer läsbart
float actualHeight = (float)maxHeight;

//float maxHeightFloat = maxHeight; // Ger kompileringsfel

//HEllo everybody
Console.Write("\nTryck på en tangent för att avsluta . . .");
Console.ReadKey();