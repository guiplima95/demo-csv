// See https://aka.ms/new-console-template for more information
using CsvDemo;
using CsvHelper.Configuration;

public class CSVMap : ClassMap<ClientModel>
{
    public CSVMap()
    {
        Map(m => m.Id).Index(0);
        Map(m => m.Name).Index(1);
        Map(m => m.Domains).Convert(args => string.Join(",", args.Value.Domains)).Index(2);
    }
}