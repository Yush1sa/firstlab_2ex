using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Secondlab
{

    public class Logic
    {
        public static int SearchingForTriplesForTriangle(List<List<int>> triples)
        {
            var cntTriples = 0;
            foreach (List<int> sides in triples) { 
                
                sides.Sort();

                if ((sides[0] + sides[1]) > sides[2])
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

        }
    }
}
