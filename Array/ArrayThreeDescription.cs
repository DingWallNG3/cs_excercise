// using System;
//
// namespace ArrayThreeDescription
// {
//     static class ArrayThreeDescription
//     {
//         static void Main(string[] args)
//         {
//             var names = new string[2, 2, 2] {{{"C#", "ASP.NET"}, {"Windows Forms", "WPF"}},
//                 {{"Xamarin", "Unity"}, {"UWP", "Azure"}}};
//
//             for (var i = 0; i < 2; i++)
//             {
//                 Console.WriteLine($"\n{i}층");
//                 for (var j = 0; j < 2; j++)
//                 {
//                     Console.WriteLine($"{names[i, j, 0],20}, {names[i, j, 1],20}");
//                 }
//             }
//         }
//     }
// }