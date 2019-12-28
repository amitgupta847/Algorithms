using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_LeetProblems
{


  class LeetCode_Easy
  {
    /* 
 Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows. 
 */
    public static int ReverseSignedInteger(int x)
    {
      int y = 0;

      while (x != 0)
      {
        int yy = y * 10 + x % 10;

        if ((yy - x % 10) / 10 != y) return 0;
        else y = yy;

        x = x / 10;
      }
      return y;
    }
  }
}
