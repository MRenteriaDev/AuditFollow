namespace API.Entities;

public class Connection
{
    public Connection()
    {
        
    }
    public Connection(string connectionid, string username)
    {
        ConnectionId = connectionid;
        Username = username;
    }

    public string ConnectionId { get; set; }
    public string Username { get; set; }
}
