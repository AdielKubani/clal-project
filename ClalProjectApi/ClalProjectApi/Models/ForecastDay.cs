namespace ClalProjectApi.Models
{
    public class ForecastDay
    {
        public DateTime Date { get; set; }
        public Day Day { get; set; }
        public Hour[] Hour { get; set; }
    }
}
