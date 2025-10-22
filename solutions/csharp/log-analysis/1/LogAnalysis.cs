public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        if (str== null)
            throw new ArgumentNullException(nameof(str));
        int index=str.IndexOf(delimiter);
        if(index==-1)
            return str; // delimiter not found
        return str.Substring(index+delimiter.Length);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str,string startDelimiter, string endDelimiter )
    {
        if (str==null)
            throw new ArgumentNullException(nameof(str));
        int startIndex=str.IndexOf(startDelimiter);
        if(startIndex==-1)
            return str; //start delimiter not found
        
    startIndex += startDelimiter.Length;

        int endIndex=str.IndexOf(endDelimiter,startIndex);
            if(endIndex==-1)
                return str;//end Delimiter not found
        //extract substring b/w the delimiters
        return str.Substring(startIndex,endIndex-startIndex);
    }   
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str )
    {
        return str.SubstringAfter(": ");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[","]");
    }
    
}