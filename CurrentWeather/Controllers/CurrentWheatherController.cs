using Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Mvc;

namespace CurrentWeather.Controllers
{
    public class CurrentWheatherController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(string id)
        {
            try
            {
                //WebConfig Settings
                string UriCurrentWheather = System.Configuration.ConfigurationManager.AppSettings["UriCurrentWheather"];
                string AppID = System.Configuration.ConfigurationManager.AppSettings["AppID"];
                string _uri = UriCurrentWheather + string.Format("?id={0}&Appid={1}", id, AppID);

                //Get data From API
                HttpClient Client = new HttpClient();
                HttpResponseMessage resp = Client.GetAsync(_uri).Result;
                resp.EnsureSuccessStatusCode();
                var result = resp.Content.ReadAsStringAsync().Result;

                //Model Entity
                CurrentWheather currentwheather = new CurrentWheather();
                currentwheather = JsonConvert.DeserializeObject<CurrentWheather>(result);

                //Return Details Views
                return View(currentwheather);
            }
            catch (System.Exception ex)
            {
                //Se puede crear manejos de errores en sesion y volver a la pagina anterior para mostrarlo.
                throw new System.Exception(ex.InnerException.Message, ex);
            }
        }
    }
}