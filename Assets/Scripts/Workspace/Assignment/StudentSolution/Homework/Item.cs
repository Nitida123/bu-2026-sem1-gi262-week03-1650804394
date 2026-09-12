using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Item
    {
        public string name;
        private int value = 10;

        public virtual void Use()
        {
            Debug.Log($"Using item: {name}");
        }
    }
}