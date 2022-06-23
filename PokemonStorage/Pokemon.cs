namespace Models;

//Class is a blueprint to create objects
//public is an example of access modifier
//public means that everyone has access to whatever its decorating
public class PokeTrainer
{

string trainerName = Console.ReadLine();

    //Empty Constructor
    public PokeTrainer()
    {
        NumBadges = 0;
        Money = 0;
    }

    //This is constructor overloading
    public PokeTrainer(string trainerName)
    {
        NumBadges = 0;
        Money = 0;
        name = trainerName;
    }

    public PokeTrainer(string trainerName, int badges)
    {
        name = trainerName;
        NumBadges = badges;
        Money = 0;
    }


    //private is another access modifier
    //private fields/methods/etc is only accessible by its owner
    //This is an example of field
    //We use field to contain data or trait of the class
    private string name;

    //example of a public getter to a private field
    public string GetName()
    {
        return name;
    }

    //Example of Setter
    public void SetName(string nameToSet)
    {
        //we can validate input data
        if(String.IsNullOrWhiteSpace(nameToSet))
        {
            //Then we'll let the user of this class know that that's not a valid data
            Console.WriteLine("Hey, this is invalid name");
        }
        else
        {
            //We set the value we got passed in to the private field name
            this.name = nameToSet;
        }
    }
