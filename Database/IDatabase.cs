using Accounting.Entities;

namespace Accounting.Database;

public interface IDatabase 
{
    IEnumerable<Client> GetAllClients();

    Client? GetClientById(Guid id);

    void UpdateClient(Client client);
}
