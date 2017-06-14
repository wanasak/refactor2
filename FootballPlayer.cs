namespace refractor2_demo
{
    public class FootballPlayer
    {
        private string _Name;
        private double[] _40YardDashTimes = null;

        public string GetName() { return _Name; }
        public double[] GetFourtyYardDashTimes()
        {
            return _40YardDashTimes;
        }

        public FootballPlayer(string name, double[] fourtyYardDashTimes)
        {
            this._Name = name;
            this._40YardDashTimes = fourtyYardDashTimes;
        }
    }
}
