using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DAMAGE = 2;
            int choice;
            int health = 100;
            int amount;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Increase health");
                Console.WriteLine("2. Take damage");
                Console.WriteLine("3. Show health");
                Console.WriteLine("4. Exit");
                Console.Write("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1 : Console.Write("Please enter an amount 0-100: ");
                             amount = int.Parse(Console.ReadLine());        // priming read
                             while (amount < 0 || amount > 100)     // sentinel value
                             {
                                Console.Write("Invalid input. Please re-enter an amount 0-100: ");
                                amount = int.Parse(Console.ReadLine());     //secondary read
                             }
                             health += amount;
                             if (health > 100)
                                health = 100;
                             break;
                    case 2 : health -= DAMAGE;
                             Console.WriteLine("You have sustained damage and your health has been reduced");
                             if (health <= 0)
                             {
                                Console.WriteLine("You are dead!");
                                return;         // jump statement
                             }
                             break;
                    case 3 : Console.WriteLine("Health: {0}%", health);
                             break;
                    case 4 : Console.WriteLine("Exiting.. Good-bye.");
                             break;
                    default : Console.WriteLine("Invalid choice");
                              break;
                }
            } while (choice != 4);
        }
    }
}
