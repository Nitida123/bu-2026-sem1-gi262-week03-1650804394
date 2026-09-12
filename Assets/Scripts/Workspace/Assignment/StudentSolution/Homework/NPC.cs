using UnityEngine;

namespace Assignment.StudentSolution
{
    public class NPC : Entity
    {
        public string dialogue = "Hello, adventurer!";
        private bool isFriendly = true;

        public virtual void Interact()
        {
            if (isFriendly)
            {
                Debug.Log($"NPC says: {dialogue}");
            }
        }
    }
}