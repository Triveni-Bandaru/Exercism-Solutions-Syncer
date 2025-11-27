public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if(string.IsNullOrEmpty(input))
            return false;
        input=input.ToLowerInvariant();
        
        var letters= new HashSet<char>();
        foreach(char c in input )
        {
            if(c>='a' && c<='z')
            {
                letters.Add(c);
                if(letters.Count==26)
                    return true;
            }
        }
        return letters.Count==26;
        

        Console.WriteLine(Pangram.IsPangram("The quick brown fox jumps over the lazy dog"));
        Console.WriteLine(Pangram.IsPangram("Hello world"));
       
    }
}
