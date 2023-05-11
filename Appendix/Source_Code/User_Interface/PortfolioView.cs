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
using static System.Windows.Forms.ListView;

namespace IA_Implementation_1
    {
    public partial class PortfolioView : Form
        {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioView"/> class.
        /// </summary>
        public PortfolioView()
            {
            InitializeComponent();
            }

        private void PortfolioView_Load(object sender, EventArgs e)
            {

            }

        private void PortfolioView_FormClosing(object sender, FormClosingEventArgs e)
            {
            //Save Database
            Program.TheDatabase.Save();

            //Exit application if indicated
            Application.Exit();
            }

        private void newPortfolioButton_ToolStripMenuItem_Click(object sender, EventArgs e)
            {
            PortfolioSetupForm psf = new PortfolioSetupForm();
            DialogResult dr = psf.ShowDialog(this);
            if (dr == DialogResult.Cancel)
                {
                return;
                }

            //If command has been given to create a new portfolio
            //Get the account information from dialog box
            AccountInfo ai = psf.GetAccountInfo();

            //Add account to db
            Program.TheDatabase.AddAccount(ai);

            //Update account list box
            this.reloadPortfolioListBox();
            }

        /// <summary>
        /// Adds the account to List View.
        /// </summary>
        /// <param name="ai">The account information.</param>
        private void addAccountToListView(AccountInfo ai)
            {
            //this.PortfolioList_listView.Items.Add(ai.Name, ai.Identifier.ToString());
            this.portfolioList_listBox.Items.Add(ai);
            }

        private void PortfolioView_Shown(object sender, EventArgs e)
            {
            //Refresh list box
            this.reloadPortfolioListBox();

            //Select first portfolio (if it exists)
            if(this.portfolioList_listBox.Items.Count > 0)
                {
                this.portfolioList_listBox.SelectedItem = this.portfolioList_listBox.Items[0];
                }

            //The held view is displayed as default upon startup; make sure that 'held' button is green to reflect this
            this.heldButton_button.BackColor = Color.LightGreen;
            }

        /// <summary>
        /// Reloads the portfolio list box. - NEW METHOD
        /// </summary>
        private void reloadPortfolioListBox()
            {
            this.portfolioList_listBox.Items.Clear();
            foreach (AccountInfo ai in Program.TheDatabase.GetAccountInfos())
                {
                this.addAccountToListView(ai);//Add AccountInfo object to listbox
                }           
            }

        private void portfolioList_listBox_SelectedValueChanged(object sender, EventArgs e)
            {
            //Enable the 'sold' and 'held' buttons if a portfolio/account is selected
            if(this.portfolioList_listBox.SelectedItem == null)
                {
                this.heldButton_button.Enabled = false;
                this.soldButton_button.Enabled = false;
                this.accountPositionViewHeld_listView.Enabled = false;
                this.accountPositionViewSold_listView.Enabled = false;
                this.newPositionToolStripMenuItem.Enabled = false;
                }
            else
                {
                this.heldButton_button.Enabled = true;
                this.soldButton_button.Enabled = true;
                this.accountPositionViewHeld_listView.Enabled = true;
                this.accountPositionViewSold_listView.Enabled = true;
                this.newPositionToolStripMenuItem.Enabled = true;
                }

            //Populate the selected account with its positions
            this.RefreshPortfolioView();
            }

        /// <summary>
        /// Populates the held list view for a given selected account.
        /// </summary>
        /// <param name="ai">The account information.</param>
        private void populateHeldListView(AccountInfo ai)
            {
            //Format list view
            this.accountPositionViewHeld_listView.Items.Clear();
            bool green = true;

            //Get the positions of the given account (either held or sold, depending on user view option)
            List<PositionInfo> positions = Program.TheDatabase.GetHeldPositions(ai);

            //Populate list view with positions in account (ONLY held positions)
            double totalValue = 0;
            double totalCostBasis = 0;
            foreach (PositionInfo p in positions)
                {
                //Add to total stock value and bookcost of account
                totalValue += p.CurrentValue;
                totalCostBasis += p.CostBasis;

                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.Symbol;
                lvi.BackColor = green ? Color.LightGreen : Color.FromKnownColor(KnownColor.Window);//To create alternating pattern
                lvi.Tag = p.ID;

                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.Quantity.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.BuyPrice.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                //time = p.BuyDate.Equals(DateTime.Today) ? "(" + p.BuyDate.ToShortTimeString() + ")" : "";
                if (p.BuyDate.Date.Equals(DateTime.Today))
                    {
                    lvsi.Text = p.BuyDate.ToShortDateString() + " - " + p.BuyDate.ToShortTimeString();
                    }
                else
                    {
                    lvsi.Text = p.BuyDate.ToShortDateString();
                    }
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.CurrentPrice.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.CostBasis.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.CurrentValue.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                double change = p.CurrentValue - p.CostBasis;
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = change.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                this.accountPositionViewHeld_listView.Items.Add(lvi);
                green = !green;
                }

            //Display held portfolio summary
            double profitPercentage = this.getProfitPercentage(totalCostBasis, totalValue);
            this.totalStockValue_label.Text = "Total Value: " + totalValue.ToString("N2");
            this.costBasis_label.Text = "Cost Basis: " + totalCostBasis.ToString("N2");
            this.netProfitLoss_label.Text = "Net Gain: " + (totalValue - totalCostBasis).ToString("N2");
            this.netChange_label.Text = "% Gain: " + profitPercentage.ToString("N2") + "%";

            //Change colour of % gain label depending on profit or loss
            this.netChange_label.ForeColor = Color.Black;
            if (profitPercentage > 0)
                {
                this.netChange_label.ForeColor = Color.Green;
                }
            else if(profitPercentage < 0)
                {
                this.netChange_label.ForeColor = Color.Red;
                }
            }

        /// <summary>
        /// Populates the sold list view for a given selected account.
        /// </summary>
        /// <param name="ai">The account information.</param>
        private void populateSoldListView(AccountInfo ai)
            {
            //Format list view
            this.accountPositionViewSold_listView.Items.Clear();
            bool green = true;

            //Get the positions of the given account (either held or sold, depending on user view option)
            List<PositionInfo> positions = Program.TheDatabase.GetSoldPositions(ai);

            //Populate list view with positions in account (ONLY sold positions, with sold properties (eg. sell date, etc.))
            double sellValue = 0;
            double totalCostBasis = 0;
            foreach (PositionInfo p in positions)
                {
                //Add to total stock value and bookcost of account
                sellValue += p.SellValue;
                totalCostBasis += p.CostBasis;

                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.Symbol;
                lvi.BackColor = green ? Color.LightGreen : Color.FromKnownColor(KnownColor.Window);//To create alternating pattern
                lvi.Tag = p.ID;

                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.Quantity.ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                if (p.BuyDate.Date.Equals(DateTime.Today))
                    {
                    lvsi.Text = p.BuyDate.ToShortDateString() + " - " + p.BuyDate.ToShortTimeString();
                    }
                else
                    {
                    lvsi.Text = p.BuyDate.ToShortDateString();
                    }
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.BuyPrice.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                if (p.SellDate.Date.Equals(DateTime.Today))
                    {
                    lvsi.Text = p.SellDate.ToShortDateString() + " - " + p.SellDate.ToShortTimeString();
                    }
                else
                    {
                    lvsi.Text = p.SellDate.ToShortDateString();
                    }
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.SellPrice.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.CostBasis.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = p.SellValue.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                double change = p.SellValue - p.CostBasis;
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = change.ToString("N2");//Format string -> N2
                lvi.SubItems.Add(lvsi);

                this.accountPositionViewSold_listView.Items.Add(lvi);
                green = !green;
                }

            //Display sold portfolio summary
            double profitPercentage = this.getProfitPercentage(totalCostBasis, sellValue);
            this.totalValSold_label.Text = "Total Value: " + sellValue.ToString("N2");
            this.costBasis_sold_label.Text = "Cost Basis: " + totalCostBasis.ToString("N2");
            this.percentChange_sold_label.Text = "Net Gain: " + (sellValue - totalCostBasis).ToString("N2");
            this.netChange_sold_label.Text = "% Gain: " + profitPercentage.ToString("N2") + "%";

            //Change colour of % gain label depending on profit or loss
            this.netChange_sold_label.ForeColor = Color.Black;
            if (profitPercentage > 0)
                {
                this.netChange_sold_label.ForeColor = Color.Green;
                }
            else if (profitPercentage < 0)
                {
                this.netChange_sold_label.ForeColor = Color.Red;
                }
            }

        /// <summary>
        /// Gets the gain (percentage)
        /// </summary>
        /// <param name="before">The before.</param>
        /// <param name="after">The after.</param>
        /// <returns></returns>
        private double getProfitPercentage(double before, double after)
            {
            if(before == 0)//Handle special case
                {
                return 0;
                }
            return ((after - before) / before)*100;
            }

        private void newPositionToolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.purchaseNewPosition();
            this.RefreshPortfolioView();
            }

        private void purchaseNewPosition()
            {
            NewPositionPurchaseForm npp = new NewPositionPurchaseForm(this.getSelectedAccountInfo().Name);
            DialogResult dr = npp.ShowDialog(this);

            //If user cancels decision, return
            if (dr == DialogResult.Cancel)
                {
                return;
                }

            //Otherwise, gather information from dialog and send it to Database
            Program.TheDatabase.AddPosition(npp.PositionBuyParams);

            //Go to held view after purchase (in case the viewer was on sold view)
            this.heldButton_button_Click(this, new EventArgs());
            }

        /// <summary>
        /// Gets the selected account's information.
        /// </summary>
        /// <returns></returns>
        private AccountInfo getSelectedAccountInfo()
            {
            return (AccountInfo)this.portfolioList_listBox.SelectedItem;
            }

        /// <summary>
        /// Gets the selected position identifier.
        /// </summary>
        /// <param name="held">if set to <c>true</c> [held].</param>
        /// <returns></returns>
        private Guid getSelectedPositionId(bool held)
            {
            SelectedListViewItemCollection selected = held ? this.accountPositionViewHeld_listView.SelectedItems : this.accountPositionViewSold_listView.SelectedItems;
            if(selected.Count != 1)//Ensure that one position is selected; more than 1 position cannot be selected due to a property of the List View
                {
                //return empy guid
                return Guid.Empty;
                }

            return (Guid)selected[0].Tag;
            }

        private void soldButton_button_Click(object sender, EventArgs e)
            {
            //Make view of held positions invisible, and make view of sold positions visible
            this.accountPositionViewHeld_listView.Visible = false;
            this.accountPositionViewSold_listView.Visible = true;

            //Make view of held positions invisible, and make view of sold positions visible
            this.accountDetails_held_groupBox.Visible = false;
            this.accountDetails_sold_groupBox.Visible = true;

            //Colour button to indicate selection
            this.heldButton_button.BackColor = Control.DefaultBackColor;
            this.soldButton_button.BackColor = Color.LightGreen;
            }

        private void sellPositionToolStripMenuItem_Click(object sender, EventArgs e)
            {
            //Return if not viewing held positions
            if (!this.accountPositionViewHeld_listView.Visible)
                {
                MessageBox.Show("Please select a held position to sell.");
                return;
                }

            //Get the ID of the selected position--inform user (display dialog) and return if none selected
            Guid id = this.getSelectedPositionId(true);
            if(id == Guid.Empty)
                {
                MessageBox.Show("Please select a position to sell.");
                return;
                }

            //retrieve position info and selected account info
            PositionInfo pi = Program.TheDatabase.GetPosition(id, this.getSelectedAccountInfo());
            AccountInfo ai = this.getSelectedAccountInfo();

            //Display diaglog to user
            PositionSaleForm psf = new PositionSaleForm(pi);
            DialogResult dr = psf.ShowDialog(this);

            //If user cancels decision, return
            if (dr == DialogResult.Cancel)
                {
                return;
                }

            //Send request to sell position to Database
            Program.TheDatabase.SellPosition(ai, id, psf.NumberToSell, psf.SellPrice);

            //Update list view
            this.RefreshPortfolioView();                   
            }

        private void heldButton_button_Click(object sender, EventArgs e)
            {
            //Make view of sold positions invisible, and make view of held positions visible
            this.accountPositionViewHeld_listView.Visible = true;
            this.accountPositionViewSold_listView.Visible = false;

            //Make view of sold positions invisible, and make view of held positions visible
            this.accountDetails_held_groupBox.Visible = true;
            this.accountDetails_sold_groupBox.Visible = false;

            //Colour button to indicate selection
            this.soldButton_button.BackColor = Control.DefaultBackColor;
            this.heldButton_button.BackColor = Color.LightGreen;
            }

        private void refreshPrices_toolStripStatusLabel_Click(object sender, EventArgs e)
            {
            //Refreshes all references stock prices
            this.Cursor = Cursors.WaitCursor;
            try
                {
                //Refresh stock prices
                Program.TheDatabase.RefreshStockPrices();

                //Update account view
                this.RefreshPortfolioView();
                this.Cursor = Cursors.Default;
                }
            catch (Exception ex)
                {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Error: " + ex.Message);
                }          
            }

        private void RefreshPortfolioView()
            {
            AccountInfo ai = this.getSelectedAccountInfo();
            if(ai != null)
                {
                this.Cursor = Cursors.WaitCursor;
                this.populateHeldListView(this.getSelectedAccountInfo());
                this.populateSoldListView(this.getSelectedAccountInfo());
                this.populateGlobalSummary();
                this.Cursor = Cursors.Default;
                }
            }

        /// <summary>
        /// Updates the global summary.
        /// </summary>
        private void populateGlobalSummary()
            {
            //Gather totals
            double totalVal = 0;
            double totalCost = 0;
            List<PositionInfo> positions = null;
            List<AccountInfo> ais = Program.TheDatabase.GetAccountInfos();
            foreach(AccountInfo ai in ais)
                {
                positions = Program.TheDatabase.GetHeldPositions(ai);
                foreach(PositionInfo pi in positions)
                    {
                    totalCost += pi.CostBasis;
                    totalVal += pi.CurrentValue;
                    }
                }

            //Update the group-box display
            double profitPercentage = getProfitPercentage(totalCost, totalVal);//get % gain
            this.totalValue_label.Text = "Total Value: " + totalVal.ToString("N2");
            this.gain_label.Text = string.Format("Total Gain: {0:N2} ({1:N2}%)", 
                                                (totalVal - totalCost),
                                                profitPercentage);

            //Change colour of % gain label depending on profit or loss
            this.gain_label.ForeColor = Color.Black;
            if (profitPercentage > 0)
                {
                this.gain_label.ForeColor = Color.Green;
                }
            else if (profitPercentage < 0)
                {
                this.gain_label.ForeColor = Color.Red;
                }
            }

        private void refreshPrices_toolStripStatusLabel_MouseHover(object sender, EventArgs e)
            {
            this.refreshPrices_toolStripStatusLabel.BackColor = Color.Gray;
            }

        private void refreshPrices_toolStripStatusLabel_MouseLeave(object sender, EventArgs e)
            {
            this.refreshPrices_toolStripStatusLabel.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

        private void netChange_sold_label_Click(object sender, EventArgs e)
            {

            }

        private void exitButton_toolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void deletePosition_toolStripMenuItem_Click(object sender, EventArgs e)
            {          
            //Get selected position id--if none selected, inform user and return
            Guid id = this.getSelectedPositionId(this.accountPositionViewHeld_listView.Visible);
            if(id == Guid.Empty)
                {
                MessageBox.Show("Please select a position to delete.");
                return;
                }

            //Ask user for confirmation; return if cancelled
            string message = "Are you sure you'd like to delete position with symbol " + Program.TheDatabase.GetPosition(id, this.getSelectedAccountInfo()).Symbol + "?";
            string caption = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result != System.Windows.Forms.DialogResult.Yes)
                {
                return;
                }

            //delete position and refresh portfolio view
            Program.TheDatabase.DeletePosition(id, this.getSelectedAccountInfo());
            this.RefreshPortfolioView();
            }
        }
    }

