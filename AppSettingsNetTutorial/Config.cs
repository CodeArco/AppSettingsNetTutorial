namespace AppSettingsNetTutorial
{
    public class Config
    {
        public string ExampleString { get; set; }
        public int ExampleInt { get; set; }
        public ExampleObject ExampleObject { get; set; }
        public List<string> ExampleStringList { get; set; }
        public List<ExampleObjectListItem> ExampleObjectList { get; set; }
    }

    public class ExampleObject
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
    }

    public class ExampleObjectListItem
    {
        public Header Header { get; set; }
        public Body Body { get; set; }
    }

    public class Header
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Body
    {
        public string Content { get; set; }
        public double Details { get; set; }
    }
}
