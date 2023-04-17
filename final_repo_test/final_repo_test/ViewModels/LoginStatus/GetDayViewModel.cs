namespace final_repo_test.ViewModels.LoginStatus
{
    public class GetDayViewModel
    {
        public List<DateTime> Mainx { get; set; } = new List<DateTime>();
        public List<int> Mainy { get; set; } = new List<int>();
        public List<TimeSpan> Headx { get; set; } = new List<TimeSpan>() { TimeSpan.Zero,new TimeSpan(6,0,0), new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0) };
        public List<int> Heady { get; set; } = new List<int>();
        public int Average { get; set; } = default!;
    }
}
