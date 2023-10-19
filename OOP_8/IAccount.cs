using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    internal interface IAccount
    {
        //        Данный интерфейс должен определять два свойства(для текущей суммы
        //денег на счете и ставки процента по вкладам) и два метода(для добавления
        //денег на счет и изъятия денег).
         float CurrentSum { get; set; }
        int TotalProcent { get; set; }

        void AddMoney(float money);

         void RemoveMoney(float money);

    
    }
}
