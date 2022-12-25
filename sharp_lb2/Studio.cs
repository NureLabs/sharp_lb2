using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb2
{
    enum Instrument_Type
    {
        Drum,
        Bass_Guitar,
        Rhythm_Guitar,
        Lead_Guitar,
        Synthesizer,
        Piano,
        Saxophone,
        Cello,
        Violin,
        Bayan
    }
    interface ICloneable
    {
        object Clone();
    }
    class Studio : ICloneable
    {
        private string name_of_studio;
        private string adress_of_studio;
        protected int amount_of_employees;

        private double one_track_cost;
        private int one_track_time_to_record; //in minutes

        private double fund_of_studio;
        private double all_employees_salary;
        private double salary_of_employee_of_studio;

        protected int amount_of_musical_instruments_in_studio;
        protected int amount_of_recoding_rooms;

        //protected Recording_Room[] room_collection;

        //private int room_id_counter;
        //one room = at least 2 instruments and 2 employees

        public Studio()
        {
            
        }
        public Studio(string name_of_studio, string adress_of_studio, int amount_of_employees,
            double one_track_cost, int one_track_time_to_record,
            double salary_of_employee_of_studio, double fund_of_studio,
            int amount_of_musical_instruments_in_studio, int amount_of_recoding_rooms)
        {
            this.name_of_studio = name_of_studio;
            this.adress_of_studio = adress_of_studio;
            this.amount_of_employees = amount_of_employees;

            this.one_track_cost = one_track_cost;
            this.one_track_time_to_record = one_track_time_to_record;

            this.salary_of_employee_of_studio = salary_of_employee_of_studio;
            this.fund_of_studio = fund_of_studio;

            this.amount_of_musical_instruments_in_studio = amount_of_musical_instruments_in_studio;
            this.amount_of_recoding_rooms = amount_of_recoding_rooms;

            //room_collection = new Recording_Room[0];

            //room_id_counter = 0;
        }

        public void Add_Recoding_Room()
        {
            amount_of_recoding_rooms++;
            //Recording_Room room = new Recording_Room();
            //Array.Resize(ref room_collection, room_collection.Length + 1);
            //room_collection[room_collection.Length - 1] = room;
        }

        public void Remove_Recoding_Room()
        {
            //Array.Resize(ref room_collection, room_collection.Length - 1);
            amount_of_recoding_rooms--;
        }

        /*public double this[int index]
        {
            get => salary_of_employee_of_studio;
        }*/

        public int Get_Rooms
        {
            get { return amount_of_recoding_rooms; }
        }

        public void Recruit_Employee()
        {
            amount_of_employees++;
        }
        public void Fire_Employee()
        {
            amount_of_employees--;
        }
        public int Get_Employees
        {
            get { return amount_of_employees; }
        }
        public string Get_Name
        {
            get { return name_of_studio; }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }


        //double this [int index1, int index2]
        //{
        //    get => one_employee_salary[index1];
        //}

        /*public double Get_Balance
        {
            get { return ; }
        }
        public long[] Get_History
        {
            get { return ; }
        }
        public int Get_Connected_Services
        {
            get { return ; }
        }
        public int Get_Taryf
        {
            get { return ; }
        }*/
    }
}
