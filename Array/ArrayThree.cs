// using System;
//
// namespace ArrayThree
// {
//     static class ArrayThree
//     {
//         static void Main(string[] args)
//         {
//             var intArray = new int[2, 3, 4]
//             {
//                 {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}},
//                 {{13, 14, 15, 16}, {17, 18, 19, 20}, {21, 22, 23, 24}}
//             };
//
//             for (var i = 0; i < 2; i++)
//             {
//                 for (var j = 0; j < 3; j++)
//                 {
//                     for (var k = 0; k < 4; k++)
//                     {
//                         Console.Write("{0,4} ", intArray[i, j, k]);
//                     }
//
//                     Console.Write("\n");
//                 }
//
//                 Console.WriteLine();
//             }
//         }
//     }
// }