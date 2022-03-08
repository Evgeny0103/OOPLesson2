using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson2
{
    public class typeAccount
    {
        enum accountType 
        {
            current, // Текущий
            correspondent,  // Кореспондентский
            calculated, // Расчетный
            budget,  // Бюджетный
            correspondentsubAccounts, // Кореспондентский суб-счета
            trustManagement, // Доверительного управления 
            special, // Специальные 
            depositAccounts, // Счета по вкладам 

        } 
    }
}
