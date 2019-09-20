namespace WeatherAppApi.Models
{

    public class ApiRequest
    {
        public string Place { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public RequestDate RequestDate { get; set; }
    }

    public class RequestDate
    {
        public string date { get; set; }
    }

}
