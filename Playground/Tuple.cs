using System.IO;
using System.Text;

namespace Playground
{
    class Tuple
    {
        static void Main(string[] args)
        {
			#region Tuple
			//var (x,y) = getDistance("hospital");

			//Console.WriteLine(x+" "+y);

			//ValueTuple<string,double> tuple = new ValueTuple<string, double>("mostafa",25.333);
			//Console.WriteLine(tuple.Item1);
			//Console.WriteLine(tuple.Item2); 
			#endregion

			#region SwitchCase New Fashion

			Console.WriteLine("Enter your number:");
			int num;
			if (int.TryParse(Console.ReadLine(),out num))
			{
                Console.WriteLine(SwitchCases.switchCases(num));
            }

            #endregion

        }
        //public static Tuple<string , decimal> getDistance(string place)
        //{
        //    return Tuple.Create(place, 25.00m);
        //}
    }
}