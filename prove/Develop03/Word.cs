class Word{
        private static string verse = (Scripture.DisplayScripture());
        private static string[] verseParts = verse.Split(" ");


    public static string[] HideWord(){
        return verseParts;
    }

}