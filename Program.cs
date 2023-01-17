using System.Text.RegularExpressions;



bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("\nWelcome to the Pig Latin Translator!\n");
    Console.Write("Enter a line to be translated: ");
    string input = Console.ReadLine();
    Console.WriteLine(Translate($"\n{input}\n"));
    //sorry, but this is the only method i scrounged through online that i could get to actually get multiple consonants at the beginning to get moved to the back
    //without also breaking something horribly and driving me nuts, i promise ill figure out the non regex method in time
    static string Translate(string word) => Regex.Replace(word, @"\b(ch?|qu?|squ|thr|th|sch|y(?!t)|x(?!r)|[bdfghjklmnprstvwz]{2,}(?=y)|[bdfghjklmnprstvwz])?(\S+)", @"$2$1ay", RegexOptions.IgnoreCase);

    while (true)
    {
        Console.WriteLine("\nDo you want to continue? y/n");
        string choice = Console.ReadLine().Trim().ToLower();

        if (choice == "y")
        {
            runProgram = true;
            break;

        }
        else if (choice == "n")
        {
            runProgram = false;
            break;

        }
    }
}



/* welcome to the graveyard of my time and sanity

char[] vowels = "aeiou".ToCharArray();
string test = "alpha";

if (.IndexOfAny(vowels) = 0)
{

}


Console.WriteLine("Welcome to the Pig Latin Translator!\n");


Console.WriteLine("Enter a line to be translated: \n");
string userInput = Console.ReadLine().ToLower();
string[] words = userInput.Split(' ');
char[] chars = userInput.ToCharArray();
string[] vowels = {"a", "e", "i", "o", "u"};
string[] consonants = {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
char[] test = "aeiou".ToCharArray();

//string[] arrayTest = words.Select(x => x.ReplaceLineEndings(userInput + "ay")).ToArray();
//Console.WriteLine(arrayTest);

Console.WriteLine(chars);

foreach (string w in words)
{
    
        Console.Write(w.Substring(1) + w.Substring(0, 1) + "ay ");
    
}

//string test = "test";
//string output1= test.Substring(1) + test.Substring(0, 1);
//Console.WriteLine(output1 + "ay");


string test = "testing in progress";

string test2 = test.Replace('t', 'e') ;
Console.WriteLine(test2);


Console.WriteLine(test.StartsWith("a"));



using System.Collections;

public static class PigLatin
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        while (runProgram)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a line to be translated: ");
            string word = Console.ReadLine();
            //Console.WriteLine(Translate("This is a test"));
            Console.WriteLine(Translate(word));

            static string Translate(string word)

            {


                string[] words = word.Trim().Split(' ');
                string[] aeiou = { "a", "e", "i", "o", "u" };
                string[] chquth = { "ch", "qu", "th" };
                string[] thr = { "thr" };
                string[] ytxr = { "yt", "xr" };
                string text = word;

                string all = "";


                foreach (var item in words)
                {
                    
                    if (item.Length > 2)
                    {
                        if (!((IList)aeiou).Contains(item.Substring(0, 1).ToString()) && (!((IList)ytxr).Contains(item.Substring(0, 2).ToString())))
                        {
                            if (((IList)chquth).Contains(item.Substring(0, 2).ToString()))
                            {
                                if (((IList)thr).Contains(item.Substring(0, 3).ToString()))
                                {
                                    text = item.Substring(3, item.Length - 3) + item.Substring(0, 3);
                                }
                                else
                                    text = item.Substring(2, item.Length - 2) + item.Substring(0, 2);
                            }
                            else
                            {
                                if (((IList)chquth).Contains(item.Substring(1, 2).ToString()))
                                {
                                    text = item.Substring(3, item.Length - 3) + item.Substring(0, 3);
                                }
                                else

                                {
                                    if (item.Contains("y") && item.IndexOf("y") != 0)
                                    {
                                        text = item.Substring(item.IndexOf("y"), item.Length - item.IndexOf("y")) + item.Substring(0, item.IndexOf("y"));
                                    }
                                    else
                                        text = item.Substring(1, item.Length - 1) + item.Substring(0, 1);
                                }
                            }
                        }
                        else
                        {
                            //This part is where it keeps messing up for when writing sentence exists
                            //logic for when theres more than 2 characters and it has vowels in it
                            //text = text + "ay ";
                            Console.WriteLine("Test test test");
                        }
                    }
                    else
                        text = item.Substring(1, item.Length - 1) + item.Substring(0, 1);
                    text = text + "ay ";

                    all = all + text;
                }
                return all.Trim();
            }
            while (true)
            {
                Console.WriteLine("Do you want to continue? y/n");
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice == "y")
                {
                    runProgram = true;
                    break;

                }
                else if (choice == "n")
                {
                    runProgram = false;
                    break;

                }

            }
        }

        }
}
*/