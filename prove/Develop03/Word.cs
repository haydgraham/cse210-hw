class Word{
        //instantiate random class
        public static Random random = new Random();

    public static string HideWord(string scripture){
        var hiddenWordsList = new List<string>();
        string verse = scripture;
        string alteredVerse = "";
        string[] verseParts = verse.Split(" ");

        //use random to select a random index.
        int hideIndex = random.Next(1, verseParts.Length);

        //use the random index to select random word within verseParts string array
        verseParts[hideIndex] = "_____";

         foreach(var part in verseParts) {
            alteredVerse += part + " ";
        }

        return alteredVerse;
    }
}