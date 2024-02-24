using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Database;
using Accounting.Entities;
namespace Accounting.Forms;
public partial class ClientForm : Form
{
    private Client _client;
    public ClientForm(Client client)
    {
        this._client = client;
        InitializeComponent();
    }
    public void OnFormLoad(object sender, EventArgs e)
    {
        surnameTextBox.Text = _client.Surname;
        nameTextBox.Text = _client.Name;
        balanceTextBox.Text = _client.Balance.ToString();
        isAdultCheckBox.Checked = _client.IsAdult;
    }
    private void saveButton_Click(object sender, EventArgs e)
    {

        _client.Surname = surnameTextBox.Text;
        _client.Name = nameTextBox.Text;
        _client.Balance = decimal.Parse(balanceTextBox.Text);
        _client.IsAdult = isAdultCheckBox.Checked;

        Close();

    }

    private void balanceTextBox_TextChanged(object sender, EventArgs e)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(balanceTextBox.Text, "[^0-9,]") || Regex.Matches(balanceTextBox.Text, @"\,").Count > 1) 
        {

            int selectionStart = balanceTextBox.SelectionStart - 1; // запомнить позицию курсора

            for (int i = 0; i < balanceTextBox.Text.Length; i++)
            {
                char ch = balanceTextBox.Text[i];
                if ((ch != ',' && !char.IsDigit(ch)) 
                 || (ch == ',' && Regex.Matches(balanceTextBox.Text, @"\,").Count > 1)) 
                {
                    balanceTextBox.Text = balanceTextBox.Text.Remove(i, 1);
                    break;
                }
            }
            if (selectionStart <= balanceTextBox.Text.Length && selectionStart > 0)
            {
                balanceTextBox.SelectionStart = selectionStart;
            } else { balanceTextBox.SelectionStart = balanceTextBox.Text.Length; }
        }
    }
}
