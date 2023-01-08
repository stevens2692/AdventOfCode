//Parse whole file to string
string text = File.ReadAllText("C:\\Users\\Matt\\OneDrive\\Documents\\Coding\\C# practice\\AdventOfCodeDay3Part2\\AdventOfCodeDay3Part2\\input.txt");

//split text into array at newline
string[] lines = text.Split("\n");

int priority = 0;
int total = 0;

//loop through array incrementing three lines at once
for ( int i = 0; i < lines.Length; i += 3)
{
    //save each of the three lines of interest as varaibles
    string line1 = lines[i];
    string line2 = lines[i + 1];
    string line3 = lines[i + 2];

    //find the letter in all three strings
    foreach (char c in line1)
    {
        if (line2.Contains(c) && line3.Contains(c))
        {
            //Maths to calculate the priority number
            if (Char.IsUpper(c))
            {
                priority = c - 38;
            }
            else
            {
                priority = c - 96;
            }
            break;
        }
    }
    total += priority;
}
Console.WriteLine(total);
