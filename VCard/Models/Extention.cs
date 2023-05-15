namespace VCard.Models;

public static class Extentionn
{
    public static void TovCard(this VCard vCard)
    {
        string Card = $"""
            BEGIN:VCARD
            VERSION:4.1
            ID:{vCard.Id}
            FN:{vCard.FullName}
            N:{vCard.Name}
            EMAIL:{vCard.Email}
            TEL:{vCard.Phone}
            ADR:{vCard.Country}
            ADR:{vCard.City}
            SORT-STRING:{vCard.Surname}
            PHOTO:{vCard.Thumbnail}
            END:VCARD
        
            """;

        string path = @"YOUR CARDS PATH" + vCard.FullName + ".vcf";
        File.WriteAllText(path, Card);
    }
}
