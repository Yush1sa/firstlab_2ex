using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Secondlab
{

    public class Logic
    {
        public List<List<int>> SearchingForTriplesForTriangle(int cnt, List<List<int>> triples)
        {
            List<List<int>> ValidTroiky = new List<List<int>>();
            for (int i = 0; i < triples.Count; i++)
            {
                var side = new List<int>();
                side = triples[i];
                side.Sort();
                if ((side[0] + side[1]) > side[2])
                {
                    ValidTroiky.Add(side);
                }
            }
            return ValidTroiky;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var triples = new List<List<int>>();
            var cnt = int.Parse(Console.ReadLine());
            string inputNumber;


            while (cnt > 0)
            {
                var sideCnt = 3;
                var side = new List<int>();
                while (sideCnt > 0) {
                    inputNumber = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputNumber))
                    {
                        break;
                    }
                    side.Add(int.Parse(inputNumber));
                    sideCnt--;
                }


                triples.Add(side);
                cnt--;
            }

            List<List<int>> ValidTroiky = new List<List<int>>();
            for (int i = 0; i < triples.Count; i++)
            {
                var side = new List<int>();
                side = triples[i];
                side.Sort();
                if ((side[0] +  side[1]) > side[2])
                {
                    ValidTroiky.Add(side);
                }
            }
    
        }
    }
}
