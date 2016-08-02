using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.DynamicProgramming
{
    class TextJustification
    {
        public String justify(String[] words, int width)
        {
            int[,] cost = new int[words.Length, words.Length];

            //next 2 for loop is used to calculate cost of putting words from 
            //i to j in one line. If words don't fit in one line then we put 
            //Integer.MAX_VALUE there. 
            for (int i = 0; i < words.Length; i++)
            {
                cost[i, i] = width - words[i].Length;
                for (int j = i + 1; j < words.Length; j++)
                {
                    cost[i, j] = cost[i, j - 1] - words[j].Length - 1;
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i; j < words.Length; j++)
                {
                    if (cost[i, j] < 0)
                    {
                        cost[i, j] = int.MaxValue;
                    }
                    else
                    {
                        cost[i, j] = (int)Math.Pow(cost[i, j], 2);
                    }
                }
            }

            //minCost from i to len is found by trying 
            //j between i to len and checking which 
            //one has min value 
            int[] minCost = new int[words.Length];
            int[] result = new int[words.Length];
            for (int i = words.Length - 1; i >= 0; i--)
            {
                minCost[i] = cost[i, words.Length - 1];
                result[i] = words.Length;
                for (int j = words.Length - 1; j > i; j--)
                {
                    if (cost[i, j - 1] == int.MaxValue)
                    {
                        continue;
                    }

                    if (minCost[i] > minCost[j] + cost[i, j - 1])
                    {
                        minCost[i] = minCost[j] + cost[i, j - 1];
                        result[i] = j;
                    }
                }
            }
            
            int ii = 0;
            int jj = 0;

            Debug.WriteLine("Minimum cost is " + minCost[0]);
            Debug.WriteLine("\n");
            //finally put all words with new line added in  
            //string buffer and print it. 
            StringBuilder builder = new StringBuilder();
            do
            {
                jj = result[ii];
                for (int k = ii; k < jj; k++)
                {
                    builder.Append(words[k] + " ");
                }
                builder.Append("\n");
                ii = jj;
            } while (jj < words.Length);

            return builder.ToString();
        }

        public static void main(String[] args)
        {
            String[] words1 = { "How", "to", "write", "code", "at", "free", "time" };
            TextJustification awl = new TextJustification();
            Debug.WriteLine(awl.justify(words1, 12));
        }
    }
}



/** 
4  * Date 05/07/2015 
5  * @author tusroy 
6  *  
7  * Video link - https://youtu.be/RORuwHiblPc 
8  *  
9  * Given a sequence of words, and a limit on the number of characters that can be put  
10  * in one line (line width). Put line breaks in the given sequence such that the  
11  * lines are printed neatly 
12  *  
13  * Solution: 
14  * Badness - We define badness has square of empty spaces in every line. So 2 empty space 
15  * on one line gets penalized as 4 (2^2) while 1 each empty space on 2 lines gets 
16  * penalized as 2(1 + 1). So we prefer 1 empty space on different lines over 2 empty space on 
17  * one line. 
18  *  
19  * For every range i,j(words from i to j) find the cost of putting them on one line. If words  
20  * from i to j cannot fit in one line cost will be infinite. Cost is calculated as square of 
21  * empty space left in line after fitting words from i to j. 
22  *  
23  * Then apply this formula to get places where words need to be going on new line. 
24  * minCost[i] = minCost[j] + cost[i][j-1] 
25  * Above formula will try every value of j from i to len and see which one gives minimum  
26  * cost to split words from i to len. 
27  *  
28  * Space complexity is O(n^2) 
29  * Time complexity is O(n^2) 
30  *  
31  * References: 
32  * http://www.geeksforgeeks.org/dynamic-programming-set-18-word-wrap/ 
33  */
//34 public class TextJustification { 
//35 

//36     public String justify(String words[], int width) { 
//37          
//38         int cost[][] = new int[words.length][words.length]; 
//39          
//40         //next 2 for loop is used to calculate cost of putting words from 
//41         //i to j in one line. If words don't fit in one line then we put 
//42         //Integer.MAX_VALUE there. 
//43         for(int i=0 ; i < words.length; i++){ 
//44             cost[i][i] = width - words[i].length(); 
//45             for(int j=i+1; j < words.length; j++){ 
//46                 cost[i][j] = cost[i][j-1] - words[j].length() - 1;  
//47             } 
//48         } 
//49          
//50         for(int i=0; i < words.length; i++){ 
//51             for(int j=i; j < words.length; j++){ 
//52                 if(cost[i][j] < 0){ 
//53                     cost[i][j] = Integer.MAX_VALUE; 
//54                 }else{ 
//55                     cost[i][j] = (int)Math.pow(cost[i][j], 2); 
//56                 } 
//57             } 
//58         } 
//59          
//60         //minCost from i to len is found by trying 
//61         //j between i to len and checking which 
//62         //one has min value 
//63         int minCost[] = new int[words.length]; 
//64         int result[] = new int[words.length]; 
//65         for(int i = words.length-1; i >= 0 ; i--){ 
//66             minCost[i] = cost[i][words.length-1]; 
//67             result[i] = words.length; 
//68             for(int j=words.length-1; j > i; j--){ 
//69                 if(cost[i][j-1] == Integer.MAX_VALUE){ 
//70                     continue; 
//71                 } 
//72                 if(minCost[i] > minCost[j] + cost[i][j-1]){ 
//73                     minCost[i] = minCost[j] + cost[i][j-1]; 
//74                     result[i] = j; 
//75                 } 
//76             } 
//77         } 
//78         int i = 0; 
//79         int j; 
//80          
//81         System.out.println("Minimum cost is " + minCost[0]); 
//82         System.out.println("\n"); 
//83         //finally put all words with new line added in  
//84         //string buffer and print it. 
//85         StringBuilder builder = new StringBuilder(); 
//86         do{ 
//87             j = result[i]; 
//88             for(int k=i; k < j; k++){ 
//89                 builder.append(words[k] + " "); 
//90             } 
//91             builder.append("\n"); 
//92             i = j; 
//93         }while(j < words.length); 
//94          
//95         return builder.toString(); 
//96     } 
//97      
//98     public static void main(String args[]){ 
//99         String words1[] = {"Tushar","likes","to","write","code","at", "free", "time"}; 
//100         TextJustification awl = new TextJustification(); 
//101         System.out.println(awl.justify(words1, 12)); 
//102     } 
//103 } 

//}
