using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace boarding_pass_System
{
    class Passenger
    {
        private string _pfname;//final first name of passenger (TRIMMED)
        private string _plname;//final last name of passenger (TRIMMED)
        private int _secno;
        private int _seatno;
        public string _fullname;
        //public int[] vacentseats = new int[40];




        public Passenger(string fname, string lname)
        {
            _Pfname = fname;
            _Plname = lname;
        }

        public string _Pfname//VALIDATION FOR FNAME OF PASSENGER
        {
            get { return _pfname; }
            set
            {
                if (value.Length > 5)
                {
                    _pfname = value.Substring(0, 5);
                }
                else
                {
                    _pfname = value;
                }

            }
        }
        public string _Plname//VALIDATION FOR LNAME OF PASSENGER
        {
            get { return _plname; }
            set
            {
                if (value.Length > 5)
                {
                    _plname = value.Substring(0, 5);//CREATING SUB STRING IF NAME IS MORE THAN 5 CHARACTERS.
                }
                else
                {
                    _plname = value;
                }

            }
        }

        public string Getname()
        {
            _fullname = _pfname + _plname;
            return _fullname;
        }
        public int Secno
        {
            get { return _secno; }
            set { _secno = value; }
        }

        public int Seatno
        {
            get { return _seatno; }
            set { _seatno = value; }
        }
        public int getrandomno()
        {
            Random rnd = new Random();
            _secno = rnd.Next(30000, 999999);
            return _secno;
        }
        public int Getseatno()
        {
            return _seatno;
        }
        public int Getsecno()
        {
            return _secno;
        }

        public int Vacentseats(int[] vacentseats)
        {
            WriteLine("FOLLOWING IS THE LIST OF EMPTY SEATS");
            for (int j = 0; j < vacentseats.Length; j++)
            {
                if (vacentseats[j] == 0)
                {
                    Write("{0},", j + 1);
                }

            }
            WriteLine("\n");
            ReadKey();
            return 0;
        }
        public int Getpassengerdetails(string[] pnames, int[] seatnos, int[] secno)
        {

            WriteLine("   NAME  --  SEATNO  --  SECURITY NO  ");
            for (int i = 0; i < seatnos.Length; i++)
            {
                if (seatnos[i] != 0)
                {
                    Write("{0}--{1}--{2}\n", pnames[i], seatnos[i], secno[i]);
                }
            }
            WriteLine("PRESS any key to continue");
            ReadKey();
            return 0;
        }

        //public int setsecno(int aseatno)
        //{
        //    _seatno = aseatno;
        //    return _seatno;
        //}



    }//END OF CLASS
}//END OF NAMESPACE
