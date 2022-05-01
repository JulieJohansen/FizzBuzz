namespace FizzBuzz;

public class Game
{
    public static string PlayGame(IEnumerable<int> range, List<Rule> rules)
    {
        var outstring = "";
        foreach (var num in range)
        {
            var stringToAdd = "";
            foreach (var rule in rules)
            {
                if (rule.RuleCheck(num))
                {
                    stringToAdd += rule.Word;
                }
            }

            if (stringToAdd == "")
            {
                stringToAdd = num.ToString();
            }

            outstring += stringToAdd + "\n";
        }

        return outstring;
    }
}