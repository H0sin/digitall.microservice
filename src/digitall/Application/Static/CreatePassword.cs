using System.Text;

namespace Application.Static;

public class CreatePassword
{
    public static string CreateUserPassword(int length)
    {
        const string valid = "1234567890";
        StringBuilder res = new StringBuilder();
        Random rnd = new Random();
        while (0 < length--)
        {
            res.Append(valid[rnd.Next(valid.Length)]);
        }
        return res.ToString();
    }
}