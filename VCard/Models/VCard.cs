namespace VCard.Models;
//{"gender":"female","name":{"title":"Mrs","first":"Julia","last":"Soltvedt"},"location":{ "street":{ "number":6846,"name":"Welding Olsens vei"},"city":"Mesnali","state":"Bergen","country":"Norway","postcode":"1625","coordinates":{ "latitude":"41.8419","longitude":"37.1876"},"timezone":{ "offset":"+3:30","description":"Tehran"} },"email":"julia.soltvedt@example.com","login":{ "uuid":"7ca9af81-b347-4686-82e8-966624a24a0c","username":"lazylion446","password":"talon","salt":"otCzIzGi","md5":"961d25f27fecd99f72c9ef54e849b4c1","sha1":"5af740a7ef92be5aaebdd5c4e367d95369d69e40","sha256":"d8f5ce61deeab03cc8dcea452b43d106faa48492b38918a6850a398a2bcc0e31"},"dob":{ "date":"1969-04-15T07:19:59.850Z","age":54},"registered":{ "date":"2010-03-14T05:03:49.195Z","age":13},"phone":"36126071","cell":"41757027","id":{ "name":"FN","value":"15046903444"},"picture":{ "large":"https://randomuser.me/api/portraits/women/17.jpg","medium":"https://randomuser.me/api/portraits/med/women/17.jpg","thumbnail":"https://randomuser.me/api/portraits/thumb/women/17.jpg"},"nat":"NO"},
public record VCard
{
    private static int _id = 1;
    public int Id { get => _id++; }
    public string FullName { get; init; }
    public string Title { get; init; }
    public string Name { get; init; }
    public string Surname { get; init; }
    public string Email { get; init; }
    public string Phone { get; init; }
    public string Country { get; init; }
    public string City { get; init; }
    public string Thumbnail { get; init; }
}

public record Id
{
    private static int _id = 1;
    public int id { get => _id++; }
}

public record Name
{
    public string title { get; init; }
    public string first { get; init; }
    public string last { get; init; }
}

public record Location
{
    public string Country { get; init; }
    public string City { get; init; }
}

public record Picture
{
    public string medium { get; init; }
}

public record Result
{
    public Id id { get; init; }
    public Name name { get; init; }
    public Location location { get; init; }

    public string email { get; init; }

    public string phone { get; init; }
    public Picture picture { get; init; }
}

public record Root
{
    public List<Result> results { get; init; }
}