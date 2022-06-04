using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_II_Game
{
    internal interface IUserRepository  //UserRepository interface veri degisikligini kodda cok degisiklik yapmadan yapabilmek icin
    {
        //Sonrasinda Interface'ten inherit alan UserRepository class'i olusturalacak
        //Metot ekleniyor interface'de
        Task<bool> Insert(User user);
    }
}
