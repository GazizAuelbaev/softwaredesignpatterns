
using System;
using Strategy;
using Strategy.Strategies;

Hero hero = new("Knight");

hero.Attack();

hero.SetWeapon(new Sword());

hero.Attack();

hero.SetWeapon(new Stick());

hero.Attack();

Console.ReadLine();
