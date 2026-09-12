using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items;

        public void CollectItem()
        {
            score += 10;
            Debug.Log("Item collected! Score increased.");
        }

        protected void LevelUp()
        {
            health += 20;
        }
    }
}