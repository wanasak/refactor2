using System.Linq;
using System.Threading.Tasks;

namespace refractor2_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FootballPlayer40YardDashInfo fb40Dash = new FootballPlayer40YardDashInfo();

            // Add Clark
            var clark40YdDashTimes = new double[] { 4.36, 4.39, 4.41 };
            var clarkPlayer = new FootballPlayer("Clark Kent", clark40YdDashTimes);
            fb40Dash.AddFootballPlayer(clarkPlayer);

            // Add Bruce
            var bruce40YdDashTimes = new double[] { 4.42, 4.43, 4.49 };
            var brucePlayer = new FootballPlayer("Bruce Wayne", bruce40YdDashTimes);
            fb40Dash.AddFootballPlayer(brucePlayer);

            fb40Dash.PrintPlayerInfo();
        }
    }
}
