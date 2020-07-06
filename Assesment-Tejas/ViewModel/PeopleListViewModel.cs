using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AssesmentTejas.Model;
using Newtonsoft.Json;

namespace AssesmentTejas.ViewModel
{
    public class PeopleListViewModel
    {
        private const string _url = "https://swapi.dev/api/people/";
        HttpClient _httpClient = new HttpClient();

        public async Task<List<Person>> GetResponseFromServer()
        {
            var responseMessage = await _httpClient.GetAsync(_url);
            var data = responseMessage.Content.ReadAsStringAsync().Result;
            var response = JsonConvert.DeserializeObject<APIResponse>(data);

            return response.results;
        }
    }
}
