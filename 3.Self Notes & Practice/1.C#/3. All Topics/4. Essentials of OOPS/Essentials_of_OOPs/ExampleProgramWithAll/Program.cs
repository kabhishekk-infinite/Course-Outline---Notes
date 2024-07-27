using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Question : -- 
Conditions : 
1. Namespace 1 : Personal_Info
   1.a Class 1 : About_Me          [ my_name, my_age, my_DOB, my_address, my_mobile, my_bloodGroup, my_mailId ]
   1.b Class 2 : About_Parents     [ father_name, father_mobnum, mother_name, mother_mobnum, ]

2. Namespace 2 : Bank_Detail_Info
   2.a Class 1 : Bank_Info         [ bank_name, bank_IFSCCode, bank_branch, bank_city ]
   2.b Class 2 : My_Bank_Details   [ accnt_name, accnt_number, accnt_cif ]
   2.c Class 3 : Bank_Transaction  [ balance, wthdraw, deposit ]

3. Namespace 3 : College_Info
   3.a Class 1 : Class_10th        [ 10_name, 10_year, 10_board, 10_subj, 10_grade, 10_city ]
   3.b Class 2 : CLass_12th        [ 12_name, 12_year, 12_board, 12_subj, 12_grade, 12_city ]
   3.c Class 3 : College           [ cg_name, cg_Pyear, cg_stream, cg_branch, cg_grade, cg_city ]

Display : All CLass.
 */


namespace ExampleProgramWithAll
{
    //1. Namespace 1 : Personal_Info
     namespace Personal_Info
    {
        public class About_Me
        {
            //Fields : 
            private string my_name;
            private int    my_age;
            private string my_DOB;
            private string my_address;
            private string my_mobile;
            private string my_bloodGroup;
            private string my_mailId;

            //Constructor  : 
            public About_Me(string my_name,int my_age, string my_DOB, string my_address, string my_mobile, string my_bloodGroup, string my_mailId)
            {
                this.my_name = my_name;
                this.my_age = my_age;
                this.my_DOB = my_DOB;
                this.my_address = my_address;
                this.my_mobile = my_mobile;
                this.my_bloodGroup = my_bloodGroup;
                this.my_mailId = my_mailId;
            }

            //Now Get_Set  :
            public string My_Name
            {
                get { return my_name; }
                set { my_name = value; }
            }
            public int My_Age
            {
                get { return my_age; }
                set { my_age = value; }
            }
            public string My_DOB
            {
                get { return my_DOB; }
                set { my_DOB = value; }
            }
            public string My_Address
            {
                get { return my_address; }
                set { my_address = value; }
            }
            public string My_Mobile
            {
                get { return my_mobile; }
                set { my_mobile = value; }
            }
            public string My_BloodGroup
            {
                get { return my_bloodGroup; }
                set { my_bloodGroup = value; }
            }
            public string My_MailId
            {
                get { return my_mailId; }
                set { my_mailId = value; }
            }


            //Display  :
            public void About_Me_Display()
            {
                Console.WriteLine($" ~ ~ ~ About Me ~ ~ :---  ");
                Console.WriteLine("");
                Console.WriteLine($" Name           : {my_name}.");
                Console.WriteLine($" Age            : {my_age}.");
                Console.WriteLine($" D.O.B          : {my_DOB}.");
                Console.WriteLine($" Address        : {my_address}.");
                Console.WriteLine($" Mobile Number  : {my_mobile}.");
                Console.WriteLine($" Blood Group    : {my_bloodGroup}.");
                Console.WriteLine($" Mail ID        : {my_mailId}.");
                Console.WriteLine("");
            }
             
        }

        public class About_Parents
        {
            //Fields :
            private string father_name;
            private string father_mobnum;
            private string mother_name; 
            private string mother_mobnum;

            //Constructor  :
            public About_Parents(string father_name, string father_mobnum, string mother_name, string mother_mobnum)
            {
                this.father_name   = father_name;
                this.father_mobnum = father_mobnum;
                this.mother_name   = mother_name;
                this.mother_mobnum = mother_mobnum;
            }

            //Now Get_Set  :
            public string Father_Name
            {
                get { return father_name; }
                set { father_name = value; }
            }
            public string Father_mobnum
            {
                get { return father_mobnum; }
                set { father_mobnum = value; }
            }
            public string Mother_Name
            {
                get { return mother_name; }
                set { mother_name = value; }
            }
            public string Mother_Mobnum
            {
                get { return mother_Mobnum; }
                set { mother_Mobnum = value; }
            }

            //Display  :
            public void About_ParentsDisplay()
            {
                Console.WriteLine($" ~ ~ ~ About Parents ~ ~ :---  ");
                Console.WriteLine("");
                Console.WriteLine($" Father_Name    : {father_name}.");
                Console.WriteLine($" Father_mobnum  : {father_mobnum}.");
                Console.WriteLine($" Mother_Name    : {mother_name}.");
                Console.WriteLine($" Mother_Mobnum  : {mother_mobnum}.");
                Console.WriteLine("");
            }

        }
    }

    //2. Namespace 2 : Bank_Detail_Info
    namespace Bank_Detail_Info
    {
        public class Bank_Info
        {
            //Fields :
            private string bank_name;
            private string bank_IFSCCode;
            private string bank_branch;
            private string bank_city;

            //Constructor  :

            //Now Get_Set  :
            //Display  :


        }

        public class My_Bank_Details
        {
            //Fields :
            private string accnt_name;
            private string accnt_number;
            private string accnt_cif;

            //Constructor  :
            //Now Get_Set  :
            //Display  : 


        }

        public class Bank_Transaction
        {
            //Fields :
            private int balance;
            private int wthdraw;
            private int deposit;

            //Constructor  :
            //Now Get_Set  :
            //Display  : 


        }

    }

    //3. Namespace 3 : College_Info
    namespace College_Info
    {
        public class Class_10th
        {
            //Fields : 
            private string name_10; 
            private int year_10;
            private string board_10;
            private string subj_10;
            private double grade_10;
            private string city_10;

            //Constructor  :
            //Now Get_Set  :
            //Display  : 

        }

        public class Class_12th
        {
            //Fields : 
            private string name_12;
            private int year_12;
            private string board_12;
            private string subj_12;
            private double grade_12;
            private string city_12;

            //Constructor  :
            //Now Get_Set  :
            //Display  :


        }

        public class College
        {
            //Fields : 
            private string cg_name; 
            private string cg_Pyear;
            private string cg_stream;
            private string cg_branch;
            private string cg_grade;
            private string cg_city;

            //Constructor  :
            //Now Get_Set  :
            //Display  : 


        }



    }

    class Program
    {
        public static void Main(string[] args)
        {






            Console.ReadKey();
        }
    }
}
