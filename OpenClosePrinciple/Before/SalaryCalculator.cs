public class SalaryCalculator
{
    private readonly IEnumerable<EmployeeReport> _employeeReports;
    public SalaryCalculator(List<EmployeeReport> employeeReports)
    {
        _employeeReports = employeeReports;
    }
    public double CalculateTotalSalaries()
    {
        double totalSalaries = 0D;
        foreach(var employeeReport in _employeeReports)
        {
            //check level and apply bonus if demands came
            totalSalaries += employeeReport.HourlyRate * employeeReport.WorkingHours;
        }
        return totalSalaries;
    }
}