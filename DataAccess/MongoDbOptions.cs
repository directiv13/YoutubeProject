namespace DataAccess
{
    public class MongoDbOptions
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string DownloadHistoryCollectionName { get; set; }
        public string SearchHistoryCollectionName { get; set; }
    }
}
