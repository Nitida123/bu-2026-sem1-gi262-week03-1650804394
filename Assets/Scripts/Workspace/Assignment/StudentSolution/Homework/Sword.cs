using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength = 80;

        public void Slash()
        {
            Debug.Log("Sword slashes!");
        }

        public override void Equip()
        {
            base.Equip();
            Debug.Log("Sword ready in hand.");
        }

        public override void DealDamage()
        {
            Debug.Log($"Sword slash deals {attackPower} damage.");
        }
    }
}