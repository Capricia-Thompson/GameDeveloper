Enemy Glados = new Enemy("Glados");

Attack Drop = new Attack("Drop", 5);

Attack LaserBeam = new Attack("Laser Beam", 20);

Attack AcidPool = new Attack("Acid Pool", 50);

Glados.AttackList.Add(Drop);
Glados.AttackList.Add(LaserBeam);
Glados.AttackList.Add(AcidPool);

Glados.RandomAttack();