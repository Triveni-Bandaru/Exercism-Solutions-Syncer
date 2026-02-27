public static class Bob
{
    public static string Response(string statement)
    {
        string phrase=statement ?? "";
        string trimmed=phrase.Trim();
        if(string.IsNullOrEmpty(trimmed))
            return "Fine. Be that way!";
        bool isQuestion=trimmed.EndsWith("?");
        var letters=trimmed.Where(char.IsLetter).ToArray();
        bool hasLetters=letters.Length>0;
        bool isYelling=hasLetters && letters.All(char.IsUpper);
        if(isYelling&& isQuestion)
            return "Calm down, I know what I'm doing!";
        if(isYelling)
            return "Whoa, chill out!";
        if(isQuestion)
            return "Sure.";
        return "Whatever.";
    }
}