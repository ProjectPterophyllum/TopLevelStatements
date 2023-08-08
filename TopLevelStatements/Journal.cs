namespace TopLevelStatements
{
    public class Journal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly Foundation { get; set; }
        Contacts Contacts { get; set; }
    }
}
