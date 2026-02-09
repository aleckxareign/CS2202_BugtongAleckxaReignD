double amount;
double exchangeRate;
double convertedAmount;

Console.Write("Enter amount in PHP: ");
amount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter exchange rate from PHP to USD: ");
exchangeRate = Convert.ToDouble(Console.ReadLine());

convertedAmount = amount * exchangeRate;

Console.WriteLine($"Amount in USD: {convertedAmount:F2}");