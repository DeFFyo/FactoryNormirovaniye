using System;


namespace Normirovanie
{
    public class Work
    {
        public int ID { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime? StartCheckDate { get; set; }
        public DateTime? EndCheckDate { get; set; }
        public double WorkTime { get; set; }
        public double? BreakTime { get; set; }
        public District District { get; set; }
        public User User { get; set; }
        public byte Caution { get; set; }


        public Work()
        {

        }
    }
}
