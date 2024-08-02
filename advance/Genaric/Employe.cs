using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance.Genaric
{
    internal class Employee : ICloneable

    {
        #region MyRegion

        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name}:: {Salary}  ";
        }


        #endregion
        #region MyRegion
        public static bool operator ==  ( Employee left, Employee right)

        { 
       
            return (left.Id == right.Id )&&(left.Name==right.Name)&&(left.Salary==right.Salary) ;
        
        }

        public static bool operator !=(Employee left, Employee right)
        {

            return (left.Id == right.Id) || (left.Name == right.Name) || (left.Salary == right.Salary);



        }

        #endregion


        public override bool Equals(object? obj)
        {
            Employee? employee = (Employee?)obj;
            return (this.Id  == employee?.Id ) && (this.Name == employee?.Name) &&  (this.Salary == employee?.Salary);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() + this.Name.GetHashCode()   + this.Salary.GetHashCode();
        }


        public int CompareTo(object? obj)
        {
            Employee passedEmployee= (Employee?)obj;

            return this.Salary.CompareTo(passedEmployee?.Salary) ;      


        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }



}
