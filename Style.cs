using System;
using System.Drawing;
using System.Windows.Forms;

namespace AprioriGui
{
    partial class MainForm:Form
    {
        void DeclareControls()
        {
            Transaction_String_ListBox = new ListBox() ;
            Transaction_ItemSet_ListBox = new ListBox();
            DistinctItems_Item_ListBox = new ListBox();
            AddTransaction_TextBox = new TextBox();
            AddSupport_TextBox = new TextBox();
            AddTransaction_Button = new Button();
            AddSupport_Button = new Button();
            FrequentItems_Item_ListBox = new ListBox();
            GenerateFrequents_Button = new Button();
        }

        void ApplyStyle()
        {
            Transaction_String_ListBox = new ListBox()
            {
                Size = new Size(200, 400),
                Location = new Point(0, 19),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = ColorTranslator.FromHtml("#F0F0F0")
            };

            Transaction_ItemSet_ListBox = new ListBox()
            {
                Size = new Size(200, 400),
                Location = new Point(200, 19),
            };

            DistinctItems_Item_ListBox = new ListBox()
            {
                Size = new Size(100, 400),
                Location = new Point(400, 19),
                MultiColumn=true,
                BackColor = ColorTranslator.FromHtml("#F0F0F0")
            };

            AddTransaction_TextBox = new TextBox()
            {
                Size = new Size(200, 20),
                Location = new Point(0, 411),
                TextAlign = HorizontalAlignment.Center,
            };

            AddTransaction_Button = new Button()
            {
                Size = new Size(200, 20),
                Location = new Point(0, 431),
                Text = "Add Transaction",
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#0078D7")
            };

            AddSupport_TextBox = new TextBox()
            {
                Size = new Size(100, 400),
                Location = new Point(400, 414)
            };

            FrequentItems_Item_ListBox = new ListBox()
            {
                Size = new Size(284, 411),
                Location = new Point(500, 19)
            };

            GenerateFrequents_Button = new Button()
            {
                Size = new Size(284, 40),
                Location = new Point(500, 411),
                BackColor= ColorTranslator.FromHtml("#4D6082"),
                ForeColor=Color.White,
                Text= "Generate Frequents"
            };

            Transaction_String_Label = new Label()
            {
                Text = "Transactions (String)",
                AutoSize=false,
                Size=new Size(150,20),
                Location = new Point(40, 2)
            };

            Transaction_ItemSet_Label = new Label()
            {
                Text = "Transactions (ItemSet)",
                AutoSize = false,
                Size = new Size(150, 20),
                Location = new Point(240, 2)
            };

            DistinctItem_Item_Label = new Label()
            {
                Text = "Distinct Item (Item)",
                AutoSize = false,
                Size = new Size(150, 20),
                Location = new Point(400, 2)
            };

            FrequentItem_Item_Label = new Label()
            {
                Text = "Candidate/Frequent (Item)",
                AutoSize = false,
                Size = new Size(150, 20),
                Location = new Point(580, 2)
            };

            AddSupport_Label = new Label()
            {
                Text = "Support",
                AutoSize = false,
                Size = new Size(150, 20),
                Location = new Point(400, 435)
            };

            this.MinimumSize = new Size(800, 490);
            this.MaximumSize = new Size(800, 490);
            this.MaximizeBox = false;
            this.Text = "Apriori Alorithm";
            this.BackColor = ColorTranslator.FromHtml("#E6E7E8");
            this.BackColor = ColorTranslator.FromHtml("#FFF29D");
        }

        void AddControls()
        {
            this.Controls.Add(Transaction_String_ListBox);
            this.Controls.Add(Transaction_ItemSet_ListBox);
            this.Controls.Add(DistinctItems_Item_ListBox);
            this.Controls.Add(AddTransaction_TextBox);
            this.Controls.Add(AddSupport_TextBox);
            this.Controls.Add(AddTransaction_Button);
            this.Controls.Add(GenerateFrequents_Button);
            this.Controls.Add(FrequentItems_Item_ListBox);
            this.Controls.Add(Transaction_String_Label);
            this.Controls.Add(Transaction_ItemSet_Label);
            this.Controls.Add(DistinctItem_Item_Label);
            this.Controls.Add(FrequentItem_Item_Label);
            this.Controls.Add(AddSupport_Label);
        }


        void AddEvents()
        {
            AddTransaction_Button.Click += new EventHandler(AddTransactionStringToListViewTransaction);
            GenerateFrequents_Button.Click += new EventHandler(AddFrequentItemsToListViewFrequentItems);
            AddTransaction_TextBox.KeyDown += new KeyEventHandler(AddTransactionStringToListViewTransaction);
        }
        void Adobe()
        {
            DeclareControls();
            ApplyStyle();
            AddEvents();
            AddControls();
        }
    }
}