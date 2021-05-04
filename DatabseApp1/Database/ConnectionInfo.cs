using System.Xml;


namespace DatabaseApplication.Database
{
    class ConnectionInfo
    {
        private readonly string filename;
        private string[] databseDetails;

        public ConnectionInfo()
        {
            filename = null;
        }

        public ConnectionInfo(string filename)
        {
            this.filename = filename;
        }

        public string[] GetConnectionInfo() //Get connection info in format: database, user, password, data, port
        {
            GetDataFromXml();
            return databseDetails;
        }

        private void GetDataFromXml()
        {
            databseDetails = new string[5];
            int i = 0;
            XmlTextReader reader = new XmlTextReader(filename);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    databseDetails[i] = reader.Value;
                    i++;
                }
            }
        }
        
        
        
    }
}
