namespace FizzBuzz;

public class Rule
{
    public int Divisor { get; }
    public string Word { get; }
    
    public Rule(int divisor, string word) 
    { 
        this.Divisor = divisor; 
        this.Word = word;
    }
    
    public bool RuleCheck(int number) 
    { 
        return (number % this.Divisor == 0);
    }
}