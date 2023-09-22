using System.Text.Json;

public class ExpList
{
    private List<Expense> exps=new();
    public void Load(string filename)
    {
        var data = File.ReadAllText(filename);
        var options = new JsonSerializerOptions();
        options.PropertyNamingPolicy =  JsonNamingPolicy.CamelCase;
        exps=JsonSerializer.Deserialize<List<Expense>>(data,options)??new();
    }
    public double AmountTotal => exps.Sum(e=>e.Amount);
    public Expense? Max => exps.OrderByDescending(e=>e.Amount)
                           .FirstOrDefault();
}