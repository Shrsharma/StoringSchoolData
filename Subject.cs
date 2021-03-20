using System;
using System.Collections.Generic;
using System.Text;

namespace StoringSchoolData
{
    abstract class Subject : Teacher
    {
        public string SubjectCode;

        public abstract string GetSubjectCode();
        public abstract void SetValues(string name, string ClassAndSection, string subject);
    }
}