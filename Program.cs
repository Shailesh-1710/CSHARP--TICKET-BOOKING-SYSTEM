using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace boarding_pass_System
{
    /// <summary>
    /// <STUDENT_NAME>SHAILESH PATEL</STUDENT>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int menuoption, seatcounter = 1, noofper, subchoice1;
            int i;
            bool validator;
            string fname, lname;
            string[] seats = new string[40];//SIZE OF THE PLANE;
            int[] secno = new int[40];//For Storing All Security Numbers TOGETHER;
            int[] seatno = new int[40];//For storing seat numbers together
            Passenger[] p = new Passenger[40];
            int seatsleft;



            if (seatcounter >= 40)
            {
                WriteLine("ALL SEATS HAVE BEEN BOOKED");
            }
            else
            {
                do
                {
                    Clear();
                    WriteLine("----------WELCOME TO BOOKING SYSTEM----------");
                    WriteLine("1 STAFF");
                    WriteLine("2 CUSTOMER");
                    WriteLine("3 EXIT");
                    validator = int.TryParse(ReadLine(), out menuoption);
                    if (validator == false)
                    {
                        WriteLine("ERROR: PLEASE ENTER INTEGER INPUT");
                        WriteLine("press any key to continue");
                        ReadKey();

                    }
                    else if (menuoption == 1 || menuoption == 2 || menuoption == 3)
                    {
                        WriteLine("");
                    }
                    else
                    {
                        WriteLine("ERROR : PLEASE ENTER IN BETWEEN 1 TO 3 ONLY");
                        WriteLine(" press any key to continue");
                        ReadKey();
                    }
                    switch (menuoption)
                    {
                        case 1:
                            {

                                WriteLine("-----STAFF MENU-----");
                                WriteLine("1 CHECK NUMBER OF AVAILABLE SEATS");
                                WriteLine("2 Print all boarding pass");
                                WriteLine("3 Passebger Details");
                                WriteLine("4 GO BACK");
                                validator = int.TryParse(ReadLine(), out subchoice1);
                                if (validator == false)
                                {
                                    WriteLine("ERROR: PLEASE ENTER INTEGER INPUT");
                                    WriteLine("press any key to continue");
                                    ReadKey();
                                }
                                else if (menuoption == 1 || menuoption == 2 || menuoption == 3)
                                {
                                    WriteLine("");
                                }
                                else
                                {
                                    WriteLine("ERROR: PLEASE ENTER 1 TO 3 ONLY");
                                    WriteLine("press any key to continue");
                                    ReadKey();
                                }
                                switch (subchoice1)
                                {
                                    case 1:
                                        {//PRINTING AVAILABLE SEATS

                                            if (seatno[0] == 0)
                                            {
                                                WriteLine("ERROR: PLEASE BOOK THE SEATS FIRST FROM CUTOMER MENU");
                                            }
                                            else
                                            {
                                                p[seatcounter - 1].Vacentseats(seatno);
                                            }
                                            WriteLine("Press any key to continue");
                                            ReadKey();
                                            break;
                                        }
                                    case 2:
                                        {
                                            if (seatno[0] == 0)
                                            {
                                                WriteLine("ERROR: PLEASE BOOK THE SEATS FIRST FROM CUTOMER MENU");
                                            }
                                            else
                                            {
                                                int k;
                                                WriteLine("FOLLOWING ARE THE BOARDING PASSES");
                                                for (k = 0; k < seatno.Length; k++)
                                                {
                                                    if (seatno[k] == 0)
                                                    {

                                                    }
                                                    else
                                                    {//PRINTING BOARDING PASS
                                                        WriteLine("********PASSENGER {0}***********", k + 1);
                                                        //WriteLine("******************************");
                                                        WriteLine("     |HELLO {0}|      ", seats[k]);
                                                        WriteLine("|Security NO: {0}         |", secno[k]);
                                                        WriteLine("|Seat NO    : {0}              |", seatno[k]);
                                                        WriteLine("******************************\n");
                                                        WriteLine("");
                                                    }
                                                }
                                            }
                                            ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (seatno[0] == 0)
                                            {
                                                WriteLine("ERROR: PLEASE BOOK THE SEATS FIRST FROM CUTOMER MENU");
                                            }
                                            else
                                            {
                                                //WriteLine("seatcounter is {0}", seatcounter);
                                                WriteLine("-View Passenger details-");
                                                p[seatcounter - 1].Getpassengerdetails(seats, seatno, secno);
                                            }
                                            WriteLine("PRESS ANY KEY TO COMNTINUE");
                                            ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            WriteLine("4 GO BACK");
                                            break;
                                        }
                                    default:
                                        {
                                            WriteLine("ERROR Please Enter between 1 to 4 only");
                                            WriteLine("press any key to continue");
                                            ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                        case 2:
                            {
                                WriteLine("-----CUSTOMER MENU-----");
                                WriteLine("1 ADD BOOKING");
                                WriteLine("2 GO BACK");
                                validator = int.TryParse(ReadLine(), out subchoice1);
                                if (validator == false)
                                {
                                    WriteLine("ERROR: PLEASE ENTER INTEGER INPUT");
                                    WriteLine("press any key to continue");
                                    ReadKey();

                                }
                                else if (menuoption == 1 || menuoption == 2)
                                {
                                    WriteLine("");
                                }
                                else
                                {
                                    WriteLine("ERROR: PLEASE ENTER 1 OR 2 ONLY");
                                    WriteLine("press any key to continue");
                                    ReadKey();
                                }
                                switch (subchoice1)
                                {
                                    case 1:
                                        {
                                            WriteLine("1 ADD NEW");
                                            //ADD NEW LOGIC
                                            Clear();
                                            WriteLine("---ADD BOOKING---");
                                            seatsleft = 40 - (seatcounter - 1);
                                            WriteLine("---PLEASE NOTE THAT THERE ARE ONLY {0} SEATS AVAILABLE---", seatsleft);
                                            WriteLine("PLEASE ENTER NUMBER OF PASSENGERS");
                                            validator = int.TryParse(ReadLine(), out noofper);
                                            if (validator == false)
                                            {
                                                WriteLine("ERROR: PLEASE ENTER INTEGER INPUT");
                                                WriteLine("press any key to continue");
                                                ReadKey();
                                            }
                                            else if (noofper <= seatsleft)
                                            {
                                                WriteLine("");
                                            }
                                            else
                                            {
                                                WriteLine("SORRY ONLY {0} seats lest", seatsleft);
                                                WriteLine("press any key to continue");
                                                ReadKey();
                                                break;
                                            }
                                            for (i = 1; i <= noofper; i++)
                                            {
                                                WriteLine("Please Enter Fname of Passenger {0}", i);
                                                fname = ReadLine();
                                                WriteLine("Please Enter Lname of Passenger {0}", i);
                                                lname = ReadLine();
                                                p[seatcounter] = new Passenger(fname, lname);
                                                seats[seatcounter - 1] = Convert.ToString(p[seatcounter]._Pfname + " " + p[seatcounter]._Plname);
                                                //SECURITY NUMBER:
                                                secno[seatcounter - 1] = p[seatcounter].getrandomno();//GANERATING RANDOM NUMBER FROM PASSENGER CLASS
                                                Clear();
                                                WriteLine("Welcome {0}", seats[seatcounter - 1]);
                                                WriteLine("YOUR SECURITY NUMBER IS : {0}", secno[seatcounter - 1]);
                                                //SEAT NUMBER:
                                                seatno[seatcounter - 1] = seatcounter;
                                                p[seatcounter].Seatno = seatno[seatcounter - 1];
                                                WriteLine("Your entry is recorder at {0}", DateTime.Now);
                                                WriteLine("Your Assigned seat is   : {0}", seatno[seatcounter - 1]);
                                                seatcounter++;
                                                WriteLine("PRESS ANY KEY TO CONTINUE");
                                                ReadKey();
                                            }
                                            break;
                                        }
                                    case 2:
                                        {

                                            break;
                                        }

                                    default:
                                        {
                                            WriteLine("ERROR Please Enter between 1 OR 2 only");
                                            WriteLine("press any key to continue");
                                            ReadKey();
                                            break;
                                        }
                                }

                                break;
                            }
                        case 3:
                            {
                                break;
                            }

                        default:
                            {

                                break;
                            }
                    }

                } while (menuoption != 3 || seatcounter <= 40);//END OF MAIN (WELCOME) DO WHILE LOOP;
            }

            ReadKey();

        }// END OF MAIN
    }//END OF CLASS
}//END OF NAMESPACE
