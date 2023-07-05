public class MeleeFighter : Enemy
{
    public MeleeFighter() : base("Melee Fighter", 120)
    {
        AttackList = new List<Attack>() { new Attack("Punch", 20), new Attack("Kick", 15), new Attack("Tackle", 25) };
    }
    public void Rage(Enemy Target)
    {
        string RdmAtck = RandomAttack();
        base.PerformAttack(Target, RdmAtck);
        Console.WriteLine($"{Name} uses rage with this attack against {Target.Name} dealing an additional 10 damage points.");
        Target.Health -= 10;
    }
}