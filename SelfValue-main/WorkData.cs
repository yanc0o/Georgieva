using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfValue
{
    public abstract class WorkData : IPrint, IComparable<WorkData> // наследяваш интерфейс-а което ти дава достъп до метода в него, наследяваш IComparable от WorkData което то позволява да сортираш всички данни по зададено от теб поле (В условието е казано да сортираш в същия клас, не в отделен, ако те пита там нещо и се заяжда) 
    {
        // създаваш две полета
        private int code;
        private string type;

        // конструктор на когото задаваш дадените стойности
        public WorkData(int code, string type)
        {
            Code = code;
            Type = type;
        }

        // пропъртита на полетата
        public int Code
        {
            get { return code; }
            set
            {
                if (value < 0)// валидация която проверява дали даден вход от потребителя е валиден
                {
                    throw new ArgumentNullException("Your code should be positive number!");
                }
                code = value;
            }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int CompareTo(WorkData other) // Метод който сортира дадена колекция по даден параметър (в случая по код-а)
        {
            return Code.CompareTo(other.Code);
        }

        // създаваш виртуален метод което ти позволява да го преизползваш във всеки клас който наседява този клас (WorkData)
        public virtual void Print() { }
    }
}
