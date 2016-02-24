using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TristanFreitasAssignment2
{
    public class TriangleFinder:Program
    {

        public string triangleType = "";
        public bool testBool = false;

        public TriangleFinder()
        {

        }

        public void Analyze(int first, int second, int third)
        {
            if (first < 0 || second < 0 || third < 0)
            {
                triangleType = "";
            }

            if (first == 0 || second == 0 || third == 0)
            {
                triangleType = "";
            }

            else if (first + second >= third && first + third >= second
                        && second + third >= first)
            {
                 if (first == second && second == third && third == first)
                {
                    triangleType = "Equilateral";
                }
                else if (first == second || second == third || third == first)
                {
                    triangleType = "Isosceles";
                }
                else if (first != second && second != third && third != first)
                {
                    triangleType = "Scalene";
                }
            }

            else if (first + second <= third && first + third <= second
                    && second + third <= first)
            {
                if (first == second && second == third && third == first)
                {
                    triangleType = "Equilateral";
                }
                else if (first == second || second == third || third == first)
                {
                    triangleType = "Isosceles";
                }
                else if (first != second && second != third && third != first)
                {
                    triangleType = "Scalene";
                }
            }
        }
    }
}
