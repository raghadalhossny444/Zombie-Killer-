using Zombieskiller;
using Zombieskiller.AttackBehaviors;

//client code 

    var hero = Hero.Instance(new MeleeAttack());
    bool running = true;
    while (running)
    {
        Console.WriteLine("\n=== Zombie Killer Game ===");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Change Attack Style");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option (1-3): ");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                hero.Attack();
                break;
            case "2":
                Console.WriteLine("\nChoose attack style:");
                Console.WriteLine("1. Melee Attack");
                Console.WriteLine("2. Ranged Attack");
                Console.Write("Select style (1-3): ");

                string? styleChoice = Console.ReadLine();
                switch (styleChoice)
                {
                    case "1":
                        hero.ChangeAttackStyle(new MeleeAttack());
                        Console.WriteLine("Changed to Melee Attack!");
                        break;
                    case "2":
                        hero.ChangeAttackStyle(new RangedAttack());
                        Console.WriteLine("Changed to Ranged Attack!");
                        break;
                    default:
                        Console.WriteLine("Invalid style choice!");
                        break;
                }
                break;
            case "3":
                running = false;
                Console.WriteLine("Thanks for playing!");
                break;
            default:
                Console.WriteLine("Invalid option! Please try again.");
                break;
        }



        


    }



