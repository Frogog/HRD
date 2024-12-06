using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD
{
    public class EmployeeTeam
    {
        public string ID_Emp;
        public string LName;
        public string Name;
        public string Pat;
        public string PosName;
        public string QualName;
        public EmployeeTeam(
            string id_emp,
            string lName,
            string name,
            string pat,
            string posName,
            string qualName
            )
        {
            ID_Emp = id_emp;
            LName = lName;
            Name = name;
            Pat = pat;
            PosName = posName;
            QualName = qualName;
        }
    }
}
