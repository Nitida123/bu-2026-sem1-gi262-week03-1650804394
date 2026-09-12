using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Armor : Equipment
    {
        public int defense = 15;

        public override void Equip()
        {
            Debug.Log($"Armor equipped with {defense} defense points.");
        }
    }
}