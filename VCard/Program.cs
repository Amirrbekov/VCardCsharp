namespace VCard;
using Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.Json;

public class Program
{
    //public static void Main(String[] args)
    //{
    //    #region Error
    //    //VCard vcard = new()
    //    //{
    //    //    Id = "22046947561",
    //    //    Gender = "Male",
    //    //    Bdate = "22-05-1996",
    //    //    Thumbnail = "https://randomuser.me/api/portraits/thumb/men/31.jpg",
    //    //    Name = "Alvar",
    //    //    Surname = "Hidle",
    //    //    Email = "alvar.hidle@example.com",
    //    //    Phone = "77925733",
    //    //    Country = "Norway",
    //    //    City = "Disena",
    //    //};

    //    //        string jsonString =
    //    //@"{
    //    //  {""gender"":""female"",""name"":{""title"":""Mrs"",""first"":""Julia"",""last"":""Soltvedt""},""location"":{ ""street"":{ ""number"":6846,""name"":""Welding Olsens vei""},""city"":""Mesnali"",""state"":""Bergen"",""country"":""Norway"",""postcode"":""1625"",""coordinates"":{ ""latitude"":""41.8419"",""longitude"":""37.1876""},""timezone"":{ ""offset"":""+3:30"",""description"":""Tehran""} },""email"":""julia.soltvedt@example.com"",""login"":{ ""uuid"":""7ca9af81-b347-4686-82e8-966624a24a0c"",""username"":""lazylion446"",""password"":""talon"",""salt"":""otCzIzGi"",""md5"":""961d25f27fecd99f72c9ef54e849b4c1"",""sha1"":""5af740a7ef92be5aaebdd5c4e367d95369d69e40"",""sha256"":""d8f5ce61deeab03cc8dcea452b43d106faa48492b38918a6850a398a2bcc0e31""},""dob"":{ ""date"":""1969-04-15T07:19:59.850Z"",""age"":54},""registered"":{ ""date"":""2010-03-14T05:03:49.195Z"",""age"":13},""phone"":""36126071"",""cell"":""41757027"",""id"":{ ""name"":""FN"",""value"":""15046903444""},""picture"":{ ""large"":""https://randomuser.me/api/portraits/women/17.jpg"",""medium"":""https://randomuser.me/api/portraits/med/women/17.jpg"",""thumbnail"":""https://randomuser.me/api/portraits/thumb/women/17.jpg""},""nat"":""NO""}";
    //    //        Console.WriteLine(jsonString);

    //    //        VCard? vcard = JsonSerializer.Deserialize<VCard>(jsonString);

    //    //        Console.WriteLine($"Date: {vcard?.Bdate}");
    //    //        Console.WriteLine($"TemperatureCelsius: {vcard?.Name}");
    //    //        Console.WriteLine($"Summary: {vcard?.Surname}"); 
    //    #endregion

    //    //using (var client = new HttpClient())
    //    //{
    //    //    // New code:
    //    //    client.BaseAddress = new Uri("https://randomuser.me/api?results=50&authuser=1");
    //    //    client.DefaultRequestHeaders.Accept.Clear();
    //    //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    //    //    static async Task<VCard> GetProductAsync(string path)
    //    //    {
    //    //        VCard vcard = null;
    //    //        HttpResponseMessage response = await client.GetAsync(path);
    //    //        if (response.IsSuccessStatusCode)
    //    //        {
    //    //            vcard = await response.Content.ReadAsAsync<VCard>();
    //    //        }
    //    //        return vcard;
    //    //    }
    //    //}
    //    Main();
    //}

    public static async Task Main(string[] args)
    {
        HttpClient httpClient = new();
        string content = await httpClient.GetStringAsync("https://randomuser.me/api?results=10");

        var data = JsonConvert.DeserializeObject<Root>(content);

        Console.WriteLine(data);

        foreach (var item in data.results)
        {
            VCard card = new()
            {
                FullName = $"{item.name.title}{item.name.first}{item.name.last}",
                Title = item.name.title,
                Name = item.name.first,
                Surname = item.name.last,
                City = item.location.City,
                Country = item.location.Country,
                Email = item.email,
                Phone = item.phone,
                Thumbnail = item.picture.medium
            };
            card.TovCard();
        }
    }
}