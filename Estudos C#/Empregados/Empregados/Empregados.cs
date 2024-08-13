namespace Empregados;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void increaseSalary(double percentage)
    {
        Salary += Salary * percentage / 100.0; //! Salary * (percentage / 100.0) => 2000 * 0.15 = 300/ Dito isso ir o salary += Salary fica,Salary = Salary+300
    }
}

