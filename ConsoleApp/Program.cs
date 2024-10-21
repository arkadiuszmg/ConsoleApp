using System.Runtime.Serialization;

int nr = 748077714;
string nrInString = nr.ToString();
char[] digits = nrInString.ToCharArray();

Console.WriteLine($"Number: {nr}");

int[] numberOfDigit = new int[10];

foreach (char digit in digits)
{
    if (digit == '0')
    {
        numberOfDigit[0]++;
    }
    else if (digit == '1')
    {
        numberOfDigit[1]++;
    }
    else if (digit == '2')
    {
        numberOfDigit[2]++;
    }
    else if (digit == '3')
    {
        numberOfDigit[3]++;
    }
    else if (digit == '4')
    {
        numberOfDigit[4]++;
    }
    else if (digit == '5')
    {
        numberOfDigit[5]++;
    }
    else if (digit == '6')
    {
        numberOfDigit[6]++;
    }
    else if (digit == '7')
    {
        numberOfDigit[7]++;
    }
    else if (digit == '8')
    {
        numberOfDigit[8]++;
    }
    else if (digit == '9')
    {
        numberOfDigit[9]++;
    }
}


Console.WriteLine($"0 => {numberOfDigit[0]}");
Console.WriteLine($"1 => {numberOfDigit[1]}");
Console.WriteLine($"2 => {numberOfDigit[2]}");
Console.WriteLine($"3 => {numberOfDigit[3]}");
Console.WriteLine($"4 => {numberOfDigit[4]}");
Console.WriteLine($"5 => {numberOfDigit[5]}");
Console.WriteLine($"6 => {numberOfDigit[6]}");
Console.WriteLine($"7 => {numberOfDigit[7]}");
Console.WriteLine($"8 => {numberOfDigit[8]}");
Console.WriteLine($"9 => {numberOfDigit[9]}");
