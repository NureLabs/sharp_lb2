using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb2
{
     class Employee : Recording_Room
    {
        private long INN;
        private string full_name_employee;
        private double salary_employee;
        private int amount_of_recorded_tracks_employee;
        
        /*public Employee()
        {
            Array.Resize(ref employee_INNs, employee_INNs.Length + 1);
            employee_INNs[employee_INNs.Length - 1] = employee_INNs.Last() + 1;
        }*/
        public Employee(long got_INN, string got_fullName, double got_salary, int got_amount)
        {
            INN = got_INN;
            full_name_employee = got_fullName;
            salary_employee = got_salary;
            amount_of_recorded_tracks_employee = got_amount;

            Array.Resize(ref employee_INNs, employee_INNs.Length + 1);
            employee_INNs[employee_INNs.Length - 1] = got_INN;

            amount_of_employees += 1;
        }
    }
}
