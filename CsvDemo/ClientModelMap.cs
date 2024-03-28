// See https://aka.ms/new-console-template for more information
using CsvDemo;
using CsvHelper.Configuration;

public class ClientModelMap : ClassMap<ClientModel>
{
    public ClientModelMap()
    {
        Map(m => m.Id);
        Map(m => m.Name);
        Map(m => m.Domains).Convert(args => string.Join(",", args.Value.Domains));
        Map(m => m.Aaa);
    }
}