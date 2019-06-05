using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment2_5212
{
    public partial class Form1 : Form
    {
        static List<Customer> CustomerDb = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
            LoadDb();
        }
        private void LoadDb()
        {
            CustomerDb.Add(new Customer("Jim", "Smith", "346-2514"));
            CustomerDb.Add(new Customer("Jo", "Baker", "346-1263"));
            CustomerDb.Add(new Customer("Aimee", "Ellery", "346-3658"));
            CustomerDb.Add(new Customer("Sam", "Herewini", "346-9898"));
        }
        public void Clearboxes()
        {
            txtFname.Text = "";
            txtFname.Clear();
            txtFname.Text = null;
            listBox1.Items.Clear();

        }
        public void ClearDisplay()
        {


        }
        public void DisplayCustomers()
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    public class Customer                               // this is a method
    {
        public string FName { get; set; }            // auto getters and setters
        public string LName { get; set; }
        public string Phone { get; set; }


        public Customer(string fn, string ln, string phone)
        {
            FName = fn;
            LName = ln;
            Phone = phone;

        }
        public string GetCustomer()
        {
            
            return FName + "\t" + LName + "\t" + Phone;                    // this part will return fname lastname etc back when it is called


        }

       


    }
    
}
