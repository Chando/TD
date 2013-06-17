namespace TowerDefence.Player
{
    public class Player
    {
        public int Lives;
        public int Money;

        public Player(int numberOfLives, int amountOfMoney)
        {
            this.Lives = numberOfLives;
            this.Money = amountOfMoney;
        }
    }
}
