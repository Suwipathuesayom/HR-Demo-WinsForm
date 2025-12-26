namespace hr_demo.Models
{
    internal class ScanRow
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string ClockIn { get; set; }
        public object UserName { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
    }
}