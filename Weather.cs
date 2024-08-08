using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather
{
    class Weather
    {
        /// <summary>
        /// Подключение к API openweathermap.org и получение данных о погоде
        /// </summary>
        /// <returns>Словарь значений</returns>
        public static Dictionary<string, dynamic> GetWeather()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://api.weatherapi.com/v1/current.json?key=4073bc555fae4d0eb62135356241907&q=Izhevsk&lang=ru");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string str = reader.ReadToEnd();
            response.Close();
            dynamic d = JsonConvert.DeserializeObject(str);
            return new Dictionary<string, dynamic>()
            {
                { "time", d.current.last_updated },
                { "temp", d.current.temp_c },
                { "description", d.current.condition.text },
                { "feelslike", d.current.feelslike_c },
                { "icon", d.current.condition.icon },
                { "wind_kph", d.current.wind_kph },
                { "humidity", d.current.humidity },
                { "precip_mm", d.current.precip_mm }
            };
        }

        public static string WindToMPS(double value)
        {
             return string.Format("{0:f1}", value / 3.6) + " м/с";
        }

        public static string WindToMPS(string value)
        {
            return WindToMPS(double.Parse(value));
        }
    }
}
