public class RangedFighter : Enemy
{
    public int Distance;
    public RangedFighter(int dist = 5) : base("Ranged Fighter")
    {
        int Distance = dist;
        AttackList = new List<Attack>() { new Attack("Shoot an arrow", 20), new Attack("Throw a knife", 15) };
    }

    public override void PerformAttack(Enemy Target, string atkName)
    {
        if (this.Distance >= 10) { base.PerformAttack(Target, atkName); }
        else
        {
            Console.WriteLine($"Unable to perform {atkName} due to insufficient distance.");
        }
    }

    public void Dash(Enemy Target)
    {
        this.Distance = 20;
        Console.WriteLine($"{Name} moved away from {Target.Name} creating more distance.");
    }
}