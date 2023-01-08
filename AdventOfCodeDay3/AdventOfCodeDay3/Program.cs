
using System;
using System.Reflection.PortableExecutable;

//Readline of file
string text = File.ReadAllText("C:\\Users\\Matt\\OneDrive\\Documents\\Coding\\C# practice\\AdventOfCodeDay3\\AdventOfCodeDay3\\input.txt");
string line;
char duplicateItem;
int priority = 0;
int total = 0;
bool loopBreak = false;
using (StringReader reader = new StringReader(text))
{
    while((line = reader.ReadLine()) != null)
    {
        loopBreak = false;
        //split each line in half
        var first = line.Substring(0, (int)(line.Length / 2));
        var last = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));
        //find the letter contained in both sunstrings
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < last.Length; j++)
            {
                if (first[i] == last[j])
                {
                    duplicateItem = first[i];
                    // Convert Duplicate letter to the priority number
                    if (Char.IsUpper(duplicateItem))
                    {
                        priority = duplicateItem - 38;
                    }
                    else
                    {
                        priority = duplicateItem - 96;
                    }
                    // break the loop when the letter is found
                    loopBreak = true;
                    break;
                }
            }
            if (loopBreak)
            {
                break;
            }
        }
        //Sum the priority number for each line in file
        total = priority + total;  
    }
    Console.WriteLine(total);
}







