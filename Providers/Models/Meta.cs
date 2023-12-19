namespace Providers.Models
{
    public class Meta
    {
        public string publisher { get; set; }
        public string licence { get; set; }
        public string documentation { get; set; }
        public string version { get; set; }
        public string comment { get; set; }
        public List<string> hasFormat { get; set; }

        public Meta(
            string publisher, 
            string licence, 
            string documentation, 
            string version, 
            string comment, 
            List<string> hasFormat)
        {
            this.publisher = publisher;
            this.licence = licence;
            this.documentation = documentation;
            this.version = version;
            this.comment = comment;
            this.hasFormat = hasFormat;
        }

        public Meta() 
            : this(default!, 
                  default!, 
                  default!, 
                  default!, 
                  default!, 
                  default!)
        {}
    }
}
