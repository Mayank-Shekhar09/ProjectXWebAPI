using Newtonsoft.Json;
using ProjectXWebAPIBL;
using ProjectXWebAPIDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectXWebAPIControllerAdding.Controllers
{
    public class FacultyController : ApiController
    {
        FacultyBL objFacultyBL;
        [HttpGet]
        [ActionName("GetAllFaculty")]
        public HttpResponseMessage GetFaculties()
        {
            try
            {
                objFacultyBL = new FacultyBL();
                List<FacultyDTO> lstFaculty = objFacultyBL.GetFaculties();
                if (lstFaculty != null)
                {
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(lstFaculty));
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    return response;
                }
                else
                {
                    var response = new HttpResponseMessage(HttpStatusCode.NoContent);
                    response.Content = new StringContent("No Table Found");
                    return response;
                }

            }
            catch (Exception ex)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent("Server is down :'(");
                return response;
            }
        }
    }
}
