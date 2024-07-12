using api.truyenonline.Models;
using API_WebService;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Helpers;
using System.Web.Http;
using WebService;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Newtonsoft.Json.Linq;

namespace api.truyenonline.Controllers
{
    public class AppController : ApiController
    {
        [Route("api/App/MenuGet")]
        [HttpPost]
        public HttpResponseMessage Menu_get()
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Menu_Get");

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

        [Route("api/App/SliderGet")]
        [HttpPost]
        public HttpResponseMessage Slider_get()
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Slider_Get");

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "Slider";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }

        [Route("api/App/TruyenHotGet")]
        [HttpPost]
        public HttpResponseMessage Truyen_Hot_get()
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Truyen_Hot_Get");

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "TruyenHot";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }
        [Route("api/App/TruyenNoiBat")]
        [HttpPost]
        public HttpResponseMessage TruyenNoiBat()
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Featured_Get");

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "Featured";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }

        [Route("api/App/TruyenMoiCapNhatGet")]
        [HttpPost]
        public HttpResponseMessage Truyen_MoiCapNhat_Get()
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Truyen_MoiCapNhat_Get");

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "TruyenMoiCapNhat";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }

        [Route("api/App/TruyenXemNhieuGet")]
        [HttpPost]
        public HttpResponseMessage Truyen_XemNhieu_Get()
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Truyen_XemNhieu_Get");

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "TruyenXemNhieuGet";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;

        }

        [Route("api/App/ItemGet")]
        [HttpPost]
        public HttpResponseMessage ItemGet([FromBody] Item item)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Item_Get", new
            {
                ID = item.ID
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "Item";
            ds.Tables[1].TableName = "Similar";
            ds.Tables[2].TableName = "Random";

            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;
        }

        [Route("api/App/ChapterGet")]
        [HttpPost]
        public HttpResponseMessage ChapterGet([FromBody] Item item)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "ChapterGet", new
            {
                IDTruyen = item.ID,
                IDChapter = item.ChapterID
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "Chapter";


            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;
        }

        [Route("api/App/CategoryGetByAlias")]
        [HttpPost]
        public HttpResponseMessage CategoryGetByAlias([FromBody] Category item)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Category_GetByAliasMenu", new
            {
                Alias = item.Alias,
                PageNumber = item.Pages
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "TotalPages";
            ds.Tables[1].TableName = "CatPages";
            ds.Tables[2].TableName = "ListItemInCat";

            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;
        }

        [Route("api/App/ChapterList")]
        [HttpPost]
        public HttpResponseMessage CategoryGetByAlias([FromBody] Item item)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "ChapterList", new
            {
                IDTruyen = item.ID,
                Page = item.Page
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "Chapters";

            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;
        }

        [Route("api/App/Search")]
        [HttpPost]
        public HttpResponseMessage Search([FromBody] TimKiem item)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "Item_Search", new
            {
                Value=item.Value,
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "Item";

            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;
        }


        [Route("api/App/User_create")]
        [HttpPost]
        public HttpResponseMessage CreateUser([FromBody] User user)
        {
            var query = DataQuery.Create("nhhhslsb_TruyenOnline", "User_Create", new
            {
                Email = user.Email,
                Pass = user.Pass,
                FullName = user.FullName
            });

            string JSONString = string.Empty;

            var ds = Database.ProcessRequest(query);

            var res = Request.CreateResponse(HttpStatusCode.OK);


            ds.Tables[0].TableName = "CodeActive";
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("Trung hiếu", "daohuu@daidaovien.com"));
            email.To.Add(new MailboxAddress("test", "phuonghoangtrang2210@gmail.com"));

            email.Subject = "Testing out email sending";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = "xin chào đạo hữu"
            };
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("daidaovien.com", 465, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate("daohuu@daidaovien.com", "MyHan0312!@");

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        

        //MailMessage mail = new MailMessage();
        //    SmtpClient SmtpServer = new SmtpClient("daidaovien.com");
        //    mail.From = new MailAddress("daohuu@daidaovien.com");
        //    mail.To.Add("phuonghoangtrang2210@gmail.com");
        //    mail.Subject = "Test Email";
            
        //    mail.Body = "Xin chào đạo hữu";
        //    SmtpServer.Port = 465;
        //    SmtpServer.Credentials = new System.Net.NetworkCredential("daohuu@daidaovien.com", "MyHan0312!@");
        //    SmtpServer.EnableSsl = true;
        //    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    SmtpServer.Send(mail);

            JSONString = JsonConvert.SerializeObject(ds);

            //Set the content of the response to be JSON Format
            res.Content = new StringContent(JSONString, System.Text.Encoding.UTF8, "application/json");

            //Return the Response
            return res;
        }
    }
}
