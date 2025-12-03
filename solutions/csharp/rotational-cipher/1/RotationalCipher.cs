public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        shiftKey = shiftKey % 26;
        char RotateChar(char c)
        {
            if(char.IsLower(c))
            {
                return (char)('a'+(c-'a'+shiftKey+26)%26);
                
            }
            else if(char.IsUpper(c))
            {
              return (char)('A'+(c-'A'+shiftKey+26)%26);  
            }
            else{
                return c;
            }
        }
        return new string(text.Select(RotateChar).ToArray());
    }
}