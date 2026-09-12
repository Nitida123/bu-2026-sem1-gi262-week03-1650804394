using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Bow : Weapon
    {
        public int range = 15;

        public void Shoot()
        {
            Debug.Log("Bow shoots an arrow!");
        }

        public override void Equip()
        {
            base.Equip();
        }

        public override void DealDamage()
        {
            Debug.Log($"Bow hits target at range {range}.");
        }
    }
}