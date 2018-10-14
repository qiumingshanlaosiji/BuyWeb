using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuyWeb.Consumer
{
    public class ApiClient
    {

        #region Private Fields

        private static HttpClient _client;

        #endregion

        #region contructors

        static ApiClient()
        {
            _client = new HttpClient();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// send GET request
        /// </summary>
        /// <typeparam name="T">response date type</typeparam>
        /// <param name="path">request url</param>
        /// <returns>response data</returns>
        public static T Get<T>(string path)
        {
            // parameter check
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("parameter [path] is null");


            // send request
            T t = default(T);

            var response = _client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                t = JsonConvert.DeserializeObject<T>(json);
            }


            return t;
        }

        /// <summary>
        /// send PUT request
        /// </summary>
        /// <typeparam name="T">response data type</typeparam>
        /// <param name="path">request url</param>
        /// <param name="data">the data put to server(optional)</param>
        /// <returns>api response data</returns>
        public static T Put<T>(string path, string data)
        {
            // parameter check
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("paramter [path] is null");

          

            // send request
            T t = default(T);

            StringContent httpContent = null;
            if (!string.IsNullOrEmpty(data))
                httpContent = new StringContent(data, Encoding.UTF8, "application/json");
            var response = _client.PutAsync(path, httpContent).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                t = JsonConvert.DeserializeObject<T>(json);
            }


            return t;
        }

        /// <summary>
        /// send POST request
        /// </summary>
        /// <typeparam name="T">response data type</typeparam>
        /// <param name="path">request url</param>
        /// <param name="data">the data to post to server</param>
        /// <returns>response data</returns>
        public static T Post<T>(string path, string data)
        {
            // parameter check
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("parameter [path] is null");

         
            // send request
            T t = default(T);

            // var httpContet = new StringContent(data, Encoding.UTF8, "application/json");
            StringContent httpContent = null;
            if (!string.IsNullOrEmpty(data))
                httpContent = new StringContent(data, Encoding.UTF8, "application/json");
            var response = _client.PostAsync(path, httpContent).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                t = JsonConvert.DeserializeObject<T>(json);
            }


            return t;
        }

        #endregion
    }

}
