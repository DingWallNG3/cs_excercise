// using System;
//
// namespace Function
// {
//     class FunctionOverload
//     {
//         static void Multi()
//         {
//             Console.WriteLine("안녕하세요.");
//         }
//
//         static void Multi(string message)
//         {
//             Console.WriteLine(message);
//         }
//
//         static void Multi(string message, int count)
//         {
//             for (var i = 0; i < count; i++)
//             {
//                 Console.WriteLine(message);
//             }
//         }
//
//         static void Main(string[] args)
//         {
//             Multi();
//             Multi("반갑습니다.");
//             Multi("또 만나요.", 3);
//         }
//     }
// }