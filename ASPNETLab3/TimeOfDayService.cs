namespace ASPNETLab3
{
    public interface ITimeOfDayService
    {
        string GetTimeOfDay();
    }

    public class TimeOfDayService : ITimeOfDayService
    {
        public string GetTimeOfDay()
        {
            var now = DateTime.Now;
            if (now.Hour >= 12 && now.Hour < 18)
                return "«зараз день";
            else if (now.Hour >= 18 && now.Hour < 24)
                return "зараз вечір";
            else if (now.Hour >= 0 && now.Hour < 6)
                return "зараз ніч";
            else
                return "зараз ранок";
        }
    }

}
