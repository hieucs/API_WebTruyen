using API_WebService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebService;
using api.truyenonline.Models;

namespace api.truyenonline.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/News/MenuGet")]
        [HttpPost]
        public HttpResponseMessage Menu_get([FromBody] Param param)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Site_Menu_Get", new
            {
                SiteID = param.SiteID
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "MenuList";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }
        [Route("api/News/SliderGet")]
        [HttpPost]
        public HttpResponseMessage Slider_Get([FromBody] Param param)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Slider_Get", new
            {
                SiteID = param.SiteID
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "Sliders";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }
        [Route("api/News/TinMoi")]
        [HttpPost]
        public HttpResponseMessage TinMoi([FromBody] Param param)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "TinMoi", new
            {
                SiteID = param.SiteID,
                CatID = param.CatID,
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "TinMoi";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }

    }
}
