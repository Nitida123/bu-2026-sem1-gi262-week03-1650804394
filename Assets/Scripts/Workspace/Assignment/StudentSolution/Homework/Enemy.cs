using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy : Entity
    {
        public int damage = 15;
        protected int aiLevel = 1;

        public virtual void Attack()
        {
            Debug.Log($"{name} attacks with {damage} damage!");
        }

        protected virtual void Patrol()
        {
            aiLevel += 1;
        }
    }
}