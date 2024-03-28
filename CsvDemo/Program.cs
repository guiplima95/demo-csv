// See https://aka.ms/new-console-template for more information
using CsvDemo;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

// Id, Name, Domains
List<ClientModel> clients =
[
    new ClientModel(Guid.NewGuid(), "FakeClient",
        [
            "test.com",
            "domain.com"
        ])
];

var config = new CsvConfiguration(CultureInfo.GetCultureInfo("en-US"))
{
    Delimiter = ";"
};

using (var csv = new CsvWriter(Console.Out, config))
{
    csv.Context.RegisterClassMap<CSVMap>();
    csv.WriteRecords(clients);
}

Console.ReadKey();