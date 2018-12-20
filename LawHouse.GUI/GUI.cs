using LawHouse.BusinessLogic;
using LawHouse.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LawHouse.GUI
{
    public partial class GUI : Form
    {
        // int currentEmployeeID;
        int currentEmployeeID;
        public GUI()
        {
            InitializeComponent();
            Set_ComboBox_Overview();
            Set_ComboBox_ServiceType_CreateCase();
            Set_TabControl_Overview_Pages();
            Set_ComboBox_Client_CreateCase();
            Set_ComboBox_Case_Service();
            Set_ComboBox_Employee_CreateService();
            Set_ComboBox_ServiceType_CreateEmployee();
             SetObjectListView_Overview();

        }

        #region Set Controls
        private void SetObjectListView_Overview()//Daniella
        {
            string selectedServiceType = (string)comboBox_Overview.SelectedItem;
            ObjectListView_Overview_HideAllColums();
            switch (selectedServiceType)
            {
                case "Klient":
                    objectListView_Overview.SetObjects(Controller.GetAllClients());
                    olvColumn_ClientID.IsVisible = true;
                    olvColumn_ClientName.IsVisible = true;
                    olvColumn_ClientAdress.IsVisible = true;
                    olvColumn_ClientPhoneNumber.IsVisible = true;


                    break;
                case "Sag":
                    objectListView_Overview.SetObjects(Controller.GetAllSag());
                    List<Case> cases = objectListView_Overview.Objects.Cast<Case>().ToList();
                    List<Case> doneCases = cases.Where(c => c.EndDate != default(DateTime)).ToList();
                    olvColumn_CaseEndDate.IsVisible = true;
                    objectListView_Overview.DisableObjects(doneCases);
                    olvColumn_CaseID.IsVisible = true;
                    olvColumn_CaseTitle.IsVisible = true;
                    olvColumn_CaseStartDate.IsVisible = true;
                    olvColumn_CaseEndDate.IsVisible = true;
                    olvColumn_CaseEstimatedHours.IsVisible = true;
                    olvColumn_CaseDescription.IsVisible = true;
                    olvColumn_CaseNotes.IsVisible = true;
                    olvColumn_CaseID.IsVisible = true;
                    olvColumn_CaseEmployeeID.IsVisible = true;
                    olvColumn_ServiceTypeID.IsVisible = true;
                   
                    break;
                case "Advokat":
                    objectListView_Overview.SetObjects(Controller.GetAllAdvokat());
                    olvColumn_EmployeeID.IsVisible = true;
                    olvColumn_EmployeeName.IsVisible = true;
                    break;
                case "Ydelse":
                    objectListView_Overview.SetObjects(Controller.GetAllServices());
                    olvColumn_ServiceID.IsVisible = true;
                    olvColumn_ServiceStartDate.IsVisible = true;
                    olvColumn_ServiceDescription.IsVisible = true;
                    olvColumn_ServicePrice.IsVisible = true;
                    olvColumn_ServiceHours.IsVisible = true;
                    olvColumn_ServiceID.IsVisible = true;
                    olvColumn_ServiceEmployeeID.IsVisible = true;
                    break;
            }
            objectListView_Overview.RebuildColumns();
        }

        private void ObjectListView_Overview_HideAllColums()//Julius
        {
            foreach (var item in objectListView_Overview.AllColumns)
            {
                item.IsVisible = false;
            }
        }

        private void Set_ComboBox_Overview()//Daniella
        {
            string[] entities = { "Sag", "Klient", "Advokat", "Ydelse" };
            comboBox_Overview.Items.AddRange(entities);
            comboBox_Overview.SelectedIndex = 0;
        }
        private void Set_ComboBox_ServiceType_CreateCase()//Daniella
        {
            comboBox_ServiceType_CreateCase.DataSource = Controller.GetAllServiceType();
            comboBox_ServiceType_CreateCase.DisplayMember = "Name";
            comboBox_ServiceType_CreateCase.ValueMember = "ID";
        }
        private void Set_ComboBox_Employee_CreateCase(int serviceTypeID)//Daniella
        {
            comboBox_Employee_CreateCase.DataSource = Controller.GetEmployeesFromServiceType(serviceTypeID);
            comboBox_Employee_CreateCase.DisplayMember = "Name";
            comboBox_Employee_CreateCase.ValueMember = "ID";
            comboBox_Employee_CreateCase.SelectedIndex = -1;
        }
        private void Set_ComboBox_Client_CreateCase()//Daniella
        {
            comboBox_Client_CreateCase.DataSource = Controller.GetAllClients();
            comboBox_Client_CreateCase.DisplayMember = "Name";
            comboBox_Client_CreateCase.ValueMember = "ID";
            comboBox_Client_CreateCase.SelectedIndex = -1;
        }

        private void Set_ComboBox_ServiceType_CreateEmployee()//Daniella
        {
            comboBox_ServiceType_CreateEmployee.DataSource = Controller.GetAllServiceType();
            comboBox_ServiceType_CreateEmployee.DisplayMember = "Name";
            comboBox_ServiceType_CreateEmployee.ValueMember = "ID";
        }
        private void Set_ComboBox_Case_Service()//Daniella
        {
            comboBox_Case_Create_Service.DataSource = Controller.GetAllSag();
            comboBox_Case_Create_Service.DisplayMember = "WorkTitle";
            comboBox_Case_Create_Service.ValueMember = "ID";
        }
        private void Set_ComboBox_Employee_CreateService()//Daniella
        {
            comboBox_Employee_Create_Service.DataSource = Controller.GetAllAdvokat();
            comboBox_Employee_Create_Service.DisplayMember = "Name";
            comboBox_Employee_Create_Service.ValueMember = "ID";
        }
        private void SetComboBox_ServiceType_CreateCase()//Daniella
        {
            comboBox_ServiceType_CreateCase.DataSource = Controller.GetAllServiceType();
            comboBox_ServiceType_CreateCase.DisplayMember = "Name";
            comboBox_ServiceType_CreateCase.ValueMember = "ID";
        }

      
   
   

      
        private void Set_TabControl_Overview_Pages()//Julius
        {
            List<string> tabsToHideAtStartup = new List<string>();
            tabsToHideAtStartup.Add("tabPage_CreateCase");
            tabsToHideAtStartup.Add("tabPage_CreateEmployee");
            tabsToHideAtStartup.Add("tabPage_CreateClient");
            tabsToHideAtStartup.Add("tabPage_CreateService");
            tabsToHideAtStartup.Add("tabpage_edit");
            hideTabs(tabsToHideAtStartup);
        }


        private void hideTabs(List<string> tabsToHide)//Julius
        {
            foreach (string tabKey in tabsToHide)
            {
                Side.TabPages.RemoveByKey(tabKey);
            }
        }

        #endregion

        #region Button_employee
        private void button_CreateEmployee_Click(object sender, EventArgs e)
        {
            currentEmployeeID = Controller.CreateAdvokat(textBox_EmployeeName.Text);
            comboBox_ServiceType_CreateEmployee.Enabled = true;
            listBox_EmployeeService_CreateEmployee.Enabled = true;
            button_AddEducation_CreateEmployee.Enabled = true;


        }
         private void button_AddSpeciality_CreateEmployee_Click(object sender, EventArgs e)
        {
            ServiceType selectedServiceType = comboBox_ServiceType_CreateEmployee.SelectedItem as ServiceType;
            if (listBox_EmployeeService_CreateEmployee.Items.Count > 0)
            {
                List<EmployeeService> employeeService_InListBox = listBox_EmployeeService_CreateEmployee.Items.Cast<EmployeeService>().ToList(); //linq
                if (!employeeService_InListBox.Any(employeeService => employeeService.ServiceID == selectedServiceType.ID))
                    Controller.AddEmployeeServiceToEmployee(currentEmployeeID, selectedServiceType.ID);
            }
            else
                Controller.AddEmployeeServiceToEmployee(currentEmployeeID, selectedServiceType.ID);
            Set_ListBox_EmployeeService_CreateEmployee();
            MessageBox.Show(" ");
            Side.TabPages.Remove(tabPage_CreateEmployee);
 
        }

        private void Set_ListBox_EmployeeService_CreateEmployee()
        {
            listBox_EmployeeService_CreateEmployee.DataSource = Controller.GetEmployeeServices(currentEmployeeID);
            listBox_EmployeeService_CreateEmployee.DisplayMember = "ServiceID";
        }

        private void button_Cancel_CreateEmployee_Click(object sender, EventArgs e)
        {
            Side.TabPages.Remove(Side.SelectedTab);
        }


        

        #endregion

        #region Button_case
        private void button_CreateCase_Click(object sender, EventArgs e)//Daniella
        {
            try
            {
                Client selectedClient = (Client)comboBox_Client_CreateCase.SelectedItem;
                Employee selectedEmployee = (Employee)comboBox_Employee_CreateCase.SelectedItem;
                ServiceType selectedService = (ServiceType)comboBox_ServiceType_CreateCase.SelectedItem;
                Controller.CreateCase(textBox_CaseTitle.Text, textbox_CaseStartDate.Text, default(DateTime), textbox_CaseKilometers.Text, textBox_CaseEstimatedHours.Text,
                    richTextBox_CaseDescription.Text, richTextBox_CaseNotes.Text, selectedClient.ID, selectedEmployee.ID, selectedService.ID);
                SetObjectListView_Overview();
                Side.TabPages.Remove(tabPage_CreateCase);
                 
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ikke alle er udfyldt, vend venligst tilbage");

            }
            //create case...

        }
        private void button_Cancel_CreateCase_Click(object sender, EventArgs e)
        {
            Side.TabPages.Remove(Side.SelectedTab);
        }
        #endregion

        #region Button_client
        private void button_CreateClient_Click(object sender, EventArgs e)//Thomas
        {
          //  try
          //  {
                string navn = textBox_ClientName.Text;
                string Adresse = textbox_ClientAdress.Text;
                string TelefonNr = textBox_ClientPhoneNumber.Text;
                Controller.CreateClient(navn, Adresse, TelefonNr);
                MessageBox.Show("Oprettet");
                textBox_ClientName.Clear();
                textbox_ClientAdress.Clear();
                textBox_ClientPhoneNumber.Clear();
       //     }
            //catch (Exception)
            //{
            //    MessageBox.Show("Ikke alt er valgt, gå venligst tilbage og indtast informatioen ");

            //}
            SetObjectListView_Overview();
            Side.TabPages.Remove(tabPage_CreateClient);
        }
        private void button_Finished_Click(object sender, EventArgs e)
        {
            SetObjectListView_Overview();
            Side.TabPages.Remove(tabPage_CreateEmployee);
        }
        private void button_Cancel_CreateClient_Click(object sender, EventArgs e)
        {
            Side.TabPages.Remove(Side.SelectedTab);
        }
        #endregion

        #region Button_service
        private void button_Cancel_CreateService_Click(object sender, EventArgs e)//Daniella
        {
            Side.TabPages.Remove(Side.SelectedTab);
        }
        private void button_AddService_Click(object sender, EventArgs e)//Daniella
        {
            Case selectedCase = (Case)comboBox_Case_Create_Service.SelectedItem;
            Employee selectedEmployee = (Employee)comboBox_Employee_Create_Service.SelectedItem;
            Controller.CreateService(textbox_ServiceStartDate.Text, textBox_ServiceDescription.Text, Convert.ToInt32(textBox_ServicePrice.Text), Convert.ToInt32(textBox_ServiceHours.Text),
                selectedCase.ID, selectedEmployee.ID);
            SetObjectListView_Overview();
            Side.TabPages.Remove(tabPage_CreateService);
        }
        #endregion

        #region Events
        private void comboBox_Overview_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetObjectListView_Overview();
        }
    

        private void button_AddNew_Click(object sender, EventArgs e)//Julius
        {
            TabPage toSwitchTo = null;
            string selectedServiceType = (string)comboBox_Overview.SelectedItem;
            switch (selectedServiceType)
            {
                case "Sag":
                    if (!Side.TabPages.Contains(tabPage_CreateCase))
                        Side.TabPages.Insert(Side.TabPages.Count, tabPage_CreateCase);
                    textbox_CaseStartDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    SetComboBox_ServiceType_CreateCase();

                    comboBox_Employee_CreateCase.DataSource = Controller.GetEmployeesFromServiceType(selectedServiceType.Length);


                    toSwitchTo = tabPage_CreateCase;
                    break;
                case "Advokat":
                    if (!Side.TabPages.Contains(tabPage_CreateEmployee))
                        Side.TabPages.Insert(Side.TabPages.Count, tabPage_CreateEmployee);
                    toSwitchTo = tabPage_CreateEmployee;
                    break;
                case "Klient":
                    if (!Side.TabPages.Contains(tabPage_CreateClient))
                        Side.TabPages.Insert(Side.TabPages.Count, tabPage_CreateClient);
                    toSwitchTo = tabPage_CreateClient;
                    break;
                case "Ydelse":
                    if (!Side.TabPages.Contains(tabPage_CreateService))
                        Side.TabPages.Insert(Side.TabPages.Count, tabPage_CreateService);
                    textbox_ServiceStartDate.Text = DateTime.Now.ToString("dd-MM-yyyy");

                    toSwitchTo = tabPage_CreateService;
                    break;

            }
            Side.SelectedTab = toSwitchTo;
        }


        private void comboBox_ServiceType_CreateCase_SelectedIndexChanged(object sender, EventArgs e) //Daniella
        {
            ServiceType selectedServiceType = (ServiceType)comboBox_ServiceType_CreateCase.SelectedItem;
            Set_ComboBox_Employee_CreateCase(selectedServiceType.ID);
        }
        private void button_Overview_SaveChanges_Click(object sender, EventArgs e)//Daniella & Thomas
        {
            foreach (object item in objectListView_Overview.Objects)
            {
                if (item is Case)
                {
                    Controller.UpdateCase(item);
                }
                else if (item is Employee)
                {
                    Controller.UpdateAdvokat(item);
                }
                else if (item is Client)
                {
                    Controller.UpdateClient(item);

                }
                else if (item is Service)
                {
                    Controller.UpdateYdelse(item);
                }
            }
        }
        #endregion

        #region button_Help
        //Julius
        private void button_Help_Overview_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=2Q_ZzBGPdqE");

        }
        private void button_Help_CreateCase_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
        private void button_Help_CreateEmployee_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
        private void button_Help_CreateClient_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
        private void button_Help_CreateService_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }



        #endregion

        private void objectListView_Overview_DoubleClick(object sender, EventArgs e)
        {

            
        }
    }
}
