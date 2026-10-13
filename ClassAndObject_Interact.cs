
// In the main method
namespace ClassandObjectsTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Item sword = new Item();
            sword.name = "Flame of Sword";
            Adventurer jason = new Adventurer();
            jason.name = "Jason";
            jason.classType = "Paladin";

            jason.GoAttack(sword);
        }
    }

// ITEM CLASS
class Item
 {
     public string name;
     public int hitDamage = 200;
 }


// Adventurer Class
class Adventurer
 {
     public string name;
     public string classType;

     public void GoAttack(Item weapon)

     {
         Console.WriteLine($"{name} attacks a monster with a {weapon.name}");
     }

     public void GoRest()
     {
         Console.WriteLine($"{name} rest in camp");
     }
 }

}
