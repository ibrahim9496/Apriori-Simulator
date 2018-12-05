using System;
using System.Windows.Forms;


namespace AprioriGui
{
    partial class MainForm:Form
    { 
        ListBox Transaction_String_ListBox;
        ListBox Transaction_ItemSet_ListBox;
        ListBox DistinctItems_Item_ListBox;
        ListBox FrequentItems_Item_ListBox;

        TextBox AddTransaction_TextBox;
        TextBox AddSupport_TextBox;

        Button AddTransaction_Button;
        Button AddSupport_Button;
        Button GenerateFrequents_Button;

        Label Transaction_String_Label;
        Label Transaction_ItemSet_Label;
        Label DistinctItem_Item_Label;
        Label FrequentItem_Item_Label;
        Label AddSupport_Label;

        Apriori apr;


        public MainForm()
        {
            Adobe();
            apr = new Apriori();
        }

        void AddTransactionStringToListViewTransaction(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AddTransaction_TextBox.Text!=string.Empty)
                { Transaction_String_ListBox.Items.Add(AddTransaction_TextBox.Text);
                    Transaction_ItemSet_ListBox.Items.Add(apr.AddTransaction(AddTransaction_TextBox.Text));
                    UpdateDistinctItemBox();
                    AddTransaction_TextBox.ResetText();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void AddTransactionStringToListViewTransaction(object sender ,EventArgs e)
        {
            if (AddTransaction_TextBox.Text != string.Empty)
            {
                Transaction_String_ListBox.Items.Add(AddTransaction_TextBox.Text);
                Transaction_ItemSet_ListBox.Items.Add(apr.AddTransaction(AddTransaction_TextBox.Text));
                UpdateDistinctItemBox();
                AddTransaction_TextBox.ResetText();
            }
        }

        void AddFrequentItemsToListViewFrequentItems(object sender, EventArgs e)
        {
            FrequentItems_Item_ListBox.Items.Clear();
            apr.Support = Int32.Parse(AddSupport_TextBox.Text);
            apr.GenerateFrequents();
            foreach(var i in apr.GetFrequentItemsId())
            {
                FrequentItems_Item_ListBox.Items.Add(apr.distinctItems.Items[i].Text);
            }
        }

        void UpdateDistinctItemBox()
        {
            DistinctItems_Item_ListBox.Items.Clear();
            foreach(var tm in apr.distinctItems.Items)
            {
                DistinctItems_Item_ListBox.Items.Add(tm.Text+":"+tm.Id);
            }
        }
    }
}