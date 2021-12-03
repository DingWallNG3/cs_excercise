// using System;
// using System.Text.RegularExpressions;
//
// class RegexDemo
// {
//     static void Main(string[] args)
//     {
//         var email = "abcd@aaa.com";
//         Console.WriteLine(IsEmail(email));
//     }
//
//     private static bool IsEmail(string email)
//     {
//         var result = false;
//
//         Regex regex = new Regex(
//             @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)" +
//             @"(([\/\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
//         
//         result = regex.IsMatch(email);
//         return result;
//     }
// }