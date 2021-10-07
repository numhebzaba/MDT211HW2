using System;

namespace HwRecoding
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesEmployee sale = new SalesEmployee("นาย เจมส์ ทองดี", 20000, 5000);
            ProgrammerEmployee programmer = new ProgrammerEmployee("นาย เน รักดี", 50000);

            sale.ShowEmployeeInfo();
            programmer.ShowEmployeeInfo();
        }
        static void addSaleEmployee(string name, int basePay, int bouns)
        {
            SalesEmployee sale = new SalesEmployee(name, basePay, bouns);
        }
    }
    public class Employee {

        public string Name;
        protected int basePay;

        public Employee(string name, int basePay) {
            this.Name = name;
            this.basePay = basePay;
        }

        public virtual int CalculatePay() {
            return basePay;
        }
        public void ShowEmployeeInfo() {
            Console.WriteLine("Employee : {0} Earned : {1} ",this.Name,this.CalculatePay());
        }
    }
    public class SalesEmployee : Employee {
        private int salesBonus;

        public SalesEmployee(string name, int basePay, int salesBonus)
        : base(name,basePay)
        {
            this.salesBonus = salesBonus;
        }

        public override int CalculatePay()
        {
            return basePay + salesBonus;
        }
    }
    class ProgrammerEmployee : Employee {
        public ProgrammerEmployee(string name,int basePay) : base(name, basePay) { }
    }
}
