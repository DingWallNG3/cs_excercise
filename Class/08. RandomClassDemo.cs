// using System;
//
// class RandomClassDemo
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("이번 주의 로또 : ");
//         Random ran = new Random();
//         var arr = new int[6];
//         var temp = 0;
//         for (var i = 0; i < 6; i++)
//         {
//             temp = ran.Next(45) + 1;
//             var flag = false;
//             if (i > 0 && i < 6)
//             {
//                 for (var j = 0; j <= i; j++)
//                 {
//                     if (arr[j] == temp)
//                     {
//                         flag = true;
//                     }
//                 }
//             }
//
//             if (flag)
//             {
//                 --i;
//             }
//             else
//             {
//                 arr[i] = temp;
//             }
//         }
//
//         for (var i = 0; i < 6; i++)
//         {
//             Console.Write("{0} ", arr[i]);
//         }
//
//         Console.WriteLine();
//     }
// }