namespace FizzBuzz
{
   public class Program
   {
      public static void Main(string[] args)
      {
         var rules = new List<Rule>
         {
            new Rule(3, "Fizz"),
            new Rule(5, "Buzz")
         };

         var range = Enumerable.Range(1, 100);
         Console.Write(Game.PlayGame(range, rules));

         rules.Clear();

         rules.Add(new Rule(4, "Fuzz"));
         rules.Add(new Rule(9, "Jazz"));

         Console.WriteLine("Spiller med nye regler;");
         var rangeReversed = Enumerable.Range(1, 100).Reverse();
         Console.Write(Game.PlayGame(rangeReversed, rules));
      }
   }
}
