/*
CREATE DATABASE Student;

USE Student;

CREATE TABLE Students
(
	StudentID varchar(6) NOT NULL,
    StudentName varchar(50) NULL,
	StdName varchar(4) NULL,
	Location varchar(50) NULL,
);

ALTER TABLE Students
ADD PRIMARY KEY (StudentID);

 Works on Console App (.NET Framework) & not on Console App
*View > Server Explorer > Right Click 'Data Connections' > Add Connection... > Select Data Source 'Microsoft SQL Server' > Data Provider '.NET Framework Data Peovider for OLE DB' > Server Name 'DESKTOP-<random>(Copy From SQL Server Management Studio)' > Database Name > Select or Enter a Database > <Select name of DB to work on>(here Student)
*Project > Add New Item > Visual C# Items > Data > LINQ to SQL Classes > Rename 'DataClassStudents.dbml'
*Solution Explorer > Project Name (HERE LINQDemo) > DataClassStudents.dbml and Expand(Server Explorer > Data Connections > desktop-<random>.Student.dbo>Tables> <table to work on>Students) and drag <table to work on>Students to DataClassesStudents.dbml
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string conn = "Data Source = DESKTOP-TMI53VD; Initial Catalog=Student; Integrated Security=true";
            string conn = "Data Source = DESKTOP-TMI53VD; Initial Catalog=Student; Integrated Security=true; User ID=sa; Password=pass@123";
            DataClassesStudentsDataContext stud = new DataClassesStudentsDataContext(conn);
            Student s1 = new Student();
            s1.StudentID = "1003";
            s1.StudentName = "ZXCH";
            s1.StdName = "VII";
            s1.Location = "Nerul, Navi Mumbai";
            stud.Students.InsertOnSubmit(s1);
            stud.SubmitChanges();
            Console.WriteLine("Record Inserted");
            Console.ReadKey();
        }
    }
}
