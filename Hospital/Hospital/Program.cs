using System;

namespace Hospital
{
    
    class Program
    {
        
        //Our Objects
        public doctor doc = new doctor();
        public department dep = new department();
        public room rom = new room();
        public patient p = new patient();


        static void Main(string[] args)
        {
            //Welcome Screen
            Console.WriteLine("**************************************");
            Console.WriteLine("********* {0} Hospital **********", hospital.hname);
            Console.WriteLine("Welcome To The Hospital\n*******************\nWe Hope You Get Well Soon\n*******************");
            Console.WriteLine("Please Tell Us Are You A Doctor OR A Patient");
            Console.WriteLine("*******************");

            selection1:
            Console.Write("Enter Your Selection\n1) Doctor\n2) Patient\n*** : ");
            string c1 = Console.ReadLine();
            Console.WriteLine("*******************");
            Console.WriteLine("Processing...");

            //Starting the first thing which is going through what we would do as a doctor or a patient
            if (c1 == "1")
            {
                doctor_m();
            }
            else if (c1 == "2")
            {
                patient_m();
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
        public static void doctor_m()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Welcome Doctor, Please Enter Your ID Number Below");
            Console.WriteLine("*******************");
            selection2:
            Console.Write("ID Number : ");
            string id = Console.ReadLine();
            Boolean ids = false; //Add the check id function
            if (ids == false)
            {
                Console.WriteLine("*******************\nWrong ID Number, Try Again!\n*******************");
                goto selection2;
            }


        } //Doctor Method End
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        // A Method For Patients
        public static void patient_m()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Welcome, We Hope You Get Well Soon\nPlease Tell Us Are You New Or You're Staying Before");
            selecton3:
            Console.Write("1) New\n2) Staying Before\n*** : ");
            string c3 = Console.ReadLine();
            
            if (c3 == "1")
            {
                Console.WriteLine("*******************");
                patient.sign_patient();
            }
            else if (c3 == "2")
            {
                Console.WriteLine("*******************");
                Console.Write("Kindly Enter Your Full Name\n*** : ");
                string patient_name = Console.ReadLine();
                patient.read_patient(patient_name);
            }
            else
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Wrong Choice, Try Again!\n*******************");
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
        
        public static int doc_num = 9;
        public static int mp_num = 20;
        public static int p_num;
        public static string dep1 = "Bones";
        public static string dep2 = "Burns";
        public static string dep3 = "Kids";
        
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

        public room()
        {

        }
    } //Rooms Class End
    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //Class for Patients
    class patient : hospital
    {
        public patient()
        {

        }
        public static void read_patient(string p_name) // To look for a patient
        {

        }
        public static void sign_patient() // To register a new patient
        {
            Console.WriteLine("*******************");
            Console.Write("Kindly Enter Your Full Name\n*** : ");
            string patient_name = Console.ReadLine();
            /////////////////////////
            Console.Write("Please Enter Your Blood Type\n*** : ");
            string blood_type = Console.ReadLine();
            /////////////////////////
            Console.Write("Please Tell Us Your Age\n*** : ");
            int age = int.Parse(Console.ReadLine());
            //////////////////////////
            Console.Write("You're *** 1) Male *** 2) Female\n*** : ");
            string c4 = Console.ReadLine();
            //////////////////////////
            string gender;
            string depart;
            ///////////////////////////
            if (c4 == "1")
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            ///////////////////////////
            if(age > 14)
            {
                Console.Write("What's Your Case?\n1) Broken Bones ***  2) Burn\n*** : ");
                string c5 = Console.ReadLine();
                ///////////////
                if(c5 == "1")
                {
                    depart = dep1;
                }
                else
                {
                    depart = dep2;
                }
            }
            else
            {
                depart = dep3;
            }
        }
    } //Patient Class End
}