// using System;
//
// namespace Struct
// {
//     class CharStruct
//     {
//         static void Main(string[] args)
//         {
//             char a = 'A';
//             char b = 'a';
//             char c = '1';
//             char d = '\t';
//
//             if (Char.IsUpper(a))
//             {
//                 Console.WriteLine("{0}은 대문자", a);
//             }
//
//             if (Char.IsLower(b))
//             {
//                 Console.WriteLine("{0}은 소문자", b);
//             }
//
//             if (Char.IsNumber(c))
//             {
//                 Console.WriteLine("{0}은 숫자형", c);
//             }
//
//             if (Char.IsWhiteSpace(d))
//             {
//                 Console.WriteLine("{0}은 공백 문자", d);
//             }
//
//             Console.WriteLine(Char.ToLower(a));
//             Console.WriteLine(Char.ToUpper(b));
//
//             string s = "abc";
//             if (Char.IsUpper(s[0]))
//             {
//                 Console.WriteLine("첫 글자가 대문자로 시작합니다.");
//             }
//             else
//             {
//                 Console.WriteLine("첫 글자가 소문자로 시작합니다.");
//             }
//
//             Console.WriteLine(Char.MinValue + ".");
//             Console.WriteLine(Char.MaxValue + ".");
//         }      
//     }
// }