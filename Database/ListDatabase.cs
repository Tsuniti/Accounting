using Accounting.Entities;
using System.Net.Http.Headers;

namespace Accounting.Database;

public class ListDatabase : IDatabase
{
    private List<Client> _clients = new List<Client>();

    public void AddClient(Client client) => _clients.Add(client);
    

    //    = new() {
    //    new Client
    //    {
    //        Id = Guid.NewGuid(),
    //        Name = "Nikita",
    //        Surname = "Kalnitskiy",
    //        Balance = 15000,
    //        IsAdult = true
    //    },
    //    new Client
    //    {
    //        Id = Guid.NewGuid(),
    //        Name = "Oleg",
    //        Surname = "Popov",
    //        Balance = 12,
    //        IsAdult = true
    //    },
    //    new Client { 
    //        Id = Guid.NewGuid(),
    //        Name = "Anna",
    //        Surname = "Pupkina",
    //        Balance = 3520,
    //        IsAdult = false
    //    }
    //    };
    public IEnumerable<Client> GetAllClients() => _clients;

    public Client? GetClientById(Guid id) => _clients.FirstOrDefault(c => c.Id == id);

    public void SaveChanges()
    {
        // в листе не нужно ничего обновлять
    }

    public void UpdateClient(Client client)
    {
        var target = _clients.FirstOrDefault(c => c.Id == client.Id);
        if (target is null) return;

        target.Name = client.Name;
        target.Surname = client.Surname;
        target.Balance = client.Balance;
        target.IsAdult = client.IsAdult;
    }
}
