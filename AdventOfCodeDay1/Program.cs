
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;



string text = File.ReadAllText("ElfCalories.txt");
string[] elf = text.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);


// add calories for each elf

int[] elfTotalCal = new int[elf.Length];

for (int i = 0; i < elf.Length; i++)
{
    string[] cal = elf[i].Split("\n");
    int[] calories = new int[cal.Length];

    for (int j = 0; j < cal.Length; j++)
    {
        calories[j] = int.Parse(cal[j]);
    }
    int sum = calories.Sum();
    elfTotalCal[i] = sum;
}

// Finding max
int m = elfTotalCal.Max();

// Positioning max
int p = Array.IndexOf(elfTotalCal, m);
Console.WriteLine(p + 1);
Console.WriteLine(m);


elfTotalCal = elfTotalCal.Where((source, index) => index != p).ToArray();

int m1 = elfTotalCal.Max();
Console.WriteLine(m1);

p = Array.IndexOf(elfTotalCal, m1);
elfTotalCal = elfTotalCal.Where((source, index) => index != p).ToArray();
int m2 = elfTotalCal.Max();
Console.WriteLine(m2);

Console.WriteLine(m1+m2+m);