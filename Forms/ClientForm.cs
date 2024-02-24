using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Database;
using Accounting.Entities;
namespace Accounting.Forms;
public partial class ClientForm : Form
{
    private Client _client;
    private IDatabase _database;
    public ClientForm(Client client, IDatabase database)
    {
        this._client = client;
        this._database = database;
        InitializeComponent();
    }
    public void OnFormLoad(object sender, EventArgs e)
    {
        surnameTextBox.Text = _client.Surname;
        nameTextBox.Text = _client.Name;
        balanceTextBox.Text = _client.Balance.ToString();
        isAdultCheckBox.Checked = _client.IsAdult;
    }
}
