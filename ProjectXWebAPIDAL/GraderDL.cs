using ProjectXWebAPIDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXWebAPIDAL
{
    public class GraderDL
    {
        GraderDTO dtoGraderObj;
        public GraderDL()
        {
            dtoGraderObj = new GraderDTO();
        }
        public List<GraderDTO> GetGraderDetails()
        {
            try
            {
                List<GraderDTO> graderList = new List<GraderDTO>();
                WebConStr graderCntx = new WebConStr();
                var dbGraderList = graderCntx.Graders.ToList();
                foreach (var gdr in dbGraderList)
                {
                    graderList.Add(
                        new GraderDTO()
                        {
                            Marks_Obtained = gdr.Marks_Obtained,
                            Feedback = gdr.Feedback,
                            BatchID = gdr.BatchID,
                            CourseID = gdr.CourseID,
                            ParticipantID = gdr.ParticipantID

                        });
                }
                return graderList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
