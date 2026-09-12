namespace Assignment.StudentSolution
{
    public class Orc : MeleeEnemy
    {
        public int rageLevel = 0;

        public void Enrage()
        {
            rageLevel += 1;
            damage += 5;
        }
    }
}