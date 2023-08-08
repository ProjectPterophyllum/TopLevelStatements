using System.Linq.Expressions;

namespace TopLevelStatements
{
    public class URL
    {
        public string scheme { get; set; }
        private string _authority = "[authority]";
        public string path { get; set; }
        private string _query = "[query]";
        private string _fragment = "[fragment]";

        public override string ToString() 
        {
            return scheme+ "://" + path;
        }
    }
}
