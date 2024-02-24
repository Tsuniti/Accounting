using Accounting.Database;
using Accounting.Entities;
namespace Accounting.Forms;

public partial class ClientsListForm : Form
{
    private IDatabase _database;
    public ClientsListForm()
    {
        _database = new EntityFrameworkDatabase();
        InitializeComponent();
    }

    public void OnFormLoaded(object sender, EventArgs e)
    {
        var clients = _database.GetAllClients().ToArray();
        clientsListBox.Items.AddRange(clients);
    }
    public void OnListBoxDoubleClick(object sender, EventArgs e)
    {
        var selectedClient = clientsListBox.SelectedItem as Client;
        int index = clientsListBox.SelectedIndex;
        if (selectedClient is null) return;
        clientsListBox.Items.Remove(clientsListBox.SelectedItem);

        var clientForm = new ClientForm(selectedClient);
        clientForm.ShowDialog();
        _database.SaveChanges();
        clientsListBox.Items.Insert(index, selectedClient);
    }

    private void addClientButton_Click(object sender, EventArgs e)
    {
        var newClient = new Client();
        var clientForm = new ClientForm(newClient);
        clientForm.ShowDialog();
        _database.AddClient(newClient);
        _database.SaveChanges();
        clientsListBox.Items.Add(newClient);
    }
}
