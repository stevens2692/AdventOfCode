//set variables

// a = rock 
// b = paper
// c = scissors

//x = rock                x = lose round 
//y = paper               y = draw
//z = scissors            z = win round

using System.Xml.Schema;

string text = File.ReadAllText("C:\\Users\\Matt\\OneDrive\\Documents\\Coding\\C# practice\\AdventOfCodeDay2\\AdventOfCodeDay2\\puzzleInput.txt");

//Console.WriteLine(text);

//part one solution

//using (StringReader reader = new StringReader(text))
//{
//    int totalScore = 0;
//    string line;
//    while ((line = reader.ReadLine()) != null)
//    {
//        string[] choices = line.Split(' ');
//        //handle score for your choice
//        switch (choices[1])
//        {
//            case "X":
//                totalScore += 1;
//                break;
//            case "Y":
//                totalScore += 2;
//                break;
//            case "Z":
//                totalScore += 3;
//                break;
//        }
//        //handle draw
//        switch ((choices[1], choices[0]))
//        {
//            case ("X", "A"):
//            case ("Y", "B"):
//            case ("Z", "C"):
//                totalScore += 3;
//                break;
//        }

//        //handle winning
//        switch ((choices[1], choices[0]))
//        {
//            case ("X","C"):
//                totalScore += 6;
//                break;
//            case ("Y","A"):
//                totalScore += 6;
//                break;
//            case ("Z","B"):
//                totalScore += 6;
//                break;
//        }
//    }
//    Console.WriteLine(totalScore);
//}

//Part 2 solution
using (StringReader reader = new StringReader(text))
{
    int totalScore = 0;
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        //handle draw
        string[] choices = line.Split(' ');
        if (choices[1] == "Y")
        {
            switch (choices[0])
            {
                case "A":
                    totalScore+=4;
                    break;
                case "B":
                    totalScore+=5;
                    break;
                case "C":
                    totalScore+=6;
                    break;
            }
        }

        //handle win
        else if (choices[1] == "Z")
        {
            switch (choices[0])
            {
                case "A":
                    totalScore += 8;
                    break;
                case "B":
                    totalScore += 9;
                    break;
                case "C":
                    totalScore += 7;
                    break;
            }
        }

        //handle lose
        else if (choices[1] == "X")
        {
            switch (choices[0])
            {
                case "A":
                    totalScore += 3;
                    break;
                case "B":
                    totalScore += 1;
                    break;
                case "C":
                    totalScore += 2;
                    break;
            }
        }

    }
    Console.WriteLine(totalScore);
}
