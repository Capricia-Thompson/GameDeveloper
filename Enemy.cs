public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string name, int health = 100)
    {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
    }
    public virtual string RandomAttack()
    {
        Random rand = new Random();
        int idx = rand.Next(this.AttackList.Count);
        return this.AttackList[idx].Name;
    }

    public virtual void PerformAttack(Enemy Target, string atkName)
    {
        Attack ChosenAttack = FindAttack(atkName);
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!");
    }

    public Attack FindAttack(string atkName)
    {
        foreach (Attack attack in this.AttackList)
        {
            if (attack.Name == atkName)
            {
                return attack;
            }
        }
        Attack foundAttack = new Attack("unknown", 0);
        return foundAttack;
    }
}