using Class_Library;
using System.Text.RegularExpressions;
namespace Assignment_4_csharp
{
    public partial class Form1 : Form
    {
        
       
       
        
        public void AddingStatus(bool type)
        {
            //changing app to add mode, disabling some buttons and enabling some others.
            resettingStatus();
            if (type)
            {

                btnAddNewProducts.Enabled = true;
                txtProductsPrice.Enabled = true;
                txtProductsName.Enabled = true;
                rtbProductsDescription.Enabled = true;
                btnDeleteProducts.Enabled = false;
                btnUpdateProducts.Enabled = false;
            }
            else
            {
           
                btnSaveNewProcedures.Enabled = true;
                txtMinutes.Enabled = true;
                txtProcedurePrice.Enabled = true;
                rtbProcedureDescription.Enabled = true;
                txtProcedureName.Enabled = true;
                btnUpdateProcedures.Enabled = false;
                btnDeleteProcedures.Enabled = false;
            }
            addStatus = true;
            editStatus = false;
        }

        private bool editStatus = false, addStatus = false;
        private Procedures _currentProduct = null;
        public void StartingStatus()
        {
            clear();
            //Initial mode for the app.
            resettingStatus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            int selectedIndex = listBoxItems.SelectedIndex;
            if(selectedIndex == -1)
            {
                StartingStatus();
                return;
            }
            ShowItemBySelectedIndex(selectedIndex);
            ShowingItemsInListBox();
        }

        private void ShowingItemsInListBox()
        {
            listBoxItems.Items.Clear();
            List<Procedures> procedures = _procedureManager.GetAllItems();
            foreach (Procedures procedure in procedures)
            {
                listBoxItems.Items.Add(procedure);
                listBoxItems.DisplayMember = "name";
            }
        }
        public void resettingStatus()
        {
            //resetting all fields.
            groupBoxProducts.Enabled = true;
            groupBoxProcedures.Enabled = true;
            listBoxItems.Enabled = true;
            btnAddNewProducts.Enabled = true;
            btnSaveNewProcedures.Enabled = true;
            btnDeleteProducts.Enabled = false;
            btnDeleteProcedures.Enabled = false;
            btnUpdateProcedures.Enabled = false;
            btnUpdateProducts.Enabled = false;
            txtProductsName.Enabled = true;
            txtProcedureName.Enabled = true;
        }
        private void btnDeleteProcedures_Click(object sender, EventArgs e)
        {
            clear();
            if (_currentProduct == null)
            {
                SetErrorMessage("No active  Procedure, Please  select or create a new one");
                return;
            }
            _procedureManager.DeleteItem(_currentProduct);
            ShowingItemsInListBox();
            StartingStatus();
            SetInfoMessage("Item deleted successfully");
        }   
        private void ShowItemBySelectedIndex(int selectedIndex)
        {
            Procedures? selectedProcedure = listBoxItems.Items[selectedIndex] as Procedures;
            if (selectedProcedure != null)
            {
                listBoxItems.Items.Clear();
                _currentProduct = _procedureManager.GetProductByName(selectedProcedure.name);
                if(selectedProcedure.minutes == 0)
                {
                    txtProductsName.Text = selectedProcedure.name;
                    txtProductsPrice.Text = selectedProcedure.price.ToString();
                    string[] noteContent = _currentProduct.description.Split(";");
                    foreach(string note in noteContent)
                    {
                        rtbProductsDescription.Text += note + "\n";
                    }
                    editingStatus(true);
                }
                else
                {
                    txtProcedureName.Text = selectedProcedure.name;
                    txtProcedurePrice.Text = selectedProcedure.price.ToString();
                    txtMinutes.Text = selectedProcedure.minutes.ToString();
                    string[] noteContent = _currentProduct.description.Split(";");
                    foreach(String note in noteContent)
                    {
                        rtbProcedureDescription.Text += note + "\n";
                    }
                    editingStatus(false);
                }
            }

        }
        private void SetInfoMessage(string info)
        {
            WarningLabel.ForeColor = Color.Green;
            WarningLabel.Text = info;
        }

        public void editingStatus(bool type)
        {
            //changing app to edit mode, disabling some buttons and enabling some others.
            resettingStatus();
            if (type)
            {
                btnAddNewProducts.Enabled = false;
                txtProductsPrice.Enabled = true;
                txtProductsName.Enabled = false;
                rtbProductsDescription.Enabled = true;
                btnUpdateProducts.Enabled = true;
                btnDeleteProducts.Enabled = true;
                btnSaveNewProcedures.Enabled = false;
            }
            else
            {
                btnAddNewProducts.Enabled = false;
                btnSaveNewProcedures.Enabled = false;
                txtMinutes.Enabled = true;
                txtProcedurePrice.Enabled = true;
                rtbProcedureDescription.Enabled = true;
                txtProcedureName.Enabled = false;
                btnUpdateProcedures.Enabled = true;
                btnDeleteProcedures.Enabled = true;
            }
            addStatus = false;
            editStatus = true;
        }
        private void HandleAddOrEdit(bool type)
        {
            if(_currentProduct == null)
            {
                SetErrorMessage("No active Product or Procedure, please select or create a new Product/Procedure");
                return;
            }
            string error = "";

            if (type)
            {
                if (string.IsNullOrEmpty(txtProductsName.Text))
                {
                    error += "Product Name cannot be empty \n";
                }
                if (string.IsNullOrEmpty(txtProductsPrice.Text) || txtProductsPrice.Text == "0" || !Microsoft.VisualBasic.Information.IsNumeric(txtProductsPrice.Text))
                {
                    error += "Product Price cannot be empty or 0 and it must be a digit";
                }
                if (error == "")
                {
                    _currentProduct.name = txtProductsName.Text;
                    _currentProduct.price = double.Parse(txtProductsPrice.Text);
                    string fullDescriptionWithLineBreaks = Regex.Replace(rtbProductsDescription.Text, @"\r\n?|\n", ";");
                    _currentProduct.description = fullDescriptionWithLineBreaks;
                    _currentProduct.minutes = 0;
                    if (addStatus)
                    {
                        _procedureManager.AddNewItem(_currentProduct);
                        listBoxItems.Items.Add(_currentProduct);
                        int currCount = listBoxItems.Items.Count;
                        listBoxItems.SelectedIndex = currCount - 1;
                        ShowingItemsInListBox();
                        editingStatus(true);
                        SetInfoMessage("New product was added.");
                    }
                    else if(editStatus)
                    {
                        _procedureManager.UpdateItem(_currentProduct);
                        ShowingItemsInListBox();
                        SetInfoMessage("Product was updated");
                    }

                }
                else
                {
                    SetErrorMessage(error);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtProcedureName.Text))
                {
                    error += "Procedure Name cannot be empty \n";
                }
                if(string.IsNullOrEmpty(txtProcedurePrice.Text) || txtProcedurePrice.Text == "0" || !Microsoft.VisualBasic.Information.IsNumeric(txtProcedurePrice.Text))
                {
                    error += "Procedure Price cannot be empty or 0 and it must be a digit";
                }
                if (string.IsNullOrEmpty(txtMinutes.Text) || txtMinutes.Text == "0" || !Microsoft.VisualBasic.Information.IsNumeric(txtMinutes.Text))
                {
                    error += "Procedure Minute cannot be empty or 0 and it must be a digit";
                }
                if(error == "")
                {
                    _currentProduct.name = txtProcedureName.Text;
                    _currentProduct.price = double.Parse(txtProcedurePrice.Text);
                    string fullDescriptionWithLineBreaks = Regex.Replace(rtbProcedureDescription.Text, @"\r\n?|\n", ";");
                    _currentProduct.description = fullDescriptionWithLineBreaks;
                    _currentProduct.minutes = int.Parse(txtMinutes.Text);
                    if (addStatus)
                    {
                        _procedureManager.AddNewItem(_currentProduct);
                        listBoxItems.Items.Add(_currentProduct);
                        int currCount = listBoxItems.Items.Count;
                        listBoxItems.SelectedIndex = currCount - 1;
                        ShowingItemsInListBox();
                        editingStatus(true);
                        SetInfoMessage("New procedure was added.");
                    }
                    else if (editStatus)
                    {
                        _procedureManager.UpdateItem(_currentProduct);
                        ShowingItemsInListBox();
                        SetInfoMessage("Procedure was updated");
                    }
                }
                else
                {
                    SetErrorMessage(error);
                }
            }
        }
        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            HandleAddOrEdit(true);
            clear();
        }

        private void btnUpdateProcedures_Click(object sender, EventArgs e)
        {
            HandleAddOrEdit(false);
            clear();
        }  
        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            clear();
            if(_currentProduct == null)
            {
                SetErrorMessage("No active  Product, Please  select or create a new one");
                return;
            }
            _procedureManager.DeleteItem(_currentProduct);
            ShowingItemsInListBox();
            StartingStatus();
            SetInfoMessage("Item deleted successfully");
        }

        private stockItemManager _procedureManager = new stockItemManager();



        private void SetErrorMessage(string error)
        {
            WarningLabel.ForeColor = Color.Red;
            WarningLabel.Text = error;
        }

        public void clear()
        {
            //clearing all fields.
            txtMinutes.Text = "";
            txtProcedurePrice.Text = "";
            txtProcedureName.Text = "";
            txtProductsName.Text = "";
            txtProductsPrice.Text = "";
            rtbProcedureDescription.Text = "";
            rtbProductsDescription.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            StartingStatus();
            ShowingItemsInListBox();
        }
        private void btnAddNewProducts_Click(object sender, EventArgs e)
        {
      
            AddingStatus(true);
            _currentProduct = new Procedures();
            HandleAddOrEdit(true);
            editingStatus(true);

            clear();
        }

        private void btnSaveNewProcedures_Click(object sender, EventArgs e)
        {

            AddingStatus(false);
            _currentProduct = new Procedures();
            HandleAddOrEdit(false);
            editingStatus(false);


            clear();
        }


    }
}