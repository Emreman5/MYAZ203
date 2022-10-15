namespace Nesne_programlama_odev;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public double Salary { get; set; }

    public override string ToString()
    {
        return $"{this.Name} {this.Surname}";
    }
}