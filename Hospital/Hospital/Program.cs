using System;
using System.IO;
using System.Text;

namespace Hospital
{
    
    class Program
    {
        
        
        //Our Objects
        public doctor doc = new doctor();
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

            goto selection1;

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
                doctor.doctor_add();
            }
            else if(c6 == "2")
            {
                doctor.doctor_search();
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
    //informations about doctors
    class doctor : hospital
    {
        public doctor()
        {

        }

        public static void doctor_search()
        {
            Console.WriteLine("*******************");
            doctorid:
            Console.Write("Welcome Doctor, Please Enter Your Name \n*** : ");
            string d_name = Console.ReadLine();
            string path = @"Doctors/" + d_name + ".txt";

            if (File.Exists(path))
            {
                Console.WriteLine("*******************");
                
                Console.WriteLine("Welcome Dr. {0}, What Do You Want To Do?", d_name);

                Console.Write("1) View My Data\n2) Update Patient Case\n3) Release A Patient From The Hospital\n*** : ");
                string dc = Console.ReadLine();
                if(dc == "1")
                {
                    string read_file = File.ReadAllText(path);
                    Console.WriteLine("*******************");
                    Console.WriteLine("*******************");
                    Console.WriteLine(read_file);
                    Console.WriteLine("*******************");
                    Console.WriteLine("*******************");
                }
                else if(dc == "2")
                {
                    p:
                    Console.Write("Enter The Patient's Name : ");
                    string p_name_d = Console.ReadLine();
                    string p_path = @"Patients/" + p_name_d + ".txt";
                    if (File.Exists(p_path))
                    {
                        Console.WriteLine("What Do You Want To Add?");
                        string text = Console.ReadLine();
                        text = text + "\n ADDED BY DR : " + d_name + "\n******\n";
                        WriteFile(p_path, text);
                    }
                    else
                    {
                        Console.WriteLine("TRY AGAIN");
                        goto p;
                    }

                }
                else if(dc == "3")
                {
                    px:
                    Console.Write("Enter The Patient's Name : ");
                    string p_name_d = Console.ReadLine();
                    string p_path = @"Patients/" + p_name_d + ".txt";
                    if (File.Exists(p_path))
                    {
                        File.Delete(p_path);
                        Console.WriteLine("Patient {0} Released, File Deleted", p_name_d);
                        
                    }
                    else
                    {
                        Console.WriteLine("TRY AGAIN");
                        goto px;
                    }
                }
            }
            else
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Wrong Name, Please Try Again!");
                goto doctorid;
            }
 
        }
        public static void doctor_add()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.Write("Please Enter Your Name : ");
            string d_name = Console.ReadLine();
            Console.Write("Please Enter Your Age : ");
            string d_age = Console.ReadLine();
            idd:
            Console.Write("Enter Your ID (4 Digits) : ");
            string id = Console.ReadLine();
            if(id.Length != 4)
            {
                Console.WriteLine("Wrong ID, Try Again!");
                goto idd;
            }
            Console.Write("Enter Your Salary : ");
            string sal = Console.ReadLine();
            Console.Write("Enter Your Specialization\n1) Bones\n2) Burns\n3) Kids\n*** : ");
            string c = Console.ReadLine();
            string spec = "";
            if(c == "1")
            {
                spec = "Bones";
            }
            else if(c == "2")
            {
                spec = "Burns";
            }
            else if(c == "3")
            {
                spec = "Kids";
            }
            ///////
            string path = @"Doctors/" + d_name + ".txt";
            

            string name = "Doctor Name : " + d_name;
            string d_id = "Doctor ID : " + id;
            string age = "Age : " + d_age;
            string special = "Specialization : " + spec;
            string salary = "Salary : " + sal;

            ///////
            WriteFile(path, name);
            WriteFile(path, d_id);
            WriteFile(path, age);
            WriteFile(path, special);
            WriteFile(path, salary);
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
        }

        static void WriteFile(string path, string data)
        {
            StreamWriter writedata = new StreamWriter(path, true);
            writedata.WriteLine(data);
            writedata.Close();


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

            string path = @"Patients/" + patient_name + ".txt";
            
            if (File.Exists(path)) 
            {
                string read_file = File.ReadAllText(path);
                Console.WriteLine("*******************");
                Console.WriteLine("*******************");
                Console.WriteLine(read_file);
                Console.WriteLine("*******************");
                Console.WriteLine("*******************");
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
            string age = Console.ReadLine();
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
            if(int.Parse(age) > 14)
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
            


            patient_name = "Patient Name : " + patient_name;
            age = "Age : " + age;
            blood_type = "Blood Type : " + blood_type;
            gender = "Gender : " + gender;
            depart = "Department : " + depart;

            WriteFile(path, patient_name);
            WriteFile(path, age);
            WriteFile(path, blood_type);
            WriteFile(path, gender);
            WriteFile(path, depart);
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            //Add The Data To The File (Name, Age, Blood Type, Gender, Department)

        }

        static void WriteFile(string path, string data)
        {
            StreamWriter writedata = new StreamWriter(path, true);
            writedata.WriteLine(data);
            writedata.Close();
            

        }
    } //Patient Class End

    
    //AAA AMM
}