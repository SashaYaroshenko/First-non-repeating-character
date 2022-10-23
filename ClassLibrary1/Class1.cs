public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        char[]charS = s.ToCharArray();
        char[]charSlower = s.ToLower().ToCharArray();
        int count = 0;
        int index = 0;
        for(int i = 0; i < charSlower.Length; i++)
        {
            count = charSlower.Count(x => x == charSlower[i]);
            if(count==1)
            {
                index = i;  
                break;
            }
        }
        if(count>1)
        {
            return "";
        }
        return new string(charS[index].ToString());
    }
}