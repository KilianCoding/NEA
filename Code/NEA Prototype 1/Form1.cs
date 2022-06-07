using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Prototype_1
{
    //This region includes all functions related to the actual form, IE: pressing buttons, inputting text etc.
    #region Form functions 
    public partial class formTill : Form
    {
        private List<CheckoutItems> CheckoutList = new List<CheckoutItems>(); //A list of every item in "basket"
        int yPos = 0; //Used to control the Y position when adding a label to the panel 

        public formTill()
        {
            InitializeComponent();
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            CheckoutItems temp = new CheckoutItems("test label", .4f);
            CheckoutList.Add(temp); //Adds the item to the list

            Label lbl = new Label(); //Creates a label with the name and price of the item, placing it into a panel
            lbl.Name = temp.getsetItemName; //Using a panel allows you to scroll through the list whilst nto moving the whole window
            lbl.Text = temp.getsetItemName + (" £") + temp.getsetItemPrice.ToString();
            lbl.Location = new Point(0, yPos); 
            lbl.BringToFront();
            panel1.Controls.Add(lbl);

            yPos = yPos + 20; //By incrementing yPos, the next item will be placed below the previous
        }
        #endregion

    }
    
    public class CheckoutItems //Class for adding items to the list
    {
        private string itemName;
        private float itemPrice;
        public CheckoutItems(string _itemName, float _itemPrice)
        {
            itemName = _itemName;
            itemPrice = _itemPrice; 
        }
        public string getsetItemName //Variables are private, so can only be accessed through getters and setters
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public float getsetItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
    }
}

