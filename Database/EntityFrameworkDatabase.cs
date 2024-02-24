using Accounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Database;

public class EntityFrameworkDatabase : DbContext, IDatabase
{
    private DbSet<Client> _clients => Set<Client>();
    public EntityFrameworkDatabase() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=clients.db");
      
    }

    public IEnumerable<Client> GetAllClients() => _clients;

    public Client? GetClientById(Guid id) => _clients.FirstOrDefault(c => c.Id == id);

    public void UpdateClient(Client client)
    {
        var target = _clients.FirstOrDefault(c => c.Id == client.Id);
        if (target is null) return;

        target.Name = client.Name;
        target.Surname = client.Surname;
        target.Balance = client.Balance;
        target.IsAdult = client.IsAdult;
    }

    public void AddClient(Client client) => _clients.Add(client);

    void IDatabase.SaveChanges()
    {
        SaveChanges();
    }
}