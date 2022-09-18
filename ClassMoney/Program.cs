using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoney
{
    class Money {
        public double all_money { get; private set; }
        public Money(double all_money)
        {
            if (all_money < 0)
                throw new ArgumentException("Вы банкрот");
            this.all_money = all_money;
        }
        public Money()
        {
            
            this.all_money =0;
        }
        public static Money operator +(Money a, Money b)
        {
            Money c = new Money(a.all_money+b.all_money);
            return c; 
        }
        public static Money operator -(Money a, Money b)
        {
            Money c = new Money(a.all_money - b.all_money);
            return c;
        }
        public static Money operator *(Money a, int b)
        {
            Money c = new Money(a.all_money *b);
            return c;
        }
        public static Money operator /(Money a, int b)
        {
            Money c = new Money(a.all_money / b);
            return c;
        }
        public static Money operator --(Money a)
        {
            a.all_money += 0.01;
            return a;
        }
        public static Money operator ++(Money a)
        {
            a.all_money -= 0.01;
            return a;
        }
        public static bool operator >(Money a, Money b)
        {
            if (a.all_money > b.all_money) 
            return true;
            else
                return false;
        }
        public static bool operator <(Money a, Money b)
        {
            if (a.all_money < b.all_money)
                return true;
            else
                return false;
        }
        public static bool operator ==(Money a, Money b)
        {
            if (a.all_money == b.all_money)
                return true;
            else
                return false;
        }
        public static bool operator !=(Money a, Money b)
        {
            if (a.all_money != b.all_money)
                return true;
            else
                return false;
        }
        public void vyvod()
        {
            Console.WriteLine($"Вы имеете {(int)all_money} рублей, {(int)((all_money%1)*100)} копейек");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внимание: в программе копейки могут иногда выводиться с погрешностью из-за особенностей храненийя данных с плавающей точкой\n\n");
            Console.WriteLine($"Введите значение первой суммы (руб,коп без пробелов): ");
            double  a= Double.Parse(Console.ReadLine());
            Money m1 = new Money(a);
            Console.WriteLine($"Введите значение второй суммы (руб,коп без пробелов): ");
            double b = Double.Parse(Console.ReadLine());
            Money m2 = new Money(b);
            m1.vyvod();
            m2.vyvod();
            int c;
            Money m3 = new Money();
            Console.WriteLine($"Выберите что вы хотите сделать: ");
            Console.WriteLine("1) Сложить две суммы\n" +
                "2) Вычесть из первой суммы вторую\n" +
                "3) Вычесть из второй суммы первую\n" +
                "4) Поделить первую сумму на число\n" +
                "5) Поделить вторую сумму на число\n" +
                "6) Умножить первую сумму на число\n" +
                "7) Умножить вторую сумму на число\n" +
                "8) Добавить к первой сумме 1 копейку\n" +
                "9) Добавить ко второй  сумме 1 копейку\n" +
                "10) Равны ли две суммы\n" +
                "11) Больше ли первая сумма второй\n" +
                "12) Больше ли вторая сумма первой\n" +
                "13) Суммы не равны\n");
            double choise = Int32.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    m3 = m1 + m2;
                    m3.vyvod();
                    break;
                case 2:
                    m3 = m1 - m2;
                    m3.vyvod();
                    break;
                case 3:
                    m3 = m2 - m1;
                    m3.vyvod();
                    break;
                case 4:
                    Console.WriteLine($"Введите значение числа: ");
                    c = Int32.Parse(Console.ReadLine());
                    m3 = m1/c;
                    m3.vyvod();
                    break;
                case 5:
                    Console.WriteLine($"Введите значение числа: ");
                    c = Int32.Parse(Console.ReadLine());
                    m3 = m2 / c;
                    m3.vyvod();
                    break;
                case 6:
                    Console.WriteLine($"Введите значение числа: ");
                    c = Int32.Parse(Console.ReadLine());
                    m3 = m1 * c;
                    m3.vyvod();
                    break;
                case 7:
                    Console.WriteLine($"Введите значение числа: ");
                    c = Int32.Parse(Console.ReadLine());
                    m3 = m1 * c;
                    m3.vyvod();
                    break;
                case 8:
                    m3 = m1++;
                    m3.vyvod();
                    break;
                case 9:
                    m3 = m2++;
                    m3.vyvod();
                    break;
                case 10:
                    Console.WriteLine(m1==m2);
                    break;
                case 11:
                    Console.WriteLine(m1 > m2);
                    break;
                case 12:
                    Console.WriteLine(m1 < m2);
                    break;
                case 13:
                    Console.WriteLine(m1 != m2);
                    break;

                default:
                    break;
            }


        }
    }
}
