using System;
using System.Collections.Generic;


class Scripture
{
    private Random random = new Random();
    // class variables
    private Reference reference;
    private List<Word> words = new List<Word>();
    private int[] indexesToHide; 
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        string[] verseParts = text.Split(" ");

        foreach (var part in verseParts) {
            words.Add(new Word(part, false));
        }
        
        // shuffle the list of words to hide and store them in an instance variable
        var indexes = new List<int>();
        for (int i = 0; i < verseParts.Length; i++) {
            indexes.Add(i);
        }

        var shuffledIndexes = new List<int>();
        
        while (shuffledIndexes.Count < verseParts.Length) { 
            //use random to select a random index.
            int randomIndex = random.Next(0, indexes.Count - 1);
            int hideIndex = indexes[randomIndex];
            indexes.RemoveAt(randomIndex);
            shuffledIndexes.Add(hideIndex);
        }
        indexesToHide = shuffledIndexes.ToArray();
    }

    public int WordCount(){
        int wordCount = words.Count;
        return wordCount;
    }

    public string LearnScripture(int wordsToHide) {
         wordsToHide = Math.Clamp(wordsToHide, 0, indexesToHide.Length);   
        
        for (int i = 0; i < wordsToHide; i++) {
            var hideIndex = indexesToHide[i];
            Word wordToHide = words[hideIndex];

            wordToHide.Hide();
        }

        return ToString();
    
    }

    
    public override string ToString()
    {
        return $"{reference} {String.Join(" ", words)}";
    }

}