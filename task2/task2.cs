using System.IO.Pipes;

int int1 = 1;
long long2 = 2;
double double3 = 3.0f;
float float4 = 4.0f;
decimal decimal5 = 2m;
bool bool6 = false;
char char7 = 'c';
string string8 = "string";

Console.WriteLine($"int1, {int1}, {int1.GetType()}");
Console.WriteLine($"long2, {long2}, {long2.GetType()}");
Console.WriteLine($"double3, {double3}, {double3.GetType()}");
Console.WriteLine($"float4, {float4}, {float4.GetType()}");
Console.WriteLine($"decimal5, {decimal5}, {decimal5.GetType()}");
Console.WriteLine($"bool6, {bool6}, {bool6.GetType()}");
Console.WriteLine($"char7, {char7}, {char7.GetType()}");
Console.WriteLine($"string8, {string8}, {string8.GetType()}");