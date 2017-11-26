using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //The Hospital Details
    class hospital
    {
        string name;
        public hospital(string n)
        {
            this.name = n;
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
