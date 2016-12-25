using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUlmartClient.MyUlmartServiceReference;

namespace MyUlmartClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void bFind_Click(object sender, EventArgs e)
        {
            MyUlmartServiceReference.MyUlmartServiceClient client = new MyUlmartServiceClient();
           
            MyProduct p = client.GetProductByKeyword(tbKeyword.Text);
            tbId.Text = p.Id.ToString();
            tbTitle.Text = p.Title;
            tbAuthor.Text = p.Author;
            tbPrice.Text = p.Price + " руб.";
            tbCountry.Text = p.Country;
        }
    }
}
