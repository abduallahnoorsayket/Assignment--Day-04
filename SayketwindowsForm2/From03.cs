
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayketwindowsForm2
{
    public partial class From03 : Form
    {
       


        List<string> names = new List<string> { };


        List<string> contacts = new List<string> { };
        List<string> addresss = new List<string> { };
        List<string> quantitys = new List<string> { };
        List<string> orders = new List<string> { };

        int i;


        public From03()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < contacts.Count(); i++)
            {
                richTextBox.Text += "\n\n\tCustomer Name :" + names[i] + "\n\n";
                richTextBox.Text += "\tContact No :" + contacts[i] + "\n\n";
                richTextBox.Text += "\tAddress :" + addresss[i] + "\n\n";


                if (orders[i] == "Black-120")
                {
                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 120;

                    richTextBox.Text += "\tOrder:Black\n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    //richTextBox.Text += "\tPrice per Unit :" + 120 + "\n\n";
                }

                else if (orders[i] == "Cold-100")
                {


                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 100;

                    richTextBox.Text += "\tOrder: Cold \n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    // richTextBox.Text += "\tPrice per Unit :" + 100 + "\n\n";

                }

                else if (orders[i] == "Hot-90")
                {


                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 90;
                    richTextBox.Text += "\tOrder: Hot \n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    // richTextBox.Text += "\tPrice per Unit :" + 90 + "\n\n";

                }


                else if (orders[i] == "Regular-80")
                {


                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 80;
                    richTextBox.Text += "\tOrder: Regular\n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    //richTextBox.Text += "\tPrice per Unit :" + 80 + "\n\n";

                }

                else
                {
                    richTextBox.Text += "\tPlease Select an Item ";
                }



                richTextBox.Text += "\tQuantity :" + quantitys[i] + "\n\n";



                nameTextBox.Text = "";
                contactNoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";




            }



        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Please enter Quantity!");
                return;
            }
            else if (String.IsNullOrEmpty(orderComboBox.Text))
            {

                MessageBox.Show("Please  select an item!");
                return;
                
            }

            else
            {
                Addinfo(nameTextBox.Text, contactNoTextBox.Text, addressTextBox.Text, orderComboBox.Text, quantityTextBox.Text);
            }
           

            ShowInfo();
        }





            private void Addinfo(string name, string contact,string address, string order, string quantity )
        {



            names.Add(name);
            for (int i = 0; i < contacts.Count(); i++)
            {
                if (contact == contacts[i])
                {
                    MessageBox.Show("Contact no. already exists.");
                    return;
                }

            }


            contacts.Add(contact);
            addresss.Add(address);
            orders.Add(order);
            quantitys.Add(quantity);


        }


       
        private void ShowInfo()
        {
            
            for ( i = 0; i < contacts.Count(); i++)
            {
                richTextBox.Text = "";

                richTextBox.Text += "\n\n\tCustomer Name :" + names[i] + "\n\n";
                richTextBox.Text += "\tContact No :" + contacts[i] + "\n\n";
                richTextBox.Text += "\tAddress :" + addresss[i] + "\n\n";


                if (orders[i] == "Black-120")
                {
                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 120;

                    richTextBox.Text += "\tOrder:Black\n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    //richTextBox.Text += "\tPrice per Unit :" + 120 + "\n\n";
                }

                else if (orders[i] == "Cold-100")
                {


                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 100;

                    richTextBox.Text += "\tOrder: Cold \n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    // richTextBox.Text += "\tPrice per Unit :" + 100 + "\n\n";

                }

                else if (orders[i] == "Hot-90")
                {


                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 90;
                    richTextBox.Text += "\tOrder: Hot \n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    // richTextBox.Text += "\tPrice per Unit :" + 90 + "\n\n";

                }


                else if (orders[i] == "Regular-80")
                {


                    int price = Convert.ToInt32(quantitys[i]);
                    price = price * 80;
                    richTextBox.Text += "\tOrder: Regular\n\n";
                    richTextBox.Text += "\tTotal Price :" + price + "\n\n";
                    //richTextBox.Text += "\tPrice per Unit :" + 80 + "\n\n";

                }

                else
                {
                    richTextBox.Text += "\tPlease Select an Item ";
                }



                richTextBox.Text += "\tQuantity :" + quantitys[i] + "\n\n";



                nameTextBox.Text = "";
                contactNoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";



            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
        }






    }
}
