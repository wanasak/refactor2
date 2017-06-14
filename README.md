# Refractoring
- Extract method

### Replace a temp with a query
Bad
```
double avgPrice = totalPrices / totalItems;
if (avgPrice > 1000)
{
  Console.WriteLine("Expensive");
}
```
Good
```
if (avgPrice() > 1000) 
{
    Console.WriteLine("Expensive");
}
double avgPrice() 
{
    return totalPrices / totalItems;
}
```

### Working with local variable
Bad
```
double average = 0;
double[] numbers = new double[] { 2.3, 4.3, 5.9 };
double totalNumbers = 0;
for (int i = 0; i < numbers.Length; i++)
{
    totalNumbers += numbers[i];
}
average = totalNumbers / numbers.Length;
```
Good
```
double[] numbers = new double[] { 2.3, 4.3, 5.9 };
double average = GetAveragePrice(numbers);
private static double GetAveragePrice(double[] numbers)
{
    double totalNumbers = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        totalNumbers += numbers[i];
    }
    return totalNumbers / numbers.Length;
}
```
