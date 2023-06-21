using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfValue
{
    public class PaymentPerHour : WorkData // наследяваш базовия клас (WorkData) което ти позволява да му използваш всички данни
    {
        // създаваш две полета
        private double payment;
        private int hours;
        // конструктор на когото задаваш дадените стойности на текущия клас (PaymentPerHour) и преизползваш тези на базовия клас (WorkData)
        public PaymentPerHour(int code, string type, double payment, int hours) : base(code, type)
        {
            Payment = payment;
            Hours = hours;
        }

        // пропъртита на полетата
        public double Payment
        {
            get { return payment; }
            set
            {
                if (value < 0) // валидация която проверява дали даден вход от потребителя е валиден
                {
                    throw new ArgumentNullException("Your payment can not be negative or neutral!");
                }
                payment = value;
            }
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0) // валидация която проверява дали даден вход от потребителя е валиден
                {
                    throw new ArgumentNullException("You should have at least 1 hour!");
                }
                hours = value;
            }
        }

        // override на виртуалния метод с когото принтиш информацията на конзолата
        public override void Print()
        {
            Console.WriteLine($"Work code and type -> {Code}, {Type}");
            Console.WriteLine($"Working hours - payment -> {Hours} - {Payment}");
        }

    }
}
