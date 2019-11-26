using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMiniProject
{
    public partial class miniProjectForm : Form
    {
        //DisplaySearch dUser = new DisplaySearch();
        //InsertUser iUser = new InsertUser();
        public miniProjectForm()
        {
            InitializeComponent();
            indicateSidePanel.Height = btnSearchUser.Height;
            indicateSidePanel.Top = btnSearchUser.Top;
            //iUser.Hide();
            // dUser.Show();
            // dUser.BringToFront();

            /*
            if (!mainPanel.Controls.Contains(DisplaySearch.Instance))
            {
                mainPanel.Controls.Add(DisplaySearch.Instance);
                DisplaySearch.Instance.Dock = DockStyle.Fill;
                DisplaySearch.Instance.BringToFront();
            }
            else
            {
                DisplaySearch.Instance.BringToFront();
            }*/

            this.displaySearch1.BringToFront();

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            indicateSidePanel.Height = btnSearchUser.Height;
            indicateSidePanel.Top = btnSearchUser.Top;
            // dUser.BringToFront();
            // iUser.Hide();
            //dUser.Show();
            /*
            if (!mainPanel.Controls.Contains(DisplaySearch.Instance))
            {
                mainPanel.Controls.Add(DisplaySearch.Instance);
                DisplaySearch.Instance.Dock = DockStyle.Fill;
                DisplaySearch.Instance.BringToFront();
            }
            else
            {
                DisplaySearch.Instance.BringToFront();
            }
            */
            this.displaySearch1.BringToFront();

        }

        private void btnInsertUser_Click(object sender, EventArgs e)
        {
            indicateSidePanel.Height = btnInsertUser.Height;
            indicateSidePanel.Top = btnInsertUser.Top;
            //iUser.BringToFront();
            //dUser.Hide();
            // iUser.Show();
       /*     if (!mainPanel.Controls.Contains(InsertUser.Instance))
            {
                mainPanel.Controls.Add(InsertUser.Instance);
                InsertUser.Instance.Dock = DockStyle.Fill;
                InsertUser.Instance.BringToFront();
            }
            else
            {
                InsertUser.Instance.BringToFront();
            }
            */
            this.insertUser1.BringToFront();
        }
    }
}
