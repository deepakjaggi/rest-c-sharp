using APIDemo.Models;
using Newtonsoft.Json;
using RestSharp;

namespace APIDemo
{
    public class ServiceCalls
    {
        public User GetUser(int id)
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("api/users/" + id);
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            User user = JsonConvert.DeserializeObject<User>(response.Content);
            return user;
        }

        public UserLists GetUserLists()
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("api/users");
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            return  JsonConvert.DeserializeObject<UserLists>(response.Content);
        }
        public User CreateUser(User user)
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("api/users");
            request.AddHeader("Accept", "application/json");
            string jsonToSend = JsonConvert.SerializeObject(user);
            request.AddJsonBody(jsonToSend);

            var response = client.Execute(request,Method.POST);

            return JsonConvert.DeserializeObject<User>(response.Content);
        }        
    }
}
