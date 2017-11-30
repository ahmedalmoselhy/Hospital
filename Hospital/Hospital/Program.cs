using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Screen
            Console.WriteLine("**************************************");
            Console.WriteLine("********* {0} Hospital **********", hospital.h);
            Console.WriteLine("Welcome To The Hospital\n*******************\nWe Hope You Get Well Soon\n*******************");
            Console.WriteLine("Please Tell Us Are You\n1) A Doctor\n2) A Patient");
            Console.WriteLine("*******************");
            
        selection1:
            Console.Write("Enter Your Selection : ");
            string c1 = Console.ReadLine();
            Console.WriteLine("*******************");
            Console.WriteLine("Processing...");

            //Starting the first thing which is going through what we would do as a doctor or a patient
            if(c1 == "1")
            {
                doctor();
            }
            else if(c1 == "2")
            {

            }
            else
            {
                Console.WriteLine("Wrong Choice, Please Try Again!");
                Console.WriteLine("*******************");
                goto selection1;

            }
        } //Main Function End -in case of being uncertain

        // A Method For Doctors
        public static void doctor()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Welcome Doctor, Please Enter Your ID Number Below");
            Console.WriteLine("*******************");
        selection2:
            Console.Write("ID Number : ");
            string id = Console.ReadLine();
            Boolean ids = false; //Add the check id function
            if(ids == false)
            {
                Console.WriteLine("*******************\nWrong ID Number, Try Again!\n*******************");
                goto selection2;
            }


        }
    }

    //The Hospital Details
    class hospital
    {
        public string hname;
        public static string h = "HOPE";
        public hospital(string n)
        {
            this.hname = n;
        }
    }

    //departments basics
    class department
    {
        string name;
        int d_num;
        int r_num;
        int p_num;
        public department(string n, int d, int r, int p)
        {
            this.name = n;
            this.d_num = d;
            this.r_num = r;
            this.p_num = p;
        }
    }

    //informations about doctors
    class doctor
    {
        string name;
        int age;
        string spec;
        public doctor(string n, string s, int a)
        {
            this.name = n;
            this.spec = s;
            this.age = a;
        }
    }

    //rooms
    class room
    {
        Boolean full;
        string p_name;

        public room(string p)
        {
            this.p_name = p;
        }
    }
}
