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
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace PathfinderLootGenerator
{
    public partial class Form1 : Form
    {
        //Create lists for every items tier
        List<ExcelData> excelDataListTierOne = new List<ExcelData>();
        List<ExcelData> excelDataListTierTwo = new List<ExcelData>();
        List<ExcelData> excelDataListTierThree = new List<ExcelData>();

        //Create list for added buttons with item's groups for further deleting
        List<Button> buttonsAdded = new List<Button>();

        //Variables to check which tier is selected
        private bool isTierOne = false;
        private bool isTierTwo = false;
        private bool isTierThree = false;

        ItemDescriptionForm itemDescriptionForm = new ItemDescriptionForm();

        private readonly FormCollection formCollection = Application.OpenForms;
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            itemDescriptionForm.Location = new Point(this.Right + 10, this.Top);
        }

        //Strip menu load button
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening dialog window for selecting Excel file
            using (OpenFileDialog excelFile = new OpenFileDialog() { Filter= "Excel Workbook|*.xlsx;*.xls", ValidateNames=true})
            {
                if (excelFile.ShowDialog() == DialogResult.OK)
                {
                    //If file loaded correctly show buttons and change info label
                    tierOneButton.Enabled = tierTwoButton.Enabled = tierThreeButton.Enabled = true;
                    infoLabel.Text = "Items loaded";
                    infoLabel.ForeColor = Color.Green;

                    //Taking Excel file exact path
                    string filePath = excelFile.FileName;
                    //Connection string for Excel files
                    string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0 Xml;HDR=YES';";

                    //Using OleDB to connect with Excel datasheet
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        //Selects for desires sheets in Excel file
                        connection.Open();
                        string selectTierOne = "SELECT * FROM [Tier 1$]";
                        string selectTierTwo = "SELECT * FROM [Tier 2$]";
                        string selectTierThree = "SELECT * FROM [Tier 3$]";

                        //Gathering data from first Excel sheet (tier 1)
                        using (OleDbCommand command = new OleDbCommand(selectTierOne, connection))
                        {
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {                               
                                while (reader.Read())
                                {
                                    // Create an instance of ExcelData for each row
                                    ExcelData excelData = new ExcelData
                                    {
                                        Number = reader["Number"].ToString(),
                                        Name = reader["Name"].ToString(),
                                        Weapon = reader["Weapon"].ToString(),
                                        Groups = reader["Groups"].ToString(),
                                        Description = reader["Description"].ToString(),
                                        Other = reader["Comments"].ToString(),
                                        Visual = reader["Appearance"].ToString(),
                                        
                                    };
                                    // Add the ExcelData object to the list
                                    excelDataListTierOne.Add(excelData);
                                }                                
                            }
                        }
                        //Gathering data from second Excel sheet (tier 2)
                        using (OleDbCommand command = new OleDbCommand(selectTierTwo, connection))
                        {
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Create an instance of ExcelData for each row
                                    ExcelData excelData = new ExcelData
                                    {
                                        Number = reader["Number"].ToString(),
                                        Name = reader["Name"].ToString(),
                                        Weapon = reader["Weapon"].ToString(),
                                        Groups = reader["Groups"].ToString(),
                                        Description = reader["Description"].ToString(),
                                        Other = reader["Comments"].ToString(),
                                        Visual = reader["Appearance"].ToString(),
                                    };
                                    // Add the ExcelData object to the list
                                    excelDataListTierTwo.Add(excelData);
                                }
                            }
                        }

                        //Gathering data from third Excel sheet (tier 3)
                        using (OleDbCommand command = new OleDbCommand(selectTierThree, connection))
                        {
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Create an instance of ExcelData for each row
                                    ExcelData excelData = new ExcelData
                                    {
                                        Number = reader["Number"].ToString(),
                                        Name = reader["Name"].ToString(),
                                        Weapon = reader["Weapon"].ToString(),
                                        Groups = reader["Groups"].ToString(),
                                        Description = reader["Description"].ToString(),
                                        Other = reader["Comments"].ToString(),
                                        Visual = reader["Appearance"].ToString(),
                                    };
                                    // Add the ExcelData object to the list
                                    excelDataListTierThree.Add(excelData);
                                }
                            }
                        }
                    }
                }
            }
        }

        //Tier 1 button handling
        private void tierOneButton_Click(object sender, EventArgs e)
        {
            //Setting that we are in tier 1
            isTierOne = true;
            //Clearing list from unnecessary items            
            itemsListBox.Items.Clear();
            if (excelDataListTierOne != null && excelDataListTierOne.Count > 0)
            {
                //If data sended correctly for the first tier of items hide buttons and change info text for next step
                tierOneButton.Visible = tierTwoButton.Visible = tierThreeButton.Visible = false;
                infoLabel.Text = "Items to roll: " + excelDataListTierOne.Count;
                itemsListBox.Visible = true;

                itemDescriptionForm.Show();
                //Fill comboBox with items
                foreach (var excelData in excelDataListTierOne)
                {
                    itemsListBox.Items.Add($"{excelData.Number}, {excelData.Name}, {excelData.Weapon}");                   
                }
            }
                
        }

        //Tier 2 button handling
        private void tierTwoButton_Click(object sender, EventArgs e)
        {
            //Setting that we are in tier 2
            isTierTwo = true;
            //Clearing list from unnecessary items
            itemsListBox.Items.Clear();
            if (excelDataListTierTwo != null && excelDataListTierTwo.Count > 0)
            {
                //If data sended correctly for the second tier of items hide buttons and change info text for next step
                tierOneButton.Visible = tierTwoButton.Visible = tierThreeButton.Visible = false;
                infoLabel.Text = "Items to roll: " + excelDataListTierTwo.Count;
                itemsListBox.Visible = true;

                itemDescriptionForm.Show();
                //Fill comboBox with items
                foreach (var excelData in excelDataListTierTwo)
                {
                    itemsListBox.Items.Add($"{excelData.Number}, {excelData.Name}, {excelData.Weapon}");
                }
            }
        }

        //Tier 3 button handling
        private void tierThreeButton_Click(object sender, EventArgs e)
        {
            //Setting that we are in tier 3
            isTierThree = true;
            //Clearing list from unnecessary items
            itemsListBox.Items.Clear();
            if (excelDataListTierThree != null && excelDataListTierThree.Count > 0)
            {
                //If data sended correctly for the third tier of items hide buttons and change info text for next step
                tierOneButton.Visible = tierTwoButton.Visible = tierThreeButton.Visible = false;
                infoLabel.Text = "Items to roll: " + excelDataListTierThree.Count;
                itemsListBox.Visible = true;

                itemDescriptionForm.Show();
                //Fill comboBox with items
                foreach (var excelData in excelDataListTierThree)
                {
                    itemsListBox.Items.Add($"{excelData.Number}, {excelData.Name}, {excelData.Weapon}");
                }
            }

        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I selected item is correct
            if (itemsListBox.SelectedItem != null)
            {
                //Select rolled item and take only its number and check if it is a weapon
                var rolledItem = itemsListBox.Text;
                var rolledItemIndex = Regex.Match(rolledItem, @"(\d+)");
                var isWeapon = Regex.Match(rolledItem, @"(.$)").ToString();
                
                //Create button instance and adding it to group for further deleting
                ButtonsDelete groupButtonsDelete = new ButtonsDelete();
                groupButtonsDelete.GroupButtonsDelete(buttonsAdded);
                ExcelData result = null;


                if (isWeapon == "Y")
                {
                    if (isTierOne)
                    {
                        //Assigning excel data for specific item to result variable
                        result = excelDataListTierOne.Find(item => item.Number == rolledItemIndex.Value);

                        //Checking if Groups column is not empty
                        if (!string.IsNullOrWhiteSpace(result.Groups))
                        {
                            //Assigning item groups to array variable
                            string[] itemGroups = result.Groups.Split('/');

                            //Creating new buttons, assigning text, name and method / setting starting location and adjusting for larger amount of buttons
                            int top = 200;
                            int left = 100;
                            for (int i = 0; i < itemGroups.Count(); i++)
                            {
                                if (i > 4 && i % 6 == 0)
                                {
                                    top = 330;
                                    left = 100;
                                }
                                Button button = new Button();
                                button.Left = left;
                                button.Top = top;
                                button.Height = 120;
                                button.Width = 165;
                                button.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);                                
                                button.Text = itemGroups[i].ToString();
                                button.Name = itemGroups[i].ToString();
                                this.Controls.Add(button);
                                left += button.Width + 10;
                                buttonsAdded.Add(button);
                                button.Click += delegate { ButtonGroup_click(sender, e, button.Name, buttonsAdded, result); }; 
                            }
                        }


                    }
                    else if (isTierTwo)
                    {
                        result = excelDataListTierTwo.Find(item => item.Number == rolledItemIndex.Value);

                        if (!string.IsNullOrWhiteSpace(result.Groups))
                        {
                            string[] itemGroups = result.Groups.Split('/');

                            int top = 200;
                            int left = 100;
                            int height = 120;
                            int width = 165;
                            if (itemGroups.Count() > 6)
                            {
                                width = 130;
                            }
                            for (int i = 0; i < itemGroups.Count(); i++)
                            {
                                if (i > 4 && i % 6 == 0)
                                {
                                    top = 330;
                                    left = 100;
                                }

                                Button button = new Button();
                                button.Left = left;
                                button.Top = top;
                                button.Height = height;
                                button.Width = width;
                                button.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                                button.Text = itemGroups[i].ToString();
                                button.Name = itemGroups[i].ToString();
                                this.Controls.Add(button);
                                left += button.Width + 10;
                                buttonsAdded.Add(button);
                                button.Click += delegate { ButtonGroup_click(sender, e, button.Name, buttonsAdded, result); };
                            }
                        }
                    }
                    else if (isTierThree)
                    {
                        result = excelDataListTierThree.Find(item => item.Number == rolledItemIndex.Value);

                        if (!string.IsNullOrWhiteSpace(result.Groups))
                        {
                            string[] itemGroups = result.Groups.Split('/');

                            int top = 200;
                            int left = 100;
                            int height = 120;
                            int width = 165;
                            if (itemGroups.Count() > 6)
                            {
                                width = 130;
                            }                            
                            for (int i = 0; i < itemGroups.Count(); i++)
                            {
                                if (i > 4 && i % 6 == 0)
                                {
                                    top = 330;
                                    left = 100;
                                }

                                Button button = new Button();
                                button.Left = left;
                                button.Top = top;
                                button.Height = height;
                                button.Width = width;
                                button.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                                button.Text = itemGroups[i].ToString();
                                button.Name = itemGroups[i].ToString();
                                this.Controls.Add(button);
                                left += button.Width + 10;
                                buttonsAdded.Add(button);
                                button.Click += delegate { ButtonGroup_click(sender, e, button.Name, buttonsAdded, result); }; 
                            }
                        }
                    }
                } 
                else if(isWeapon == "N")
                {
                    //If item is not a weapon skip creating buttong and write description into rich text box
                    result = excelDataListTierOne.Find(item => item.Number == rolledItemIndex.Value);
                    ButtonItem_click(null, EventArgs.Empty, result, null);
                }
              
            }
        }

        void ButtonGroup_click(object sender, EventArgs e, string groupName, List<Button> buttonsAdded, ExcelData rolledItem)
        {
            
            ButtonsDelete groupButtonsDelete = new ButtonsDelete();
            groupButtonsDelete.GroupButtonsDelete(buttonsAdded);
            string itemHandWielding = "";

            if (groupName != null)
            {
                string[] itemWielding = groupName.Split('.', (char)StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    //Check which Handed weapon it is?
                    itemHandWielding = itemWielding[1];
                }
                catch
                {                    
                    //do nothing, those items are not weapons
                }

                if (itemHandWielding == "1H" && itemWielding != null)
                {
                    string weaponsToRoll = "";
                    OneHandedItemsDescriptions oneHandedItemsDescriptions = new OneHandedItemsDescriptions();
                    weaponsToRoll = oneHandedItemsDescriptions.OneHandedItemsDescription(itemWielding[0]);
                    string[] weaponsToRollArray = weaponsToRoll.Split('.');

                    int top = 200;
                    int left = 100;
                    int height = 120;
                    int width = 165;
                    if (weaponsToRollArray.Count() > 6)
                    {
                        width = 130;
                    }
                    if (weaponsToRollArray.Count() > 11)
                    {
                        height = 100;
                    }

                    for (int i = 0; i < weaponsToRollArray.Count(); i++)
                    {
                        if (i > 4 && i % 6 == 0)
                        {
                            top = 330;
                            left = 100;                            
                        } 
                        if (i > 11 && i % 6 == 0)
                        {
                            top = 450;
                            left = 100;
                        }

                        Button button = new Button();
                        button.Left = left;
                        button.Top = top;
                        button.Height = height;
                        button.Width = width;
                        button.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                        button.Text = weaponsToRollArray[i].ToString();
                        button.Name = weaponsToRollArray[i].ToString();
                        button.Click += delegate { ButtonItem_click(sender, e, rolledItem, button.Name); };
                        this.Controls.Add(button);
                        left += button.Width + 10;
                        buttonsAdded.Add(button);                        
                    }

                }
                if (itemHandWielding == "2H" && itemWielding != null)
                {
                    string weaponsToRoll = "";
                    TwoHandedItemsDescriptions twoHandedItemsDescriptions = new TwoHandedItemsDescriptions();
                    weaponsToRoll = twoHandedItemsDescriptions.TwoHandenItemsDescription(itemWielding[0]);
                    string[] weaponsToRollArray = weaponsToRoll.Split('.');

                    int top = 200;
                    int left = 100;
                    int height = 120;
                    int width = 165;
                    if (weaponsToRollArray.Count() > 6)
                    {
                        width = 130;
                    }
                    if (weaponsToRollArray.Count() > 11)
                    {
                        height = 100;
                    }

                    for (int i = 0; i < weaponsToRollArray.Count(); i++)
                    {
                        if (i > 4 && i % 6 == 0)
                        {
                            top = 330;
                            left = 100;
                        }
                        if (i > 11 && i % 6 == 0)
                        {
                            top = 450;
                            left = 100;
                        }

                        Button button = new Button();
                        button.Left = left;
                        button.Top = top;
                        button.Height = height;
                        button.Width = width;
                        button.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
                        button.Text = weaponsToRollArray[i].ToString();
                        button.Name = weaponsToRollArray[i].ToString();
                        button.Click += delegate { ButtonItem_click(sender, e, rolledItem, button.Name); };
                        this.Controls.Add(button);
                        left += button.Width + 10;
                        buttonsAdded.Add(button);
                    }

                }
            }
        }
        //Adding item name and description to second form with rich text boxes for futher coping and using
        void ButtonItem_click(object sender, EventArgs e, ExcelData rolledItem, string weaponName)
        {   
            //Adding item description form to list to check if it's oppened or not
            var openedForms = Application.OpenForms.OfType<ItemDescriptionForm>().ToList();
            //Instance of ItemDescriptionForm
            ItemDescriptionForm itemDescriptionForm = null;

            if (openedForms.Count == 0)
            {
                itemDescriptionForm = new ItemDescriptionForm();
                //If the ItemDescriptionForm is close set it to null (release resources)
                itemDescriptionForm.FormClosed += (s, args) => { itemDescriptionForm = null; };
                //Open window form and set its starting location
                itemDescriptionForm.Show();
                itemDescriptionForm.Location = new Point(this.Right + 10, this.Top);
            }
            else
            {
                //Adding oppened form to itemDescriptionForm variable
                itemDescriptionForm = openedForms.First();
            }

            if (itemDescriptionForm != null)
            {
                //adding space before weapon name so it looks nicer when listed with non weapon items
                weaponName = " " + weaponName;
                //Clearing text box from previous item description, setting location and filling with item name and description
                itemDescriptionForm.itemDescriptionRichBox.Clear();
                itemDescriptionForm.Location = new Point(this.Right + 10, this.Top);

                if (isTierOne)
                {
                    itemDescriptionForm.itemDescriptionRichBox.SelectionColor = Color.ForestGreen;
                }
                else if (isTierTwo)
                {
                    itemDescriptionForm.itemDescriptionRichBox.SelectionColor = Color.RoyalBlue;
                }
                else if (isTierThree)
                {
                    itemDescriptionForm.itemDescriptionRichBox.SelectionColor = Color.Crimson;
                }

                itemDescriptionForm.itemDescriptionRichBox.AppendText(weaponName + " " + rolledItem.Name + " ");
                itemDescriptionForm.itemDescriptionRichBox.SelectionColor = Color.Black;
                itemDescriptionForm.itemDescriptionRichBox.AppendText(rolledItem.Description);
            }
        }
        //Button that goes back to tier choosing step / reset tier choice / clear buttons
        private void backToTiersButton_Click(object sender, EventArgs e)
        {
            tierOneButton.Visible = tierTwoButton.Visible = tierThreeButton.Visible = true;      
            isTierOne = isTierTwo = isTierThree = false;
            itemsListBox.Visible = false;
            ButtonsDelete buttonsDelete = new ButtonsDelete();
            buttonsDelete.GroupButtonsDelete(buttonsAdded);
        }
    }
}
