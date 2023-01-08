

string text = File.ReadAllText("C:\\Users\\Matt\\OneDrive\\Documents\\Coding\\C# practice\\AdventOfCodeDay4\\AdventOfCodeDay4\\input.txt");
//string text = File.ReadAllText("C:\\Users\\Matt\\OneDrive\\Documents\\Coding\\C# practice\\AdventOfCodeDay4\\AdventOfCodeDay4\\TextFile1.txt");
string line;
int counter = 0;
using (StringReader reader = new StringReader(text))
{
    while ((line = reader.ReadLine()) != null)
    {
        string[] elves = line.Split(',');
        string elf1 = elves[0];
        string elf2 = elves[1];
        string[] elfRange1 = elf1.Split('-');
        string[] elfRange2 = elf2.Split('-');
        int elf1Low = int.Parse((elfRange1[0]));
        int elf2Low = int.Parse((elfRange2[0]));    
        int elf1High = int.Parse((elfRange1[1]));
        int elf2High = int.Parse((elfRange2[1]));

        if (elf1Low <= elf2Low && elf1High >= elf2Low)
        {
            counter++;
        }
        else if (elf1Low <= elf2High && elf1High >= elf2High)
        {
            counter++;
        }
        else if (elf2Low <= elf1Low && elf2High >= elf1Low) 
        {
            counter++;
        }


        //if (elf1Low <= elf2Low && elf1High>= elf2High)
        //{
        //    counter++;
        //}
        //if (elf2Low <= elf1Low && elf2High>= elf1High && elf1 != elf2)
        //{
        //    counter++;
        //}
    }
}
Console.WriteLine(counter);