//29535123p48723487597645723645 - exempelinput

Console.WriteLine("Skriv in en sträng med siffror och bokstäver.");
string input = Console.ReadLine();
long sum = 0;

for (int i = 0; i < input.Length; i++)
{
    if (Int32.TryParse(input[i].ToString(), out int number))
    {
        for (int j = i + 1; j < input.Length; j++)
        {
            if (Int32.TryParse(input[j].ToString(), out int number2))
            {
                if (number == number2)
                {
                    var numberSequence = long.Parse(input[i..(j + 1)]);
                    Console.Write(input[0..i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(numberSequence);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(input[(j + 1)..input.Length] + "\n");
                    sum += numberSequence;
                    break;
                }
                continue;
            }
            break;
        }
    }
    continue;
}
Console.WriteLine($"\nDen totala summan av alla färgade sektioner är {sum}.");
