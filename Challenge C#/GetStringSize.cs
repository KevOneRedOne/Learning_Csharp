namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
            if (str != null)
            {
                return str.Length;
            } 
            return 0;
        }
    }
}