namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            string reversestr = "";
            char[] charArray = str.ToCharArray();

           for (int i = charArray.Length - 1; i >= 0; i--)
           {
               reversestr += charArray[i];   
           }
            return reversestr;
        }
    }
}