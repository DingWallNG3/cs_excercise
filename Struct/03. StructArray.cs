// using System;
//
// namespace StructArray
// {
//     struct BusinessCard
//     {
//         public string Name;
//         public int Age;
//     }
//
//     class StructArray
//     {
//         static void Print(string name, int age) => Console.WriteLine($"{name}은(는) {age}살입니다.");
//
//         static void Main(string[] args)
//         {
//             BusinessCard biz;
//             biz.Name = "백승수";
//             biz.Age = 17;
//             Print(biz.Name, biz.Age);
//
//             var names = new BusinessCard[2];
//             names[0].Name = "이세영";
//             names[0].Age = 102;
//             names[1].Name = "권경민";
//             names[1].Age = 31;
//             for (var i = 0; i < names.Length; i++)
//             {
//                 Print(names[i].Name, names[i].Age);
//             }
//         }
//     }
// }