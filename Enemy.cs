class Enemy
{
    string Name;
    int Health;
    public List<Attack> AttackList;

    public Enemy(string name, int health = 100)
    {
        Name = name;
        AttackList = new List<Attack>();
    }
    public Attack RandomAttack()
    {
        Random rand = new Random();
        int idx = rand.Next(this.AttackList.Count);
        return this.AttackList[idx];
    }
}