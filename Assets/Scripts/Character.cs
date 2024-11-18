using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Character
    {
        public string name1 { set; get; }
        private int health;
        protected Position position;



        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                    health = 0;
                else if (value > 100)
                    health = 100;
                else
                    health = value;
            }
        }
        public Character(string characterName, int characterHealth, Position characterPosition)
        {
            name1 = characterName;
            Health = characterHealth;
            position = characterPosition;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log(name1);
            Debug.Log(Health);
            position.PrintPosition();
        }

        public void Attack(int damage, Character target)
        {
            target.Health -= damage;

        }

        public void Attack(int damage, Character target, string attackType)
        {
            Attack(damage, target);
            Debug.Log(attackType);

        }
    }
}
