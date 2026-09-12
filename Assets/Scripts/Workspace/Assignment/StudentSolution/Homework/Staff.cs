using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower = 30;

        public void CastSpell()
        {
            Debug.Log("Staff unleashes magic energy!");
        }

        public override void Equip()
        {
            base.Equip();
        }

        public override void DealDamage()
        {
            Debug.Log($"Staff deals {attackPower + magicPower} magic damage.");
        }
    }
}