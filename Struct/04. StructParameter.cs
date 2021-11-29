// using System;
// using System.Runtime.InteropServices;
//
// namespace Struct
// {
//     struct Member
//     {
//         public string Name;
//         public int Age;
//     }
//
//     class StructParameter
//     {
//         static void Main(string[] args)
//         {
//             var name = "백승수";
//             var age = 21;
//             Print(name, age);
//
//             Member m;
//             m.Name = "이세영";
//             m.Age = 100;
//             Print(m);
//         }
//
//         static void Print(string name, int age) => Console.WriteLine($"이름 : {name}, 나이 : {age}");
//         static void Print(Member member) => Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
//     }
// }