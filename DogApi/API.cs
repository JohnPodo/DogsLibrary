using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dog.Models;
using Newtonsoft.Json;
using RestSharp;

namespace DogApi
{
    public class API
    {
        public static List<Breed> GetData()
        {
            var client = new RestClient("https://api.thedogapi.com/v1/breeds");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-api-key", "bbinjodvmks");
            IRestResponse response = client.Execute(request);
            List<Breed> breeds = JsonConvert.DeserializeObject<List<Breed>>(response.Content);
            return breeds;
        }
    }
}
