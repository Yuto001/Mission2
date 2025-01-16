using System.Xml.Linq;
using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        int dice = 0;

        StimulateDice sd = new StimulateDice();

        System.Console.WriteLine("Welcom to the dice throwing stimulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to stimulate?");
        dice = int.Parse(System.Console.ReadLine());

        sd.CalcDice(dice);
    }
}