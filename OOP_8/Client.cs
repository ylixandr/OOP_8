using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    internal class Client:IAccount,IDepositAccount
    {
        private string _clientName;
        private float _accountMoney;
        private int _procent;

        public Client(string clientName, float accountMoney, int procent)
        {
            _accountMoney = accountMoney;
            _procent = procent;
            _clientName = clientName;
        
        }

        public float CurrentSum { get { return _accountMoney; } set => _accountMoney = value; }

        public int TotalProcent { get { return _procent; } set => _procent = value; }

        public void AddMoney(float money)
        {
            _accountMoney += money;
            
        }

        public void RemoveMoney(float money)
        {
            _accountMoney -= money;
        }
        public void Info()
        {
            Console.WriteLine($"Имя клиента: {_clientName}, Сумма на счете: {_accountMoney}, Процент: {_procent}" );
        }

        public void CalculateInterest()
        {
            float interest = _accountMoney * _procent / 100;

            // Добавить проценты к балансу
            _accountMoney += interest;

            Console.WriteLine($"Начисление процентов. После вычета сумма {_accountMoney}");
        }
    }
}
