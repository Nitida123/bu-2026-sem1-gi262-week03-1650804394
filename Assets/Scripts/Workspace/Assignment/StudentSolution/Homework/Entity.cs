using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Entity
    {
        public string name;
        private Vector3 position;
        protected int health = 100;

        public virtual void Update()
        {
            position += Vector3.zero;
        }

        protected virtual void TakeDamage()
        {
            health -= 10;
            Debug.Log($"{name} took damage. Current health: {health}");
        }

        private void Move()
        {
            position += Vector3.forward;
        }
    }
}