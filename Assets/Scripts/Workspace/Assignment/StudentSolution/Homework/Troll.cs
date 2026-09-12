namespace Assignment.StudentSolution
{
    public class Troll : MeleeEnemy
    {
        public int regenerationRate = 2;

        public void Regenerate()
        {
            health += regenerationRate;
        }
    }
}