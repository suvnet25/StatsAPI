public class Statistics
{
    public int Id { get; set; }

    public string IPAddress { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public DateTime DateSearched { get; set; } = DateTime.UtcNow;
}
