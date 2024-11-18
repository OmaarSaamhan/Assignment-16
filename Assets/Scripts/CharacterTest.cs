using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{


    public class Test : MonoBehaviour
    {
        Soldier soldier;
        Officer officer;
        void Start()
        {
            soldier = new Soldier("Omar", 100, new Position(10, 5, 0));
            officer = new Officer("Sarah", 100, new Position(15, 10, 0));

            Character[] characters = new Character[] { soldier, officer };

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            officer.Attack(30, soldier);
            officer.Attack(30, soldier, "shooting");


        }

    }
}
