class Attack
{
    string Name;
    int DamageAmount;
    public Attack(string name, int dmg)
    {
        Name = name;
        DamageAmount = dmg;
        Console.WriteLine($"{Name} used to deliver {DamageAmount} damage points!");
    }
}