using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Aplicativo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {

            string nombre = txt1.Text;
            string prioridad = txt2.Text;

            string url = "http://localhost:51272/api/Tarea";

            api ap = new api();


            TareaRequest req = new TareaRequest();
            job j = new job();
            req.nombre = j.nombre;
            req.prioridad = j.prioridad;
          

            string res = ap.Send<TareaRequest>(url, req, "POST");


        }

        public class job
        {

            public string nombre { get; set; }
            
            public string prioridad { get; set; }



        }

        public class api
        {

            public string Send<T>(string url, T objectRequest, string method = "POST")
            {
                string result = "";

                try
                {


                    //serializamos el objeto
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                    //peticion
                    WebRequest request = WebRequest.Create(url);
                    //headers
                    request.Method = method;
                    request.PreAuthenticate = true;
                    request.ContentType = "application/json;charset=utf-8'";


                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(json);
                        streamWriter.Flush();
                    }

                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        result = streamReader.ReadToEnd();
                    }

                }
                catch (Exception e)
                {

                    result = e.Message;

                }

                return result;
            }
        }





    }




}
