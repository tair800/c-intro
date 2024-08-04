// Task 1
int num1 = 333;
string result1 = "7" + num1.ToString() + "8";
Console.WriteLine($"Result 1: {result1}"); // 73338

// Task 2
int num2 = 333;
string result2 = num2.ToString() + num2.ToString();
Console.WriteLine($"Result 2: {result2}"); // 333333

// Task 3
int num3 = 12345;
double result3 = num3 * 0.18;
result3 = result3 * 0.03;
Console.WriteLine($"Result 3: {result3}");

// Task 4
int num4 = 123;
string result4Str = num4.ToString() + "7";
double result4 = Convert.ToInt32(result4Str) * 0.07;
Console.WriteLine($"Result 4: {result4}");

// Task 5
int num5 = 1234;
string result5Str = "4" + num5.ToString() + "44";
double result5 = Convert.ToInt32(result5Str) * 0.44;
Console.WriteLine($"Result 5: {result5}");

// Task 6
int num6 = 1234;
double result6 = num6 * 0.20;
result6 = result6 * 0.10;
result6 = Math.Pow(result6, 2);
Console.WriteLine($"Result 6: {result6}");

// Task 7
int num7a = 12345;
int num7b = 54321;
int sum = num7a + num7b;
string result7Str = "5" + sum.ToString() + "5";
double result7 = Convert.ToInt32(result7Str) * 0.05;
Console.WriteLine($"Result 7: {result7}");