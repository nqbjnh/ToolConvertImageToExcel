using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ToolConvertImageToExcel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("https://gist.githubusercontent.com/nqbjnh/5fe0a140393099eaf10302720ba79e9d/raw/ToolConvertImageToExcel").ConfigureAwait(false).GetAwaiter().GetResult();
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    var config = JsonConvert.DeserializeObject<JObject>(responseContent);
                    var enable = config.GetValue("Enable").Value<bool>();
                    if (!enable)
                    {
                        MessageBox.Show(config.GetValue("Message").Value<string>(), "Message");
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                
            }
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
