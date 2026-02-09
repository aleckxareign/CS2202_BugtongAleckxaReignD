double principal;
double rate;
double time;
double simpleInterest;

Console.Write("Enter principal amount: ");
principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter rate of interest: ");
rate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter time in years: ");
time = Convert.ToDouble(Console.ReadLine());

simpleInterest = (principal * rate * time) / 100;

Console.WriteLine($"Simple Interest: {simpleInterest:F2}");
