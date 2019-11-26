using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMiniProject
{
    public partial class DisplaySearch : UserControl
    {
       
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

//        private static DisplaySearch _instance=null;
        private BindingSource bindingSource1 = new BindingSource();
        private databaseStoreProdMiniProject.dataBaseFunction DbFunction = new databaseStoreProdMiniProject.dataBaseFunction();
        private List<databaseStoreProdMiniProject.PersonObject> listPObject = new List<databaseStoreProdMiniProject.PersonObject>();
/*    
        public static DisplaySearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DisplaySearch();
                return _instance;
                
            }
        }*/
        public DisplaySearch()
        {
            InitializeComponent();
        }

        private int counter = 0;
        private void DisplaySearch_Load(object sender, EventArgs e)
        {
            while (counter < 4) {
                try
                {
                    listPObject = DbFunction.getAllData();
                    bindingSource1.DataSource = listPObject;
                    this.dataGridView1.DataSource = bindingSource1;

                    System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
                    timer1.Interval = 5000;
                    timer1.Tick += new EventHandler(timer_Tick);
                    timer1.Start();
                    break;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                    //logger.Error(ex.StackTrace);
                    counter++;
                    MessageBox.Show("Retry connection to database");


                }
              
                if (counter == 3) {
                    MessageBox.Show("Retry 3 times, no connection found");
                    counter = 0;
                    break;
                }

            }
           
           
        }

        private void timer_Tick(Object sender, EventArgs e) {
            listPObject = DbFunction.getAllData();
            bindingSource1.DataSource = listPObject;
            this.dataGridView1.DataSource = bindingSource1;
        }
          
       
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
    
}
