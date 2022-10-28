using LibaryWord;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

if (args.Length > 0)
{
    menuswitch();
}
else
{
    printMenu();
}



void menuswitch()
{
    switch (args[0].ToLower())
    {
        case ("-lists"):

            printLists();
            break;

        case ("-new"):

            newList(args);
            break;

        case ("-add"):

            addToLists(args);
            break;

        case ("-remove"):

            removeWord(args);
            break;

        case ("-words"):

            sortListsBySelectedList(args);
            
            break;

        case ("-count"):

            countWordsInLists(args);

            break;

        case ("-practice"):

            
            practiceWords(args);
            break;



        default:
            Console.WriteLine("I dont know what you ment, try one of these commands instead:\n");
            printMenu();

            break;
    }

}

//-lists
//Listar namnen på alla ordlistor från mappen i appdata/local/”mapp med .dat filer”

static void printLists()
{
    Console.WriteLine("Here is the list of languages!");
    foreach (string list in WordList.GetLists())
    {
        Console.WriteLine(list);
    }

}

//-new < list name > < language 1 > < language 2 > .. < langauge n >
//Skapar(och sparar) en ny lista med angivet namn och så många språk som angivits. Går direkt in i loopen för att addera nya ord (se -add).

static void newList(string[] args)
{
    if (args.Length >= 3)
    {
        WordList newList = new WordList(args[1], args.Skip(2).ToArray());
        //addToLists();
        //saveList();

    }
    else
    {
        Console.WriteLine("You did not enter correct amount of languages! Enter atleast 2 languages!");
    }
}

//-add < list name >
//Frågar användaren efter ett nytt ord (på listans första språk), och frågar därefter i tur och ordning efter översättningar till alla språk i listan. 7
//Sedan fortsätter den att fråga efter nya ord tills användaren avbryter genom att mata in en tom rad. 

static void addToLists(string[] args)
{
    if (args.Length >= 1)
    {
        string filename = args[1];
        WordList addWords = WordList.LoadList(filename);

        
        bool isAddingWords = true;
        while (isAddingWords)
        {
            List<string> totalWords = new List<string>();
            Console.WriteLine("Enter one word for each language!");
            foreach (string lang in addWords.Languages)
            {
                Console.WriteLine($"Enter a word for the language: {lang} ");
                string input = Console.ReadLine();
                if (!String.IsNullOrEmpty(input))
                {
                    totalWords.Add(input);
                }
                else
                {
                    isAddingWords = false;
                    break;
                }
            }
            if (totalWords.Count == addWords.Languages.Length)
            {
                addWords.Add(totalWords.ToArray());
            }
        }
        addWords.Save();

        Console.WriteLine("The new words has been added to the list!");
        
    }
    else
    {
        Console.WriteLine("I think you missed the new lists name!");
    }
}

//-remove <list name> <language> <word 1> <word 2> .. <word n>
//Raderar angivna ord från namngiven lista och språk.

static void removeWord(string[] args)
{
    if (args.Length >= 2)
    {
        string filename = args[1];
        WordList removeWords = WordList.LoadList(filename);
        
        int indexOfLanguage = Array.FindIndex(WordList.LoadList(args[1]).Languages, 
            (x) => string.Equals(x, args[2], StringComparison.OrdinalIgnoreCase));
        List<string> totalWordsToRemove = new List<string>();
        Console.WriteLine("Enter the words you would like to remove! \nWhen you done just press enter!");
        while (true)
        {

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            totalWordsToRemove.Add(input);

        }
        foreach (string word in totalWordsToRemove)
        {
            removeWords.Remove(indexOfLanguage, word);

        }

        removeWords.Save();

        Console.WriteLine("The words you entered is now removed from the selected list!");

    }
    else
    {
        Console.WriteLine("i think you missed the lists name!");
    }
}


//-words <listname> <sortByLanguage>
//Listar ord (alla språk) från angiven lista. Om man anger språk sorteras listan efter
//det, annars sortera efter första språket.

static void sortListsBySelectedList(string[] args)
{
    if (args.Length == 2 || args.Length == 3)
    {
        string filename = args[1];
        WordList sortWords = WordList.LoadList(filename);

        int indexOfLanguage = 0;

        if (args.Length == 3)
        {
            string selectedLanguage = args[2];
            

            for (int i = 0; i < sortWords.Languages.Length; i++)
            {
                if (selectedLanguage == sortWords.Languages[i])
                {
                    indexOfLanguage = i;
                }
            }
        }
        foreach (string lang in sortWords.Languages)
        {
            Console.Write(lang.PadRight(15).ToUpper());
        }
        Console.WriteLine();
        sortWords.List(indexOfLanguage, PrintTranslations);
       
    }
    else
    {
        Console.WriteLine("i think you missed the lists name!");
    }
}

static void PrintTranslations(string[] translations)
{
        foreach (string currentString in translations)
        {
            Console.Write(currentString.PadRight(15));
        }
        Console.WriteLine();
}

//-count <listname>
//Skriver ut hur många ord det finns i namngiven lista.

static void countWordsInLists(string[] args)
{
    string filename = args[1];
    WordList countWords = WordList.LoadList(filename);
    if (args.Length == 2)
    {
        if (args.Length == 2)
        {
            Console.WriteLine(countWords.Count());
        }
    }
    //args.length = 2 för att det ska funka. i en if sats. detta gäller alla metoder som tar in parametrar!
    else
    {
        Console.WriteLine("I think you missed to enter the list name!");
    }
}

//-practice <listname>
//Ber användaren översätta ett slumpvis valt ord ur listan från ett slumpvis valt
//språk till ett annat. Skriver ut om det var rätt eller fel, och fortsätter fråga efter
//ord tills användaren lämnar en tom inmatning. Då skrivs antal övade ord ut, samt
//hur stor andel av orden man haft rätt på. 

static void practiceWords(string[] args)
{
    string filename = args[1];
    WordList practice = WordList.LoadList(filename);


    bool practicingWords = true;
    int countAnswers = 0;
    int countCorrectAnswers = 0;
    
    while (practicingWords)
    {
        
        Word practiceWord = practice.GetWordToPractice();
        string fromLanguage =  practice.Languages[practiceWord.FromLanguage];
        string toLanguage = practice.Languages[practiceWord.ToLanguage];
        string wordTranslateFrom = practiceWord.Translations[practiceWord.FromLanguage];
        string wordTranslateTo = practiceWord.Translations[practiceWord.ToLanguage];

        Console.WriteLine($"Translate the word {wordTranslateFrom.ToUpper()} from {fromLanguage.ToUpper()} to {toLanguage.ToUpper()}: ");
        string answer = Console.ReadLine();
        if (!string.IsNullOrEmpty(answer))
        {
            if (answer.ToLower() == wordTranslateTo.ToLower())
            {
                Console.WriteLine("Correct!");
                countCorrectAnswers++;
            }
            else
            {
                Console.WriteLine($"Sorry that was wrong! The correct answer was {wordTranslateTo}");
            }
            countAnswers++;
        }
        else
        {
            float correctPercentage = (float)countCorrectAnswers / (float)countAnswers * 100;
            Console.WriteLine($"You tried: {countAnswers} times!");
            Console.WriteLine($"You had: {correctPercentage}% correct answers!");
            practicingWords = false;
            break;
        }

    }
}

void printMenu()
{
    Console.WriteLine("Here is some options you can choose from: \n");
    Console.WriteLine("-lists");
    Console.WriteLine("-new < list name > < language 1 > < language 2 > .. < langauge n >");
    Console.WriteLine("-add < list name >");
    Console.WriteLine("-remove < list name > < language > < word 1 > < word 2 > .. < word n >");
    Console.WriteLine("-words<listname> < sortByLanguage >");
    Console.WriteLine("-count < listname >");
    Console.WriteLine("-practice < listname >");
}


