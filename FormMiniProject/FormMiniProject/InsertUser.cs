using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using databaseStoreProdMiniProject;
using System.Diagnostics;

namespace FormMiniProject
{
    public partial class InsertUser : UserControl
    {
        public LoggingClass logClass = new LoggingClass();
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

//        private static InsertUser _instance;
        Boolean flag;
        Boolean hasError = true;
/*        public static InsertUser Instance
        {
            get
            { 
                if (_instance == null)
                    _instance = new InsertUser();
                return _instance;

            }
        }*/
        public InsertUser()
        {
            InitializeComponent();
        }
//insert btn
        private void btnInsert_Click(object sender, EventArgs e)
        {
            /*
            String allAddress = "";
            foreach (Control childAddress in getAllControl(this, typeof(TextBox)))
            {
                if (childAddress is TextBox && childAddress.Name.Contains("tbAddAddress"))
                {
                    Console.WriteLine("+++++++++" + childAddress.Text);
                    allAddress += ((TextBox)childAddress).Text + ",";
                }
            }
            MessageBox.Show("values : " + allAddress +",name = " + this.tbName.Text +",nric= "+ this.tbNRIC.Text);
            */


            String address = "";
            String email = "";
            if (this.tbAltAddress.Text != null)
                address = this.tbAddress.Text + "," + this.tbAltAddress.Text;
            else
                address = this.tbAddress.Text;

            if (this.tbAltEmail.Text != null)
                email = this.tbEmail.Text + "," + this.tbAltEmail.Text;
            else
                email = this.tbEmail.Text;

            if (hasError == false)
            {
                databaseStoreProdMiniProject.dataBaseFunction DbFunction = new databaseStoreProdMiniProject.dataBaseFunction();
                databaseStoreProdMiniProject.PersonObject pObject = new databaseStoreProdMiniProject.PersonObject();
                pObject.Name = this.tbName.Text;
                pObject.Nric = this.tbNRIC.Text;
                pObject.PhoneNo = Int32.Parse(this.tbPhoneNum.Text);
                pObject.Email = email;
                pObject.Address = address;
                pObject.DOB = this.datePickerDOB.Value.Date;


                try
                {
                    DbFunction.insertData(pObject);

                    clearTbLB();
                    MessageBox.Show("Inserted to object");
                }
                catch (Exception ex)
                {
                    logClass.LogMsgToFile(ex.ToString());
                    //logClass.LogMsgToFile("Stack Trace" + ex.StackTrace.ToString());
                    MessageBox.Show("Please check Input value. NRIC must not be inserted before.");
                    logger.Error(ex, "qwerty123");
                }


                    Util.objectList.Add(pObject);

                foreach (var i in Util.objectList)
                {
                    Console.WriteLine("value : " + i.ToString());

                }

                
            }
            else {
                MessageBox.Show("Please fill up the form correctly");
            }
            

        }
//clear btn        
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTbLB();
            
        }

        private void clearTbLB() {
            this.tbName.Clear();
            this.tbEmail.Clear();
            this.tbNRIC.Clear();
            this.tbAddress.Clear();
            this.tbAltAddress.Clear();
            this.tbAltEmail.Clear();
            this.tbPhoneNum.Clear();
            this.lbEmailvalidate.Text = "";
            this.lbNamevalidate.Text = "";
            this.lbNRICvalidate.Text = "";
            this.lbAddressvalidate.Text = "";
            this.lbPhoneNovalidate.Text = "";
        }
//Name
        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
//NRIC
        private void tbNRIC_TextChanged(object sender, EventArgs e)
        {
            flag = false;
            flag = ValidateInsertValue.isValidSgFin(this.tbNRIC.Text);
           
            if (flag == true)
            {
                lbNRICvalidate.Text = "Correct NRIC";
                hasError = false;
            }
            else
            {
                if (this.tbNRIC.Text != "") {
                    lbNRICvalidate.Text = "Wrong NRIC";
                }
                else {
                    lbNRICvalidate.Text = "";
                }
                hasError = true;

            }
            
        }
//DOB
        private void datePickerDOB_ValueChanged_1(object sender, EventArgs e)
        {
            /*DateTimePicker dtp = sender as DateTimePicker;
           DateTime today = DateTime.Today.Date;
           if (datePickerDOB.Value < today) {

           }*/
            datePickerDOB.MaxDate = DateTime.Now.Date;
        }
//phoneNo
        private void tbPhoneNum_TextChanged(object sender, EventArgs e)
        {
            flag = false;
            String phoneValue = this.tbPhoneNum.Text;
            flag = ValidateInsertValue.checkphoneNo(phoneValue);
            if (flag == true)
            {
                lbPhoneNovalidate.Text = "Correct";
                hasError = false;
            }
            else
            {
                if (this.tbPhoneNum.Text != "")
                {
                    lbPhoneNovalidate.Text = "Invalid Number";
                }
                else
                {
                    lbPhoneNovalidate.Text = "";
                }
                hasError = true;

            }
        }

//address
        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbAltAddress_TextChanged(object sender, EventArgs e)
        {

        }
       
//email
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            String emailValue = this.tbEmail.Text;
            flag = ValidateInsertValue.checkEmail(emailValue);
            if (flag == true)
            {
                lbEmailvalidate.Text = "Correct";
                hasError = false;
            }
            else
            {
                if (this.tbEmail.Text != "")
                {
                    lbEmailvalidate.Text = "Invalid Email";
                }
                else
                {
                    lbEmailvalidate.Text = "";
                }
                hasError = true;

            }

        }
        private void tbAltEmail_TextChanged(object sender, EventArgs e)
        {
            String emailValue = this.tbEmail.Text;
            flag = ValidateInsertValue.checkEmail(emailValue);
            if (flag == true)
            {
                lbAltEmailvalidate.Text = "Correct";
                hasError = false;
            }
            else
            {
                if (this.tbEmail.Text != "")
                {
                    lbAltEmailvalidate.Text = "Invalid Email";
                }
                else
                {
                    lbAltEmailvalidate.Text = "";
                }
                hasError = true;
            }
        }








        //ignore below here, for dynamic textbox
        public IEnumerable<Control> getAllControl(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAllControl(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        int countAddress = 0;
        int totalCountAddress = 2;
        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (countAddress < totalCountAddress) {
                int InsertedRowNum = 4;//Insert to the 3nd Row for example
                addRow(InsertedRowNum, addtbAddress(), delbtnAddress());
                countAddress++;
                
            }

           
        }

        int countEmail = 0;
        int totalCountEmail = 2;
        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            int countRow = tableMain.GetRow(lbEmail) + 1;
            
            if (countEmail < totalCountEmail)
            {
                addRow(countRow, addtbEmail(), delBtnEmail());
                countEmail++;
            }

            /*
            String[] s = new string[3];
            for (int i = 0; i < 3; i++) {
                s[i] = ((TextBox)tableMain.Controls["tbAddEmail" + (i + 1).ToString()]).Text;
                Console.WriteLine(tbAddEmail.Name +"andy"+ i+ "qwerty" + s[i]);
            }*/
            
            
        }

        

        public System.Windows.Forms.TextBox addtbAddress() {
            System.Windows.Forms.TextBox tbAddAddress = new System.Windows.Forms.TextBox();
            tbAddAddress.Width = 200;
            this.Controls.Add(tbAddAddress);
            tbAddAddress.Name = "tbAddAddress" + this.countAddress.ToString();
            //Console.WriteLine(btnAddAddress.Name + "12345" + btnAddAddress.Text);
            return tbAddAddress;
        }
        public System.Windows.Forms.TextBox addtbEmail()
        {
            System.Windows.Forms.TextBox tbAddEmail = new System.Windows.Forms.TextBox();
            tbAddEmail.Width = 200;
            this.Controls.Add(tbAddEmail);
            tbAddEmail.Name = "tbAddEmail" + this.countEmail.ToString();
            return tbAddEmail;
        }

        public System.Windows.Forms.Button delbtnAddress()
        {
            System.Windows.Forms.Button btnDelAddress = new System.Windows.Forms.Button();
            btnDelAddress.Text = "Del";
            this.Controls.Add(btnDelAddress);
            totalCountAddress++;
            return btnDelAddress;
        }
        /*
        void delBtn_click(object sender, EventArgs e)
        {
            tableMain.Controls.Add(delbtnAddress(), 2, InsertedRowNum);
            tableMain.Controls.Add(delBtnEmail(), 4, InsertedRowNum);
        }*/

        public System.Windows.Forms.Button delBtnEmail()
        {
            System.Windows.Forms.Button btnDelEmail = new System.Windows.Forms.Button();
            btnDelEmail.Text = "Del";
            this.Controls.Add(btnDelEmail);
            totalCountEmail++;
            return btnDelEmail;
        }



        private void addRow(int InsertedRowNum, TextBox addtb, Button addBtn ) {
           
            tableMain.AutoScroll = true;
            tableMain.Visible = false; //otherwise this control will repaint itself again and again
            //
            //Insert new RowStyles corresponding to new row
            //
            RowStyle NewRowStyle = new RowStyle();
            NewRowStyle.SizeType = SizeType.AutoSize;
            NewRowStyle.Height = 50;
            tableMain.RowStyles.Insert(InsertedRowNum, NewRowStyle);
            //
            //Increase row count
            //
            tableMain.RowCount++;
            //
            //Shift exist controls down
            //
            foreach (Control ExistControl in tableMain.Controls)
            {
                if (tableMain.GetRow(ExistControl) >= InsertedRowNum)
                {
                    tableMain.SetRow(ExistControl,
                                            tableMain.GetRow(ExistControl) + 1);
                }
            }

            //
            //Add new row of controls
            tableMain.Controls.Add(addtb, 2, InsertedRowNum);
            tableMain.Controls.Add(addBtn, 4, InsertedRowNum);
            /*
            for (int ColumnNum = 0; ColumnNum < tableMain.ColumnCount; ColumnNum++)
            {
                tableMain.Controls.Add(new CheckBox(), ColumnNum, InsertedRowNum);
            }*/
            tableMain.Visible = true;

        }

        private void tableMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
