using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Archer : RangeEnemy
    {
        public int accuracy = 80;

        public override void Attack()
        {
            AimAndShoot();
        }

        public void AimAndShoot()
        {
            Debug.Log($"Archer shoots with accuracy {accuracy}%");
        }
    }
}