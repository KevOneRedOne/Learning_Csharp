namespace CSharpDiscovery.Quest01
{
    public class DoubleArrayForEvenInteger_Exercice
    {
         public static int[] DoubleArrayForEvenInteger(int[] inputTab)
        { 
            var outputTab = new int[inputTab.Length];

           for (int i = 0; i < inputTab.Length; i++)
           {
                outputTab[i] = inputTab[i];
               if (inputTab[i] % 2 != 0)
               {
                    outputTab[i] = inputTab[i] * 2;
               }
           }
           return outputTab;
        }
    }
}