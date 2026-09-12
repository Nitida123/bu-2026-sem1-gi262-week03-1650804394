using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Mage : RangeEnemy
    {
        public int mana = 50;

        public override void Attack()
        {
            CastSpell();
        }

        public void CastSpell()
        {
            if (mana >= 10)
            {
                mana -= 10;
                Debug.Log("Mage casted a spell!");
            }
        }
    }
}