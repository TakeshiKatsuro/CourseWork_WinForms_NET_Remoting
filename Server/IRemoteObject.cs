namespace Server
{
    public interface IRemoteObject
    {
        int Autorization(string login, string password);
        int Registration(string login, string name, string familia, string password);
    }
}
