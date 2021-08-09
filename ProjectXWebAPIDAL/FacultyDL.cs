using ProjectXWebAPIDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXWebAPIDAL
{
    public class FacultyDL
    {
        FacultyDTO dtFacObj;
        public FacultyDL()
        {
            dtFacObj = new FacultyDTO();
        }
        public List<FacultyDTO> GetFaculties()
        {
            try
            {
                List<FacultyDTO> facList = new List<FacultyDTO>();
                WebConStr facCntx = new WebConStr();
                var dbfacList = facCntx.Faculties.ToList();
                foreach (var item in dbfacList)
                {
                    facList.Add(
                        new FacultyDTO()
                        {
                            FacultyName = item.FacultyName,
                            EmailID = item.EmailID,
                            PSNo = item.PSNo
                        });
                }
                return facList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
