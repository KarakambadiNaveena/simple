using disconnected_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using disconnected_BLL;

namespace disconnected_helper
{
    public class helper_class
    {
        DAL_class dal = new DAL_class();

        public bool AddNewstudent(BLL_class student)
        {
            return dal.Insertstudent(student);
        }
        public bool EditstudentData(int studid, BLL_class student)
        {
            return dal.Updatestudent(studid, student);
        }
        public bool RemoveStudentData(int studid)
        {
            return dal.DeleteStudent(studid);
        }
        public List<BLL_class> studentList()
        {
            return dal.ShowAllstudents();
        }
        public BLL_class Locatestudent(int studid)
        {
            return dal.Findstudent(studid);
        }
    }
}
