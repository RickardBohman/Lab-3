using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace LibaryWord
{
    public class WordList : Word
    {
        private List<Word> _Words = new List<Word>();


        //Properties:

        public string Name { get; private set; }

        public string[] Languages { get; }

        //Metoder:

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
            //Konstruktor. Sätter properites Name och Languages till parametrarnas värden.
        }

        public static string[] GetLists()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string fullpath = Path.Combine(path, "lab 3");

            return Directory.GetFiles(fullpath, "*.dat")
                .Select(file => Path.GetFileNameWithoutExtension(file))
                .ToArray();

            //Returnerar array med namn på alla listor som finns lagrade (utan filändelsen).
        }

        //public static string[] GetLists()
        //{
        //    string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        //    return Directory.GetFiles(path, "*.dat")
        //        .Select(file => Path.GetFileNameWithoutExtension(file))
        //        .ToArray();

        //    //Returnerar array med namn på alla listor som finns lagrade (utan filändelsen).
        //}

        public static WordList LoadList(string name)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullpath = Path.Combine(path, "lab 3");
            string filePath = Path.Combine(fullpath, $"{name}.dat");
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    string[] Language = reader.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
                    WordList wordList = new WordList(name, Language);
                    string row;
                    while(!reader.EndOfStream)
                    {
                        row = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(row))
                        {
                            string[] translations = row.Split(';',StringSplitOptions.RemoveEmptyEntries);
                            wordList.Add(translations);
                        }
                    }
                    return wordList;
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("File not found!");
            }

            //Laddar in ordlistan(name anges utan filändelse) och returnerar som WordList.
        }
        public void Save()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullpath = Path.Combine(path, "lab 3");
            string filePath = Path.Combine(fullpath, $"{Name}.dat");
            DirectoryInfo directory = new DirectoryInfo(fullpath);
            if (!directory.Exists)
            {
                directory.Create();
            }

            using (TextWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(string.Join(';', Languages));
                foreach(Word word in _Words)
                {
                    writer.WriteLine(string.Join(';', word.Translations));
                }
                writer.Close();
            }

            //Sparar listan till en fil med samma namn som listan och filändelse.dat
        }

        public void ReNameList(string newName)
        {
            Name = newName;
        }
        public void Add(params string[] translations)
        {
            if (translations.Length != Languages.Length)
            {
                throw new ArgumentException("Wrong numbers of translations!");
            }

            _Words.Add(new Word(translations));
            //Lägger till ord i listan.Kasta ArgumentException om det är fel antal translations.
        }
        public bool Remove(int translation, string word)
        {
            foreach(Word currentWord in _Words)
            {
                if (currentWord.Translations[translation] == word)
                {
                    _Words.Remove(currentWord);
                    return true;
                }
            }
            return false;

            //translation motsvarar index i Languages.Sök igenom språket och ta bort ordet.
            //Returnerar true om ordet fanns(och alltså tagits bort), annars false.
        }

        public int Count() => _Words.Count;
        
                
            //Räknar och returnerar antal ord i listan.
        
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedWordList = _Words.OrderBy(w => w.Translations[sortByTranslation]).ToList();

            foreach(Word word in sortedWordList)
            {
                showTranslations(word.Translations);
            }
            //sortByTranslation = Vilket språk listan ska sorteras på.
            //showTranslations = Callback som anropas för varje ord i listan.
        }

        public Word GetWordToPractice()
        {
            int indexOFRandomWord = Random.Shared.Next(_Words.Count);

            Word randomWord = _Words[indexOFRandomWord];
            int to = Random.Shared.Next(Languages.Length);
            int from = Random.Shared.Next(Languages.Length);
            while(from == to)
            {
               to = Random.Shared.Next(Languages.Length);
            }

            //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
            //FromLanguage och ToLanguage(dock inte samma).

            return new Word(from,to,randomWord.Translations);
            
        }

    }
}
