using Microsoft.VisualBasic;

namespace ClalProjectApi.Models
{
    public class Hour
    {
        public string Time { get; set; }
        public double Temp_c { get; set; }
        public Condition Condition { get; set;}
    }
}
