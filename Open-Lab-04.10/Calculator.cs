using System;
using System.Linq;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            double x = Convert.ToDouble(nums.Sum());
            float result = Convert.ToSingle(x / nums.Length);
            return result;
        }
    }
}
