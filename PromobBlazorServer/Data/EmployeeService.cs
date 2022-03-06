using Newtonsoft.Json;
using Promob.Model.Entities;
using RestSharp;
using System.Net;
using System.Text;

namespace PromobBlazorServer.Data
{
    public class EmployeeService
    {
        string baseUrl = "https://localhost:7267/";

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Employee");
            return JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
        }

        public async Task<Employee> GetEmployeesByIdAsync(long id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Employee/{id}");
            return JsonConvert.DeserializeObject<Employee>(json);
        }

        public async Task<List<Employee>> GetEmployeesByNameAsync(string name)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Employee/name/{name}");
            return JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
        }

        public async Task<List<Employee>> GetEmployeesByHappyAsync(bool happy)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Employee/happy/{happy}");
            return JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
        }

        public async Task<HttpResponseMessage> InsertEmployeeAsync(Employee employee)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Employee", getStringContentFromObject(employee));
        }

        public async Task<HttpResponseMessage> UpdateEmployeeAsync(long id, Employee employee)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Employee/{id}", getStringContentFromObject(employee));
        }

        public async Task<HttpResponseMessage> DeleteEmployeeAsync(long id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Employee/{id}");
        }

        private StringContent getStringContentFromObject(object obj) => new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

        private void GetClient(string url, Method method, out RestClient client, out RestRequest request)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.Expect100Continue = true;
            client = new RestClient(url);
            request = new RestRequest();
            request.Method = method;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
        }
    }
}
