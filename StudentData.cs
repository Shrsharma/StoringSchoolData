using System;
using System.Collections.Generic;
using System.Text;

namespace StoringSchoolData
{
    class StudentData : Student
    {
        public override string GetClassAndSection()
        {
            return ClassAndSection;
        }

        public override string GetName()
        {
            return Name;
        }

        public override void SetValues(string name, string ClassAndSession)
        {
            this.Name = name;
            this.ClassAndSection = ClassAndSession;
        }
    }
}
