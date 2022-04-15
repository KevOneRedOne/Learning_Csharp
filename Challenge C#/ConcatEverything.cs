namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            string onlyonestr = ""; 
            
            for (int i = 0; i < str.Length; i++)
            {
                onlyonestr += str[i];
            }
            return onlyonestr;
        }
    }
}