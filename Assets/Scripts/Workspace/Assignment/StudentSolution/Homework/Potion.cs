using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Potion : Item
    {
        public int healingAmount = 50;

        public override void Use()
        {
            Debug.Log($"Drank potion, healed for {healingAmount} HP.");
        }
    }
}