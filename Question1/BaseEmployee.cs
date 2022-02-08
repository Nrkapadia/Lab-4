using System;
namespace BaseEmployee{
     public class Employee{

        private string _firstName;
        private string _lastName;
        private double _monthly_Sal;

        public string FirstName{
            get=>_firstName;
            set=>_firstName=value;
        }
        public string LastName{
            get=>_lastName;
            set=>_lastName=value;
        }

        public double Monthly_Sal{
            get=>_monthly_Sal;
            set{
                if(value<0.0d)
                {
                    _monthly_Sal=0.0d;
                }
                else{
                    _monthly_Sal=value;
                }
            }
        }
      
        public Employee(string fname,string lname,double sal){
                    _firstName=fname;
                    _lastName=lname;
                    if(sal<0.0)
                    {
                        _monthly_Sal=0.0;
                    }
                    else
                    {
                        _monthly_Sal=sal;
                    }
        }
        public virtual double giveRaise(double a){
            _monthly_Sal+=_monthly_Sal*(a/100);
            return _monthly_Sal;
        }

        public double calculateGrossSalary()
        {
            return this.Monthly_Sal*12;
        }
        public override string ToString()
        {
            return $"Employee's name is {this.FirstName} {this.LastName} \nand his monthly salary is {this.Monthly_Sal} and anual salary is {this.calculateGrossSalary()}.";
        }
    
    }
    public class PermenetEmployee : Employee
    {
        private double _hra;
        private double _da;
        private double _pf;

        //by setting only getter method I made them read-only properties
        public double Hra{
            get=>_hra;
        }
        public double Da{
            get=>_da;
        }
        public double Pf{
            get=>_pf;
        }
        

        // here I used concept of method hiding for calculateGrossSalary using new keyword
        public new double calculateGrossSalary()
        {
              return (this.Monthly_Sal+(this.Monthly_Sal*Hra)/100+(this.Monthly_Sal*Da)/100-(this.Monthly_Sal*Pf)/100)*12;
        }


        //here i used method overrideing in c sharp
        public override double giveRaise(double a)
        {
              return this.Monthly_Sal+(this.Monthly_Sal*a)/100;
        }
        public PermenetEmployee(string fname,string lname,double sal,double hra,double da, double pf):base(fname,lname,sal) {
            _hra=hra;
            _da=da;
            _pf=pf;
        }
        public override string ToString()
        {
            return $"Permenent Employee's name is {this.FirstName} {this.LastName}\nand his monthly salary is {this.Monthly_Sal} and anual salary with {this.Hra}%HRA + {this.Da}%DA + {this.Pf}% PF is {this.calculateGrossSalary()}.";
        }
    }
}