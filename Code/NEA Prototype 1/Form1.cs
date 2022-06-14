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

        private void AddItemToList(object sender, EventArgs e)
        {
            float price = 0f; //A temporary way of giving each item a price. 
            switch ((sender as Button).Name) 
            {
                case "btnItem1":
                    price = 50.99f;
                    break;
                case "btnItem2":
                    price = 8.99f;
                    break;
                case "btnItem3":
                    price = 24.99f;
                    break;
            }
            CheckoutItems temp = new CheckoutItems(((sender as Button).Name).Remove(0,3), price); //gets the name of the button that ran the function, removes the first 3 characters (btn) and gives it a price
            CheckoutList.Add(temp); //Adds the item to the list

            Label lbl = new Label(); //Creates a label with the name and price of the item, placing it into a panel
            lbl.Name = temp.getsetItemName; //Using a panel allows you to scroll through the list without moving the whole window
            lbl.Text = temp.getsetItemName + (" £") + temp.getsetItemPrice.ToString();
            lbl.Location = new Point(0, yPos); 
            panelBasket.Controls.Add(lbl); //Adds the label the basket panel

            dgvBasket.Rows.Add("ID", (sender as Button).Name, price, "count", "Remove");
            _ = dgvColumnRemove.UseColumnTextForButtonValue;

            yPos += 20; //By incrementing by 20 yPos, the next item will be placed below the previous
        }
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


