using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Employee
    {
        //property Name
        private string name;
        public string Name
        {
            set
            {
                if(value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be blank!!!!!!!!");
                }
            }

            get
            {
                return name;
            }
        }


        // property EmpNo
        private static int empno_auto=0;
        private int empno;
        public int EmpNo
        {
            get
            {
                return empno;
            }
        }

        //property Basic
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if(value  > 2000 && value < 10000000)
                {
                    basic = value;

                }
                else
                {
                   // Console.WriteLine("Basic must be >= 2000");
                    basic = 2000;
                }

            }
            get
            {
                return basic;
            }
        }

        //property DeptNo
        private short deptno;
        public short DeptNo
        {
            set
            {
               if(value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("Invalid DEptNo");
                    deptno = 1;
                }
            }
            get
            {
                return deptno;
            }
        }

        public decimal GetNetSalary()
        {
            decimal salary = Basic + 1000;
            return salary;
        }

        public Employee(string Name="Invalid name", decimal Basic=2000, short DeptNo=1)
        {
            empno_auto++;
            empno = empno_auto;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;

        }


        //public Employee(string Name,decimal Basic,short DeptNo)
        //{
        //    empno_auto++;
        //    empno=empno_auto;
        //    this.Name = Name;
        //    this.Basic = Basic;
        //    this.DeptNo = DeptNo;

        //}

        //public Employee(string Name, decimal Basic)
        //{
        //    empno_auto++; 
        //    empno = empno_auto;
        //    this.Name = Name;
        //    this.Basic = Basic;
        //    this.DeptNo = 0;
        //}

        //public Employee(string Name)
        //{
        //    empno_auto++;
        //    empno = empno_auto;
        //    this.Name = Name;
        //    this.DeptNo = 0;
        //    this.Basic = 0;
        //}

        //public Employee()
        //{
        //    empno_auto++;
        //    empno = empno_auto;
        //    this.Name = "";
        //    this.DeptNo = 0;
        //    this.Basic = 0;
        //}


        class Assign1
        {
            static void Main( )
            {
                Employee o1 = new Employee();
                Employee o2 = new Employee();
                Employee o3 = new Employee();
                
                Console.WriteLine (o1.EmpNo);
                Console.WriteLine (o2.EmpNo);
                Console.WriteLine(o3.EmpNo);
              
                Console.WriteLine("--------------------------");
                
                Console.WriteLine (o3.EmpNo);
                Console.WriteLine (o2.EmpNo);
                Console.WriteLine (o1.EmpNo);


                //Console.WriteLine("--------------------------");
                //Console.WriteLine(o1.EmpNo);
                //Console.WriteLine(o1.DeptNo);
                //Console.WriteLine(o1.Basic);
                //Console.WriteLine(o1.Name);
                //Console.WriteLine("Net Salary = " + o1.GetNetSalary());

                //Console.WriteLine("--------------------------");

                //Employee o4 = new Employee("Amol", 123465, 10);
                //Console.WriteLine(o4.EmpNo);
                //Console.WriteLine(o4.DeptNo);
                //Console.WriteLine(o4.Basic);
                //Console.WriteLine(o4.Name);
                //Console.WriteLine("Net Salary = " + o4.GetNetSalary());


                //Console.WriteLine("--------------------------");


                //Employee o6 = new Employee("Amol", 3000);
                //Console.WriteLine(o6.EmpNo);
                //Console.WriteLine(o6.DeptNo);
                //Console.WriteLine(o6.Basic);
                //Console.WriteLine(o6.Name);
                //Console.WriteLine("Net Salary = " + o6.GetNetSalary());

                //Console.WriteLine("--------------------------");




            }


        }
    }
}
