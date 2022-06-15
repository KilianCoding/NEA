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
            Button btnPressed = sender as Button; //Sender is essentially just whatever runs the subroutine. In this case, only buttons can run the subroutine so
                                                  //specifying doesn't make sense, but you could have multiple things running this subroutine, so you need to specify
            float price = 0f; //A temporary way of giving each item a price. 

            switch ((btnPressed).Name) 
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
            CheckoutItems temp = new CheckoutItems((btnPressed.Name).Remove(0,3), price); //gets the name of the button that ran the function, removes the first 3 characters (btn) and gives it a price
            CheckoutList.Add(temp); //Adds the item to the list

            /* Label lbl = new Label(); //Creates a label with the name and price of the item, placing it into a panel
            lbl.Name = temp.getsetItemName; //Using a panel allows you to scroll through the list without moving the whole window
            lbl.Text = temp.getsetItemName + (" £") + temp.getsetItemPrice.ToString();
            lbl.Location = new Point(0, yPos); 
            panelBasket.Controls.Add(lbl); //Adds the label the basket panel
            yPos += 20; //By incrementing by 20 yPos, the next item will be placed below the previous */

            dgvBasket.Rows.Add("ID", btnPressed.Name, price, "count", "Remove"); //Adds a row in the grid
            _ = dgvColumnRemove.UseColumnTextForButtonValue; //Creates a button in the remove column with the text in that column, in this case, remove
            
            
        }
        private void dgvBasket_CellClicked(object sender, DataGridViewCellEventArgs e) //e is essentially all the information about the dgvcell events
        {
            if (e.RowIndex >= 0)
            {
                dgvBasket.Rows.RemoveAt(e.RowIndex); //e.RowIndex is the row which contians the button that has been pressed, removes this row
            }
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


