
namespace GachaSimulator
{
    public class Game
    {
        private static Random generator = new Random();

        public Game()
        {

        }

        public void Spin()
        {
            int spinResult = generator.Next(1, 1001);

            // private 
            // return("result");
        }
    }
}