namespace Providers.Models
{
    public class WeatherData
    {
        public string context { get; set; }
        public Meta meta { get; set; }
        public Items items { get; set; }

        public WeatherData(string context, Meta meta, Items items)
        {
            this.context = context;
            this.meta = meta;
            this.items = items;
        }

        public WeatherData() 
            : this(default!, default!, default!)
        {}
    }
}
