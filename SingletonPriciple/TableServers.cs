namespace SingletonPriciple
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        //You can't instantiate this class outside of this class
        //this is to ensure that only one instance of this class is always
        //created in the lifetime of this app
        private TableServers()
        {
            servers.Add("Ola");
            servers.Add("BOla");
            servers.Add("KOla");
            servers.Add("JOla");
        }

        //To get an instance of this class, you will have to call this. 
        //You can't call TableServer servers = new TableServers()
        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer++];
            if (nextServer >= servers.Count)
                nextServer = 0;
            return output;
        }
    }
}