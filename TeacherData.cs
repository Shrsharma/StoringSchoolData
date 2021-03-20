using System;
using System.Collections.Generic;
using System.Text;

namespace StoringSchoolData
{
    class TeacherData : Subject
    {


        public override string GetClassAndSection()
        {
            return ClassAndSection;
        }

        public override string GetName()
        {
            return Name;
        }
        public override string GetSubjectCode()
        {
            return SubjectCode;
        }

        public override void SetValues(string name, string ClassAndSession, string subject)
        {
            this.Name = name;
            this.ClassAndSection = ClassAndSession;
            this.SubjectCode = subject;
        }
    }
}