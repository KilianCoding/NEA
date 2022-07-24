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
        //private List<CheckoutItems> CheckoutList = new List<CheckoutItems>(); //A list of every item in "basket"


        decimal total = 0; //Using decimal allows me to add decimals without everything breaking

        public formTill()
        {
            InitializeComponent();
        }

        private void AddItemToList(object sender, EventArgs e)
        {
            Button btnPressed = sender as Button; //Sender is essentially just information about whatever has called the subroutine.
                                                  //In this case, only buttons can call the subroutine, so specifying as button doesn't make sense, but you could have multiple things running this subroutine,
                                                  //so you need to specify, so we would need to specify that the sender is for when a button calls the subroutine
            
            decimal price = 0; //A temporary,crude way of giving each item a price. Decimal allows me to add decimels without problems (doubles and floats bug out)

            switch ((btnPressed).Name) 
            {
                case "btnItem1":
                    price = 50.99M; //M is required when assigining a decimel, similarly to how f is required for a float in unity
                    break;
                case "btnItem2":
                    price = 8.99M;
                    break;
                case "btnItem3":
                    price = 24.99M;
                    break;
            }

            /*CheckoutItems temp = new CheckoutItems((btnPressed.Name).Remove(0,3),price); //gets the name of the button that ran the function, removes the first 3 characters (btn) and gives it a price
            CheckoutList.Add(temp); //Adds the item to the list*/


            dgvBasket.Rows.Add("ID", btnPressed.Name, price, "Remove"); //Adds a row in the grid
        _ = dgvColumnRemove.UseColumnTextForButtonValue; //Creates a button in the remove column with the text in that column, in this case, remove

            total = total + price;
            lblCurrentTotal.Text = ("Currrent total: £" + Convert.ToString(total)); //Keeps track of running total

        }
        private void dgvBasket_CellClicked(object sender, DataGridViewCellEventArgs e) //e is essentially all the information about datagridviewcell events
        {
            if (e.RowIndex >= 0 && dgvBasket.CurrentCell.Value.ToString() == "Remove") //Ensures you can't try to delete the top column, which causes an error and that you pressing the remove button, not just any cell
            {
                total = total - Convert.ToDecimal(dgvBasket.CurrentRow.Cells[2].Value); //Gets the value of the cell in the second column of this row (the price column)
                lblCurrentTotal.Text = ("Currrent total: £" + Convert.ToString(total)); 
                dgvBasket.Rows.RemoveAt(e.RowIndex); //e.RowIndex is the row which contains the button that has been pressed, removes this row
            }
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your total is £"+ total.ToString(), "Checkout");
        }

        private void formTill_Load(object sender, EventArgs e)
        {
             
        }

        private void btnTestDb_Click(object sender, EventArgs e)
        {
            DatabaseConnectivity DBcon = new DatabaseConnectivity(); //Creates insance of database class, runs a command
            DBcon.NewSale();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            Form form = new HomeForm();
            form.Show();
            this.Close();
        }
    }
        #endregion
}

    public class CheckoutItems //Class for adding items to the list
    {
        private string itemName;
        private decimal itemPrice;
        public CheckoutItems(string _itemName, decimal _itemPrice)
        {
            itemName = _itemName;
            itemPrice = _itemPrice; 
        }
      
    /* public string getsetItemName //Variables are private, so can only be accessed through getters and setters
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public float getsetItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }*/
    }


