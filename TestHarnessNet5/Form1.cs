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
        private PolarisAccountHolder acctHolder;
        public Form1()
        {
            InitializeComponent();
            //Create the accountHolder
            List<PolarisTransaction> polarisTransactionsList = new List<PolarisTransaction>
            {
                new PolarisTransaction
                {
                    AccountGuid = Guid.NewGuid(),
                    BeginningBalance = 100.00M,
                    EndingBalance = 100.00M,
                    Memo = "THIS IS A TEST ONE MY DUDE",
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
                    Memo = "THIS IS A TEST TWO MY BROTHER",
                    TransactionAmount = 300.00M,
                    TransactionDateTime = DateTime.Today,
                    TransactionGuid = Guid.NewGuid(),
                    TransactionId = 2,
                    TransactionType = "DUMMY TWO"
                },
                new PolarisTransaction
                {
                    AccountGuid = Guid.NewGuid(),
                    BeginningBalance = 400.00M,
                    EndingBalance = 4000400.00M,
                    Memo = "THIS IS A TEST THREE MY HOMIE",
                    TransactionAmount = 4000000.00M,
                    TransactionDateTime = DateTime.Today,
                    TransactionGuid = Guid.NewGuid(),
                    TransactionId = 3,
                    TransactionType = "DUMMY THREE"
                }
            };

            acctHolder = new PolarisAccountHolder();
            acctHolder.AccountGuid = Guid.NewGuid();
            acctHolder.AccountHolder = "SOME DUDE YOU DONT KNOW";
            acctHolder.AccountId = 1;
            acctHolder.AccountType = "DUMMY ACCOUNT";
            acctHolder.PolarisTransactions = polarisTransactionsList;

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //Clear the existing text
            jsonTextBox.Text = string.Empty;

            jsonTestLib testLib = new jsonTestLib();
            jsonTextBox.Text = testLib.SerializeJsonToString(acctHolder);

            MessageBox.Show("DONE");
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            //Purposely commented out as file folders/permissions may vary
            //only for testing anyway. Uncomment with your own path first
            //string pathToSave = @"C:\Temp\JsonFile_" + DateTime.UtcNow.Second + ".txt";
            //if (!string.IsNullOrEmpty(jsonTextBox.Text))
            //{
            //    File.WriteAllText(pathToSave,jsonTextBox.Text);
            //}
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            jsonTestLib testLib = new jsonTestLib();
            PolarisAccountHolder deserializedPolarisAccountHolder;
            if (!string.IsNullOrEmpty(jsonTextBox.Text))
            {
                deserializedPolarisAccountHolder = testLib.DeserializeJsonFromString(jsonTextBox.Text);
                MessageBox.Show("DONE");
            }
            else
            {
                MessageBox.Show("Make sure you have either clicked the Execute or " +
                                "Execute/Formatted button first. Textbox can't be empty");
            }
        }

        private void btnExecuteFormatted_Click(object sender, EventArgs e)
        {
            //Clear the existing text
            jsonTextBox.Text = string.Empty;

            jsonTestLib testLib = new jsonTestLib();
            jsonTextBox.Text = testLib.SerializeFormattedJsonToString(acctHolder);

            MessageBox.Show("DONE");

        }
    }
}
