public abstract class BaseSalaryCalculator
{
    protected EmployeeReport EmployeeReport { get ; private set; }
    public BaseSalaryCalculator(EmployeeReport employeeReport)
    {
        EmployeeReport = employeeReport;
    }
    public abstract double CalculateSalaries();
}