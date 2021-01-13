using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zfJsonTestLibraries;
using zfJsonTestLibraries.Objects;

namespace TestHarnessNet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            List<PolarisTransaction> polarisTransactionsList = new List<PolarisTransaction>
            {
                new PolarisTransaction
                {
                    AccountGuid = Guid.NewGuid(),
                    BeginningBalance = 100.00M,
                    EndingBalance = 100.00M,
                    Memo = "THIS IS A TEST ONE",
                    TransactionAmount = 0.00M,
                    TransactionDateTime = DateTime.Today,
                    TransactionGuid = Guid.NewGuid(),
                    TransactionId = 1,
                    TransactionType = "DUMMY ONE"
                },
                new PolarisTransaction
                {
                    AccountGuid = Guid.NewGuid(),
                    BeginningBalance = 100.00M,
                    EndingBalance = 400.00M,
                    Memo = "THIS IS A TEST TWO",
                    TransactionAmount = 300.00M,
                    TransactionDateTime = DateTime.Today,
                    TransactionGuid = Guid.NewGuid(),
                    TransactionId = 1,
                    TransactionType = "DUMMY TWO"
                },
                new PolarisTransaction
                {
                    AccountGuid = Guid.NewGuid(),
                    BeginningBalance = 400.00M,
                    EndingBalance = 4000400.00M,
                    Memo = "THIS IS A TEST TWO",
                    TransactionAmount = 4000000.00M,
                    TransactionDateTime = DateTime.Today,
                    TransactionGuid = Guid.NewGuid(),
                    TransactionId = 1,
                    TransactionType = "DUMMY THREE"
                }
            };

            PolarisAccountHolder acctHolder = new PolarisAccountHolder();
            acctHolder.AccountGuid = Guid.NewGuid();
            acctHolder.AccountHolder = "SOME DUDE";
            acctHolder.AccountId = 1;
            acctHolder.AccountType = "DUMMY ACCOUNT";
            acctHolder.PolarisTransactions = polarisTransactionsList;
            jsonTestLib testLib = new jsonTestLib();
            jsonTextBox.Text = testLib.SerializeJsonToString(acctHolder);

            MessageBox.Show("DONE");
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string pathToSave = @"C:\Temp\JsonFile_" + DateTime.UtcNow.Second + ".txt";
            if (!string.IsNullOrEmpty(jsonTextBox.Text))
            {
                File.WriteAllText(pathToSave,jsonTextBox.Text);
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            jsonTestLib testLib = new jsonTestLib();

            if (!string.IsNullOrEmpty(jsonTextBox.Text))
            {
                PolarisAccountHolder deserializedPolarisAccountHolder =
                    testLib.DeserializeJsonFromString(jsonTextBox.Text);
            }

            MessageBox.Show("Done");
        }
    }
}
