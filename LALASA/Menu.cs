using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LALASA
{
    public partial class form_Menu : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_LALASA");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        bool newCust;
        string staffID;

        public form_Menu(string parStaffID)
        {
            InitializeComponent();
            staffID = parStaffID;
        }

        private void form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tc_MainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tc_MainMenu.SelectedIndex)
            {
                case 0:
                    try
                    {
                        string selectedTrans = "";
                        DataTable tempTable = new DataTable();
                        btn_CreateTrans.Enabled = true;
                        btn_DeleteTrans.Enabled = false;
                        btn_AddService.Enabled = true;
                        cb_CustomerID.Enabled = true;
                        btn_DeleteService.Enabled = true;
                        dgv_DetailTransServices.Enabled = true;
                        dtp_Date.Enabled = true;
                        dtp_DueDate.Enabled = true;
                        tb_AdditionalFee.Enabled = true;
                        tb_Description.Enabled = true;
                        cb_ServiceID.Enabled = true;
                        tb_ServiceFee.Enabled = true;
                        nud_QuantityService.Enabled = true;
                        dtp_DueDate.Value = dtp_Date.Value.AddDays(14);
                        tb_TransSubtotal.Text = "0";
                        dgv_DetailTransServices.DataSource = null;
                        newCust = true;
                        btn_TUpdate.Enabled = false;

                        sqlConnect.Open();

                        // Customer List
                        string newCustID;
                        sqlQuery = $"select concat('C', lpad(substr(max(CUST_ID), 2, 2) + 1, 2, '0')) from CUSTOMER;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        newCustID = (string)sqlCommand.ExecuteScalar();
                        tempTable = new DataTable();
                        sqlQuery = $"select CUST_ID from CUSTOMER where STATUS_DELETE = 'N';";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        tempTable.Rows.Add(newCustID);
                        cb_CustomerID.DataSource = tempTable;
                        cb_CustomerID.DisplayMember = "CUST_ID";
                        cb_CustomerID.ValueMember = "CUST_ID";
                        cb_CustomerID.SelectedIndex = cb_CustomerID.Items.Count - 1;

                        // Trans ID List
                        tempTable = new DataTable();
                        sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' order by 1 desc;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        dgv_TransList.DataSource = tempTable;
                        dgv_TransList.ClearSelection();

                        // Trans ID Judul
                        sqlQuery = $"select fAutoGenerateTransID();";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        selectedTrans = (string)sqlCommand.ExecuteScalar();
                        lbl_TransCode.Text = $"TRANSACTION CODE : {selectedTrans}";

                        // Fill service lists
                        tempTable = new DataTable();
                        sqlQuery = $"select SERVICE_ID from SERVICES where STATUS_DELETE = 'N';";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        cb_ServiceID.DataSource = tempTable;
                        cb_ServiceID.DisplayMember = "SERVICE_ID";

                        sqlConnect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                case 1:
                    try
                    {
                        DataTable tempTable = new DataTable();

                        // Trans ID List
                        tempTable = new DataTable();
                        sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' order by 1 desc;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        dgv_TransDTList.DataSource = tempTable;
                        dgv_TransDTList.ClearSelection();

                        btn_TSAdd.Enabled = false;
                        btn_TSDelete.Enabled = false;
                        btn_TUpdate.Enabled = false;

                        tempTable = new DataTable();
                        sqlQuery = $"select SERVICE_ID from SERVICES where STATUS_DELETE = 'N';";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        cb_TransServiceID.DataSource = tempTable;
                        cb_TransServiceID.DisplayMember = "SERVICE_ID";
                        cb_TransServiceID.ValueMember = "SERVICE_ID";

                        tempTable = new DataTable();
                        dgv_TSList.DataSource = tempTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        DataTable tempTable = new DataTable();

                        // Trans ID List
                        tempTable = new DataTable();
                        sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' order by 1 desc;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        dgv_TransScheduleList.DataSource = tempTable;
                        dgv_TransScheduleList.ClearSelection();

                        tempTable = new DataTable();
                        sqlQuery = $"select STAFF_ID from STAFF where STATUS_DELETE = 'N';";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        cb_StaffScheduleList.DataSource = tempTable;
                        cb_StaffScheduleList.DisplayMember = "STAFF_ID";
                        cb_StaffScheduleList.ValueMember = "STAFF_ID";

                        btn_SAdd.Enabled = false;
                        btn_SDelete.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        sqlConnect.Open();
                        DataTable tempTable = new DataTable();

                        // Trans ID List
                        tempTable = new DataTable();
                        sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' order by 1 desc;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        dgv_PTransID.DataSource = tempTable;
                        dgv_PTransID.ClearSelection();

                        btn_PAdd.Enabled = false;
                        btn_PDelete.Enabled = false;
                        sqlConnect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnect.Close();
                    }
                    break;
                case 4:
                    try
                    {
                        btn_CCreate.Enabled = true;
                        btn_CDelete.Enabled = false;
                        btn_CUpdate.Enabled = false;

                        DataTable tempTable = new DataTable();
                        sqlQuery = $"select CUST_ID from CUSTOMER where STATUS_DELETE = 'N' order by 1 desc;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        dgv_Cust.DataSource = tempTable;
                        dgv_Cust.ClearSelection();

                        sqlConnect.Open();
                        sqlQuery = $"select concat('C', lpad(max(substr(CUST_ID, 2, 2) + 1), 2, '0')) from CUSTOMER;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        tb_CCustID.Text = (string)sqlCommand.ExecuteScalar();
                        sqlConnect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnect.Close();
                    }
                    break;
                case 5:
                    try
                    {
                        btn_SCreate.Enabled = true;
                        btn_SDel.Enabled = false;
                        btn_SUpdate.Enabled = false;

                        DataTable tempTable = new DataTable();
                        sqlQuery = $"select STAFF_ID from STAFF where STATUS_DELETE = 'N' order by 1 desc;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlAdapter.Fill(tempTable);
                        dgv_Staff.DataSource = tempTable;
                        dgv_Staff.ClearSelection();

                        sqlConnect.Open();
                        sqlQuery = $"select concat('S', lpad(max(substr(STAFF_ID, 2, 2) + 1), 2, '0')) from STAFF;";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        tb_SStaffID.Text = (string)sqlCommand.ExecuteScalar();
                        sqlConnect.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        sqlConnect.Close();
                    }
                    break;
            }
        }

        private void cb_CustomerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();

                // Autofill customer
                if (cb_CustomerID.Text.Length == 3)
                {
                    tempTable = new DataTable();
                    sqlQuery = $"select * from CUSTOMER where CUST_ID = '{cb_CustomerID.Text}' and STATUS_DELETE = 'N';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                }

                if(tempTable.Rows.Count > 0)
                {
                    tb_CustomerName.Enabled = false;
                    tb_CompanyName.Enabled = false;
                    tb_Address.Enabled = false;
                    tb_Phone.Enabled = false;

                    tb_CustomerName.Text = tempTable.Rows[0][1].ToString();
                    tb_CompanyName.Text = tempTable.Rows[0][2].ToString();
                    tb_Address.Text = tempTable.Rows[0][3].ToString();
                    tb_Phone.Text = tempTable.Rows[0][4].ToString();

                    newCust = false;
                }
                else
                {
                    tb_CustomerName.Enabled = true;
                    tb_CompanyName.Enabled = true;
                    tb_Address.Enabled = true;
                    tb_Phone.Enabled = true;

                    tb_CustomerName.Text = String.Empty;
                    tb_CompanyName.Text = String.Empty;
                    tb_Address.Text = String.Empty;
                    tb_Phone.Text = String.Empty;

                    newCust = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_ServiceID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();

                // Autofill customer
                tempTable = new DataTable();
                sqlQuery = $"select * from SERVICES where SERVICE_ID = '{cb_ServiceID.Text}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);

                if (tempTable.Rows.Count > 0)
                {
                    tb_ServiceName.Text = tempTable.Rows[0][1].ToString();
                    tb_ServiceFee.Text = tempTable.Rows[0][2].ToString();
                }
                else
                {
                    tb_ServiceName.Text = String.Empty;
                    tb_ServiceFee.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataTable dtDetailService = new DataTable();

        private void btn_AddService_Click(object sender, EventArgs e)
        {
            try
            {
                // Autofill customer
                sqlQuery = $"select SERVICE_ID, SERVICE_NAME, SERVICE_FEE, {nud_QuantityService.Value} as 'QUANTITY', SERVICE_FEE * {nud_QuantityService.Value} as 'TOTAL' from SERVICES where SERVICE_ID = '{cb_ServiceID.Text}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDetailService);

                dgv_DetailTransServices.DataSource = dtDetailService;

                // Update price
                tb_TransSubtotal.Text = "0";
                if (dtDetailService.Rows.Count > 0)
                {
                    foreach (DataRow row in dtDetailService.Rows)
                    {
                        tb_TransSubtotal.Text = Convert.ToString(Convert.ToInt32(row[4]) + Convert.ToInt32(tb_TransSubtotal.Text));;
                    }
                }

                cb_ServiceID.SelectedIndex = 0;
                nud_QuantityService.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_DetailTransServices.Rows.RemoveAt(dgv_DetailTransServices.CurrentRow.Index);
                dtDetailService.Rows.RemoveAt(dgv_DetailTransServices.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_TransList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Change form
                btn_CreateTrans.Enabled = false;
                btn_DeleteTrans.Enabled = true;
                btn_AddService.Enabled = false;
                cb_CustomerID.Enabled = false;
                btn_DeleteService.Enabled = false;
                dgv_DetailTransServices.Enabled = false;
                cb_ServiceID.Enabled = false;
                tb_ServiceFee.Enabled = false;
                nud_QuantityService.Enabled = false;
                btn_TUpdate.Enabled = true;

                // Gets selected data
                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from TRANSACTION where TRANS_ID = '{dgv_TransList.CurrentCell.Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);

                // Input selected data
                lbl_TransCode.Text = $"TRANSACTION CODE : {tempTable.Rows[0][0]}";
                cb_CustomerID.SelectedValue = tempTable.Rows[0][1];
                dtp_Date.Value = Convert.ToDateTime(tempTable.Rows[0][3]);
                dtp_DueDate.Value = Convert.ToDateTime(tempTable.Rows[0][4]);
                tb_TransSubtotal.Text = tempTable.Rows[0][5].ToString();
                tb_AdditionalFee.Text = tempTable.Rows[0][6].ToString();
                tb_Description.Text = tempTable.Rows[0][7].ToString();
                tempTable = new DataTable();
                sqlQuery = $"select dts.SERVICE_ID, SERVICE_NAME, DETAIL_TRANS_FEE as 'SERVICE_FEE', DETAIL_TRANS_QTY as 'QUANTITY', DETAIL_TRANS_SUBTOTAL as 'TOTAL' from DETAIL_TRANS_SERVICES dts left join SERVICES s on s.SERVICE_ID = dts.SERVICE_ID where TRANS_ID = '{dgv_TransList.CurrentCell.Value}' and dts.STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_DetailTransServices.DataSource = tempTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void tb_TransSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();

                // Trans ID List
                tempTable = new DataTable();
                sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' and TRANS_ID like '%{tb_TransSearch.Text}%' order by 1 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_TransList.DataSource = tempTable;
                dgv_TransList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DeleteTrans_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"update TRANSACTION set STATUS_DELETE = 'Y' where TRANS_ID = '{dgv_TransList.CurrentCell.Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                dgv_TransList.Rows.RemoveAt(dgv_TransList.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }

        }

        void clearForm()
        {

            try
            {
                sqlConnect.Open();

                dgv_TransList.ClearSelection();
                dtp_Date.Value = DateTime.Now;
                dtp_DueDate.Value = dtp_Date.Value.AddDays(14);
                tb_TransSubtotal.Text = "0";
                cb_CustomerID.SelectedIndex = cb_CustomerID.Items.Count - 1;
                cb_ServiceID.SelectedIndex = 0;
                dgv_DetailTransServices.DataSource = null;

                // Trans ID Judul
                sqlQuery = $"select fAutoGenerateTransID();";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                string selectedTrans = (string)sqlCommand.ExecuteScalar();
                lbl_TransCode.Text = $"TRANSACTION CODE : {selectedTrans}";

                // Change form
                btn_CreateTrans.Enabled = true;
                btn_DeleteTrans.Enabled = false;
                btn_AddService.Enabled = true;
                cb_CustomerID.Enabled = true;
                btn_DeleteService.Enabled = true;
                dgv_DetailTransServices.Enabled = true;
                dtp_Date.Enabled = true;
                dtp_DueDate.Enabled = true;
                tb_AdditionalFee.Enabled = true;
                tb_Description.Enabled = true;
                cb_ServiceID.Enabled = true;
                tb_ServiceFee.Enabled = true;
                nud_QuantityService.Enabled = true;
                newCust = true;
                tb_Description.Text = "";
                tb_AdditionalFee.Text = "";
                btn_TUpdate.Enabled = false;

                string newCustID;
                DataTable tempTable = new DataTable();
                sqlQuery = $"select concat('C', lpad(substr(max(CUST_ID), 2, 2) + 1, 2, '0')) from CUSTOMER;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                newCustID = (string)sqlCommand.ExecuteScalar();
                tempTable = new DataTable();
                sqlQuery = $"select CUST_ID from CUSTOMER where STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                tempTable.Rows.Add(newCustID);
                cb_CustomerID.DataSource = tempTable;
                cb_CustomerID.DisplayMember = "CUST_ID";
                cb_CustomerID.ValueMember = "CUST_ID";
                cb_CustomerID.SelectedIndex = cb_CustomerID.Items.Count - 1;

                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        private void btn_ClearTrans_Click(object sender, EventArgs e)
        {
            try
            {
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_CreateTrans_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();

                if (tb_CustomerName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Customer Name !");
                    tb_CustomerName.Focus();
                }
                else if (tb_Address.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Customer Address !");
                    tb_Address.Focus();
                }
                else if (tb_Phone.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Customer Phone !");
                    tb_Phone.Focus();
                }
                else if (tb_TransSubtotal.Text == "0")
                {
                    MessageBox.Show("No Service Were Added !");
                }
                else if (tb_ServiceFee.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Service Fee !");
                }
                else if (dtp_Date.Value > dtp_DueDate.Value)
                {
                    MessageBox.Show("Due Date must be larger than trans date !");
                }
                else
                {
                    DataTable tempTable = new DataTable();

                    if (newCust)
                    {
                        string companyName = "null";
                        if (tb_CompanyName.Text != String.Empty) companyName = $"'{tb_CompanyName.Text}'";
                        sqlQuery = $"insert into CUSTOMER(CUST_ID, CUST_NAME, CUST_COMPANY, CUST_ADDRESS, CUST_PHONE) values('{cb_CustomerID.Text}', '{tb_CustomerName.Text}', {companyName}, '{tb_Address.Text}', '{tb_Phone.Text}');";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlCommand.ExecuteNonQuery();
                    }

                    string transDesc = "null";
                    string transAddFee = "null";

                    sqlQuery = $"select fAutoGenerateTransID();";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    string transID = (string)sqlCommand.ExecuteScalar();

                    if (tb_Description.Text != String.Empty) transDesc = $"'{tb_Description.Text}'";
                    if (tb_AdditionalFee.Text != String.Empty) transAddFee = $"'{tb_AdditionalFee.Text}'";
                    sqlQuery = $"insert into TRANSACTION(TRANS_ID, CUST_ID, STAFF_ID, TRANS_DATE, TRANS_DUEDATE, TRANS_SUBTOTAL, TRANS_DESC, TRANS_ADDITIONAL_FEE) values('{transID}', '{cb_CustomerID.Text}', '{staffID}', '{dtp_Date.Text}', '{dtp_DueDate.Text}', '{tb_TransSubtotal.Text}', {transDesc}, {transAddFee});";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlCommand.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dgv_DetailTransServices.Rows)
                    {
                        sqlQuery = $"insert into DETAIL_TRANS_SERVICES(TRANS_ID, SERVICE_ID, DETAIL_TRANS_QTY, DETAIL_TRANS_FEE, DETAIL_TRANS_SUBTOTAL) values('{transID}', '{row.Cells[0].Value}', '{row.Cells[3].Value}', '{row.Cells[2].Value}', '{row.Cells[4].Value}');";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlCommand.ExecuteNonQuery();
                    }

                    // Trans ID List
                    tempTable = new DataTable();
                    sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' order by 1 desc;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                    dgv_TransList.DataSource = tempTable;
                    dgv_TransList.ClearSelection();
                }

                sqlConnect.Close();

                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void tb_SearchTransSchedule_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();

                // Trans ID List
                tempTable = new DataTable();
                sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' and TRANS_ID like '%{tb_SearchTransSchedule.Text}%' order by 1 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_TransScheduleList.DataSource = tempTable;
                dgv_TransScheduleList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_TransScheduleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_SAdd.Enabled = true;
                btn_SDelete.Enabled = true;

                DataTable tempTable = new DataTable();
                sqlConnect.Open();

                sqlQuery = $"select fAutoGenerateScheduleID('{dgv_TransScheduleList.CurrentCell.Value}');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                tb_ScheduleID.Text = (string)sqlCommand.ExecuteScalar();

                tempTable = new DataTable();
                sqlQuery = $"select SCHEDULE_ID, STAFF_ID, SCHEDULE_START, SCHEDULE_END from SCHEDULE where TRANS_ID = '{dgv_TransScheduleList.CurrentCell.Value}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_ScheduleList.DataSource = tempTable;
                dgv_ScheduleList.ClearSelection();

                tempTable = new DataTable();
                sqlQuery = $"select dts.SERVICE_ID as 'SRV', DETAIL_TRANS_QTY as 'QTY' from DETAIL_TRANS_SERVICES dts left join SERVICES s on s.SERVICE_ID = dts.SERVICE_ID where TRANS_ID = '{dgv_TransScheduleList.CurrentCell.Value}' and dts.STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_SchDetailServiceList.DataSource = tempTable;
                dgv_SchDetailServiceList.ClearSelection();

                tb_TransScheduleID.Text = Convert.ToString(dgv_TransScheduleList.CurrentCell.Value);

                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void cb_StaffScheduleList_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlConnect.Open();

                sqlQuery = $"select STAFF_NAME, STAFF_POSITION from STAFF where STAFF_ID = '{cb_StaffScheduleList.Text}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);

                if (tempTable.Rows.Count > 0)
                {
                    tb_SchStaffName.Text = tempTable.Rows[0][0].ToString();
                    tb_SchStaffPosition.Text = tempTable.Rows[0][1].ToString();
                }

                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void ongoingTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from vOngoingTransDetail;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_View.DataSource = tempTable;
                dgv_View.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   

        }

        private void lateTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from vLateTrans;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_View.DataSource = tempTable;
                dgv_View.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void doneTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from vDoneTrans;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_View.DataSource = tempTable;
                dgv_View.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from vRevenuePerMonth;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_View.DataSource = tempTable;
                dgv_View.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_TransDTList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_TSAdd.Enabled = true;
                btn_TSDelete.Enabled = true;
                btn_TUpdate.Enabled = true;

                DataTable tempTable = new DataTable();
                sqlQuery = $"select s.SERVICE_ID, SERVICE_NAME, DETAIL_TRANS_QTY, DETAIL_TRANS_FEE from DETAIL_TRANS_SERVICES dts left join SERVICES s on dts.SERVICE_ID = s.SERVICE_ID where dts.STATUS_DELETE = 'N' and TRANS_ID = '{dgv_TransDTList.CurrentCell.Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_TSList.DataSource = tempTable;
                dgv_TSList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_TransServiceID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_TransServiceID.Text.Length == 4)
                {
                    DataTable tempTable = new DataTable();
                    sqlQuery = $"select SERVICE_ID, SERVICE_NAME, SERVICE_FEE from SERVICES where STATUS_DELETE = 'N' and SERVICE_ID = '{cb_TransServiceID.Text}';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);

                    tb_TransServiceName.Text = tempTable.Rows[0][1].ToString();
                    tb_TransServiceFee.Text = tempTable.Rows[0][2].ToString();
                    nud_QuantityService.Value = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }

        }

        private void btn_TSAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"insert into DETAIL_TRANS_SERVICES values ('{dgv_TransDTList.CurrentCell.Value}', '{cb_TransServiceID.Text}', '{nud_QtyTrans.Value}', '{tb_TransServiceFee.Text}', '{Convert.ToInt32(nud_QtyTrans.Value) * Convert.ToInt32(tb_TransServiceFee.Text)}', 'ONGOING', 'N');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();

                sqlQuery = $"update TRANSACTION set TRANS_SUBTOTAL = TRANS_SUBTOTAL + {Convert.ToInt32(nud_QtyTrans.Value) * Convert.ToInt32(tb_TransServiceFee.Text)} where TRANS_ID = '{dgv_TransDTList.CurrentCell.Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                DataTable tempTable = new DataTable();
                sqlQuery = $"select s.SERVICE_ID, SERVICE_NAME, DETAIL_TRANS_QTY, DETAIL_TRANS_FEE from DETAIL_TRANS_SERVICES dts left join SERVICES s on dts.SERVICE_ID = s.SERVICE_ID where dts.STATUS_DELETE = 'N' and TRANS_ID = '{dgv_TransDTList.CurrentCell.Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_TSList.DataSource = tempTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_TSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand("pDeleteDetailTrans", sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTransID", $"{dgv_TransDTList.CurrentCell.Value}");
                sqlCommand.Parameters.AddWithValue("parServiceID", $"{dgv_TSList.CurrentRow.Cells[0].Value}");
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                dgv_TSList.Rows.RemoveAt(dgv_TransList.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_SAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"insert into SCHEDULE values ('{tb_ScheduleID.Text}','{tb_TransScheduleID.Text}','{cb_StaffScheduleList.Text}','{dtp_SStart.Text}','{dtp_SEnd.Text}','N');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();

                sqlQuery = $"select fAutoGenerateScheduleID('{dgv_TransScheduleList.CurrentCell.Value}');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                tb_ScheduleID.Text = (string)sqlCommand.ExecuteScalar();

                DataTable tempTable = new DataTable();
                sqlQuery = $"select SCHEDULE_ID, STAFF_ID, SCHEDULE_START, SCHEDULE_END from SCHEDULE where TRANS_ID = '{dgv_TransScheduleList.CurrentCell.Value}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_ScheduleList.DataSource = tempTable;
                dgv_ScheduleList.ClearSelection();
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_SDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"update SCHEDULE set STATUS_DELETE = 'Y' where SCHEDULE_ID = '{dgv_ScheduleList.CurrentRow.Cells[0].Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();
                dgv_ScheduleList.Rows.RemoveAt(dgv_ScheduleList.CurrentRow.Index);
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void dgv_PTransID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();

                sqlQuery = $"select * from TRANSACTION where TRANS_ID = '{dgv_PTransID.CurrentCell.Value}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);

                tb_PTransactionID.Text = tempTable.Rows[0][0].ToString();
                dtp_PDate.Text = tempTable.Rows[0][3].ToString();
                dtp_PDueDate.Text = tempTable.Rows[0][4].ToString();
                tb_PTransTotal.Text = tempTable.Rows[0][5].ToString();
                tb_PAddFee.Text = tempTable.Rows[0][6].ToString();
                tb_PDesc.Text = tempTable.Rows[0][7].ToString();

                btn_PAdd.Enabled = true;
                btn_PDelete.Enabled = true;

                tempTable = new DataTable();
                sqlQuery = $"select * from PAYMENT where TRANS_ID = '{dgv_PTransID.CurrentCell.Value}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_Payment.DataSource = tempTable;

                sqlConnect.Open();
                sqlQuery = $"select fAutoGeneratePaymentID('{dgv_PTransID.CurrentCell.Value}');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                tb_PPaymentID.Text = (string)sqlCommand.ExecuteScalar();
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' and TRANS_ID like '%{tb_Search}%'order by 1 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_PTransID.DataSource = tempTable;
                dgv_PTransID.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_PTransID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select TRANS_ID from TRANSACTION where STATUS_DELETE = 'N' and TRANS_ID like '%{tb_PTransID}%' order by 1 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_TransDTList.DataSource = tempTable;
                dgv_TransDTList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_PDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"update PAYMENT set STATUS_DELETE = 'Y' where PAYMENT_ID = '{dgv_Payment.CurrentRow.Cells[0].Value}';)";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                dgv_Payment.Rows.RemoveAt(dgv_Payment.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_PAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"insert into PAYMENT values ('{tb_PPaymentID.Text}', '{dgv_PTransID.CurrentCell.Value}', '{cb_PPaymentType.Text}', '{dtp_PaymentDate.Text}', '{tb_PPaymentAmount.Text}', 'N' )";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from PAYMENT where TRANS_ID = '{dgv_PTransID.CurrentCell.Value}' and STATUS_DELETE = 'N';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_Payment.DataSource = tempTable;

                tb_PPaymentAmount.Text = String.Empty;
                tb_PPaymentID.Text = String.Empty;
                dgv_PTransID.ClearSelection();

                sqlConnect.Open();
                sqlQuery = $"select fAutoGeneratePaymentID('{dgv_PTransID.CurrentCell.Value}');";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                tb_PPaymentID.Text = (string)sqlCommand.ExecuteScalar();
                sqlConnect.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from SCHEDULE where STATUS_DELETE = 'N' and SCHEDULE_END > curdate();;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_View.DataSource = tempTable;
                dgv_View.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tb_SearchCust_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select CUST_ID from CUSTOMER where STATUS_DELETE = 'N' and CUST_ID like '{tb_SearchCust.Text}' order by 1 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_Cust.DataSource = tempTable;
                dgv_Cust.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_StaffID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tempTable = new DataTable();
                sqlQuery = $"select STAFF_ID from STAFF where STATUS_DELETE = 'N' and STAFF_ID like '{tb_StaffID.Text}' order by 1 desc;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                dgv_Staff.DataSource = tempTable;
                dgv_Staff.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_CCreate.Enabled = false;
                btn_CUpdate.Enabled = true;
                btn_CDelete.Enabled = true;

                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from CUSTOMER where CUST_ID = '{dgv_Cust.CurrentCell.Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);

                tb_CCustID.Text = tempTable.Rows[0][0].ToString();
                tb_CCustName.Text = tempTable.Rows[0][1].ToString();
                tb_CCompany.Text = tempTable.Rows[0][2].ToString();
                tb_CAddress.Text = tempTable.Rows[0][3].ToString();
                tb_CPhone.Text = tempTable.Rows[0][4].ToString();

                tempTable = new DataTable();
                sqlConnect.Open();
                sqlCommand = new MySqlCommand("pShowCustTrans", sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parID", $"{dgv_Cust.CurrentCell.Value}");
                sqlAdapter.Fill(tempTable);
                sqlCommand.ExecuteNonQuery();
                dgv_CCust.DataSource = tempTable;
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_CClear_Click(object sender, EventArgs e)
        {
            try
            {
                btn_CCreate.Enabled = true;
                btn_CDelete.Enabled = false;
                btn_CUpdate.Enabled = false;

                DataTable tempTable = new DataTable();
                sqlConnect.Open();
                sqlQuery = "select concat('C', lpad(max(substr(CUST_ID, 2, 2) + 1), 2, '0')) from CUSTOMER;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                tb_CCustID.Text = (string)sqlCommand.ExecuteScalar();
                sqlConnect.Close();

                tb_CCustName.Text = String.Empty;
                tb_CCompany.Text = String.Empty;
                tb_CAddress.Text = String.Empty;
                tb_CPhone.Text = String.Empty;

                tempTable = new DataTable();
                dgv_CCust.DataSource = tempTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_CDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"update CUSTOMER set STATUS_DELETE = 'Y' where CUST_ID = '{dgv_Cust.CurrentCell.Value}';";
                dgv_Cust.Rows.RemoveAt(dgv_Cust.CurrentRow.Index);

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();

                DataTable tempTable = new DataTable();
                sqlQuery = "select concat('C', lpad(max(substr(CUST_ID, 2, 2) + 1), 2, '0')) from CUSTOMER;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                tb_CCustID.Text = (string)sqlCommand.ExecuteScalar();


                tb_CCustName.Text = String.Empty;
                tb_CCompany.Text = String.Empty;
                tb_CAddress.Text = String.Empty;
                tb_CAddress.Text = String.Empty;

                tempTable = new DataTable();
                dgv_CCust.DataSource = tempTable;
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_CCreate_Click(object sender, EventArgs e)
        {
            if (tb_CCustName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Customer Name");
            }
            else if (tb_CAddress.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Customer Address");
            }
            else if (tb_CPhone.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Customer Phone");
            }
            else
            {
                try
                {
                    sqlConnect.Open();
                    sqlQuery = $"insert into CUSTOMER values ('{tb_CCustID.Text}', '{tb_CCustName.Text}', '{tb_CCompany.Text}', '{tb_CAddress.Text}', '{tb_CPhone.Text}', 'N');";

                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlCommand.ExecuteNonQuery();

                    DataTable tempTable = new DataTable();
                    sqlQuery = "select concat('C', lpad(max(substr(CUST_ID, 2, 2) + 1), 2, '0')) from CUSTOMER;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                    tb_CCustID.Text = (string)sqlCommand.ExecuteScalar();

                    tempTable = new DataTable();
                    sqlQuery = $"select CUST_ID from CUSTOMER where STATUS_DELETE = 'N' order by 1 desc;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                    dgv_Cust.DataSource = tempTable;
                    dgv_Cust.ClearSelection();

                    tb_CCustName.Text = String.Empty;
                    tb_CCompany.Text = String.Empty;
                    tb_CAddress.Text = String.Empty;
                    tb_CAddress.Text = String.Empty;

                    tempTable = new DataTable();
                    dgv_CCust.DataSource = tempTable;
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnect.Close();
                }
            }
        }

        private void btn_CUpdate_Click(object sender, EventArgs e)
        {
            if (tb_CCustName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Customer Name");
            }
            else if (tb_CAddress.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Customer Address");
            }
            else if (tb_CPhone.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Customer Phone");
            }
            else
            {
                try
                {
                    sqlConnect.Open();
                    sqlQuery = $"update CUSTOMER set CUST_NAME = '{tb_CCustName.Text}', CUST_COMPANY = '{tb_CCompany.Text}', CUST_ADDRESS = '{tb_CAddress.Text}', CUST_PHONE = '{tb_CPhone.Text}' where CUST_ID = '{tb_CCustID.Text}';";

                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlCommand.ExecuteNonQuery();

                    DataTable tempTable = new DataTable();
                    sqlQuery = "select concat('C', lpad(max(substr(CUST_ID, 2, 2) + 1), 2, '0')) from CUSTOMER;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                    tb_CCustID.Text = (string)sqlCommand.ExecuteScalar();


                    tb_CCustName.Text = String.Empty;
                    tb_CCompany.Text = String.Empty;
                    tb_CAddress.Text = String.Empty;
                    tb_CAddress.Text = String.Empty;

                    tempTable = new DataTable();
                    dgv_CCust.DataSource = tempTable;
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnect.Close();
                }
            }
               
        }

        private void dgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_CCreate.Enabled = false;
                btn_CUpdate.Enabled = true;
                btn_CDelete.Enabled = true;

                DataTable tempTable = new DataTable();
                sqlQuery = $"select * from STAFF where STAFF_ID = '{dgv_Staff.CurrentCell.Value}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);

                tb_SStaffID.Text = tempTable.Rows[0][0].ToString();
                tb_SName.Text = tempTable.Rows[0][1].ToString();
                tb_SPosition.Text = tempTable.Rows[0][2].ToString();
                tb_SEmail.Text = tempTable.Rows[0][3].ToString();
                tb_SPhone.Text = tempTable.Rows[0][4].ToString();
                tb_SAddress.Text = tempTable.Rows[0][5].ToString();
                tb_SPassword.Text = tempTable.Rows[0][6].ToString();

                tempTable = new DataTable();
                sqlConnect.Open();
                sqlCommand = new MySqlCommand("pShowTransSchedule", sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parID", $"{dgv_Staff.CurrentCell.Value}");
                sqlAdapter.Fill(tempTable);
                sqlCommand.ExecuteNonQuery();
                dgv_SStaff.DataSource = tempTable;
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_SClear_Click(object sender, EventArgs e)
        {
            try
            {
                btn_CCreate.Enabled = false;
                btn_CUpdate.Enabled = true;
                btn_CDelete.Enabled = true;

                DataTable tempTable = new DataTable();
                sqlConnect.Open();
                sqlQuery = "select concat('S', lpad(max(substr(STAFF_ID, 2, 2) + 1), 2, '0')) from STAFF;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                tb_SStaffID.Text = (string)sqlCommand.ExecuteScalar();
                sqlConnect.Close();

                tb_SName.Text = String.Empty;
                tb_SPosition.Text = String.Empty;
                tb_SEmail.Text = String.Empty;
                tb_SPhone.Text = String.Empty;
                tb_SAddress.Text = String.Empty;
                tb_SPassword.Text = String.Empty;

                tempTable = new DataTable();
                dgv_SStaff.DataSource = tempTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_SDel_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = $"update STAFF set STATUS_DELETE = 'Y' where STAFF_ID = '{dgv_Staff.CurrentCell.Value}';";
                dgv_Cust.Rows.RemoveAt(dgv_Cust.CurrentRow.Index);

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlCommand.ExecuteNonQuery();

                DataTable tempTable = new DataTable();
                sqlQuery = "select concat('S', lpad(max(substr(STAFF_ID, 2, 2) + 1), 2, '0')) from STAFF;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tempTable);
                tb_SStaffID.Text = (string)sqlCommand.ExecuteScalar();


                tb_SName.Text = String.Empty;
                tb_SPosition.Text = String.Empty;
                tb_SEmail.Text = String.Empty;
                tb_SPhone.Text = String.Empty;
                tb_SAddress.Text = String.Empty;
                tb_SPassword.Text = String.Empty;

                tempTable = new DataTable();
                dgv_SStaff.DataSource = tempTable;
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void btn_SCreate_Click(object sender, EventArgs e)
        {
            if (tb_SName.Text == String.Empty || tb_SPosition.Text == String.Empty || tb_SEmail.Text == String.Empty || tb_SPhone.Text == String.Empty || tb_SAddress.Text == String.Empty || tb_SPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Enter All Data !");
            }
            else
            {
                try
                {
                    sqlConnect.Open();
                    sqlQuery = $"insert into STAFF values ('{tb_SStaffID.Text}', '{tb_SName.Text}', '{tb_SPosition.Text}', '{tb_SEmail.Text}', '{tb_SPhone.Text}', '{tb_SAddress.Text}', '{tb_SPassword}', 'N');";

                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlCommand.ExecuteNonQuery();

                    DataTable tempTable = new DataTable();
                    sqlQuery = "select concat('S', lpad(max(substr(STAFF_ID, 2, 2) + 1), 2, '0')) from STAFF;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                    tb_SStaffID.Text = (string)sqlCommand.ExecuteScalar();

                    tempTable = new DataTable();
                    sqlQuery = $"select STAFF_ID from STAFF where STATUS_DELETE = 'N' order by 1 desc;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                    dgv_Staff.DataSource = tempTable;
                    dgv_Staff.ClearSelection();

                    tb_SName.Text = String.Empty;
                    tb_SPosition.Text = String.Empty;
                    tb_SEmail.Text = String.Empty;
                    tb_SPhone.Text = String.Empty;
                    tb_SAddress.Text = String.Empty;
                    tb_SPassword.Text = String.Empty;

                    tempTable = new DataTable();
                    dgv_SStaff.DataSource = tempTable;
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnect.Close();
                }
            }
        }

        private void btn_SUpdate_Click(object sender, EventArgs e)
        {
            if (tb_SName.Text == String.Empty || tb_SPosition.Text == String.Empty || tb_SEmail.Text == String.Empty || tb_SPhone.Text == String.Empty || tb_SAddress.Text == String.Empty || tb_SPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Enter All Data !");
            }
            else
            {
                try
                {
                    sqlConnect.Open();
                    sqlQuery = $"update STAFF set STAFF_ID = '{tb_SStaffID.Text}', STAFF_POSITION = '{tb_SPosition.Text}', STAFF_EMAIL = '{tb_SEmail.Text}', STAFF_PHONE = '{tb_SPhone.Text}', STAFF_ADDRESS = '{tb_SAddress.Text}', STAFF_PASSWORD = '{tb_SPassword}' where STAFF_ID = '{tb_SStaffID.Text}';";

                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlCommand.ExecuteNonQuery();

                    DataTable tempTable = new DataTable();
                    sqlQuery = "select concat('S', lpad(max(substr(STAFF_ID, 2, 2) + 1), 2, '0')) from STAFF;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(tempTable);
                    tb_SStaffID.Text = (string)sqlCommand.ExecuteScalar();

                    tb_SName.Text = String.Empty;
                    tb_SPosition.Text = String.Empty;
                    tb_SEmail.Text = String.Empty;
                    tb_SPhone.Text = String.Empty;
                    tb_SAddress.Text = String.Empty;
                    tb_SPassword.Text = String.Empty;

                    tempTable = new DataTable();
                    dgv_SStaff.DataSource = tempTable;
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    sqlConnect.Close();
                }
            }
        }

        private void btn_TUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtp_Date.Value > dtp_DueDate.Value)
                {
                    MessageBox.Show("Due Date must be larger than date !");
                }
                else
                {
                    sqlConnect.Open();
                    sqlQuery = $"update TRANSACTION set TRANS_DATE = '{dtp_Date.Text}', TRANS_DUEDATE = '{dtp_DueDate.Text}', TRANS_DESC = '{tb_Description.Text}', TRANS_ADDITIONAL_FEE = '{tb_AdditionalFee.Text}' where TRANS_ID = '{dgv_TransList.CurrentCell.Value}';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }
    }
}

