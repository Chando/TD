namespace TowerDefence.Player
{
    class PlayerFactory
    {
        public void GetEasyPlayer()
        {
            var result = new Player(100, 1000);//SA - Again, settings file.
        }

        public void GetMediumPlayer()
        {
            var result = new Player(80, 800);
        }

        public void GetHardPlayer()
        {
            var result = new Player(60, 600);
        }
    }
}
