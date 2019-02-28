using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoMasterDetailClassic : Office2007Form
    {
        #region Private variables

        private DataSet _DsCustomers;
        private Random _Rand = new Random();

        private string[] _ContactName = {"John Hancock", "Jane Doe", "Felix Unger",
            "Frank Columbo", "Sam Drucker", "Hank Kimbel", "Mr. Haney", "Leonard McCoy",
            "Boris Badenov", "Olive Oyl", "Mr. Peabody", "Gilbert Grape", "Johnny Quest" };

        private string[] _Companies = {
            "Arvind Mills", "Calipso Entertainment", "JumpBack Records",
            "Timeless Treasures", "Heatsinks Inc.", "Hamilton Paper", "Paradyne Inc.",
            "Marathon Oil", "L & R Moving", "Best Paper", "Wonka Vision"};

        #endregion

        public DemoMasterDetailClassic()
        {
            InitializeComponent();

            // Initialize the grid, bind to our grid data
            // and set the sample description text

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoMasterDetailClassic.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            // Initialize our DataSet and generate
            // some random, non-sensical data to display

            InitDataSet();

            GenerateCustomers();
            GenerateRelations();
            GenerateBindingSources();

            // Hook some data binding events in order to
            // customize the display a little bit

            sgCustomers.DataBindingStart += SgCustomersDataBindingStart;
            sgCustomers.DataBindingComplete += SgCustomersDataBindingComplete;

            sgContacts.DataBindingComplete += SgContactsDataBindingComplete;
            sgSites.DataBindingComplete += SgSitesDataBindingComplete;
            sgContracts.DataBindingComplete += SgContractsDataBindingComplete;
        }

        #region InitDataSet

        /// <summary>
        /// Creates and initializes our DataSet
        /// </summary>
        private void InitDataSet()
        {
            _DsCustomers = new DataSet();

            _DsCustomers.Tables.Add("Customers");
            _DsCustomers.Tables["Customers"].TableName = "Customers";
            _DsCustomers.Tables["Customers"].Columns.Add("CustomerID", typeof(Int32));
            _DsCustomers.Tables["Customers"].Columns.Add("CustomerName", typeof(string));
            _DsCustomers.Tables["Customers"].Columns.Add("Status", typeof(string));

            _DsCustomers.Tables.Add("Contacts");
            _DsCustomers.Tables["Contacts"].TableName = "Contacts";
            _DsCustomers.Tables["Contacts"].Columns.Add("ContactID", typeof(string));
            _DsCustomers.Tables["Contacts"].Columns.Add("CustomerID", typeof(Int32));
            _DsCustomers.Tables["Contacts"].Columns.Add("SiteID", typeof(string));
            _DsCustomers.Tables["Contacts"].Columns.Add("ContactName", typeof(string));
            _DsCustomers.Tables["Contacts"].Columns.Add("ContactEmail", typeof(string));

            _DsCustomers.Tables.Add("Sites");
            _DsCustomers.Tables["Sites"].TableName = "Sites";
            _DsCustomers.Tables["Sites"].Columns.Add("SiteID", typeof(string));
            _DsCustomers.Tables["Sites"].Columns.Add("CustomerID", typeof(Int32));
            _DsCustomers.Tables["Sites"].Columns.Add("SiteName", typeof(string));
            _DsCustomers.Tables["Sites"].Columns.Add("SiteAddress", typeof(string));
            _DsCustomers.Tables["Sites"].Columns.Add("SitePhone", typeof(string));

            _DsCustomers.Tables.Add("Contracts");
            _DsCustomers.Tables["Contracts"].TableName = "Contracts";
            _DsCustomers.Tables["Contracts"].Columns.Add("ContractID", typeof(string));
            _DsCustomers.Tables["Contracts"].Columns.Add("CustomerID", typeof(Int32));
            _DsCustomers.Tables["Contracts"].Columns.Add("ContractReference", typeof(string));
            _DsCustomers.Tables["Contracts"].Columns.Add("ContractTypeId", typeof(string));

            _DsCustomers.Tables.Add("Renewals");
            _DsCustomers.Tables["Renewals"].TableName = "Renewals";
            _DsCustomers.Tables["Renewals"].Columns.Add("RenewalID", typeof(string));
            _DsCustomers.Tables["Renewals"].Columns.Add("ContractID", typeof(string));
            _DsCustomers.Tables["Renewals"].Columns.Add("StartDate", typeof(DateTime));
            _DsCustomers.Tables["Renewals"].Columns.Add("EndDate", typeof(DateTime));
            _DsCustomers.Tables["Renewals"].Columns.Add("Cost", typeof(Int32));
        }

        #endregion

        #region GenerateCustomers

        /// <summary>
        /// Generates a random set of customers, contacts,
        /// sites, and contracts.
        /// </summary>
        private void GenerateCustomers()
        {
            for (int i = 0; i < _Companies.Length; i++)
            {
                int custId = i + 1;

                DataRow drow = _DsCustomers.Tables["Customers"].NewRow();
                drow["CustomerID"] = custId;
                drow["CustomerName"] = _Companies[i];
                drow["Status"] = (i % 3 == 0) ? "InActive" : "Active";

                _DsCustomers.Tables["Customers"].Rows.Add(drow);

                GenerateContacts(custId);
                GenerateSites(custId);
                GenerateContracts(custId);
            }
        }

        #region GenerateContacts

        /// <summary>
        /// Generates a random set of Contacts
        /// </summary>
        /// <param name="custId"></param>
        private void GenerateContacts(int custId)
        {
            BitArray ba = new BitArray(_ContactName.Length);

            int n = _Rand.Next(7, _ContactName.Length);

            for (int i = 0; i < n; i++)
            {
                int contactId = GetNextContact(ba);
                int companyId = (contactId % _Companies.Length);

                string contactName = _ContactName[contactId];
                string email = (contactName + "@" + _Companies[companyId] + ".com").Replace(" ", "");

                DataRow drow = _DsCustomers.Tables["Contacts"].NewRow();
                drow["ContactID"] = contactId;
                drow["CustomerID"] = custId;
                drow["SiteID"] = custId;
                drow["ContactName"] = contactName;
                drow["ContactEmail"] = email;

                _DsCustomers.Tables["Contacts"].Rows.Add(drow);
            }
        }

        #region GetNextContact

        /// <summary>
        /// Gets the next unused random contact
        /// </summary>
        /// <param name="ba"></param>
        /// <returns></returns>
        private int GetNextContact(BitArray ba)
        {
            int m = _Rand.Next(0, _ContactName.Length);

            while (ba[m] == true)
                m = _Rand.Next(0, _ContactName.Length);

            ba[m] = true;

            return (m);
        }

        #endregion

        #endregion

        #region GenerateSites

        /// <summary>
        /// Generates a random set of customer Sites
        /// </summary>
        /// <param name="custId"></param>
        private void GenerateSites(int custId)
        {
            int n = _Rand.Next(4, 12);

            for (int i = 0; i < n; i++)
            {
                int siteId = i + 1;

                DataRow drow = _DsCustomers.Tables["Sites"].NewRow();
                drow["SiteID"] = siteId;
                drow["CustomerID"] = custId;
                drow["SiteName"] = "Office Site " + siteId;

                if (_Rand.Next() % 4 != 0)
                    drow["SiteAddress"] = GetIpValue();

                _DsCustomers.Tables["Sites"].Rows.Add(drow);
            }
        }

        #region GetIpValue

        /// <summary>
        /// Creates a random, nonsensical IP Address
        /// solely for display purposes only
        /// </summary>
        /// <returns></returns>
        private string GetIpValue()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                sb.Append(_Rand.Next(0, 255));
                sb.Append('.');
            }

            sb.Length--;

            return (sb.ToString());
        }

        #endregion

        #endregion

        #region GenerateContracts

        /// <summary>
        /// Generates a random set of Customer Contracts
        /// and their associated Renewals
        /// </summary>
        /// <param name="custId"></param>
        private void GenerateContracts(int custId)
        {
            int n = _Rand.Next(7, 12);

            for (int i = 0; i < n; i++)
            {
                int contractId = (custId * 100) + i;

                DataRow drow = _DsCustomers.Tables["Contracts"].NewRow();
                drow["ContractID"] = contractId;
                drow["CustomerID"] = custId;
                drow["ContractReference"] = (i * 10) + "-" + ((i + 1) * 10 - 1);
                drow["ContractTypeID"] = _Rand.Next(100, 200);

                _DsCustomers.Tables["Contracts"].Rows.Add(drow);

                GenerateRenewals(contractId);
            }
        }

        #region GenerateRenewals

        /// <summary>
        /// Generates a random set of Contract Renewals
        /// </summary>
        /// <param name="contractId"></param>
        private void GenerateRenewals(int contractId)
        {
            int n = _Rand.Next(3, 5);

            for (int i = 0; i < n; i++)
            {
                int x = _Rand.Next(14, 90);

                DateTime sdate = DateTime.Now.AddDays(_Rand.Next(-100, 100));
                DateTime edate = DateTime.Now.AddDays(x);

                DataRow drow = _DsCustomers.Tables["Renewals"].NewRow();
                drow["RenewalID"] = sdate.DayOfYear;
                drow["ContractID"] = contractId;
                drow["StartDate"] = sdate;
                drow["EndDate"] = edate;
                drow["Cost"] = x * 250;

                _DsCustomers.Tables["Renewals"].Rows.Add(drow);
            }
        }

        #endregion

        #endregion

        #endregion

        #region GenerateRelations

        /// <summary>
        /// Generates the associated relations between
        /// the various elements of out DataSet data
        /// </summary>
        private void GenerateRelations()
        {
            _DsCustomers.Relations.Add("Contacts",
                _DsCustomers.Tables["Customers"].Columns["CustomerID"],
                _DsCustomers.Tables["Contacts"].Columns["CustomerID"], false);

            _DsCustomers.Relations.Add("Sites",
                _DsCustomers.Tables["Customers"].Columns["CustomerID"],
                _DsCustomers.Tables["Sites"].Columns["CustomerID"], false);

            _DsCustomers.Relations.Add("Contracts",
                _DsCustomers.Tables["Customers"].Columns["CustomerID"],
                _DsCustomers.Tables["Contracts"].Columns["CustomerID"], false);

            _DsCustomers.Relations.Add("Renewals",
                _DsCustomers.Tables["Contracts"].Columns["ContractID"],
                _DsCustomers.Tables["Renewals"].Columns["ContractID"], false);
        }

        #endregion

        #region GenerateBindingSources

        /// <summary>
        /// Generates, and assigns, the necessary BindingSources
        /// to support the separate grid Master/Detail configuration
        /// </summary>
        private void GenerateBindingSources()
        {
            BindingSource bsCustomers = new BindingSource(_DsCustomers, "Customers");
            sgCustomers.PrimaryGrid.DataSource = bsCustomers;

            BindingSource bsContacts = new BindingSource();
            bsContacts.DataSource = bsCustomers;
            bsContacts.DataMember = "Contacts";
            sgContacts.PrimaryGrid.DataSource = bsContacts;

            BindingSource bsSites = new BindingSource();
            bsSites.DataSource = bsCustomers;
            bsSites.DataMember = "Sites";
            sgSites.PrimaryGrid.DataSource = bsSites;

            BindingSource bsContracts = new BindingSource();
            bsContracts.DataSource = bsCustomers;
            bsContracts.DataMember = "Contracts";
            sgContracts.PrimaryGrid.DataSource = bsContracts;
        }

        #endregion

        #region SgCustomersDataBindingStart

        /// <summary>
        /// Handles the Customers DataBindingStart event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SgCustomersDataBindingStart(object sender, GridDataBindingStartEventArgs e)
        {
            // Tell the SuperGrid we don't want him to process any
            // discovered child relations for this grid - we want all
            // relational data to be displayed in separate SuperGrids

            if (e.TableName.Equals("Customers") == true)
                e.ProcessChildRelations = ProcessChildRelations.Never;
        }

        #endregion

        #region SgCustomersDataBindingComplete

        /// <summary>
        /// Handles the Customers DataBindingComplete event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SgCustomersDataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            // Change some layout display values

            e.GridPanel.Columns["CustomerName"].Width = 150;
            e.GridPanel.Columns["CustomerID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
            e.GridPanel.Columns["Status"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
        }

        #endregion

        #region SgContactsDataBindingComplete

        /// <summary>
        /// Handles the Contacts DataBindingComplete event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SgContactsDataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            // Change some layout display values

            e.GridPanel.Columns["ContactID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
            e.GridPanel.Columns["CustomerID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
            e.GridPanel.Columns["SiteID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;

            e.GridPanel.Columns["ContactName"].Width = 150;
            e.GridPanel.Columns["ContactEmail"].Width = 250;
        }

        #endregion

        #region SgSitesDataBindingComplete

        /// <summary>
        /// Handles the Sites DataBindingComplete event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SgSitesDataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            // Change some layout display values

            e.GridPanel.Columns["CustomerID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
            e.GridPanel.Columns["SiteID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
        }

        #endregion

        #region SgContractsDataBindingComplete

        /// <summary>
        /// Handles the Contracts DataBindingComplete event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SgContractsDataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            if (e.GridPanel.Name.Equals("Contracts"))
            {
                // Change some layout display values for the Contracts grid

                e.GridPanel.Columns["CustomerID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
                e.GridPanel.Columns["ContractReference"].CellStyles.Default.Alignment = Alignment.MiddleCenter;
                e.GridPanel.Columns["ContractTypeID"].CellStyles.Default.Alignment = Alignment.MiddleCenter;

                e.GridPanel.Columns["ContractReference"].Width = 150;
            }
            else
            {
                // Change some layout display values for the Renewals grid

                e.GridPanel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter;

                e.GridPanel.Columns["Cost"].EditorType = typeof(GridDoubleInputEditControl);

                GridDoubleInputEditControl gnu =
                    (GridDoubleInputEditControl)e.GridPanel.Columns["Cost"].RenderControl;

                gnu.DisplayFormat = "C";
            }
        }

        #endregion

        #endregion
    }
}