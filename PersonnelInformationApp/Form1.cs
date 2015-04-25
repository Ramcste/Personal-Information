using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelInformationApp
{
    public partial class Form1 : Form
    {
        private string firstName="";
        private string lastName = "";
        private string fathersName = "";
        private string mothersName = "";
        private string address = "";



        public Form1()
        {
            InitializeComponent();
        }

     

        private void saveInformationButton_Click(object sender, EventArgs e)
        {
     //  public  List <string, string, string, string, string> list = new List<string, string, string, string, string>(); 


            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;

       //     list.Add(firstName,lastName,fathersName,mothersName,address);

            MessageBox.Show("Your Information is Saved");

            Reset();

        }

        private void showAllInfromationButton_Click(object sender, EventArgs e)
        {

            //firstNameTextBox.Text = firstName;
            //lastNameTextBox.Text = lastName;
            //fathersNameTextBox.Text = fathersName;
            //mothersNameTextBox.Text = mothersName;
            //addressTextBox.Text = address;

            MessageBox.Show("\n Full Name is:" +firstName +" "+lastName
                             +"\n Parents Name :"
                             +"\n Fathers' Name:"+fathersName+
                             "\n Mother's name :"+mothersName+
                             "\n Address: "+address);



        }

        private void adressShowButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Address is: " + address);
          Reset();
        }

        private void nameShowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Full Name is: " + firstName+" "+lastName);
            Reset();
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nFathers Name: " +fathersName+
                            "\nMothers Name: " +mothersName );

            Reset();
        }

        private void Reset()
        {
           firstNameTextBox.Text="";
           lastNameTextBox.Text="";
           fathersNameTextBox.Text="";
           mothersNameTextBox.Text="";
           addressTextBox.Text="";



        }

        
    }
}
