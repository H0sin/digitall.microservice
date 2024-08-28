using System.Text.RegularExpressions;

namespace Application.Utilities;

public class EnglishText
{
    public static bool IsEnglishText(string text)
    {
        string cleanedText = Regex.Replace(text, @"[^a-zA-Z]", "");
        return cleanedText.Length > 0 && cleanedText.All(c => Char.IsLetter(c) && (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z'));
    }
    
    public static bool IsValidUsername(string username)
    {
        string pattern = @"^(?!_)[a-zA-Z0-9_]+(?<!_)$";
        
        return Regex.IsMatch(username, pattern);
    }
}