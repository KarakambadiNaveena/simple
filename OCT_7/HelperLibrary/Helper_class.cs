using BusinessLogicLayerLibrary;
using DataAccessLayerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class Helper_class
    {
        DAL_class dal = null;
        public Helper_class()
        {
            dal = new DAL_class();
        }


        public bool AddMember(BLL_class member)
        {
            return dal.InsertMember(member);



        }
        public bool EditMember(BLL_class member)
        {
            return dal.UpdateMember(member);



        }
        public List<BLL_class> ShowMemberList()
        {
            return dal.MemberList();
        }
    }
}
