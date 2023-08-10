using System.Net;
using System.Text.Encodings.Web;

namespace TopLevelStatements
{
    public class Web_site:URL
    {
        public string site_name;
        public string site_description;
        public IPAddress site_ip;
        public void set_name(string name)
        {
            site_name = name;
        }
        public void set_description(string description)
        {
            site_description = description;
        }
        public void set_ip(IPAddress ip) 
        {
            site_ip = ip;
        }
        public string get_name()
        {
            return site_name;
        }
        public string get_description()
        { 
            return site_description; 
        }
        public override string ToString()
        {
            return site_name + " - " + site_description + " - " + site_ip + " " + base.ToString();
        }
    }
}
