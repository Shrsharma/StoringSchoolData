using System;
using System.Collections.Generic;
using System.Text;

namespace StoringSchoolData
{
    class MainInterface
    {
        public static void Do()
        {
            Console.WriteLine("Students In Class");
            StudentData s1 = new StudentData();
            s1.SetValues("Light", "IX A");
            Console.WriteLine("\nName: " + s1.GetName() + ", Class And Section: " + s1.GetClassAndSection());
            StudentData s2 = new StudentData();
            s2.SetValues("Misa", "IX A");
            Console.WriteLine("\nName: " + s2.GetName() + ", Class And Section: " + s2.GetClassAndSection());
            StudentData s3 = new StudentData();
            s3.SetValues("Ryuk", "IX A");
            Console.WriteLine("\nName: " + s3.GetName() + ", Class And Session: " + s3.GetClassAndSection());

            Console.WriteLine("\nSubjects Taught By Teacher");
            TeacherData t1 = new TeacherData();
            t1.SetValues("Ms. Rugzaki", "X A", "S001");
            Console.WriteLine("\nName: " + t1.GetName() + ", Class And Section: " + t1.GetClassAndSection() + ", Subject code: " + t1.GetSubjectCode());
            TeacherData t2 = new TeacherData();
            t2.SetValues("Ms. Yagami", "X A", "S002");
            Console.WriteLine("\nName: " + t2.GetName() + ", Class And Session: " + t2.GetClassAndSection() + ", Subject code: " + t2.GetSubjectCode());
            TeacherData t3 = new TeacherData();
            t3.SetValues("Ms. Takada", "X A", "S003");
            Console.WriteLine("\nName: " + t3.GetName() + ", Class And Session: " + t3.GetClassAndSection() + ", Subject code: " + t3.GetSubjectCode());
        }
    }
}
