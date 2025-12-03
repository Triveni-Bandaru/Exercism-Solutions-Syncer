using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        //Replacing hyphens with spaces
        phrase = phrase.Replace("-"," ");
        //Removing all punctuations
        phrase=Regex.Replace(phrase,"[^A-Za-z ]","");
        //splitting it into words
        var words=phrase.Split(' ',StringSplitOptions.RemoveEmptyEntries);

       // Take first letter of each word, uppercase
        string acronym="";
        foreach(var word in words)
        {
            acronym+=char.ToUpper(word[0]);
        }
        return acronym;
    }
}