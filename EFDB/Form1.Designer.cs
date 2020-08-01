namespace EFDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.submit_name = new System.Windows.Forms.CheckBox();
            this.submit_country = new System.Windows.Forms.CheckBox();
            this.submit_contact = new System.Windows.Forms.CheckBox();
            this.date_calculated = new System.Windows.Forms.CheckBox();
            this.date_received = new System.Windows.Forms.CheckBox();
            this.date_published = new System.Windows.Forms.CheckBox();
            this.gas = new System.Windows.Forms.CheckBox();
            this.ipcc1996 = new System.Windows.Forms.CheckBox();
            this.ipcc2006 = new System.Windows.Forms.CheckBox();
            this.mi_id = new System.Windows.Forms.CheckBox();
            this.url = new System.Windows.Forms.CheckBox();
            this.mi_key = new System.Windows.Forms.CheckBox();
            this.mi_id_06 = new System.Windows.Forms.CheckBox();
            this.mi_key_06 = new System.Windows.Forms.CheckBox();
            this.prop_tech = new System.Windows.Forms.CheckBox();
            this.prop_param = new System.Windows.Forms.CheckBox();
            this.prop_regional = new System.Windows.Forms.CheckBox();
            this.prop_control = new System.Windows.Forms.CheckBox();
            this.prop_other = new System.Windows.Forms.CheckBox();
            this.ef_desc = new System.Windows.Forms.CheckBox();
            this.ef_value = new System.Windows.Forms.CheckBox();
            this.uni_id = new System.Windows.Forms.CheckBox();
            this.ef_value_cu = new System.Windows.Forms.CheckBox();
            this.ef_com_unit_id = new System.Windows.Forms.CheckBox();
            this.ef_equation = new System.Windows.Forms.CheckBox();
            this.ipcc_sheet = new System.Windows.Forms.CheckBox();
            this.source_data = new System.Windows.Forms.CheckBox();
            this.tref_fullref = new System.Windows.Forms.CheckBox();
            this.tref_language = new System.Windows.Forms.CheckBox();
            this.tref_abstract = new System.Windows.Forms.CheckBox();
            this.conf_upper = new System.Windows.Forms.CheckBox();
            this.conf_lower = new System.Windows.Forms.CheckBox();
            this.data_quality = new System.Windows.Forms.CheckBox();
            this.distrib_id = new System.Windows.Forms.CheckBox();
            this.dq_ref = new System.Windows.Forms.CheckBox();
            this.dq_other_info = new System.Windows.Forms.CheckBox();
            this.ef_type_id = new System.Windows.Forms.CheckBox();
            this.meas_freq = new System.Windows.Forms.CheckBox();
            this.meas_standard = new System.Windows.Forms.CheckBox();
            this.meas_ext_qual_control = new System.Windows.Forms.CheckBox();
            this.meas_date = new System.Windows.Forms.CheckBox();
            this.comments_provider = new System.Windows.Forms.CheckBox();
            this.comments_others = new System.Windows.Forms.CheckBox();
            this.cbxSector = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDBName
            // 
            this.txtDBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDBName.Location = new System.Drawing.Point(13, 13);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.ReadOnly = true;
            this.txtDBName.Size = new System.Drawing.Size(668, 20);
            this.txtDBName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(688, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // submit_name
            // 
            this.submit_name.AutoSize = true;
            this.submit_name.Checked = true;
            this.submit_name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.submit_name.Location = new System.Drawing.Point(6, 19);
            this.submit_name.Name = "submit_name";
            this.submit_name.Size = new System.Drawing.Size(91, 17);
            this.submit_name.TabIndex = 2;
            this.submit_name.Text = "Data Provider";
            this.submit_name.UseVisualStyleBackColor = true;
            // 
            // submit_country
            // 
            this.submit_country.AutoSize = true;
            this.submit_country.Checked = true;
            this.submit_country.CheckState = System.Windows.Forms.CheckState.Checked;
            this.submit_country.Location = new System.Drawing.Point(5, 42);
            this.submit_country.Name = "submit_country";
            this.submit_country.Size = new System.Drawing.Size(130, 17);
            this.submit_country.TabIndex = 3;
            this.submit_country.Text = "Data Provider Country";
            this.submit_country.UseVisualStyleBackColor = true;
            // 
            // submit_contact
            // 
            this.submit_contact.AutoSize = true;
            this.submit_contact.Checked = true;
            this.submit_contact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.submit_contact.Location = new System.Drawing.Point(5, 65);
            this.submit_contact.Name = "submit_contact";
            this.submit_contact.Size = new System.Drawing.Size(131, 17);
            this.submit_contact.TabIndex = 4;
            this.submit_contact.Text = "Data Provider Contact";
            this.submit_contact.UseVisualStyleBackColor = true;
            // 
            // date_calculated
            // 
            this.date_calculated.AutoSize = true;
            this.date_calculated.Checked = true;
            this.date_calculated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.date_calculated.Location = new System.Drawing.Point(5, 88);
            this.date_calculated.Name = "date_calculated";
            this.date_calculated.Size = new System.Drawing.Size(101, 17);
            this.date_calculated.TabIndex = 5;
            this.date_calculated.Text = "Date calculated";
            this.date_calculated.UseVisualStyleBackColor = true;
            // 
            // date_received
            // 
            this.date_received.AutoSize = true;
            this.date_received.Checked = true;
            this.date_received.CheckState = System.Windows.Forms.CheckState.Checked;
            this.date_received.Location = new System.Drawing.Point(5, 111);
            this.date_received.Name = "date_received";
            this.date_received.Size = new System.Drawing.Size(222, 17);
            this.date_received.TabIndex = 6;
            this.date_received.Text = "Date submitted to EFDB by Data Provider";
            this.date_received.UseVisualStyleBackColor = true;
            // 
            // date_published
            // 
            this.date_published.AutoSize = true;
            this.date_published.Checked = true;
            this.date_published.CheckState = System.Windows.Forms.CheckState.Checked;
            this.date_published.Location = new System.Drawing.Point(5, 134);
            this.date_published.Name = "date_published";
            this.date_published.Size = new System.Drawing.Size(168, 17);
            this.date_published.TabIndex = 7;
            this.date_published.Text = "Date posted to EFDB by IPCC";
            this.date_published.UseVisualStyleBackColor = true;
            // 
            // gas
            // 
            this.gas.AutoSize = true;
            this.gas.Checked = true;
            this.gas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gas.Location = new System.Drawing.Point(5, 157);
            this.gas.Name = "gas";
            this.gas.Size = new System.Drawing.Size(45, 17);
            this.gas.TabIndex = 8;
            this.gas.Text = "Gas";
            this.gas.UseVisualStyleBackColor = true;
            // 
            // ipcc1996
            // 
            this.ipcc1996.AutoSize = true;
            this.ipcc1996.Checked = true;
            this.ipcc1996.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ipcc1996.Location = new System.Drawing.Point(5, 180);
            this.ipcc1996.Name = "ipcc1996";
            this.ipcc1996.Size = new System.Drawing.Size(185, 17);
            this.ipcc1996.TabIndex = 9;
            this.ipcc1996.Text = "IPCC 1996 Source/Sink Category";
            this.ipcc1996.UseVisualStyleBackColor = true;
            // 
            // ipcc2006
            // 
            this.ipcc2006.AutoSize = true;
            this.ipcc2006.Checked = true;
            this.ipcc2006.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ipcc2006.Location = new System.Drawing.Point(5, 203);
            this.ipcc2006.Name = "ipcc2006";
            this.ipcc2006.Size = new System.Drawing.Size(185, 17);
            this.ipcc2006.TabIndex = 10;
            this.ipcc2006.Text = "IPCC 2006 Source/Sink Category";
            this.ipcc2006.UseVisualStyleBackColor = true;
            // 
            // mi_id
            // 
            this.mi_id.AutoSize = true;
            this.mi_id.Checked = true;
            this.mi_id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_id.Location = new System.Drawing.Point(5, 226);
            this.mi_id.Name = "mi_id";
            this.mi_id.Size = new System.Drawing.Size(118, 17);
            this.mi_id.TabIndex = 11;
            this.mi_id.Text = "Main identifier 1996";
            this.mi_id.UseVisualStyleBackColor = true;
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Checked = true;
            this.url.CheckState = System.Windows.Forms.CheckState.Checked;
            this.url.Location = new System.Drawing.Point(580, 249);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(46, 17);
            this.url.TabIndex = 12;
            this.url.Text = "Link";
            this.url.UseVisualStyleBackColor = true;
            // 
            // mi_key
            // 
            this.mi_key.AutoSize = true;
            this.mi_key.Checked = true;
            this.mi_key.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_key.Location = new System.Drawing.Point(256, 19);
            this.mi_key.Name = "mi_key";
            this.mi_key.Size = new System.Drawing.Size(138, 17);
            this.mi_key.TabIndex = 13;
            this.mi_key.Text = "Main identifier 1996 key";
            this.mi_key.UseVisualStyleBackColor = true;
            // 
            // mi_id_06
            // 
            this.mi_id_06.AutoSize = true;
            this.mi_id_06.Checked = true;
            this.mi_id_06.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_id_06.Location = new System.Drawing.Point(256, 42);
            this.mi_id_06.Name = "mi_id_06";
            this.mi_id_06.Size = new System.Drawing.Size(118, 17);
            this.mi_id_06.TabIndex = 14;
            this.mi_id_06.Text = "Main identifier 2006";
            this.mi_id_06.UseVisualStyleBackColor = true;
            // 
            // mi_key_06
            // 
            this.mi_key_06.AutoSize = true;
            this.mi_key_06.Checked = true;
            this.mi_key_06.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_key_06.Location = new System.Drawing.Point(256, 65);
            this.mi_key_06.Name = "mi_key_06";
            this.mi_key_06.Size = new System.Drawing.Size(138, 17);
            this.mi_key_06.TabIndex = 15;
            this.mi_key_06.Text = "Main identifier 2006 key";
            this.mi_key_06.UseVisualStyleBackColor = true;
            // 
            // prop_tech
            // 
            this.prop_tech.AutoSize = true;
            this.prop_tech.Checked = true;
            this.prop_tech.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prop_tech.Location = new System.Drawing.Point(256, 88);
            this.prop_tech.Name = "prop_tech";
            this.prop_tech.Size = new System.Drawing.Size(139, 17);
            this.prop_tech.TabIndex = 16;
            this.prop_tech.Text = "Technologies/Practices";
            this.prop_tech.UseVisualStyleBackColor = true;
            // 
            // prop_param
            // 
            this.prop_param.AutoSize = true;
            this.prop_param.Checked = true;
            this.prop_param.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prop_param.Location = new System.Drawing.Point(256, 111);
            this.prop_param.Name = "prop_param";
            this.prop_param.Size = new System.Drawing.Size(133, 17);
            this.prop_param.TabIndex = 17;
            this.prop_param.Text = "Parameters/Conditions";
            this.prop_param.UseVisualStyleBackColor = true;
            // 
            // prop_regional
            // 
            this.prop_regional.AutoSize = true;
            this.prop_regional.Checked = true;
            this.prop_regional.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prop_regional.Location = new System.Drawing.Point(256, 134);
            this.prop_regional.Name = "prop_regional";
            this.prop_regional.Size = new System.Drawing.Size(159, 17);
            this.prop_regional.TabIndex = 18;
            this.prop_regional.Text = "Region/Regional Conditions";
            this.prop_regional.UseVisualStyleBackColor = true;
            // 
            // prop_control
            // 
            this.prop_control.AutoSize = true;
            this.prop_control.Checked = true;
            this.prop_control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prop_control.Location = new System.Drawing.Point(256, 157);
            this.prop_control.Name = "prop_control";
            this.prop_control.Size = new System.Drawing.Size(182, 17);
            this.prop_control.TabIndex = 19;
            this.prop_control.Text = "Abatement/Control Technologies";
            this.prop_control.UseVisualStyleBackColor = true;
            // 
            // prop_other
            // 
            this.prop_other.AutoSize = true;
            this.prop_other.Checked = true;
            this.prop_other.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prop_other.Location = new System.Drawing.Point(256, 180);
            this.prop_other.Name = "prop_other";
            this.prop_other.Size = new System.Drawing.Size(57, 17);
            this.prop_other.TabIndex = 20;
            this.prop_other.Text = "Others";
            this.prop_other.UseVisualStyleBackColor = true;
            // 
            // ef_desc
            // 
            this.ef_desc.AutoSize = true;
            this.ef_desc.Checked = true;
            this.ef_desc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ef_desc.Location = new System.Drawing.Point(256, 203);
            this.ef_desc.Name = "ef_desc";
            this.ef_desc.Size = new System.Drawing.Size(79, 17);
            this.ef_desc.TabIndex = 21;
            this.ef_desc.Text = "Description";
            this.ef_desc.UseVisualStyleBackColor = true;
            // 
            // ef_value
            // 
            this.ef_value.AutoSize = true;
            this.ef_value.Checked = true;
            this.ef_value.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ef_value.Location = new System.Drawing.Point(256, 226);
            this.ef_value.Name = "ef_value";
            this.ef_value.Size = new System.Drawing.Size(53, 17);
            this.ef_value.TabIndex = 22;
            this.ef_value.Text = "Value";
            this.ef_value.UseVisualStyleBackColor = true;
            // 
            // uni_id
            // 
            this.uni_id.AutoSize = true;
            this.uni_id.Checked = true;
            this.uni_id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uni_id.Location = new System.Drawing.Point(256, 249);
            this.uni_id.Name = "uni_id";
            this.uni_id.Size = new System.Drawing.Size(45, 17);
            this.uni_id.TabIndex = 23;
            this.uni_id.Text = "Unit";
            this.uni_id.UseVisualStyleBackColor = true;
            // 
            // ef_value_cu
            // 
            this.ef_value_cu.AutoSize = true;
            this.ef_value_cu.Checked = true;
            this.ef_value_cu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ef_value_cu.Location = new System.Drawing.Point(442, 19);
            this.ef_value_cu.Name = "ef_value_cu";
            this.ef_value_cu.Size = new System.Drawing.Size(132, 17);
            this.ef_value_cu.TabIndex = 24;
            this.ef_value_cu.Text = "Value in common units";
            this.ef_value_cu.UseVisualStyleBackColor = true;
            // 
            // ef_com_unit_id
            // 
            this.ef_com_unit_id.AutoSize = true;
            this.ef_com_unit_id.Checked = true;
            this.ef_com_unit_id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ef_com_unit_id.Location = new System.Drawing.Point(442, 42);
            this.ef_com_unit_id.Name = "ef_com_unit_id";
            this.ef_com_unit_id.Size = new System.Drawing.Size(87, 17);
            this.ef_com_unit_id.TabIndex = 25;
            this.ef_com_unit_id.Text = "Common unit";
            this.ef_com_unit_id.UseVisualStyleBackColor = true;
            // 
            // ef_equation
            // 
            this.ef_equation.AutoSize = true;
            this.ef_equation.Checked = true;
            this.ef_equation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ef_equation.Location = new System.Drawing.Point(442, 65);
            this.ef_equation.Name = "ef_equation";
            this.ef_equation.Size = new System.Drawing.Size(68, 17);
            this.ef_equation.TabIndex = 26;
            this.ef_equation.Text = "Equation";
            this.ef_equation.UseVisualStyleBackColor = true;
            // 
            // ipcc_sheet
            // 
            this.ipcc_sheet.AutoSize = true;
            this.ipcc_sheet.Checked = true;
            this.ipcc_sheet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ipcc_sheet.Location = new System.Drawing.Point(442, 88);
            this.ipcc_sheet.Name = "ipcc_sheet";
            this.ipcc_sheet.Size = new System.Drawing.Size(105, 17);
            this.ipcc_sheet.TabIndex = 27;
            this.ipcc_sheet.Text = "IPCC Worksheet";
            this.ipcc_sheet.UseVisualStyleBackColor = true;
            // 
            // source_data
            // 
            this.source_data.AutoSize = true;
            this.source_data.Checked = true;
            this.source_data.CheckState = System.Windows.Forms.CheckState.Checked;
            this.source_data.Location = new System.Drawing.Point(442, 111);
            this.source_data.Name = "source_data";
            this.source_data.Size = new System.Drawing.Size(96, 17);
            this.source_data.TabIndex = 28;
            this.source_data.Text = "Source of data";
            this.source_data.UseVisualStyleBackColor = true;
            // 
            // tref_fullref
            // 
            this.tref_fullref.AutoSize = true;
            this.tref_fullref.Checked = true;
            this.tref_fullref.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tref_fullref.Location = new System.Drawing.Point(442, 134);
            this.tref_fullref.Name = "tref_fullref";
            this.tref_fullref.Size = new System.Drawing.Size(126, 17);
            this.tref_fullref.TabIndex = 29;
            this.tref_fullref.Text = "Technical Reference";
            this.tref_fullref.UseVisualStyleBackColor = true;
            // 
            // tref_language
            // 
            this.tref_language.AutoSize = true;
            this.tref_language.Checked = true;
            this.tref_language.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tref_language.Location = new System.Drawing.Point(442, 157);
            this.tref_language.Name = "tref_language";
            this.tref_language.Size = new System.Drawing.Size(123, 17);
            this.tref_language.TabIndex = 30;
            this.tref_language.Text = "Reference language";
            this.tref_language.UseVisualStyleBackColor = true;
            // 
            // tref_abstract
            // 
            this.tref_abstract.AutoSize = true;
            this.tref_abstract.Checked = true;
            this.tref_abstract.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tref_abstract.Location = new System.Drawing.Point(442, 180);
            this.tref_abstract.Name = "tref_abstract";
            this.tref_abstract.Size = new System.Drawing.Size(113, 17);
            this.tref_abstract.TabIndex = 31;
            this.tref_abstract.Text = "Abstract in English";
            this.tref_abstract.UseVisualStyleBackColor = true;
            // 
            // conf_upper
            // 
            this.conf_upper.AutoSize = true;
            this.conf_upper.Checked = true;
            this.conf_upper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.conf_upper.Location = new System.Drawing.Point(442, 203);
            this.conf_upper.Name = "conf_upper";
            this.conf_upper.Size = new System.Drawing.Size(131, 17);
            this.conf_upper.TabIndex = 32;
            this.conf_upper.Text = "Upper confidence limit";
            this.conf_upper.UseVisualStyleBackColor = true;
            // 
            // conf_lower
            // 
            this.conf_lower.AutoSize = true;
            this.conf_lower.Checked = true;
            this.conf_lower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.conf_lower.Location = new System.Drawing.Point(442, 226);
            this.conf_lower.Name = "conf_lower";
            this.conf_lower.Size = new System.Drawing.Size(131, 17);
            this.conf_lower.TabIndex = 33;
            this.conf_lower.Text = "Lower confidence limit";
            this.conf_lower.UseVisualStyleBackColor = true;
            // 
            // data_quality
            // 
            this.data_quality.AutoSize = true;
            this.data_quality.Checked = true;
            this.data_quality.CheckState = System.Windows.Forms.CheckState.Checked;
            this.data_quality.Location = new System.Drawing.Point(442, 249);
            this.data_quality.Name = "data_quality";
            this.data_quality.Size = new System.Drawing.Size(82, 17);
            this.data_quality.TabIndex = 34;
            this.data_quality.Text = "Data quality";
            this.data_quality.UseVisualStyleBackColor = true;
            // 
            // distrib_id
            // 
            this.distrib_id.AutoSize = true;
            this.distrib_id.Checked = true;
            this.distrib_id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.distrib_id.Location = new System.Drawing.Point(580, 19);
            this.distrib_id.Name = "distrib_id";
            this.distrib_id.Size = new System.Drawing.Size(110, 17);
            this.distrib_id.TabIndex = 35;
            this.distrib_id.Text = "Distribution shape";
            this.distrib_id.UseVisualStyleBackColor = true;
            // 
            // dq_ref
            // 
            this.dq_ref.AutoSize = true;
            this.dq_ref.Checked = true;
            this.dq_ref.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dq_ref.Location = new System.Drawing.Point(580, 42);
            this.dq_ref.Name = "dq_ref";
            this.dq_ref.Size = new System.Drawing.Size(130, 17);
            this.dq_ref.TabIndex = 36;
            this.dq_ref.Text = "Data quality reference";
            this.dq_ref.UseVisualStyleBackColor = true;
            // 
            // dq_other_info
            // 
            this.dq_other_info.AutoSize = true;
            this.dq_other_info.Checked = true;
            this.dq_other_info.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dq_other_info.Location = new System.Drawing.Point(580, 65);
            this.dq_other_info.Name = "dq_other_info";
            this.dq_other_info.Size = new System.Drawing.Size(144, 17);
            this.dq_other_info.TabIndex = 37;
            this.dq_other_info.Text = "Other info on data quality";
            this.dq_other_info.UseVisualStyleBackColor = true;
            // 
            // ef_type_id
            // 
            this.ef_type_id.AutoSize = true;
            this.ef_type_id.Checked = true;
            this.ef_type_id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ef_type_id.Location = new System.Drawing.Point(580, 88);
            this.ef_type_id.Name = "ef_type_id";
            this.ef_type_id.Size = new System.Drawing.Size(112, 17);
            this.ef_type_id.TabIndex = 38;
            this.ef_type_id.Text = "Type of parameter";
            this.ef_type_id.UseVisualStyleBackColor = true;
            // 
            // meas_freq
            // 
            this.meas_freq.AutoSize = true;
            this.meas_freq.Checked = true;
            this.meas_freq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.meas_freq.Location = new System.Drawing.Point(580, 134);
            this.meas_freq.Name = "meas_freq";
            this.meas_freq.Size = new System.Drawing.Size(140, 17);
            this.meas_freq.TabIndex = 39;
            this.meas_freq.Text = "Measurement frequency";
            this.meas_freq.UseVisualStyleBackColor = true;
            // 
            // meas_standard
            // 
            this.meas_standard.AutoSize = true;
            this.meas_standard.Checked = true;
            this.meas_standard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.meas_standard.Location = new System.Drawing.Point(580, 111);
            this.meas_standard.Name = "meas_standard";
            this.meas_standard.Size = new System.Drawing.Size(134, 17);
            this.meas_standard.TabIndex = 39;
            this.meas_standard.Text = "Measurement standard";
            this.meas_standard.UseVisualStyleBackColor = true;
            // 
            // meas_ext_qual_control
            // 
            this.meas_ext_qual_control.AutoSize = true;
            this.meas_ext_qual_control.Checked = true;
            this.meas_ext_qual_control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.meas_ext_qual_control.Location = new System.Drawing.Point(580, 157);
            this.meas_ext_qual_control.Name = "meas_ext_qual_control";
            this.meas_ext_qual_control.Size = new System.Drawing.Size(198, 17);
            this.meas_ext_qual_control.TabIndex = 40;
            this.meas_ext_qual_control.Text = "Measurement external quality control";
            this.meas_ext_qual_control.UseVisualStyleBackColor = true;
            // 
            // meas_date
            // 
            this.meas_date.AutoSize = true;
            this.meas_date.Checked = true;
            this.meas_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.meas_date.Location = new System.Drawing.Point(580, 180);
            this.meas_date.Name = "meas_date";
            this.meas_date.Size = new System.Drawing.Size(114, 17);
            this.meas_date.TabIndex = 41;
            this.meas_date.Text = "Measurement date";
            this.meas_date.UseVisualStyleBackColor = true;
            // 
            // comments_provider
            // 
            this.comments_provider.AutoSize = true;
            this.comments_provider.Checked = true;
            this.comments_provider.CheckState = System.Windows.Forms.CheckState.Checked;
            this.comments_provider.Location = new System.Drawing.Point(580, 203);
            this.comments_provider.Name = "comments_provider";
            this.comments_provider.Size = new System.Drawing.Size(181, 17);
            this.comments_provider.TabIndex = 42;
            this.comments_provider.Text = "Comments from the data provider";
            this.comments_provider.UseVisualStyleBackColor = true;
            // 
            // comments_others
            // 
            this.comments_others.AutoSize = true;
            this.comments_others.Checked = true;
            this.comments_others.CheckState = System.Windows.Forms.CheckState.Checked;
            this.comments_others.Location = new System.Drawing.Point(580, 226);
            this.comments_others.Name = "comments_others";
            this.comments_others.Size = new System.Drawing.Size(130, 17);
            this.comments_others.TabIndex = 43;
            this.comments_others.Text = "Comments from others";
            this.comments_others.UseVisualStyleBackColor = true;
            // 
            // cbxSector
            // 
            this.cbxSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSector.FormattingEnabled = true;
            this.cbxSector.Items.AddRange(new object[] {
            "(All)",
            "Energy",
            "Industrial Processes",
            "Agriculture",
            "LUCF",
            "Waste"});
            this.cbxSector.Location = new System.Drawing.Point(57, 327);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Size = new System.Drawing.Size(121, 21);
            this.cbxSector.TabIndex = 44;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(184, 327);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 45;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(13, 378);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(779, 227);
            this.txtResult.TabIndex = 46;
            this.txtResult.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Sector:";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(636, 320);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 48;
            this.btnSelect.Text = "Select All";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUnselect
            // 
            this.btnUnselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnselect.Location = new System.Drawing.Point(717, 320);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(75, 23);
            this.btnUnselect.TabIndex = 49;
            this.btnUnselect.Text = "Unselect All";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.submit_name);
            this.groupBox1.Controls.Add(this.submit_country);
            this.groupBox1.Controls.Add(this.submit_contact);
            this.groupBox1.Controls.Add(this.date_calculated);
            this.groupBox1.Controls.Add(this.date_received);
            this.groupBox1.Controls.Add(this.date_published);
            this.groupBox1.Controls.Add(this.gas);
            this.groupBox1.Controls.Add(this.comments_others);
            this.groupBox1.Controls.Add(this.ipcc1996);
            this.groupBox1.Controls.Add(this.comments_provider);
            this.groupBox1.Controls.Add(this.ipcc2006);
            this.groupBox1.Controls.Add(this.meas_date);
            this.groupBox1.Controls.Add(this.mi_id);
            this.groupBox1.Controls.Add(this.meas_ext_qual_control);
            this.groupBox1.Controls.Add(this.url);
            this.groupBox1.Controls.Add(this.meas_standard);
            this.groupBox1.Controls.Add(this.mi_key);
            this.groupBox1.Controls.Add(this.meas_freq);
            this.groupBox1.Controls.Add(this.mi_id_06);
            this.groupBox1.Controls.Add(this.ef_type_id);
            this.groupBox1.Controls.Add(this.mi_key_06);
            this.groupBox1.Controls.Add(this.dq_other_info);
            this.groupBox1.Controls.Add(this.prop_tech);
            this.groupBox1.Controls.Add(this.dq_ref);
            this.groupBox1.Controls.Add(this.prop_param);
            this.groupBox1.Controls.Add(this.distrib_id);
            this.groupBox1.Controls.Add(this.prop_regional);
            this.groupBox1.Controls.Add(this.data_quality);
            this.groupBox1.Controls.Add(this.prop_control);
            this.groupBox1.Controls.Add(this.conf_lower);
            this.groupBox1.Controls.Add(this.prop_other);
            this.groupBox1.Controls.Add(this.conf_upper);
            this.groupBox1.Controls.Add(this.ef_desc);
            this.groupBox1.Controls.Add(this.tref_abstract);
            this.groupBox1.Controls.Add(this.ef_value);
            this.groupBox1.Controls.Add(this.tref_language);
            this.groupBox1.Controls.Add(this.uni_id);
            this.groupBox1.Controls.Add(this.tref_fullref);
            this.groupBox1.Controls.Add(this.ef_value_cu);
            this.groupBox1.Controls.Add(this.source_data);
            this.groupBox1.Controls.Add(this.ef_com_unit_id);
            this.groupBox1.Controls.Add(this.ipcc_sheet);
            this.groupBox1.Controls.Add(this.ef_equation);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 275);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which data to compare";
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar.Location = new System.Drawing.Point(13, 354);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(779, 18);
            this.pBar.TabIndex = 51;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(266, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 617);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxSector);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDBName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EFDB Comparer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox submit_name;
        private System.Windows.Forms.CheckBox submit_country;
        private System.Windows.Forms.CheckBox submit_contact;
        private System.Windows.Forms.CheckBox date_calculated;
        private System.Windows.Forms.CheckBox date_received;
        private System.Windows.Forms.CheckBox date_published;
        private System.Windows.Forms.CheckBox gas;
        private System.Windows.Forms.CheckBox ipcc1996;
        private System.Windows.Forms.CheckBox ipcc2006;
        private System.Windows.Forms.CheckBox mi_id;
        private System.Windows.Forms.CheckBox url;
        private System.Windows.Forms.CheckBox mi_key;
        private System.Windows.Forms.CheckBox mi_id_06;
        private System.Windows.Forms.CheckBox mi_key_06;
        private System.Windows.Forms.CheckBox prop_tech;
        private System.Windows.Forms.CheckBox prop_param;
        private System.Windows.Forms.CheckBox prop_regional;
        private System.Windows.Forms.CheckBox prop_control;
        private System.Windows.Forms.CheckBox prop_other;
        private System.Windows.Forms.CheckBox ef_desc;
        private System.Windows.Forms.CheckBox ef_value;
        private System.Windows.Forms.CheckBox uni_id;
        private System.Windows.Forms.CheckBox ef_value_cu;
        private System.Windows.Forms.CheckBox ef_com_unit_id;
        private System.Windows.Forms.CheckBox ef_equation;
        private System.Windows.Forms.CheckBox ipcc_sheet;
        private System.Windows.Forms.CheckBox source_data;
        private System.Windows.Forms.CheckBox tref_fullref;
        private System.Windows.Forms.CheckBox tref_language;
        private System.Windows.Forms.CheckBox tref_abstract;
        private System.Windows.Forms.CheckBox conf_upper;
        private System.Windows.Forms.CheckBox conf_lower;
        private System.Windows.Forms.CheckBox data_quality;
        private System.Windows.Forms.CheckBox distrib_id;
        private System.Windows.Forms.CheckBox dq_ref;
        private System.Windows.Forms.CheckBox dq_other_info;
        private System.Windows.Forms.CheckBox ef_type_id;
        private System.Windows.Forms.CheckBox meas_freq;
        private System.Windows.Forms.CheckBox meas_standard;
        private System.Windows.Forms.CheckBox meas_ext_qual_control;
        private System.Windows.Forms.CheckBox meas_date;
        private System.Windows.Forms.CheckBox comments_provider;
        private System.Windows.Forms.CheckBox comments_others;
        private System.Windows.Forms.ComboBox cbxSector;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button btnCancel;
    }
}

