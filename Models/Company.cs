namespace start_csharp.Models;

public class Company
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public int StoresNumber { get; set; } = 0;
    public string? LegalName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}
