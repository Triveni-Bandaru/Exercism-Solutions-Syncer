public static class Isogram
{
    public static bool IsIsogram(string word)
    {
       if (string.IsNullOrEmpty(word))
            return true;

        word=word.ToLowerInvariant();
        var letters = new HashSet<char>();
        foreach(char c in word)
        {
            if (!char.IsLetter(c))
                continue;
            if(letters.Contains(c))
                return false;
             
            letters.Add(c);
            
        }
        return true;
        //Console.WriteLine(Isogram.IsIsogram("The quick brown fox jumps over the lazy dog"));
        Console.WriteLine(Isogram.IsIsogram("downstream"));
               

        
        
    }
}
