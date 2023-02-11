class WordHider {
    private string phrase; // "Adam fell that men might be" -> [0,1,2,3,4,5]
    private Random random = new Random();
    private int[] indexesToHide; // [5,3,1,2,4,0]

    public WordHider(string phrase)
    {
        if (phrase == null) {
            throw new ArgumentException("phrase cannot be null");
        }
        this.phrase = phrase;
        
        string[] verseParts = phrase.Split(" "); // ["Adam", "____", "____", "___", "may", "be"]

        // TODO: randomize the order in which all the words get removed
        // shuffle the list of words to hide and store them in an instance variable
        var indexes = new List<int>(); 
        // [0,1,2,3,4,5] -> 6
        // [0,2,3,4,5] -> 5
        for (int i = 0; i < verseParts.Length; i++) {
            indexes.Add(i);
        }

        var shuffledIndexes = new List<int>(); // [] -> I want a list of 3 indexes that need to be hidden
        // TODO: select random word indexes to blank, up until the specified numberToHide
        while (shuffledIndexes.Count < verseParts.Length) { 
            //use random to select a random index.
            int randomIndex = random.Next(0, indexes.Count - 1);
            int hideIndex = indexes[randomIndex];
            indexes.RemoveAt(randomIndex);
            shuffledIndexes.Add(hideIndex);
        }
        indexesToHide = shuffledIndexes.ToArray();
    }

    //instantiate random class

    // numberToHide = 3
    public string HideWords(int numberToHide) {
        numberToHide = Math.Clamp(numberToHide, 0, indexesToHide.Length);
        // indexesToHide = [3,2,5,1,0,4]
        //                  ^ ^ ^ ^
        // numberToHide = 3
        

        string[] verseParts = phrase.Split(" ");       
        
        for (int i = 0; i < numberToHide; i++) {
            var hideIndex = indexesToHide[i];
            string wordToHide = verseParts[hideIndex];
            string underscores = "";
            for(int j = 0; j < wordToHide.Length; j++){
                underscores += "_";
            }
            verseParts[hideIndex] = underscores;
        }

        //store the word at that random index into a variable
        //and replace each letter with an underscore

        return String.Join(" ", verseParts);
    }
}