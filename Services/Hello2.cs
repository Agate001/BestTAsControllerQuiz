// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using BestTAsControllerQuiz.Model;

// namespace BestTAsControllerQuiz.Services
// {
//     public class Hello2
//     {
//         private readonly List<Name> _name = new();
//         public Hello2()
//         {
//             _name.Add(new Name
//             {
//                 Id = 1,
//                 user = "Carlos",
//             });
//             _name.Add(new Name
//             {
//                 Id = 2,
//                 user = "Jacob",
//             });
//             _name.Add(new Name
//             {
//                 Id = 3,
//                 user = "Ken",
//             });
//             _name.Add(new Name
//             {
//                 Id = 4,
//                 user = "Jose",
//             });
//         }


//         public Name? GetNameById(int id)
//         {
//              _name.FirstOrDefault(n => n.Id == id);
//              return $"hello + {user}.";
//         }

//     }
// }