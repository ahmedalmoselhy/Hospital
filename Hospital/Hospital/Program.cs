using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Screen
            Console.WriteLine("**************************************");
            Console.WriteLine("********* {0} Hospital **********", hospital.hname);
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
                patient();
            }
            else
            {
                Console.WriteLine("Wrong Choice, Please Try Again!");
                Console.WriteLine("*******************");
                goto selection1;

            }
        } //Main Function End
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>
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


        } //Doctor Method End
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        // A Method For Patients
        public static void patient()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Welcome, We Hope You Get Well Soon\nPlease Tell Us Are You New Or You're Staying Before");
        selecton3:
            Console.Write("1) New\n2) Staying Before\n*** : ");
            string c3 = Console.ReadLine();
            Boolean cs = false;
            if(c3 == "1")
            {

            }
            else if(c3 == "2")
            {

            }
            else
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Wrong Choice, Try Again!\n*******************");
                goto selecton3;
            }

            if(cs == false)
            {
                Console.WriteLine("*******************\nSelect Again!\n*******************");
                goto selecton3;
            }
        } //Patient Method End
    }
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //The Hospital Details
    abstract class hospital
    {
        
        public static string hname = "HOPE";
        public int r_num = 20;
        public int d_num = 3;
        public int doc_num = 9;
        public int mp_num = 20;
        public int p_num;
        public hospital()
        {
            
        }
    } //Hospital Class End
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //departments basics
    class department : hospital
    {
        public department()
        {
            string[] dep = new string[d_num];
            dep[0] = "Bones";
            dep[1] = "Burns";
            dep[2] = "Kids";

        }
    } //Department Class End
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //informations about doctors
    class doctor : hospital
    {
        
        public doctor()
        {
            
        }
    } //Doctor Class End
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //rooms
    class room : hospital
    {
        Boolean full; // in case room is full no patient allowed
        

        public room(string p)
        {
            
        }
    } //Rooms Class End
    /////////////////////////////////////////////////////////////////////////////////////////////
}
