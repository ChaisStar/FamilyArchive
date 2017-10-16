namespace FamilyArchive.Application
{
    public class ApplicationSettings
    {
        public Database Database { get; set; }
    }

    public class Database
    {
        public Database(string server, string port, string name, string user, string password)
        {
            ConnectionString = $"Server={server};Port={port};Database={name};User Id={user};Password={password}";
        }

        public string ConnectionString { get; set; }
    }
}