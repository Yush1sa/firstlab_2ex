using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Secondlab
{

    public class Logic
    {
        public int SearchingForTriplesForTriangle(int cnt, List<List<int>> triples)
        {
            var cntTriples = 0;
            for (int i = 0; i < triples.Count; i++)
            {
                var side = new List<int>();
                side = triples[i];
                side.Sort();
                if ((side[0] + side[1]) > side[2])
                {
                    cntTriples++;
                }
            }
            return cntTriples;
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

            var cntTriples = 0;
            for (int i = 0; i < triples.Count; i++)
            {
                var side = new List<int>();
                side = triples[i];
                side.Sort();
                if ((side[0] + side[1]) > side[2])
                {
                    cntTriples++;
                }
            }

        }
    }
}
