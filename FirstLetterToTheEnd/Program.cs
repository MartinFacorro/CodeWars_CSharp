namespace FirstLetterToTheEnd
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
       * Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
      Examples

       * 
       */
      Console.WriteLine(MoveToEnd("Pig latin is cool")); // igPay atinlay siay oolcay
      Console.WriteLine(MoveToEnd("Hello world !"));     // elloHay orldway !
    }

    public static string MoveToEnd(string pParam)
    {
      var NumberOfWords = CountWordsInString(pParam);
      return "";
    }

    private static int CountWordsInString(string pParam)
    { 
    
    }
  }
}