using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectXWebAPIDAL;
using ProjectXWebAPIDTO;

namespace ProjectXWebAPIBL
{
    public class GraderBL
    {
        GraderDL dalGraderObj;
        public GraderBL()
        {
            dalGraderObj = new GraderDL();
        }
        public List<GraderDTO> GetGraderDetails()
        {
            try
            {
                var graderList = dalGraderObj.GetGraderDetails();
                return graderList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
