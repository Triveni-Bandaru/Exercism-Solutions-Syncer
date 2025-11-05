using System;
using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result=new StringBuilder();
        bool toUpperNext=false;
        foreach(char ch in identifier)
        {
            if(char.IsControl(ch))
            {
                result.Append("CTRL");
            }
            else if(ch==' ')
            {
                result.Append('_')  ; 
            }
            else if(ch=='-')
            {
                toUpperNext=true;
            }
            else if(ch=='_')
            {
               result.Append('_');
            }
            else if(char.IsLetter(ch))
            {
                if(toUpperNext)
                {
                    result.Append(char.ToUpperInvariant(ch));
                    toUpperNext=false;
                }
                else if(ch>='α' && ch <= 'ω')
                {
                    continue;
                }
                else
                {
                    result.Append(ch);
                }
            }
        }
       return result.ToString();
    }
}
