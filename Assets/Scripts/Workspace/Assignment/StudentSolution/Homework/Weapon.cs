using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Weapon : Equipment
    {
        public int attackPower = 20;

        public virtual void DealDamage()
        {
            Debug.Log($"Weapon deals {attackPower} damage.");
        }
    }
}