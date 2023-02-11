class Word{

    //instantiate random class
    public static Random random = new Random();

    public static string HideWord(string scripture){
        string verse = scripture;
        string alteredVerse = "";
        string[] verseParts = verse.Split(" ");

        //use random to select a random index.
        int hideIndex = random.Next(1, verseParts.Length);

        //store the word at that random index into a variable
        //and replace each letter with an underscore
        string wordToHide = verseParts[hideIndex];
        string underscores = "";
        for(int i = 0; i < wordToHide.Length; i++){
            underscores += "_";
        }
        verseParts[hideIndex] = underscores;

        //
         foreach(var part in verseParts) {
            alteredVerse += part + " ";
        }

        return alteredVerse;
    }
}