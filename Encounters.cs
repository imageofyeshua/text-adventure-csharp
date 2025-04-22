namespace EndersDungeon;

class Encounters
{
    static Random rand = new Random();
    // Encounter Generic

    // Encounters
    public static void FirstEncounter()
    {
        Console.WriteLine("You throw open the door and grab a rusty metal sword, while charging toward your captor");
        Console.WriteLine("He turns...");
        Console.ReadKey();
    }

    // Encounter Tools
    public static void Combat(bool random, string name, int power, int helath)
    {
        string n = "";
        int p = 0;
        int h = 0;

        if(random)
        {

        }
        else
        {
            n = name;
            p = power;
            h = helath;
        }
        while(h > 0)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("| (A)ttack (D)efend |");
            Console.WriteLine("|   (R)un   (H)eal  |");
            Console.WriteLine("=========================================");
            Console.WriteLine("Potions: " + Program.currentPlayer.potion + "  Health: " + Program.currentPlayer.health);
            string input = Console.ReadLine();
            if (input.ToLower() == "a" || input.ToLower() == "attack")
            {
                // Attack
                Console.WriteLine("With haste you surge forth, your swords flying in your hands! As you pass, the " + n + " strikes you!");
                int damage = p - Program.currentPlayer.armorValue;
                int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage" );
                Program.currentPlayer.health -= damage;
                h -= attack;
            }
            else if (input.ToLower() == "d" || input.ToLower() == "defent")
            {
                // Defent
            }
            else if (input.ToLower() == "r" || input.ToLower() == "run")
            {
                // Run
            }
            else if (input.ToLower() == "h" || input.ToLower() == "heal")
            {
                // Heal
            }
            Console.ReadKey();
        }
    }
}