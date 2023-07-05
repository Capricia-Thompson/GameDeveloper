MeleeFighter Meleer = new MeleeFighter();
RangedFighter Ranger = new RangedFighter();
MagicCaster Caster = new MagicCaster();

Meleer.PerformAttack(Ranger, "Kick");

Meleer.Rage(Caster);

Ranger.PerformAttack(Meleer, "Shoot an arrow");

Ranger.Dash(Meleer);

Ranger.PerformAttack(Meleer, "Shoot an arrow");

Caster.PerformAttack(Meleer, "Fireball");

Caster.Heal(Ranger);

Caster.Heal(Caster);