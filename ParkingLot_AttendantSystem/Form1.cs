using System;
using System.Windows.Forms;

namespace ITS3100_ParkingApp3
{
    public partial class mainForm : Form
    {
        #region const strings

        const string newCustomerTitle = "Find Customer Parking";
        const string searchCustomerTitle = "Search Customer Records";
        const string removeCustomerTitle = "Remove Customer Records";
        const string parkingLotStatusTitle = "Parking Lot Status";
        const string newCustomerError = "Error! \r\n\r\n" +
        "The Fullname must be between 3 and 25 characters\r\n" +
        "The License Plate must be between 1 and 8 characters";
        #endregion

        public mainForm()
        {
            InitializeComponent();
        }

        #region Main Menu

        private void mnuLogoff_Click(object sender, EventArgs e)
        {
            main_Panel.Visible = false;
            hidePanels();
            mnuStatus.Visible = false;
            mnuTestCases.Visible = false;
        }

        private void mnuAttendant_Click(object sender, EventArgs e)
        {
            main_Panel.Visible = true;
            mnuStatus.Visible = true;
            mnuTestCases.Visible = false;
        }

        private void mnuTester_Click(object sender, EventArgs e)
        {
            main_Panel.Visible = true;
            mnuStatus.Visible = true;
            mnuTestCases.Visible = true;
        }

        private void mnuStatus_Click(object sender, EventArgs e)
        {
            string result = ParkingLot.parkingLotStatus();
            MessageBox.Show(result, parkingLotStatusTitle);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mnuClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        #endregion

        #region Main Panel

        private void showPanel(Panel p)
        {
            hidePanels();
            p.Visible = true;
        }

        private void hidePanels()
        {
            newCustomer_Panel.Visible = false;
            searchCustomer_Panel.Visible = false;
            removeCustomer_Panel.Visible = false;
        }

        private void new_Button_Click(object sender, EventArgs e)
        {
            showPanel(newCustomer_Panel);
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            showPanel(searchCustomer_Panel);
        }

        private void remove_Button_Click(object sender, EventArgs e)
        {
            showPanel(removeCustomer_Panel);
        }
        #endregion

        #region Other Panel
        
        private void findParking_Button_Click(object sender, EventArgs e)
        {
            // Validation - Fullname between 3 and 25 characters &
            // Validation - License Plate between 1 and 8 characters
            if (newFullname_TBox.Text.Trim().Length > 2 && newFullname_TBox.Text.Trim().Length < 26 &&
            newLicensePlate_TBox.Text.Trim().Length > 0 && newLicensePlate_TBox.Text.Trim().Length < 9)
            {
                MessageBox.Show(ParkingLot.findParking(newFullname_TBox.Text, newLicensePlate_TBox.Text), newCustomerTitle);
                newFullname_TBox.Text = "";
                newLicensePlate_TBox.Text = "";
            }
            else
            {
                MessageBox.Show(newCustomerError, newCustomerTitle);
            }
            newFullname_TBox.Focus();
        }
        
        private void searchPanel_Button_Click(object sender, EventArgs e)
        {
            string result = "";
            if (searchFullname_RButton.Checked == true)
            {
                result = ParkingLot.findCustomer(1, search_TBox.Text);
            }
            if (searchLicensePlate_RButton.Checked == true)
            {
                result = ParkingLot.findCustomer(2, search_TBox.Text);
            }
            if (searchParkingSpace_RButton.Checked == true)
            {
                result = ParkingLot.findCustomer(3, search_TBox.Text);
            }
            MessageBox.Show(result, searchCustomerTitle);
        }

        private void removePanel_Button_Click(object sender, EventArgs e)
        {
            string result = "";
            if (removeFullname_RButton.Checked == true)
            {
                result = ParkingLot.removeCustomer(1, remove_TBox.Text);
            }
            if (removeLicensePlate_RButton.Checked == true)
            {
                result = ParkingLot.removeCustomer(2, remove_TBox.Text);
            }
            if (removeParkingSpace_RButton.Checked == true)
            {
                result = ParkingLot.removeCustomer(3, remove_TBox.Text);
            }
            MessageBox.Show(result, removeCustomerTitle);
        }


        #endregion

        #region TextBox Search & Remove Length

        private void searchTBLength(object sender, EventArgs e)
        {
            search_TBox.Text = "";
            if (searchFullname_RButton.Checked == true) search_TBox.MaxLength = 25;
            if (searchLicensePlate_RButton.Checked == true) search_TBox.MaxLength = 8;
            if (searchParkingSpace_RButton.Checked == true) search_TBox.MaxLength = 4;
        }

        private void removeTBLength(object sender, EventArgs e)
        {
            remove_TBox.Text = "";
            if (removeFullname_RButton.Checked == true) remove_TBox.MaxLength = 25;
            if (removeLicensePlate_RButton.Checked == true) remove_TBox.MaxLength = 8;
            if (removeParkingSpace_RButton.Checked == true) remove_TBox.MaxLength = 4;
        }
        #endregion

        #region Test Cases

        private void mnuTestNameNull_Click(object sender, EventArgs e)
        {
            string result = Customer.testCustomerNameNull();
            MessageBox.Show(result, "Test: Customer Name is Null");
        }

        private void mnuTestNameShort_Click(object sender, EventArgs e)
        {
            string result = Customer.testCustomerNameShort();
            MessageBox.Show(result, "Test: Customer Name is Short");
        }

        private void mnuTestNameLong_Click(object sender, EventArgs e)
        {
            string result = Customer.testCustomerNameLong();
            MessageBox.Show(result,"Test: Customer Name is Long");
        }

        private void mnuTestPlateNull_Click(object sender, EventArgs e)
        {
            string result = Customer.testCustomerPlateNull();
            MessageBox.Show(result, "Test: Customer Plate is Null");
        }

        private void mnuTestPlateShort_Click(object sender, EventArgs e)
        {
            string result = Customer.testCustomerPlateShort();
            MessageBox.Show(result, "Test: Customer Plate is Short");
        }

        private void mnuTestPlateLong_Click(object sender, EventArgs e)
        {
            string result = Customer.testCustomerPlateLong();
            MessageBox.Show(result, "Test: Customer Plate is Long");
        }

        private void mnuParkingLotFull_Click(object sender, EventArgs e)
        {
            string result = ParkingLot.testParkingLotFull();
            MessageBox.Show(result, "Test: Parking Lot is Full");
        }

        private void mnuTestParkingLotEmpty_Click(object sender, EventArgs e)
        {
            string result = ParkingLot.testParkingLotEmpty();
            MessageBox.Show(result, "Test: Parking Lot is Empty");
        }

        private void mnuTestParkingLotAssign_Click(object sender, EventArgs e)
        {
            Random randomX = new Random();
            string[] rNames = new string[26] {
                "Alpha", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India",
                "Juliett", "Kilo", "Lima", "Mike", "November", "Oscar", "Papa", "Quebec", "Romeo",
                "Sierra", "Tango", "Uniform", "Victor", "Whiskey", "Xray", "Yankee", "Zulu" };
            string[] rPlates = new string[5] { "ABC 123", "Go Fast", "New Car", "Valet", "Royalty" };
            string cName = string.Format(rNames[randomX.Next(26)] + " " + rNames[randomX.Next(26)]);
            while (cName.Length > 25) {
                cName = string.Format(rNames[randomX.Next(26)] + " " + rNames[randomX.Next(26)]);
            }
            string result = ParkingLot.findParking(cName, rPlates[randomX.Next(5)]);
            MessageBox.Show(result, "Test: Customer Assigned to Parking Lot");
        }

        private void mnuTestParkingLotRemove_Click(object sender, EventArgs e)
        {
            string result = "";
            result += ParkingLot.findParking("Richard Adams", "XYZ789");
            result += "\r\n" + ParkingLot.removeCustomer(1, "Richard Adams");
            MessageBox.Show(result, "Test: Customer Removed from Parking Lot");
        }

        #endregion

    }
}
