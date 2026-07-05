using System;

public class TypeCombinator
{
    //The final result to print to the console.
    public string type;
    //The primary type and its index number from the list
    public string pType;
    public int pIndex;
    //The secondary type and its index number from the list
    public string sType;
    public int sIndex;

    public string[] types = new string[] {"Normal","Fighting","Flying","Posion","Ground","Rock","Bug","Ghost","Steel","Fire","Water","Grass","Electric","Psychic","Ice","Dragon","Dark","Fairy"};
    public TypeCombinator()
	{
        Random rand = new Random();

        pIndex = rand.Next(types.Length);
        pType = types[pIndex];

        sIndex = rand.Next(types.Length);
        sType = types[sIndex];

        Console.WriteLine("Combination is " + pType + "/" + sType + ".");

	}
    public static void Main
    {
        
    }
}
