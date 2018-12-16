﻿
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
        int currentEmployeeID;
        public GUI()
        {
            InitializeComponent();
            Set_ComboBox_Overview();
            Set_ComboBox_Category_CreateCase();
            Set_TabControl_Overview_Pages();
            Set_ComboBox_Client_CreateCase();
            Set_ComboBox_Education_CreateEmployee();
            Set_ComboBox_Case_Service();
            Set_ComboBox_Employee_CreateService();
            SetObjectListView_Overview();
        }

        #region Set Controls
        private void SetObjectListView_Overview()//Daniella
        {
            string selectedCategory = (string)comboBox_Overview.SelectedItem;
            ObjectListView_Overview_HideAllColums();
            switch (selectedCategory)
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
                    List<Case> doneCases = cases.Where(c =>  c.EndDate != default(DateTime)).ToList();
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

        private void ObjectListView_Overview_HideAllColums()//Daniella
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
        private void Set_ComboBox_Category_CreateCase()//Daniella
        {
            comboBox_Category_CreateCase.DataSource = Controller.GetAllCategory();
            comboBox_Category_CreateCase.DisplayMember = "Name";
            comboBox_Category_CreateCase.ValueMember = "ID";
        }
        private void Set_ComboBox_Employee_CreateCase(int categoryID)//Daniella
        {
            comboBox_Employee_CreateCase.DataSource = Controller.GetEmployeesFromCategory(categoryID);
            comboBox_Employee_CreateCase.DisplayMember = "Name";
            comboBox_Employee_CreateCase.ValueMember = "ID";
            comboBox_Employee_CreateCase.SelectedIndex = -1;
        }
        private void Set_ComboBox_Client_CreateCase( )//Daniella
        {
            comboBox_Client_CreateCase.DataSource = Controller.GetAllClients();
            comboBox_Client_CreateCase.DisplayMember = "Name";
            comboBox_Client_CreateCase.ValueMember = "ID";
            comboBox_Client_CreateCase.SelectedIndex = -1;
        }

        private void Set_ComboBox_Education_CreateEmployee()
        {
            comboBox_Education_CreateEmployee.DataSource = Controller.GetAllEducations();
            comboBox_Education_CreateEmployee.DisplayMember = "Name";
            comboBox_Education_CreateEmployee.ValueMember ="EmployeeID";
        }
        private void Set_ComboBox_Case_Service()
        {
            comboBox_Case_Create_Service.DataSource = Controller.GetAllSag();
            comboBox_Case_Create_Service.DisplayMember = "WorkTitle";
            comboBox_Case_Create_Service.ValueMember = "ID";
        }
        private void Set_ComboBox_Employee_CreateService()
        {
            comboBox_Employee_Create_Service.DataSource = Controller.GetAllAdvokat();
            comboBox_Employee_Create_Service.DisplayMember = "Name";
            comboBox_Employee_Create_Service.ValueMember = "ID";
        }
        private void SetComboBox_ServiceType_CreateCase()//Daniella
        {
            comboBox_Category_CreateCase.DataSource = Controller.GetAllCategory();
            comboBox_Category_CreateCase.DisplayMember = "Name";
            comboBox_Category_CreateCase.ValueMember = "ID";
        }

        private void Set_TabControl_Overview_Pages()//Julius
        {
            List<string> tabsToHideAtStartup = new List<string>();
            tabsToHideAtStartup.Add("tabPage_CreateCase");
            tabsToHideAtStartup.Add("tabPage_CreateEmployee");
            tabsToHideAtStartup.Add("tabPage_CreateClient");
            tabsToHideAtStartup.Add("tabPage_CreateService");
            hideTabs(tabsToHideAtStartup);
        }
  

        private void hideTabs(List<string> tabsToHide)
        {
            foreach (string tabKey in tabsToHide)
            {
                tabControl_Overview.TabPages.RemoveByKey(tabKey);
            }
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
            string selectedCategory = (string)comboBox_Overview.SelectedItem;
            switch (selectedCategory)
            {
                case "Sag":
                    if (!tabControl_Overview.TabPages.Contains(tabPage_CreateCase))
                        tabControl_Overview.TabPages.Insert(tabControl_Overview.TabPages.Count, tabPage_CreateCase);
                    textbox_CaseStartDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    SetComboBox_ServiceType_CreateCase();

                    comboBox_Employee_CreateCase.DataSource = Controller.GetEmployeesFromCategory(selectedCategory.Length);


                    toSwitchTo = tabPage_CreateCase;
                    break;
                case "Advokat":
                    if (!tabControl_Overview.TabPages.Contains(tabPage_CreateEmployee))
                        tabControl_Overview.TabPages.Insert(tabControl_Overview.TabPages.Count, tabPage_CreateEmployee);
                    toSwitchTo = tabPage_CreateEmployee;
                    break;
                case "Klient":
                    if (!tabControl_Overview.TabPages.Contains(tabPage_CreateClient))
                        tabControl_Overview.TabPages.Insert(tabControl_Overview.TabPages.Count, tabPage_CreateClient);
                    toSwitchTo = tabPage_CreateClient;
                    break;
                case "Ydelse":
                    if (!tabControl_Overview.TabPages.Contains(tabPage_CreateService))
                        tabControl_Overview.TabPages.Insert(tabControl_Overview.TabPages.Count, tabPage_CreateService);
                    textbox_ServiceStartDate.Text = DateTime.Now.ToString("dd-MM-yyyy");

                    toSwitchTo = tabPage_CreateService;
                    break;
            }
            tabControl_Overview.SelectedTab = toSwitchTo;
        }

     

       

        private void button_CreateEmployee_Click(object sender, EventArgs e)
        {
            currentEmployeeID = Controller.CreateAdvokat(textBox_EmployeeName.Text);
            comboBox_Education_CreateEmployee.Enabled = true;
            listBox_EmployeeEducations_CreateEmployee.Enabled = true;
            button_AddEducation_CreateEmployee.Enabled = true;
            
        }


        //DER ER FEJL HER, DEN SKAL LAVES OM TIL TJENSTE YDELSER
        private void button_AddSpeciality_CreateEmployee_Click(object sender, EventArgs e)
        {
            Education selectedEducation = (Education)comboBox_Education_CreateEmployee.SelectedItem;
            if (listBox_EmployeeEducations_CreateEmployee.Items.Count > 0)
            {
                List<Education> educationsInListBox = listBox_EmployeeEducations_CreateEmployee.Items.Cast<Education>().ToList();
                if (!educationsInListBox.Any(education => education.Name == selectedEducation.Name))
                    Controller.AddEducationToEmployee(selectedEducation.Name, currentEmployeeID);
            }
            else
                Controller.AddEducationToEmployee(selectedEducation.Name, currentEmployeeID);
            listBox_EmployeeEducations_CreateEmployee.DataSource = Controller.GetEducationsFromEmployee(currentEmployeeID);
            listBox_EmployeeEducations_CreateEmployee.DisplayMember = "Name";
        }
        private void button_CreateCase_Click(object sender, EventArgs e)//Daniella
        {
            //create case...
            Client selectedClient = (Client)comboBox_Client_CreateCase.SelectedItem;
            Employee selectedEmployee = (Employee)comboBox_Employee_CreateCase.SelectedItem;
            Category selectedService = (Category)comboBox_Category_CreateCase.SelectedItem;
            Controller.CreateCase(textBox_CaseTitle.Text, textbox_CaseStartDate.Text, default(DateTime), textbox_CaseKilometers.Text, textBox_CaseEstimatedHours.Text,
                richTextBox_CaseDescription.Text, richTextBox_CaseNotes.Text, selectedClient.ID, selectedEmployee.ID, selectedService.ID);
            SetObjectListView_Overview();
            tabControl_Overview.TabPages.Remove(tabPage_CreateCase);
        }
        private void button_CreateClient_Click(object sender, EventArgs e)//Daniella
        {
            try
            {
                string navn = textBox_ClientName.Text;
                string Adresse = textbox_ClientAdress.Text;
                string TelefonNr = textBox_ClientPhoneNumber.Text;
                Controller.CreateClient(navn, Adresse, TelefonNr);
                MessageBox.Show("Oprettet");
                textBox_ClientName.Clear();
                textbox_ClientAdress.Clear();
                textBox_ClientPhoneNumber.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ikke alt er valgt, gå venligst tilbage og indtast informatioen ");

            }
            SetObjectListView_Overview();
            tabControl_Overview.TabPages.Remove(tabPage_CreateClient);
        }
        private void button_Finished_Click(object sender, EventArgs e)
        {
            SetObjectListView_Overview();
            tabControl_Overview.TabPages.Remove(tabPage_CreateEmployee);
        }
        private void comboBox_Category_CreateCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)comboBox_Category_CreateCase.SelectedItem;
            Set_ComboBox_Employee_CreateCase(selectedCategory.ID);
        }
        private void button_Cancel_CreateCase_Click(object sender, EventArgs e)
        {
            tabControl_Overview.TabPages.Remove(tabControl_Overview.SelectedTab);
        }
        private void button_Cancel_CreateEmployee_Click(object sender, EventArgs e)
        {
            tabControl_Overview.TabPages.Remove(tabControl_Overview.SelectedTab);
        }
        private void button_Cancel_CreateClient_Click(object sender, EventArgs e)
        {
            tabControl_Overview.TabPages.Remove(tabControl_Overview.SelectedTab);
        }
        private void button_Cancel_CreateService_Click(object sender, EventArgs e)
        {
            tabControl_Overview.TabPages.Remove(tabControl_Overview.SelectedTab);
        }
        #endregion

        private void button_AddService_Click(object sender, EventArgs e)
        {
            Case selectedCase = (Case)comboBox_Case_Create_Service.SelectedItem;
            Employee selectedEmployee = (Employee)comboBox_Employee_Create_Service.SelectedItem;
            Controller.CreateService(textbox_ServiceStartDate.Text, textBox_ServiceDescription.Text, textBox_ServicePrice.Text, label_ServiceHours.Text,
                selectedCase.ID, selectedEmployee.ID );
            SetObjectListView_Overview();
            tabControl_Overview.TabPages.Remove(tabPage_CreateService);
        }
    }
}
