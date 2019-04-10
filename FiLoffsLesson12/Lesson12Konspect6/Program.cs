using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Konspect6
{
    delegate Name UI(FamilyAndName obj);
    public class Name
    {
        public string myName;
    }
    public class FamilyAndName : Name
    {
        public string Family;
    }
    public class UserInfo
    {
        public static Name UIName(Name obj)
        {
            obj.myName = "Имя пользователя: \"" + obj.myName + "\"";
            return obj;
        }
        public static FamilyAndName UIFamilyName(FamilyAndName obj)
        {
            obj.Family = "Имя и фамилия: \"" + obj.myName + " " + obj.Family + "\"";
            return obj;
        }
    }
    class Program
    {
        static void Main()
        {
            // Пример ковариантности
            // Можно использовать метод, возвращаемым типом параметра которого
            // является производный класс
            UI user1 = UserInfo.UIFamilyName;
            // Пример контравариантности
            // Можно использовать метод, аргументом которого является базовый класс
            user1 = UserInfo.UIName;
        }
    }
}
