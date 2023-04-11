namespace FirstLetterToTheEnd
{
  public class Program
  {

    static void Main(string[] args)
    {
      /*
       * Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
      Examples

       * 
       */
      Console.WriteLine(MoveToEnd("Pig latin is cool")); // igPay atinlay siay oolcay
      //Console.WriteLine(MoveToEnd("Hello world !"));     // elloHay orldway !
    }

    public static string MoveToEnd(string pParam)
    {
      List<String> separateWords = new List<string>();

      //var NumberOfWords = CountWordsInString(pParam);
      separateWords = pParam.Split(' ').ToList();

      foreach (string word in separateWords)
      {
        Console.WriteLine(word);
        moveFirstLetterToTheEnd(word);
      }
      return "";
    }

    public static string moveFirstLetterToTheEnd(string pParam)
    {
      char[] unitWord = pParam.ToCharArray();

      for (int incrementator = 0; incrementator < unitWord.Length; incrementator++)
      {
        Console.WriteLine(unitWord[incrementator]);
      }
      return "";
    }
  }
}