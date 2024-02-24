using Accounting.Database;
using Accounting.Entities;
namespace Accounting.Forms;

public partial class ClientsListForm : Form
{
    private IDatabase _database;
    public ClientsListForm()
    {
        _database = new ListDatabase();
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

        if (selectedClient is null) return;

        var clientForm = new ClientForm(selectedClient, _database);
        clientForm.ShowDialog();
    }
}
