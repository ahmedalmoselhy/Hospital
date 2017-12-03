using System;
using System.IO;

namespace Hospital
{
    
    class Program
    {

        
        //Our Objects
        public doctor doc = new doctor();
        public department dep = new department();
        public patient p = new patient();


        static void Main(string[] args)
        {
            if (!Directory.Exists(@"Patients"))
            {
                Directory.CreateDirectory(@"Patients");
            }
            if (!Directory.Exists(@"Doctors"))
            {
                Directory.CreateDirectory(@"Doctors");
            }
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
        selection4:
            Console.Write("Are You A \n1) New Doctor OR 2) Registered Doctor\n*** : ");

            string c6 = Console.ReadLine();
            if(c6 == "1")
            {

            }
            else if(c6 == "2")
            {

            }
            else
            {
                Console.WriteLine("Wrong Choice, Please Try Again!\n*******************");
                goto selection4;
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
                patient.read_patient();
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

        public static void doctor_search()
        {
            
        }
    } //Doctor Class End
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //Class for Patients
    class patient : hospital
    {
        public patient()
        {

        }
        public static void read_patient() // To look for a patient
        {
        patientname:
            Console.Write("Kindly Enter Your Full Name\n*** : ");
            string patient_name = Console.ReadLine();

            string path = "Patients/" + patient_name + ".txt";
            // hna ht3ml search 3la file mwgood b 2sm el patient ely d5l dh, lw mwgood tmam, lw msh mwgood try again
            if (File.Exists(path)) //hna el search 3la elfile fi directory Patients
            {
                string read_file = File.ReadAllText(path);
                Console.WriteLine(read_file);
            }
            else
            {
                Console.WriteLine("*******************");
                Console.WriteLine("There's No Patient With This Name In Our Database! Please Try again!\n*******************");
                goto patientname;
            }
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
            ///////////////
            //now we have all data about the patient!

            string path = @"Patients/" + patient_name + ".txt";
            File.Create(path);


            //Add The Data To The File (Name, Age, Blood Type, Gender, Department)
            
        }
    } //Patient Class End
}