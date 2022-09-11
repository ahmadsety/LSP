namespace EmployeeLib
{
    public interface ICeo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public void CalculatePerHourRate(int rank);

    } 
}