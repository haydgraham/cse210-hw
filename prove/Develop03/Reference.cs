class Reference
{
    private string book;
    private int chapter;
    private string verseRange;

    public Reference(string book, int chapter, string verseRange)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseRange = verseRange;
    }

    public override string ToString()
    {
        return $"{book} {chapter}:{verseRange}";
    }
}