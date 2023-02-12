
class Word {
    private string word;
    private string hiddenWord;
    private bool isHidden;

    public Word(string word, bool isHidden)
    {
        this.isHidden = isHidden;
        this.word = word;
        string underscores = "";
        for(int j = 0; j < word.Length; j++){
            underscores += "_";
        }
        hiddenWord = underscores;
    }

    public override string ToString()
    {
        if (isHidden) {
            return hiddenWord;
        }
        return word;
    }

    public void Hide()
    {
        this.isHidden = true;
    }
    public void Unhide()
    {
        this.isHidden = false;
    }
}