public class MagicCaster : Enemy
{
    public MagicCaster() : base("Magic Caster", 80)
    {
        AttackList = new List<Attack>() { new Attack("Fireball", 25), new Attack("Lightning Bolt", 20), new Attack("Staff Strike", 10) };
    }

    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        Console.WriteLine($"{Name} healed {Target.Name}. {Target.Name}'s health is now at {Target.Health}.");
    }
}