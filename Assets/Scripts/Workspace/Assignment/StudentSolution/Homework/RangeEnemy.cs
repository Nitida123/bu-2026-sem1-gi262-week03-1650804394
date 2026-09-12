using UnityEngine;

namespace Assignment.StudentSolution
{
    public class RangeEnemy : Enemy
    {
        public int range = 10;

        public override void Attack()
        {
            Debug.Log($"Ranged attack from distance: {range}");
        }
    }
}