using System.Runtime.Serialization;

int nr = 748077714;
string nrInString = nr.ToString();
char[] digits = nrInString.ToCharArray();

Console.WriteLine($"Number: {nr}");

int[] counterOfDigit = new int[10];

foreach (char digit in digits)
{
    if (digit == '0')
    {
        counterOfDigit[0]++;
    }
    else if (digit == '1')
    {
        counterOfDigit[1]++;
    }
    else if (digit == '2')
    {
        counterOfDigit[2]++;
    }
    else if (digit == '3')
    {
        counterOfDigit[3]++;
    }
    else if (digit == '4')
    {
        counterOfDigit[4]++;
    }
    else if (digit == '5')
    {
        counterOfDigit[5]++;
    }
    else if (digit == '6')
    {
        counterOfDigit[6]++;
    }
    else if (digit == '7')
    {
        counterOfDigit[7]++;
    }
    else if (digit == '8')
    {
        counterOfDigit[8]++;
    }
    else if (digit == '9')
    {
        counterOfDigit[9]++;
    }
}


Console.WriteLine($"0 => {counterOfDigit[0]}");
Console.WriteLine($"1 => {counterOfDigit[1]}");
Console.WriteLine($"2 => {counterOfDigit[2]}");
Console.WriteLine($"3 => {counterOfDigit[3]}");
Console.WriteLine($"4 => {counterOfDigit[4]}");
Console.WriteLine($"5 => {counterOfDigit[5]}");
Console.WriteLine($"6 => {counterOfDigit[6]}");
Console.WriteLine($"7 => {counterOfDigit[7]}");
Console.WriteLine($"8 => {counterOfDigit[8]}");
Console.WriteLine($"9 => {counterOfDigit[9]}");
