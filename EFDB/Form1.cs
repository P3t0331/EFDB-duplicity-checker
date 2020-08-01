using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EFDB
{
    public partial class Form1 : Form
    {
        OleDbConnection Connection;

        public Form1()
        {
            InitializeComponent();
            cbxSector.SelectedIndex = 0;
            Connection = new OleDbConnection();
            Connection.StateChange += Connection_StateChange;
        }

        private void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            btnStart.Enabled = e.CurrentState == ConnectionState.Open;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chBox in groupBox1.Controls)
            {
                chBox.Checked = true;
            }
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chBox in groupBox1.Controls)
            {
                chBox.Checked = false;
            }
        }

        public void OpenConnectionInteractive()
        {
            CloseConnection();

            OpenFileDialog fileDlg = new OpenFileDialog();

            fileDlg.DefaultExt = "mdb";
            fileDlg.Filter = "MDB files (*.mdb)|*.mdb";
            fileDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fileDlg.Title = "Open EFDB database";

            DialogResult dlgResult = fileDlg.ShowDialog();

            if (dlgResult != DialogResult.OK)
                return;

            try
            {
                Connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileDlg.FileName + ";";
                Connection.Open();
                
                object[] obj = { null, null, "emission_factor" };
                DataTable table = Connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, obj);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Database is not a valid EFDB database!", "EFDB comparer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CloseConnection();
                    return;
                }

                txtDBName.Text = fileDlg.FileName;
            }
            catch (Exception ex)
            {
                string msg = "Error connecting to EFDB database! Error: " + ex.Message;
                MessageBox.Show(msg, "EFDB comparer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void CloseConnection()
        {
            Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenConnectionInteractive();
        }
        public bool ListsEqual(List<string> L1,  List<string> L2)
        {
            if (L1.Count == L2.Count)
            {

                for (int i = 0; i < L1.Count; i++)
                {
                    if (L1[i] != L2[i])
                        return false;

                }
                return true;
            }
            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy)
                return;
            if (!Checked())
                return;
            if (!WantsToContinue())
                return;

            string sector;
            switch (cbxSector.SelectedIndex)
            {
                default:
                    sector = "0";
                    break;
                case 1:
                    sector = "1";
                    break;
                case 2:
                    sector = "2";
                    break;
                case 3:
                    sector = "4";
                    break;
                case 4:
                    sector = "5";
                    break;
                case 5:
                    sector = "6";
                    break;
            }

            Dictionary<int, List<string>> efGasDict = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> efIpcc96Dict = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> efIpcc06Dict = new Dictionary<int, List<string>>();

            string query = "SELECT ef_id, pol_id FROM ef_gas_ass ORDER BY ef_id, pol_id";
            OleDbCommand cmd = Connection.CreateCommand();
            cmd.CommandText = query;
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (!efGasDict.ContainsKey((int)rd["ef_id"]))
                    efGasDict.Add((int)rd["ef_id"], new List<string>());
                efGasDict[(int)rd["ef_id"]].Add((string)rd["pol_id"]);
            }
            rd.Close();

            query = "SELECT ef_id, ipcc_code_96, ipcc_code_06 FROM ef_ipcc_ass ORDER BY ef_id, ipcc_code_96, ipcc_code_06";
            cmd = Connection.CreateCommand();
            cmd.CommandText = query;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (!efIpcc96Dict.ContainsKey((int)rd["ef_id"]))
                    efIpcc96Dict.Add((int)rd["ef_id"], new List<string>());
                if (!efIpcc06Dict.ContainsKey((int)rd["ef_id"]))
                    efIpcc06Dict.Add((int)rd["ef_id"], new List<string>());
                efIpcc96Dict[(int)rd["ef_id"]].Add((string)rd["ipcc_code_96"]);
                efIpcc06Dict[(int)rd["ef_id"]].Add((string)rd["ipcc_code_06"]);
            }
            rd.Close();

            query = "SELECT ef.ef_id, ef.ef_id_view, ef.submit_name, ef.submit_country, ef.submit_contact, ef.date_calculated," +
                "ef.date_received, ef.date_published, " +
                "ef.mi_id, ef.mi_key, ef.mi_id_06, ef.mi_key_06, ef.prop_tech, ef.prop_param, ef.prop_regional, ef.prop_control, " +
                "ef.prop_other, ef.ef_desc, ef.ef_value, u.uni_name as uni_name, ef.ef_value_cu, cu.uni_name as uni_name_cu, ef.ef_equation, ef.ipcc_sheet," +
                "ef.source_data, ef.tref_fullref, ef.tref_language, ef.tref_abstract, ef.conf_upper, ef.conf_lower, ef.data_quality," +
                "ef.distrib_id, ef.dq_ref, ef.dq_other_info, ef.ef_type_id, ef.meas_standard, ef.meas_freq, ef.meas_ext_qual_control," +
                "ef.meas_date, ef.comments_provider, ef.comments_others, ef.url " +
                "FROM((emission_factor ef " +
                "INNER JOIN unit u ON ef.uni_id = u.uni_id) " +
                "LEFT JOIN unit cu ON ef.ef_com_unit_id = cu.uni_id) ";
            if (sector != "0")
            {
                query = query + "WHERE ef.ef_id_view LIKE '" + sector + "%' ";
                if (sector == "2")
                    query = query + "OR ef.ef_id_view LIKE '3%' ";

            }

            WorkerParams Wparams = new WorkerParams();
            cmd = Connection.CreateCommand();
            cmd.CommandText = query;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                EF ef = new EF();
                ef.id = (int)rd["ef_id"];
                ef.id_view = (int)rd["ef_id_view"];
                ef.submit_name = rd["submit_name"].ToString();
                ef.submit_country = rd["submit_country"].ToString();
                ef.submit_contact = rd["submit_contact"].ToString();
                ef.date_calculated = rd["date_calculated"].ToString();
                ef.date_received = rd["date_received"].ToString();
                ef.date_published = rd["date_published"].ToString();
                ef.gases = efGasDict[ef.id];
                ef.ipcc1996 = efIpcc96Dict[ef.id];
                ef.ipcc2006 = efIpcc06Dict[ef.id];
                ef.mi_id = (short)rd["mi_id"];
                ef.mi_key = rd["mi_key"].ToString();
                ef.mi_id_06 = (short)rd["mi_id_06"];
                ef.mi_key_06 = rd["mi_key_06"].ToString();
                ef.prop_tech = rd["prop_tech"].ToString();
                ef.prop_param = rd["prop_param"].ToString();
                ef.prop_regional = rd["prop_regional"].ToString();
                ef.prop_control = rd["prop_control"].ToString();
                ef.prop_other = rd["prop_other"].ToString();
                ef.ef_desc = rd["ef_desc"].ToString();
                ef.ef_value = rd["ef_value"].ToString();
                ef.uni_name = rd["uni_name"].ToString();
                ef.ef_value_cu = rd["ef_value_cu"].ToString();
                ef.ef_com_unit_name = rd["uni_name_cu"].ToString();
                ef.ef_equation = rd["ef_equation"].ToString();
                ef.ipcc_sheet = rd["ipcc_sheet"].ToString();
                ef.source_data = rd["source_data"].ToString();
                ef.tref_fullref = rd["tref_fullref"].ToString();
                ef.tref_language = rd["tref_language"].ToString();
                ef.tref_abstract = rd["tref_abstract"].ToString();
                ef.conf_upper = rd["conf_upper"].ToString();
                ef.conf_lower = rd["conf_lower"].ToString();
                ef.data_quality = rd["data_quality"].ToString();
                ef.distrib_id = (short)rd["distrib_id"];
                ef.dq_ref = rd["dq_ref"].ToString();
                ef.dq_other_info = rd["dq_other_info"].ToString();
                ef.ef_type_id = (short)rd["ef_type_id"];
                ef.meas_standard = rd["meas_standard"].ToString();
                ef.meas_freq = rd["meas_freq"].ToString();
                ef.meas_ext_qual_control = rd["meas_ext_qual_control"].ToString();
                ef.meas_date = rd["meas_date"].ToString();
                ef.comments_provider = rd["comments_provider"].ToString();
                ef.comments_others = rd["comments_others"].ToString();
                ef.url = rd["url"].ToString();

                Wparams.EFList1.Add(ef);
                Wparams.EFList2.Add(ef);
            }
            rd.Close();


            pBar.Value = 0;
            pBar.Maximum = Wparams.EFList1.Count;
            txtResult.Text = "";
            SetControlState(false);
            bgWorker.RunWorkerAsync(Wparams);
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkerParams Params = (WorkerParams)e.Argument;
            e.Result = "";
            
            foreach (EF ef1 in Params.EFList1)
            {
                string result = "";
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                bgWorker.ReportProgress(0);
                if (ef1.skip)
                    continue;

                foreach (EF ef2 in Params.EFList2)
                {
                    if (ef1.id == ef2.id || ef2.skip)
                        continue;

                    if (submit_name.Checked && ef1.submit_name != ef2.submit_name)
                        continue;
                    if (submit_country.Checked && ef1.submit_country != ef2.submit_country)
                        continue;
                    if (submit_contact.Checked && ef1.submit_contact != ef2.submit_contact)
                        continue;
                    if (date_calculated.Checked && ef1.date_calculated != ef2.date_calculated)
                        continue;
                    if (date_received.Checked && ef1.date_received != ef2.date_received)
                        continue;
                    if (date_published.Checked && ef1.date_published != ef2.date_published)
                        continue;
                    if (gas.Checked && !ListsEqual(ef1.gases, ef2.gases))
                        continue;
                    if (ipcc1996.Checked && !ListsEqual(ef1.ipcc1996, ef2.ipcc1996))
                        continue;
                    if (ipcc2006.Checked && !ListsEqual(ef1.ipcc2006, ef2.ipcc2006))
                        continue;
                    if (mi_id.Checked && ef1.mi_id != ef2.mi_id)
                        continue;
                    if (mi_key.Checked && ef1.mi_key != ef2.mi_key)
                        continue;
                    if (mi_id_06.Checked && ef1.mi_id_06 != ef2.mi_id_06)
                        continue;
                    if (mi_key_06.Checked && ef1.mi_key_06 != ef2.mi_key_06)
                        continue;
                    if (prop_tech.Checked && ef1.prop_tech != ef2.prop_tech)
                        continue;
                    if (prop_param.Checked && ef1.prop_param != ef2.prop_param)
                        continue;
                    if (prop_regional.Checked && ef1.prop_regional != ef2.prop_regional)
                        continue;
                    if (prop_control.Checked && ef1.prop_control != ef2.prop_control)
                        continue;
                    if (prop_other.Checked && ef1.prop_other != ef2.prop_other)
                        continue;
                    if (ef_desc.Checked && ef1.ef_desc != ef2.ef_desc)
                        continue;
                    if (ef_value.Checked && ef1.ef_value != ef2.ef_value)
                        continue;
                    if (uni_id.Checked && ef1.uni_name != ef2.uni_name)
                        continue;
                    if (ef_value_cu.Checked && ef1.ef_value_cu != ef2.ef_value_cu)
                        continue;
                    if (ef_com_unit_id.Checked && ef1.ef_com_unit_name != ef2.ef_com_unit_name)
                        continue;
                    if (ef_equation.Checked && ef1.ef_equation != ef2.ef_equation)
                        continue;
                    if (ipcc_sheet.Checked && ef1.ipcc_sheet != ef2.ipcc_sheet)
                        continue;
                    if (source_data.Checked && ef1.source_data != ef2.source_data)
                        continue;
                    if (tref_fullref.Checked && ef1.tref_fullref != ef2.tref_fullref)
                        continue;
                    if (tref_language.Checked && ef1.tref_language != ef2.tref_language)
                        continue;
                    if (tref_abstract.Checked && ef1.tref_abstract != ef2.tref_abstract)
                        continue;
                    if (conf_upper.Checked && ef1.conf_upper != ef2.conf_upper)
                        continue;
                    if (conf_lower.Checked && ef1.conf_lower != ef2.conf_lower)
                        continue;
                    if (data_quality.Checked && ef1.data_quality != ef2.data_quality)
                        continue;
                    if (distrib_id.Checked && ef1.distrib_id != ef2.distrib_id)
                        continue;
                    if (dq_ref.Checked && ef1.dq_ref != ef2.dq_ref)
                        continue;
                    if (dq_other_info.Checked && ef1.dq_other_info != ef2.dq_other_info)
                        continue;
                    if (ef_type_id.Checked && ef1.ef_type_id != ef2.ef_type_id)
                        continue;
                    else if (ef1.ef_type_id == 1)
                    {
                        if (meas_standard.Checked && ef1.meas_standard != ef2.meas_standard)
                            continue;
                        if (meas_freq.Checked && ef1.meas_freq != ef2.meas_freq)
                            continue;
                        if (meas_ext_qual_control.Checked && ef1.meas_ext_qual_control != ef2.meas_ext_qual_control)
                            continue;
                        if (meas_date.Checked && ef1.meas_date != ef2.meas_date)
                            continue;
                    }
                    if (comments_provider.Checked && ef1.comments_provider != ef2.comments_provider)
                        continue;
                    if (comments_others.Checked && ef1.comments_others != ef2.comments_others)
                        continue;
                    if (url.Checked && ef1.url != ef2.url)
                        continue;

                    if (!ef1.skip)
                    {
                        ef1.skip = true;
                        result = ef1.id_view.ToString();
                    }

                    result = result + ", " + ef2.id_view.ToString();

                    ef2.skip = true;
                }

                if (result != "")
                    e.Result +="Match:  " + result + Environment.NewLine + Environment.NewLine;
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBar.Increment(1);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                txtResult.Text = "Operation Cancelled by user";
                pBar.Value = 0;
            }
            else
                txtResult.Text = e.Result.ToString();
            SetControlState(true);

        }
        public void SetControlState(bool enabled)
        {

            groupBox1.Enabled = enabled;
            button1.Enabled = enabled;
            cbxSector.Enabled = enabled;
            btnStart.Enabled = enabled;
            btnSelect.Enabled = enabled;
            btnUnselect.Enabled = enabled;
            btnCancel.Enabled = !enabled;

        }
        public bool Checked()
        {
            int count = 0;
            foreach (CheckBox ChBox in groupBox1.Controls)
            {
                if (ChBox.Checked)
                    count++;
            }
            if (count == 0)
            {
                MessageBox.Show("You need to have checked at least 1 data to compare", "EFDB comparer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
                
        }
        public bool WantsToContinue()
        {
            var result = MessageBox.Show("This operation might take some time. Continue?", "EFDB Comparer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
                return false;
            else
                return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bgWorker.WorkerSupportsCancellation)
            {
                bgWorker.CancelAsync();
            }
        }
    }
}
