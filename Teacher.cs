using System;
using System.Collections.Generic;
using System.Text;

namespace StoringSchoolData
{
    abstract class Teacher
    {
        protected String Name;
        protected String ClassAndSection;

        public abstract String GetName();
        public abstract String GetClassAndSection();

    }
}