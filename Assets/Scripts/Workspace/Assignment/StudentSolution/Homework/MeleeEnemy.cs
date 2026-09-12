using UnityEngine;

namespace Assignment.StudentSolution
{
    public class MeleeEnemy : Enemy
    {
        public int strength = 5;

        public override void Attack()
        {
            Debug.Log($"Melee attack dealing {damage + strength} damage.");
        }
    }
}