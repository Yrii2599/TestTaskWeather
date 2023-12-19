namespace Providers.Models
{
    public class LatestReading
    {
        public string id { get; set; }
        public string date { get; set; }
        public DateTime dateTime { get; set; }
        public string measure { get; set; }
        public double value { get; set; }

        public LatestReading(
            string id,
            string date,
            DateTime dateTime, 
            string measure, 
            double value)
        {
            this.id = id;
            this.date = date;
            this.dateTime = dateTime;
            this.measure = measure;
            this.value = value;
        }

        public LatestReading()
             : this(default!,
                   default!, 
                   default!, 
                   default!, 
                   default!)
        {}
    }
}
