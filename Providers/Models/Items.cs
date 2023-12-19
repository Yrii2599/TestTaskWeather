namespace Providers.Models
{
    public class Items
    {
        public string id { get; set; }
        public string label { get; set; }
        public LatestReading latestReading { get; set; }
        public string notation { get; set; }
        public string parameter { get; set; }
        public string parameterName { get; set; }
        public int period { get; set; }
        public string qualifier { get; set; }
        public string station { get; set; }
        public string stationReference { get; set; }
        public List<string> type { get; set; }
        public string unit { get; set; }
        public string unitName { get; set; }
        public string valueType { get; set; }



        public Items()
            : this(default!,
                  default!,
                  default!,
                  default!,
                  default!,
                  default!,
                  default!,
                  default!, 
                  default!,
                  default!,
                  default!,
                  default!,
                  default!,
                  default!)
        {}

        public Items(string id,
            string label,
            LatestReading latestReading,
            string notation, string parameter,
            string parameterName, 
            int period, 
            string qualifier,
            string station, 
            string stationReference, 
            List<string> type,
            string unit,
            string unitName, 
            string valueType)
        {
            this.id = id;
            this.label = label;
            this.latestReading = latestReading;
            this.notation = notation;
            this.parameter = parameter;
            this.parameterName = parameterName;
            this.period = period;
            this.qualifier = qualifier;
            this.station = station;
            this.stationReference = stationReference;
            this.type = type;
            this.unit = unit;
            this.unitName = unitName;
            this.valueType = valueType;
        }
    }
}
