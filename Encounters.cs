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
        Combat(false, "Human Rouge", 1, 4);
    }

    // Encounter Tools
    public static void Combat(bool random, string name, int power, int health)
    {
        string n = "";
        int p = 0;
        int h = 0;

        if (random)
        {

        }
        else
        {
            n = name;
            p = power;
            h = health;
        }
        while (h > 0)
        {
            Console.Clear();
            Console.WriteLine(n);
            Console.WriteLine(p + "/" + h);
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
                if (damage < 0) damage = 0;
                int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                Program.currentPlayer.health -= damage;
                h -= attack;
            }
            else if (input.ToLower() == "d" || input.ToLower() == "defent")
            {
                // Defent
                Console.WriteLine("As the " + n + " prepares to strike, you ready your sword in a defensive stance");
                int damage = (p / 4) - Program.currentPlayer.armorValue;
                if (damage < 0) damage = 0;
                int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                Program.currentPlayer.health -= damage;
                h -= attack;
            }
            else if (input.ToLower() == "r" || input.ToLower() == "run")
            {
                // Run
                if (rand.Next(0, 2) == 0)
                {
                    Console.WriteLine("As you sprint away from the " + n + ", its strike catches you in the back, sending you sprawing on the ground.");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0) damage = 0;
                    Console.WriteLine("You lose " + damage + " helath and are unable to escape");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You use your crazy ninja moves to evade the " + n + " and you successfully escape!");
                    Console.ReadKey();
                    // go to store
                }
            }
            else if (input.ToLower() == "h" || input.ToLower() == "heal")
            {
                // Heal
                if (Program.currentPlayer.potion == 0)
                {
                    Console.WriteLine("As you desperately grasp for a potion in your bag, all that you feel are empty glass flasks.");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0) damage = 0;
                    Console.WriteLine("The " + n + " strikes you with a mighty blow, and you lose " + damage + " health!");
                }
                else
                {
                    Console.WriteLine("You reach into your bag and pull out a glowing, purple flask. You take a long drink.");
                    int potionV = 5;
                    Console.WriteLine("You gain " + potionV + " health");
                    Program.currentPlayer.health += potionV;
                    Console.WriteLine("As you were occupied, the " + n + " advanced and struck.");
                    int damage = (p/2) - Program.currentPlayer.armorValue;
                    if (damage < 0) damage = 0;
                    Console.WriteLine("You lose " + damage + " health.");
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}