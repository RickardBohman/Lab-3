namespace LibaryWord
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] translations)
        {
            Translations = translations;

            //initialiserar ’Translations’ med data som skickas in som ’translations’
        }

        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            FromLanguage = fromLanguage;

            ToLanguage = toLanguage;

            Translations = translations;

            //som ovan, fast sätter även FromLanguage och ToLanguage.
        }

        public override string ToString() //Kanske ändra på hur man skriver ut när man väl skriver ut? tex att alltid ha listan med ett ", " mellan alla ord?
        {
            return base.ToString();
        }
    }

}