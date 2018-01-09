namespace lasoda
{
    partial class Lasodamanage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lasodamanage));
            this.disabilityCauseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lasodaDataSet = new lasoda.LasodaDataSet();
            this.affectedBodyPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disabilitySeverityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disabilityTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impairmentDurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onsetOfDisabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualImpairmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hearingImpairmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biographicDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lasodaDataSetBiography = new lasoda.LasodaDataSetBiography();
            this.epUserAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.disabilityTypeTableAdapter = new lasoda.LasodaDataSetTableAdapters.DisabilityTypeTableAdapter();
            this.impairmentDurationTableAdapter = new lasoda.LasodaDataSetTableAdapters.ImpairmentDurationTableAdapter();
            this.onsetOfDisabilityTableAdapter = new lasoda.LasodaDataSetTableAdapters.OnsetOfDisabilityTableAdapter();
            this.visualImpairmentTableAdapter = new lasoda.LasodaDataSetTableAdapters.VisualImpairmentTableAdapter();
            this.disabilityCauseTableAdapter = new lasoda.LasodaDataSetTableAdapters.DisabilityCauseTableAdapter();
            this.disabilitySeverityTableAdapter = new lasoda.LasodaDataSetTableAdapters.DisabilitySeverityTableAdapter();
            this.affectedBodyPartTableAdapter = new lasoda.LasodaDataSetTableAdapters.AffectedBodyPartTableAdapter();
            this.hearingImpairmentTableAdapter = new lasoda.LasodaDataSetTableAdapters.HearingImpairmentTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.biographicDetailTableAdapter = new lasoda.LasodaDataSetBiographyTableAdapters.BiographicDetailTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tpReports = new System.Windows.Forms.TabPage();
            this.menustripReports = new System.Windows.Forms.MenuStrip();
            this.msReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miSummaryByUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miBasicDetailReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailReportbyDisabilityType = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailReportByUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailReportbyAgeBracket = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailReportByAgeandgender = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailReportByGenderandDisability = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailReportbyDisabilityCauseandType = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailReportByDisabilityTypeandSeverity = new System.Windows.Forms.ToolStripMenuItem();
            this.miBasicDetailReportByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.miBasicDetailReportbyCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbProfileVisual = new System.Windows.Forms.ComboBox();
            this.cbProfileKinRelationship = new System.Windows.Forms.ComboBox();
            this.cbProfileOnset = new System.Windows.Forms.ComboBox();
            this.tbProfileMedicalAddress = new System.Windows.Forms.TextBox();
            this.tbProfileMedicalNum = new System.Windows.Forms.TextBox();
            this.tbProfileMedicalName = new System.Windows.Forms.TextBox();
            this.tbProfileKinOther = new System.Windows.Forms.TextBox();
            this.tbProfileKinPhone = new System.Windows.Forms.TextBox();
            this.cbProfilePsycho = new System.Windows.Forms.ComboBox();
            this.tbProfileKinFirst = new System.Windows.Forms.TextBox();
            this.cbProfilePart = new System.Windows.Forms.ComboBox();
            this.tbProfileKinAddress = new System.Windows.Forms.TextBox();
            this.cbProfileHearing = new System.Windows.Forms.ComboBox();
            this.tbProfileKinSurname = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbprofileGender = new System.Windows.Forms.GroupBox();
            this.rbProfileFemale = new System.Windows.Forms.RadioButton();
            this.rbProfileMale = new System.Windows.Forms.RadioButton();
            this.cbProfileType = new System.Windows.Forms.ComboBox();
            this.cbProfileNeuro = new System.Windows.Forms.ComboBox();
            this.dtpProfileDOB = new System.Windows.Forms.DateTimePicker();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.cbProfileCause = new System.Windows.Forms.ComboBox();
            this.cbProfileSeverity = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.cbProfileDuration = new System.Windows.Forms.ComboBox();
            this.tbProfileAddress = new System.Windows.Forms.TextBox();
            this.tbProfilePhone = new System.Windows.Forms.TextBox();
            this.tbProfileSurname = new System.Windows.Forms.TextBox();
            this.tbProfileFirstname = new System.Windows.Forms.TextBox();
            this.tbProfileEmail = new System.Windows.Forms.TextBox();
            this.tbProfileotherName = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.dgvViewProfile = new System.Windows.Forms.DataGridView();
            this.biodataIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biodataIntegerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasrraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disabilityTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disabilityCauseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disabilitySeverityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impairmentDurationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neuroDisabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psychiatricDisabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affectedBodyPartIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualImpairmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hearingImpairmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onsetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othernameKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipKinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesMedicalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipNumberMedicalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressMedicalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLastModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ssManageUser = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.bClear = new System.Windows.Forms.Button();
            this.bUser = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbDeactivate = new System.Windows.Forms.RadioButton();
            this.rbActivate = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.tbPass1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRegistration = new System.Windows.Forms.TabControl();
            this.tpPersonal = new System.Windows.Forms.TabPage();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.bBrowsePhoto = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.lfilename = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbLasrraID = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbOthername = new System.Windows.Forms.TextBox();
            this.tbRessidence = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbDisabilityID = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.tbPhonenumber = new System.Windows.Forms.TextBox();
            this.tpNextOfKin = new System.Windows.Forms.TabPage();
            this.statusStrip4 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tbKinAddress = new System.Windows.Forms.TextBox();
            this.cbkinRelationship = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tbKinSurname = new System.Windows.Forms.TextBox();
            this.tbKinFirstName = new System.Windows.Forms.TextBox();
            this.tbKinOtherName = new System.Windows.Forms.TextBox();
            this.tbKinPhone = new System.Windows.Forms.TextBox();
            this.tpDisabilityInfo = new System.Windows.Forms.TabPage();
            this.statusStrip5 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.button21 = new System.Windows.Forms.Button();
            this.bDisabilitySave = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.cbCause = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.lbNeuro = new System.Windows.Forms.ListBox();
            this.cbBodyParts = new System.Windows.Forms.ComboBox();
            this.cbSeverity = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.cbDisabilityType = new System.Windows.Forms.ComboBox();
            this.cbDisabilityDuration = new System.Windows.Forms.ComboBox();
            this.cbOnset = new System.Windows.Forms.ComboBox();
            this.cbVisual = new System.Windows.Forms.ComboBox();
            this.cbHearing = new System.Windows.Forms.ComboBox();
            this.lbPsychiatric = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tpMedicalOfficer = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tbOficerName = new System.Windows.Forms.TextBox();
            this.tbOfficerNumber = new System.Windows.Forms.TextBox();
            this.tbOfficerAddress = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tpLasodaMain = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCurrentUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbLasodaApp = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.disabilityCauseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasodaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectedBodyPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disabilitySeverityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disabilityTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impairmentDurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onsetOfDisabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualImpairmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearingImpairmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biographicDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasodaDataSetBiography)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserAccount)).BeginInit();
            this.tpReports.SuspendLayout();
            this.menustripReports.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbprofileGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewProfile)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbRegistration.SuspendLayout();
            this.tpPersonal.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.tpNextOfKin.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tpDisabilityInfo.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tpMedicalOfficer.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tpLasodaMain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbLasodaApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // disabilityCauseBindingSource
            // 
            this.disabilityCauseBindingSource.DataMember = "DisabilityCause";
            this.disabilityCauseBindingSource.DataSource = this.lasodaDataSet;
            // 
            // lasodaDataSet
            // 
            this.lasodaDataSet.DataSetName = "LasodaDataSet";
            this.lasodaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // affectedBodyPartBindingSource
            // 
            this.affectedBodyPartBindingSource.DataMember = "AffectedBodyPart";
            this.affectedBodyPartBindingSource.DataSource = this.lasodaDataSet;
            // 
            // disabilitySeverityBindingSource
            // 
            this.disabilitySeverityBindingSource.DataMember = "DisabilitySeverity";
            this.disabilitySeverityBindingSource.DataSource = this.lasodaDataSet;
            // 
            // disabilityTypeBindingSource
            // 
            this.disabilityTypeBindingSource.DataMember = "DisabilityType";
            this.disabilityTypeBindingSource.DataSource = this.lasodaDataSet;
            // 
            // impairmentDurationBindingSource
            // 
            this.impairmentDurationBindingSource.DataMember = "ImpairmentDuration";
            this.impairmentDurationBindingSource.DataSource = this.lasodaDataSet;
            // 
            // onsetOfDisabilityBindingSource
            // 
            this.onsetOfDisabilityBindingSource.DataMember = "OnsetOfDisability";
            this.onsetOfDisabilityBindingSource.DataSource = this.lasodaDataSet;
            // 
            // visualImpairmentBindingSource
            // 
            this.visualImpairmentBindingSource.DataMember = "VisualImpairment";
            this.visualImpairmentBindingSource.DataSource = this.lasodaDataSet;
            // 
            // hearingImpairmentBindingSource
            // 
            this.hearingImpairmentBindingSource.DataMember = "HearingImpairment";
            this.hearingImpairmentBindingSource.DataSource = this.lasodaDataSet;
            // 
            // biographicDetailBindingSource
            // 
            this.biographicDetailBindingSource.DataMember = "BiographicDetail";
            this.biographicDetailBindingSource.DataSource = this.lasodaDataSetBiography;
            // 
            // lasodaDataSetBiography
            // 
            this.lasodaDataSetBiography.DataSetName = "LasodaDataSetBiography";
            this.lasodaDataSetBiography.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // epUserAccount
            // 
            this.epUserAccount.ContainerControl = this;
            // 
            // disabilityTypeTableAdapter
            // 
            this.disabilityTypeTableAdapter.ClearBeforeFill = true;
            // 
            // impairmentDurationTableAdapter
            // 
            this.impairmentDurationTableAdapter.ClearBeforeFill = true;
            // 
            // onsetOfDisabilityTableAdapter
            // 
            this.onsetOfDisabilityTableAdapter.ClearBeforeFill = true;
            // 
            // visualImpairmentTableAdapter
            // 
            this.visualImpairmentTableAdapter.ClearBeforeFill = true;
            // 
            // disabilityCauseTableAdapter
            // 
            this.disabilityCauseTableAdapter.ClearBeforeFill = true;
            // 
            // disabilitySeverityTableAdapter
            // 
            this.disabilitySeverityTableAdapter.ClearBeforeFill = true;
            // 
            // affectedBodyPartTableAdapter
            // 
            this.affectedBodyPartTableAdapter.ClearBeforeFill = true;
            // 
            // hearingImpairmentTableAdapter
            // 
            this.hearingImpairmentTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // biographicDetailTableAdapter
            // 
            this.biographicDetailTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tpReports
            // 
            this.tpReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tpReports.Controls.Add(this.menustripReports);
            this.tpReports.Location = new System.Drawing.Point(4, 25);
            this.tpReports.Name = "tpReports";
            this.tpReports.Size = new System.Drawing.Size(1307, 631);
            this.tpReports.TabIndex = 4;
            this.tpReports.Text = "Reports";
            this.tpReports.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // menustripReports
            // 
            this.menustripReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msReports});
            this.menustripReports.Location = new System.Drawing.Point(0, 0);
            this.menustripReports.Name = "menustripReports";
            this.menustripReports.Size = new System.Drawing.Size(1307, 24);
            this.menustripReports.TabIndex = 0;
            this.menustripReports.Text = "menuStrip1";
            // 
            // msReports
            // 
            this.msReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSummaryByUser,
            this.miBasicDetailReport,
            this.miDetailReportbyDisabilityType,
            this.miDetailReportByUser,
            this.miDetailReportbyAgeBracket,
            this.miDetailReportByAgeandgender,
            this.miDetailReportByGenderandDisability,
            this.miDetailReportbyDisabilityCauseandType,
            this.miDetailReportByDisabilityTypeandSeverity,
            this.miBasicDetailReportByDate,
            this.miBasicDetailReportbyCurrentUser});
            this.msReports.Name = "msReports";
            this.msReports.Size = new System.Drawing.Size(87, 20);
            this.msReports.Text = "View Reports";
            this.msReports.Click += new System.EventHandler(this.msReports_Click);
            // 
            // miSummaryByUser
            // 
            this.miSummaryByUser.Name = "miSummaryByUser";
            this.miSummaryByUser.Size = new System.Drawing.Size(374, 22);
            this.miSummaryByUser.Text = "View Summary Report by User";
            this.miSummaryByUser.Click += new System.EventHandler(this.fssefvToolStripMenuItem_Click);
            // 
            // miBasicDetailReport
            // 
            this.miBasicDetailReport.Name = "miBasicDetailReport";
            this.miBasicDetailReport.Size = new System.Drawing.Size(374, 22);
            this.miBasicDetailReport.Text = "View Basic Detail Report";
            this.miBasicDetailReport.Click += new System.EventHandler(this.fgdvfdbgToolStripMenuItem_Click);
            // 
            // miDetailReportbyDisabilityType
            // 
            this.miDetailReportbyDisabilityType.Name = "miDetailReportbyDisabilityType";
            this.miDetailReportbyDisabilityType.Size = new System.Drawing.Size(374, 22);
            this.miDetailReportbyDisabilityType.Text = "View Detail Report by Disability Type";
            this.miDetailReportbyDisabilityType.Click += new System.EventHandler(this.miDetailReportbyDisabilityType_Click);
            // 
            // miDetailReportByUser
            // 
            this.miDetailReportByUser.Name = "miDetailReportByUser";
            this.miDetailReportByUser.Size = new System.Drawing.Size(374, 22);
            this.miDetailReportByUser.Text = "View Detail Report by User";
            this.miDetailReportByUser.Click += new System.EventHandler(this.miDetailReportByUser_Click);
            // 
            // miDetailReportbyAgeBracket
            // 
            this.miDetailReportbyAgeBracket.Name = "miDetailReportbyAgeBracket";
            this.miDetailReportbyAgeBracket.Size = new System.Drawing.Size(374, 22);
            this.miDetailReportbyAgeBracket.Text = "View Detail Report by Age Bracket";
            this.miDetailReportbyAgeBracket.Click += new System.EventHandler(this.miDetailReportbyAgeBracket_Click);
            // 
            // miDetailReportByAgeandgender
            // 
            this.miDetailReportByAgeandgender.Name = "miDetailReportByAgeandgender";
            this.miDetailReportByAgeandgender.Size = new System.Drawing.Size(374, 22);
            this.miDetailReportByAgeandgender.Text = "View Detail Report by Age and Gender";
            this.miDetailReportByAgeandgender.Click += new System.EventHandler(this.miDetailReportByAgeandgender_Click);
            // 
            // miDetailReportByGenderandDisability
            // 
            this.miDetailReportByGenderandDisability.Name = "miDetailReportByGenderandDisability";
            this.miDetailReportByGenderandDisability.Size = new System.Drawing.Size(374, 22);
            this.miDetailReportByGenderandDisability.Text = "View Detail Report by Gender and Disability";
            this.miDetailReportByGenderandDisability.Click += new System.EventHandler(this.miDetailReportByGenderandDisability_Click);
            // 
            // miDetailReportbyDisabilityCauseandType
            // 
            this.miDetailReportbyDisabilityCauseandType.Name = "miDetailReportbyDisabilityCauseandType";
            this.miDetailReportbyDisabilityCauseandType.Size = new System.Drawing.Size(374, 22);
            this.miDetailReportbyDisabilityCauseandType.Text = "View Detail Report by Disability Cause and Disability Type";
            this.miDetailReportbyDisabilityCauseandType.Click += new System.EventHandler(this.miDetailReportbyDisabilityCauseandType_Click);
            // 
            // miDetailReportByDisabilityTypeandSeverity
            // 
            this.miDetailReportByDisabilityTypeandSeverity.Name = "miDetailReportByDisabilityTypeandSeverity";
            this.miDetailReportByDisabilityTypeandSeverity.Size = new System.Drawing.Size(374, 22);
            this.miDetailReportByDisabilityTypeandSeverity.Text = "View Detail Report by Disability Type and Severity";
            this.miDetailReportByDisabilityTypeandSeverity.Click += new System.EventHandler(this.miDetailReportByDisabilityTypeandSeverity_Click);
            // 
            // miBasicDetailReportByDate
            // 
            this.miBasicDetailReportByDate.Name = "miBasicDetailReportByDate";
            this.miBasicDetailReportByDate.Size = new System.Drawing.Size(374, 22);
            this.miBasicDetailReportByDate.Text = "View Basic Detail Report by Date";
            this.miBasicDetailReportByDate.Click += new System.EventHandler(this.miBasicDetailReportByDate_Click);
            // 
            // miBasicDetailReportbyCurrentUser
            // 
            this.miBasicDetailReportbyCurrentUser.Name = "miBasicDetailReportbyCurrentUser";
            this.miBasicDetailReportbyCurrentUser.Size = new System.Drawing.Size(374, 22);
            this.miBasicDetailReportbyCurrentUser.Text = "View Basic Detail Report by Current Logged in User";
            this.miBasicDetailReportbyCurrentUser.Click += new System.EventHandler(this.miBasicDetailReportbyCurrentUser_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.dgvViewProfile);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1307, 631);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "View Profile";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1151, 18);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(123, 31);
            this.button13.TabIndex = 8;
            this.button13.Text = "Export";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1090, 599);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "Delete";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(977, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbProfileVisual);
            this.panel2.Controls.Add(this.cbProfileKinRelationship);
            this.panel2.Controls.Add(this.cbProfileOnset);
            this.panel2.Controls.Add(this.tbProfileMedicalAddress);
            this.panel2.Controls.Add(this.tbProfileMedicalNum);
            this.panel2.Controls.Add(this.tbProfileMedicalName);
            this.panel2.Controls.Add(this.tbProfileKinOther);
            this.panel2.Controls.Add(this.tbProfileKinPhone);
            this.panel2.Controls.Add(this.cbProfilePsycho);
            this.panel2.Controls.Add(this.tbProfileKinFirst);
            this.panel2.Controls.Add(this.cbProfilePart);
            this.panel2.Controls.Add(this.tbProfileKinAddress);
            this.panel2.Controls.Add(this.cbProfileHearing);
            this.panel2.Controls.Add(this.tbProfileKinSurname);
            this.panel2.Controls.Add(this.label82);
            this.panel2.Controls.Add(this.label84);
            this.panel2.Controls.Add(this.label85);
            this.panel2.Controls.Add(this.label80);
            this.panel2.Controls.Add(this.label83);
            this.panel2.Controls.Add(this.label69);
            this.panel2.Controls.Add(this.label68);
            this.panel2.Controls.Add(this.label78);
            this.panel2.Controls.Add(this.label70);
            this.panel2.Controls.Add(this.label77);
            this.panel2.Controls.Add(this.label71);
            this.panel2.Controls.Add(this.label76);
            this.panel2.Controls.Add(this.label72);
            this.panel2.Controls.Add(this.label73);
            this.panel2.Location = new System.Drawing.Point(1068, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 527);
            this.panel2.TabIndex = 4;
            // 
            // cbProfileVisual
            // 
            this.cbProfileVisual.DataSource = this.visualImpairmentBindingSource;
            this.cbProfileVisual.DisplayMember = "ImpairmentDescription";
            this.cbProfileVisual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileVisual.FormattingEnabled = true;
            this.cbProfileVisual.Location = new System.Drawing.Point(105, 86);
            this.cbProfileVisual.Name = "cbProfileVisual";
            this.cbProfileVisual.Size = new System.Drawing.Size(124, 21);
            this.cbProfileVisual.TabIndex = 38;
            this.cbProfileVisual.ValueMember = "visualImpairmentId";
            // 
            // cbProfileKinRelationship
            // 
            this.cbProfileKinRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileKinRelationship.FormattingEnabled = true;
            this.cbProfileKinRelationship.Items.AddRange(new object[] {
            "AUNT",
            "BROTHER",
            "CHILD",
            "COUSIN",
            "FATHER",
            "HUSBAND",
            "MOTHER",
            "NEIGHBOUR",
            "NEPHEW",
            "NIECE",
            "NONE",
            "SISTER",
            "UNCLE",
            "WIFE"});
            this.cbProfileKinRelationship.Location = new System.Drawing.Point(105, 341);
            this.cbProfileKinRelationship.Name = "cbProfileKinRelationship";
            this.cbProfileKinRelationship.Size = new System.Drawing.Size(121, 21);
            this.cbProfileKinRelationship.TabIndex = 37;
            this.cbProfileKinRelationship.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // cbProfileOnset
            // 
            this.cbProfileOnset.DataSource = this.onsetOfDisabilityBindingSource;
            this.cbProfileOnset.DisplayMember = "onsetDuration";
            this.cbProfileOnset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileOnset.FormattingEnabled = true;
            this.cbProfileOnset.Location = new System.Drawing.Point(105, 155);
            this.cbProfileOnset.Name = "cbProfileOnset";
            this.cbProfileOnset.Size = new System.Drawing.Size(121, 21);
            this.cbProfileOnset.TabIndex = 36;
            this.cbProfileOnset.ValueMember = "onsetId";
            // 
            // tbProfileMedicalAddress
            // 
            this.tbProfileMedicalAddress.Location = new System.Drawing.Point(105, 433);
            this.tbProfileMedicalAddress.Name = "tbProfileMedicalAddress";
            this.tbProfileMedicalAddress.Size = new System.Drawing.Size(121, 20);
            this.tbProfileMedicalAddress.TabIndex = 34;
            // 
            // tbProfileMedicalNum
            // 
            this.tbProfileMedicalNum.Location = new System.Drawing.Point(105, 401);
            this.tbProfileMedicalNum.Name = "tbProfileMedicalNum";
            this.tbProfileMedicalNum.Size = new System.Drawing.Size(121, 20);
            this.tbProfileMedicalNum.TabIndex = 33;
            // 
            // tbProfileMedicalName
            // 
            this.tbProfileMedicalName.Location = new System.Drawing.Point(105, 368);
            this.tbProfileMedicalName.Name = "tbProfileMedicalName";
            this.tbProfileMedicalName.Size = new System.Drawing.Size(121, 20);
            this.tbProfileMedicalName.TabIndex = 32;
            // 
            // tbProfileKinOther
            // 
            this.tbProfileKinOther.Location = new System.Drawing.Point(105, 243);
            this.tbProfileKinOther.Name = "tbProfileKinOther";
            this.tbProfileKinOther.Size = new System.Drawing.Size(121, 20);
            this.tbProfileKinOther.TabIndex = 31;
            this.tbProfileKinOther.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // tbProfileKinPhone
            // 
            this.tbProfileKinPhone.Location = new System.Drawing.Point(105, 277);
            this.tbProfileKinPhone.Name = "tbProfileKinPhone";
            this.tbProfileKinPhone.Size = new System.Drawing.Size(121, 20);
            this.tbProfileKinPhone.TabIndex = 30;
            // 
            // cbProfilePsycho
            // 
            this.cbProfilePsycho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfilePsycho.FormattingEnabled = true;
            this.cbProfilePsycho.Items.AddRange(new object[] {
            "Alzheimer\'s Disease",
            "Anxiety Depression",
            "Bipolar Disorder",
            "Depression",
            "Memory Loss",
            "Obsessive Compulsive Disorder",
            "Others",
            "None"});
            this.cbProfilePsycho.Location = new System.Drawing.Point(105, 14);
            this.cbProfilePsycho.Name = "cbProfilePsycho";
            this.cbProfilePsycho.Size = new System.Drawing.Size(121, 21);
            this.cbProfilePsycho.TabIndex = 34;
            // 
            // tbProfileKinFirst
            // 
            this.tbProfileKinFirst.Location = new System.Drawing.Point(105, 208);
            this.tbProfileKinFirst.Name = "tbProfileKinFirst";
            this.tbProfileKinFirst.Size = new System.Drawing.Size(121, 20);
            this.tbProfileKinFirst.TabIndex = 29;
            this.tbProfileKinFirst.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // cbProfilePart
            // 
            this.cbProfilePart.DataSource = this.affectedBodyPartBindingSource;
            this.cbProfilePart.DisplayMember = "description";
            this.cbProfilePart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfilePart.FormattingEnabled = true;
            this.cbProfilePart.Location = new System.Drawing.Point(105, 45);
            this.cbProfilePart.Name = "cbProfilePart";
            this.cbProfilePart.Size = new System.Drawing.Size(121, 21);
            this.cbProfilePart.TabIndex = 32;
            this.cbProfilePart.ValueMember = "bodypartId";
            // 
            // tbProfileKinAddress
            // 
            this.tbProfileKinAddress.Location = new System.Drawing.Point(105, 313);
            this.tbProfileKinAddress.Name = "tbProfileKinAddress";
            this.tbProfileKinAddress.Size = new System.Drawing.Size(121, 20);
            this.tbProfileKinAddress.TabIndex = 28;
            // 
            // cbProfileHearing
            // 
            this.cbProfileHearing.DataSource = this.hearingImpairmentBindingSource;
            this.cbProfileHearing.DisplayMember = "hearingImpairmentDescription";
            this.cbProfileHearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileHearing.FormattingEnabled = true;
            this.cbProfileHearing.Location = new System.Drawing.Point(105, 121);
            this.cbProfileHearing.Name = "cbProfileHearing";
            this.cbProfileHearing.Size = new System.Drawing.Size(121, 21);
            this.cbProfileHearing.TabIndex = 27;
            this.cbProfileHearing.ValueMember = "hearingImpairmentId";
            this.cbProfileHearing.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tbProfileKinSurname
            // 
            this.tbProfileKinSurname.Location = new System.Drawing.Point(105, 182);
            this.tbProfileKinSurname.Name = "tbProfileKinSurname";
            this.tbProfileKinSurname.Size = new System.Drawing.Size(121, 20);
            this.tbProfileKinSurname.TabIndex = 26;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(1, 24);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(98, 13);
            this.label82.TabIndex = 16;
            this.label82.Text = "psychiatricDisability";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(4, 86);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(88, 13);
            this.label84.TabIndex = 18;
            this.label84.Text = "visual Impairment";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(6, 159);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(33, 13);
            this.label85.TabIndex = 19;
            this.label85.Text = "onset";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(4, 48);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(65, 13);
            this.label80.TabIndex = 14;
            this.label80.Text = "affectedPart";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(3, 124);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(96, 13);
            this.label83.TabIndex = 17;
            this.label83.Text = "hearing Impairment";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 186);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(62, 13);
            this.label69.TabIndex = 2;
            this.label69.Text = "surnameKin";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(4, 219);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(64, 13);
            this.label68.TabIndex = 1;
            this.label68.Text = "firstnameKin";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(3, 433);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(81, 13);
            this.label78.TabIndex = 11;
            this.label78.Text = "addressMedical";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 250);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(72, 13);
            this.label70.TabIndex = 3;
            this.label70.Text = "othernameKin";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(3, 401);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(81, 13);
            this.label77.TabIndex = 10;
            this.label77.Text = "NumberMedical";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(6, 277);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(52, 13);
            this.label71.TabIndex = 4;
            this.label71.Text = "phoneKin";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(3, 373);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(75, 13);
            this.label76.TabIndex = 9;
            this.label76.Text = "namesMedical";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(6, 311);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(59, 13);
            this.label72.TabIndex = 5;
            this.label72.Text = "addressKin";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 342);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(75, 13);
            this.label73.TabIndex = 6;
            this.label73.Text = "relationshipKin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbprofileGender);
            this.panel1.Controls.Add(this.cbProfileType);
            this.panel1.Controls.Add(this.cbProfileNeuro);
            this.panel1.Controls.Add(this.dtpProfileDOB);
            this.panel1.Controls.Add(this.label55);
            this.panel1.Controls.Add(this.label54);
            this.panel1.Controls.Add(this.cbProfileCause);
            this.panel1.Controls.Add(this.cbProfileSeverity);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Controls.Add(this.label64);
            this.panel1.Controls.Add(this.cbProfileDuration);
            this.panel1.Controls.Add(this.tbProfileAddress);
            this.panel1.Controls.Add(this.tbProfilePhone);
            this.panel1.Controls.Add(this.tbProfileSurname);
            this.panel1.Controls.Add(this.tbProfileFirstname);
            this.panel1.Controls.Add(this.tbProfileEmail);
            this.panel1.Controls.Add(this.tbProfileotherName);
            this.panel1.Controls.Add(this.label81);
            this.panel1.Controls.Add(this.label79);
            this.panel1.Controls.Add(this.label63);
            this.panel1.Controls.Add(this.label62);
            this.panel1.Controls.Add(this.label60);
            this.panel1.Controls.Add(this.label58);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.label57);
            this.panel1.Location = new System.Drawing.Point(823, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 527);
            this.panel1.TabIndex = 3;
            // 
            // gbprofileGender
            // 
            this.gbprofileGender.Controls.Add(this.rbProfileFemale);
            this.gbprofileGender.Controls.Add(this.rbProfileMale);
            this.gbprofileGender.Location = new System.Drawing.Point(69, 140);
            this.gbprofileGender.Name = "gbprofileGender";
            this.gbprofileGender.Size = new System.Drawing.Size(170, 53);
            this.gbprofileGender.TabIndex = 40;
            this.gbprofileGender.TabStop = false;
            this.gbprofileGender.Text = "gender";
            // 
            // rbProfileFemale
            // 
            this.rbProfileFemale.AutoSize = true;
            this.rbProfileFemale.Location = new System.Drawing.Point(85, 23);
            this.rbProfileFemale.Name = "rbProfileFemale";
            this.rbProfileFemale.Size = new System.Drawing.Size(56, 17);
            this.rbProfileFemale.TabIndex = 1;
            this.rbProfileFemale.TabStop = true;
            this.rbProfileFemale.Text = "female";
            this.rbProfileFemale.UseVisualStyleBackColor = true;
            // 
            // rbProfileMale
            // 
            this.rbProfileMale.AutoSize = true;
            this.rbProfileMale.Location = new System.Drawing.Point(6, 23);
            this.rbProfileMale.Name = "rbProfileMale";
            this.rbProfileMale.Size = new System.Drawing.Size(47, 17);
            this.rbProfileMale.TabIndex = 0;
            this.rbProfileMale.TabStop = true;
            this.rbProfileMale.Text = "male";
            this.rbProfileMale.UseVisualStyleBackColor = true;
            // 
            // cbProfileType
            // 
            this.cbProfileType.DataSource = this.disabilityTypeBindingSource;
            this.cbProfileType.DisplayMember = "disabilityTypeName";
            this.cbProfileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileType.FormattingEnabled = true;
            this.cbProfileType.Location = new System.Drawing.Point(105, 356);
            this.cbProfileType.Name = "cbProfileType";
            this.cbProfileType.Size = new System.Drawing.Size(121, 21);
            this.cbProfileType.TabIndex = 39;
            this.cbProfileType.ValueMember = "disabilityTypeId";
            // 
            // cbProfileNeuro
            // 
            this.cbProfileNeuro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileNeuro.FormattingEnabled = true;
            this.cbProfileNeuro.Items.AddRange(new object[] {
            "Asperger Syndrome",
            "Autism",
            "Cerebral Palsy",
            "Communication Disorder",
            "Down Syndrome",
            "Epilepsy",
            "Klineefelter Syndrome",
            "None"});
            this.cbProfileNeuro.Location = new System.Drawing.Point(105, 498);
            this.cbProfileNeuro.Name = "cbProfileNeuro";
            this.cbProfileNeuro.Size = new System.Drawing.Size(121, 21);
            this.cbProfileNeuro.TabIndex = 38;
            // 
            // dtpProfileDOB
            // 
            this.dtpProfileDOB.Location = new System.Drawing.Point(46, 213);
            this.dtpProfileDOB.Name = "dtpProfileDOB";
            this.dtpProfileDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpProfileDOB.TabIndex = 24;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(5, 215);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(30, 13);
            this.label55.TabIndex = 4;
            this.label55.Text = "DOB";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(5, 250);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(44, 13);
            this.label54.TabIndex = 3;
            this.label54.Text = "address";
            // 
            // cbProfileCause
            // 
            this.cbProfileCause.DataSource = this.disabilityCauseBindingSource;
            this.cbProfileCause.DisplayMember = "disabilityCauseName";
            this.cbProfileCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileCause.FormattingEnabled = true;
            this.cbProfileCause.Location = new System.Drawing.Point(105, 393);
            this.cbProfileCause.Name = "cbProfileCause";
            this.cbProfileCause.Size = new System.Drawing.Size(121, 21);
            this.cbProfileCause.TabIndex = 37;
            this.cbProfileCause.ValueMember = "disabilityCauseId";
            this.cbProfileCause.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // cbProfileSeverity
            // 
            this.cbProfileSeverity.DataSource = this.disabilitySeverityBindingSource;
            this.cbProfileSeverity.DisplayMember = "severityName";
            this.cbProfileSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileSeverity.FormattingEnabled = true;
            this.cbProfileSeverity.Location = new System.Drawing.Point(105, 430);
            this.cbProfileSeverity.Name = "cbProfileSeverity";
            this.cbProfileSeverity.Size = new System.Drawing.Size(121, 21);
            this.cbProfileSeverity.TabIndex = 36;
            this.cbProfileSeverity.ValueMember = "disabilitySeverityId";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(-3, 93);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(57, 13);
            this.label53.TabIndex = 2;
            this.label53.Text = "othername";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(0, 55);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(49, 13);
            this.label64.TabIndex = 13;
            this.label64.Text = "firstname";
            // 
            // cbProfileDuration
            // 
            this.cbProfileDuration.DataSource = this.impairmentDurationBindingSource;
            this.cbProfileDuration.DisplayMember = "duration";
            this.cbProfileDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfileDuration.FormattingEnabled = true;
            this.cbProfileDuration.Location = new System.Drawing.Point(105, 462);
            this.cbProfileDuration.Name = "cbProfileDuration";
            this.cbProfileDuration.Size = new System.Drawing.Size(121, 21);
            this.cbProfileDuration.TabIndex = 35;
            this.cbProfileDuration.ValueMember = "impairmentDurationId";
            this.cbProfileDuration.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // tbProfileAddress
            // 
            this.tbProfileAddress.Location = new System.Drawing.Point(105, 243);
            this.tbProfileAddress.Name = "tbProfileAddress";
            this.tbProfileAddress.Size = new System.Drawing.Size(121, 20);
            this.tbProfileAddress.TabIndex = 26;
            this.tbProfileAddress.TextChanged += new System.EventHandler(this.tbProfileAddress_TextChanged);
            // 
            // tbProfilePhone
            // 
            this.tbProfilePhone.Location = new System.Drawing.Point(105, 313);
            this.tbProfilePhone.Name = "tbProfilePhone";
            this.tbProfilePhone.Size = new System.Drawing.Size(121, 20);
            this.tbProfilePhone.TabIndex = 25;
            // 
            // tbProfileSurname
            // 
            this.tbProfileSurname.Location = new System.Drawing.Point(105, 17);
            this.tbProfileSurname.Name = "tbProfileSurname";
            this.tbProfileSurname.Size = new System.Drawing.Size(121, 20);
            this.tbProfileSurname.TabIndex = 23;
            // 
            // tbProfileFirstname
            // 
            this.tbProfileFirstname.Location = new System.Drawing.Point(105, 48);
            this.tbProfileFirstname.Name = "tbProfileFirstname";
            this.tbProfileFirstname.Size = new System.Drawing.Size(121, 20);
            this.tbProfileFirstname.TabIndex = 22;
            // 
            // tbProfileEmail
            // 
            this.tbProfileEmail.Location = new System.Drawing.Point(105, 277);
            this.tbProfileEmail.Name = "tbProfileEmail";
            this.tbProfileEmail.Size = new System.Drawing.Size(121, 20);
            this.tbProfileEmail.TabIndex = 20;
            // 
            // tbProfileotherName
            // 
            this.tbProfileotherName.Location = new System.Drawing.Point(105, 93);
            this.tbProfileotherName.Name = "tbProfileotherName";
            this.tbProfileotherName.Size = new System.Drawing.Size(121, 20);
            this.tbProfileotherName.TabIndex = 19;
            this.tbProfileotherName.TextChanged += new System.EventHandler(this.tbProfileotherName_TextChanged);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(5, 501);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(75, 13);
            this.label81.TabIndex = 15;
            this.label81.Text = "neuroDisability";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(4, 462);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(45, 13);
            this.label79.TabIndex = 0;
            this.label79.Text = "duration";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(0, 24);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(47, 13);
            this.label63.TabIndex = 12;
            this.label63.Text = "surname";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(4, 436);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(43, 13);
            this.label62.TabIndex = 11;
            this.label62.Text = "severity";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(4, 401);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(36, 13);
            this.label60.TabIndex = 9;
            this.label60.Text = "cause";
            this.label60.Click += new System.EventHandler(this.label60_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(3, 364);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(69, 13);
            this.label58.TabIndex = 7;
            this.label58.Text = "disability type";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(3, 313);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(37, 13);
            this.label56.TabIndex = 5;
            this.label56.Text = "phone";
            this.label56.Click += new System.EventHandler(this.label56_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(0, 140);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(40, 13);
            this.label52.TabIndex = 1;
            this.label52.Text = "gender";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(5, 284);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(31, 13);
            this.label57.TabIndex = 6;
            this.label57.Text = "email";
            // 
            // dgvViewProfile
            // 
            this.dgvViewProfile.AllowUserToAddRows = false;
            this.dgvViewProfile.AllowUserToDeleteRows = false;
            this.dgvViewProfile.AutoGenerateColumns = false;
            this.dgvViewProfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvViewProfile.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvViewProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biodataIdDataGridViewTextBoxColumn,
            this.biodataIntegerDataGridViewTextBoxColumn,
            this.lasrraIdDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.othernameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.homeAddressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactPhoneDataGridViewTextBoxColumn,
            this.disabilityTypeIdDataGridViewTextBoxColumn,
            this.disabilityCauseIdDataGridViewTextBoxColumn,
            this.disabilitySeverityIdDataGridViewTextBoxColumn,
            this.impairmentDurationIdDataGridViewTextBoxColumn,
            this.neuroDisabilityDataGridViewTextBoxColumn,
            this.psychiatricDisabilityDataGridViewTextBoxColumn,
            this.affectedBodyPartIdDataGridViewTextBoxColumn,
            this.visualImpairmentIdDataGridViewTextBoxColumn,
            this.hearingImpairmentIdDataGridViewTextBoxColumn,
            this.onsetIdDataGridViewTextBoxColumn,
            this.surnameKinDataGridViewTextBoxColumn,
            this.firstnameKinDataGridViewTextBoxColumn,
            this.othernameKinDataGridViewTextBoxColumn,
            this.phoneKinDataGridViewTextBoxColumn,
            this.addressKinDataGridViewTextBoxColumn,
            this.relationshipKinDataGridViewTextBoxColumn,
            this.namesMedicalDataGridViewTextBoxColumn,
            this.membershipNumberMedicalDataGridViewTextBoxColumn,
            this.addressMedicalDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateLastModifiedDataGridViewTextBoxColumn,
            this.photoLinkDataGridViewTextBoxColumn});
            this.dgvViewProfile.DataSource = this.biographicDetailBindingSource;
            this.dgvViewProfile.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvViewProfile.Location = new System.Drawing.Point(8, 65);
            this.dgvViewProfile.Name = "dgvViewProfile";
            this.dgvViewProfile.ReadOnly = true;
            this.dgvViewProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewProfile.Size = new System.Drawing.Size(809, 553);
            this.dgvViewProfile.TabIndex = 0;
            this.dgvViewProfile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewProfile_CellContentClick);
            this.dgvViewProfile.SelectionChanged += new System.EventHandler(this.dgvViewProfile_SelectionChanged);
            // 
            // biodataIdDataGridViewTextBoxColumn
            // 
            this.biodataIdDataGridViewTextBoxColumn.DataPropertyName = "biodataId";
            this.biodataIdDataGridViewTextBoxColumn.HeaderText = "biodataId";
            this.biodataIdDataGridViewTextBoxColumn.Name = "biodataIdDataGridViewTextBoxColumn";
            this.biodataIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biodataIntegerDataGridViewTextBoxColumn
            // 
            this.biodataIntegerDataGridViewTextBoxColumn.DataPropertyName = "biodataInteger";
            this.biodataIntegerDataGridViewTextBoxColumn.HeaderText = "biodataInteger";
            this.biodataIntegerDataGridViewTextBoxColumn.Name = "biodataIntegerDataGridViewTextBoxColumn";
            this.biodataIntegerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lasrraIdDataGridViewTextBoxColumn
            // 
            this.lasrraIdDataGridViewTextBoxColumn.DataPropertyName = "lasrraId";
            this.lasrraIdDataGridViewTextBoxColumn.HeaderText = "lasrraId";
            this.lasrraIdDataGridViewTextBoxColumn.Name = "lasrraIdDataGridViewTextBoxColumn";
            this.lasrraIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // othernameDataGridViewTextBoxColumn
            // 
            this.othernameDataGridViewTextBoxColumn.DataPropertyName = "othername";
            this.othernameDataGridViewTextBoxColumn.HeaderText = "othername";
            this.othernameDataGridViewTextBoxColumn.Name = "othernameDataGridViewTextBoxColumn";
            this.othernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeAddressDataGridViewTextBoxColumn
            // 
            this.homeAddressDataGridViewTextBoxColumn.DataPropertyName = "homeAddress";
            this.homeAddressDataGridViewTextBoxColumn.HeaderText = "homeAddress";
            this.homeAddressDataGridViewTextBoxColumn.Name = "homeAddressDataGridViewTextBoxColumn";
            this.homeAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "contactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "contactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            this.contactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disabilityTypeIdDataGridViewTextBoxColumn
            // 
            this.disabilityTypeIdDataGridViewTextBoxColumn.DataPropertyName = "disabilityTypeId";
            this.disabilityTypeIdDataGridViewTextBoxColumn.HeaderText = "disabilityTypeId";
            this.disabilityTypeIdDataGridViewTextBoxColumn.Name = "disabilityTypeIdDataGridViewTextBoxColumn";
            this.disabilityTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disabilityCauseIdDataGridViewTextBoxColumn
            // 
            this.disabilityCauseIdDataGridViewTextBoxColumn.DataPropertyName = "disabilityCauseId";
            this.disabilityCauseIdDataGridViewTextBoxColumn.HeaderText = "disabilityCauseId";
            this.disabilityCauseIdDataGridViewTextBoxColumn.Name = "disabilityCauseIdDataGridViewTextBoxColumn";
            this.disabilityCauseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disabilitySeverityIdDataGridViewTextBoxColumn
            // 
            this.disabilitySeverityIdDataGridViewTextBoxColumn.DataPropertyName = "disabilitySeverityId";
            this.disabilitySeverityIdDataGridViewTextBoxColumn.HeaderText = "disabilitySeverityId";
            this.disabilitySeverityIdDataGridViewTextBoxColumn.Name = "disabilitySeverityIdDataGridViewTextBoxColumn";
            this.disabilitySeverityIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // impairmentDurationIdDataGridViewTextBoxColumn
            // 
            this.impairmentDurationIdDataGridViewTextBoxColumn.DataPropertyName = "impairmentDurationId";
            this.impairmentDurationIdDataGridViewTextBoxColumn.HeaderText = "impairmentDurationId";
            this.impairmentDurationIdDataGridViewTextBoxColumn.Name = "impairmentDurationIdDataGridViewTextBoxColumn";
            this.impairmentDurationIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // neuroDisabilityDataGridViewTextBoxColumn
            // 
            this.neuroDisabilityDataGridViewTextBoxColumn.DataPropertyName = "neuroDisability";
            this.neuroDisabilityDataGridViewTextBoxColumn.HeaderText = "neuroDisability";
            this.neuroDisabilityDataGridViewTextBoxColumn.Name = "neuroDisabilityDataGridViewTextBoxColumn";
            this.neuroDisabilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psychiatricDisabilityDataGridViewTextBoxColumn
            // 
            this.psychiatricDisabilityDataGridViewTextBoxColumn.DataPropertyName = "psychiatricDisability";
            this.psychiatricDisabilityDataGridViewTextBoxColumn.HeaderText = "psychiatricDisability";
            this.psychiatricDisabilityDataGridViewTextBoxColumn.Name = "psychiatricDisabilityDataGridViewTextBoxColumn";
            this.psychiatricDisabilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // affectedBodyPartIdDataGridViewTextBoxColumn
            // 
            this.affectedBodyPartIdDataGridViewTextBoxColumn.DataPropertyName = "affectedBodyPartId";
            this.affectedBodyPartIdDataGridViewTextBoxColumn.HeaderText = "affectedBodyPartId";
            this.affectedBodyPartIdDataGridViewTextBoxColumn.Name = "affectedBodyPartIdDataGridViewTextBoxColumn";
            this.affectedBodyPartIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visualImpairmentIdDataGridViewTextBoxColumn
            // 
            this.visualImpairmentIdDataGridViewTextBoxColumn.DataPropertyName = "visualImpairmentId";
            this.visualImpairmentIdDataGridViewTextBoxColumn.HeaderText = "visualImpairmentId";
            this.visualImpairmentIdDataGridViewTextBoxColumn.Name = "visualImpairmentIdDataGridViewTextBoxColumn";
            this.visualImpairmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hearingImpairmentIdDataGridViewTextBoxColumn
            // 
            this.hearingImpairmentIdDataGridViewTextBoxColumn.DataPropertyName = "hearingImpairmentId";
            this.hearingImpairmentIdDataGridViewTextBoxColumn.HeaderText = "hearingImpairmentId";
            this.hearingImpairmentIdDataGridViewTextBoxColumn.Name = "hearingImpairmentIdDataGridViewTextBoxColumn";
            this.hearingImpairmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onsetIdDataGridViewTextBoxColumn
            // 
            this.onsetIdDataGridViewTextBoxColumn.DataPropertyName = "onsetId";
            this.onsetIdDataGridViewTextBoxColumn.HeaderText = "onsetId";
            this.onsetIdDataGridViewTextBoxColumn.Name = "onsetIdDataGridViewTextBoxColumn";
            this.onsetIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameKinDataGridViewTextBoxColumn
            // 
            this.surnameKinDataGridViewTextBoxColumn.DataPropertyName = "surnameKin";
            this.surnameKinDataGridViewTextBoxColumn.HeaderText = "surnameKin";
            this.surnameKinDataGridViewTextBoxColumn.Name = "surnameKinDataGridViewTextBoxColumn";
            this.surnameKinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameKinDataGridViewTextBoxColumn
            // 
            this.firstnameKinDataGridViewTextBoxColumn.DataPropertyName = "firstnameKin";
            this.firstnameKinDataGridViewTextBoxColumn.HeaderText = "firstnameKin";
            this.firstnameKinDataGridViewTextBoxColumn.Name = "firstnameKinDataGridViewTextBoxColumn";
            this.firstnameKinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // othernameKinDataGridViewTextBoxColumn
            // 
            this.othernameKinDataGridViewTextBoxColumn.DataPropertyName = "othernameKin";
            this.othernameKinDataGridViewTextBoxColumn.HeaderText = "othernameKin";
            this.othernameKinDataGridViewTextBoxColumn.Name = "othernameKinDataGridViewTextBoxColumn";
            this.othernameKinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneKinDataGridViewTextBoxColumn
            // 
            this.phoneKinDataGridViewTextBoxColumn.DataPropertyName = "phoneKin";
            this.phoneKinDataGridViewTextBoxColumn.HeaderText = "phoneKin";
            this.phoneKinDataGridViewTextBoxColumn.Name = "phoneKinDataGridViewTextBoxColumn";
            this.phoneKinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressKinDataGridViewTextBoxColumn
            // 
            this.addressKinDataGridViewTextBoxColumn.DataPropertyName = "addressKin";
            this.addressKinDataGridViewTextBoxColumn.HeaderText = "addressKin";
            this.addressKinDataGridViewTextBoxColumn.Name = "addressKinDataGridViewTextBoxColumn";
            this.addressKinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationshipKinDataGridViewTextBoxColumn
            // 
            this.relationshipKinDataGridViewTextBoxColumn.DataPropertyName = "relationshipKin";
            this.relationshipKinDataGridViewTextBoxColumn.HeaderText = "relationshipKin";
            this.relationshipKinDataGridViewTextBoxColumn.Name = "relationshipKinDataGridViewTextBoxColumn";
            this.relationshipKinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namesMedicalDataGridViewTextBoxColumn
            // 
            this.namesMedicalDataGridViewTextBoxColumn.DataPropertyName = "namesMedical";
            this.namesMedicalDataGridViewTextBoxColumn.HeaderText = "namesMedical";
            this.namesMedicalDataGridViewTextBoxColumn.Name = "namesMedicalDataGridViewTextBoxColumn";
            this.namesMedicalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipNumberMedicalDataGridViewTextBoxColumn
            // 
            this.membershipNumberMedicalDataGridViewTextBoxColumn.DataPropertyName = "membershipNumberMedical";
            this.membershipNumberMedicalDataGridViewTextBoxColumn.HeaderText = "membershipNumberMedical";
            this.membershipNumberMedicalDataGridViewTextBoxColumn.Name = "membershipNumberMedicalDataGridViewTextBoxColumn";
            this.membershipNumberMedicalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressMedicalDataGridViewTextBoxColumn
            // 
            this.addressMedicalDataGridViewTextBoxColumn.DataPropertyName = "addressMedical";
            this.addressMedicalDataGridViewTextBoxColumn.HeaderText = "addressMedical";
            this.addressMedicalDataGridViewTextBoxColumn.Name = "addressMedicalDataGridViewTextBoxColumn";
            this.addressMedicalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "dateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateLastModifiedDataGridViewTextBoxColumn
            // 
            this.dateLastModifiedDataGridViewTextBoxColumn.DataPropertyName = "dateLastModified";
            this.dateLastModifiedDataGridViewTextBoxColumn.HeaderText = "dateLastModified";
            this.dateLastModifiedDataGridViewTextBoxColumn.Name = "dateLastModifiedDataGridViewTextBoxColumn";
            this.dateLastModifiedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoLinkDataGridViewTextBoxColumn
            // 
            this.photoLinkDataGridViewTextBoxColumn.DataPropertyName = "photoLink";
            this.photoLinkDataGridViewTextBoxColumn.HeaderText = "photoLink";
            this.photoLinkDataGridViewTextBoxColumn.Name = "photoLinkDataGridViewTextBoxColumn";
            this.photoLinkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.ssManageUser);
            this.tabPage3.Controls.Add(this.tableLayoutPanel6);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1307, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage User";
            // 
            // ssManageUser
            // 
            this.ssManageUser.Location = new System.Drawing.Point(0, 609);
            this.ssManageUser.Name = "ssManageUser";
            this.ssManageUser.Size = new System.Drawing.Size(1307, 22);
            this.ssManageUser.TabIndex = 6;
            this.ssManageUser.Text = "statusStrip6";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.49735F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.50265F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel6.Controls.Add(this.bClear, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.bUser, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.bClose, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(105, 241);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(272, 41);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // bClear
            // 
            this.bClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.bClear.Location = new System.Drawing.Point(3, 3);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(77, 23);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "Clear screen";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bUser
            // 
            this.bUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.bUser.Location = new System.Drawing.Point(86, 3);
            this.bUser.Name = "bUser";
            this.bUser.Size = new System.Drawing.Size(63, 23);
            this.bUser.TabIndex = 1;
            this.bUser.Text = "save";
            this.bUser.UseVisualStyleBackColor = true;
            this.bUser.Click += new System.EventHandler(this.button12_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(155, 3);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(190, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Manage User Account";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.13812F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.86188F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.cbCategory, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.gbStatus, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbUsername, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbPass2, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.tbPass1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(27, 31);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.63636F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(540, 204);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "User Category";
            // 
            // cbCategory
            // 
            this.cbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Administrator",
            "End User"});
            this.cbCategory.Location = new System.Drawing.Point(84, 163);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(237, 21);
            this.cbCategory.TabIndex = 9;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbDeactivate);
            this.gbStatus.Controls.Add(this.rbActivate);
            this.gbStatus.Location = new System.Drawing.Point(327, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(157, 52);
            this.gbStatus.TabIndex = 10;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Account Status";
            // 
            // rbDeactivate
            // 
            this.rbDeactivate.AutoSize = true;
            this.rbDeactivate.Location = new System.Drawing.Point(67, 29);
            this.rbDeactivate.Name = "rbDeactivate";
            this.rbDeactivate.Size = new System.Drawing.Size(77, 17);
            this.rbDeactivate.TabIndex = 1;
            this.rbDeactivate.TabStop = true;
            this.rbDeactivate.Text = "Deactivate";
            this.rbDeactivate.UseVisualStyleBackColor = true;
            this.rbDeactivate.CheckedChanged += new System.EventHandler(this.rbDeactivate_CheckedChanged);
            // 
            // rbActivate
            // 
            this.rbActivate.AutoSize = true;
            this.rbActivate.Location = new System.Drawing.Point(6, 29);
            this.rbActivate.Name = "rbActivate";
            this.rbActivate.Size = new System.Drawing.Size(55, 17);
            this.rbActivate.TabIndex = 0;
            this.rbActivate.TabStop = true;
            this.rbActivate.Text = "Active";
            this.rbActivate.UseVisualStyleBackColor = true;
            this.rbActivate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Full Name";
            // 
            // tbUsername
            // 
            this.tbUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUsername.Location = new System.Drawing.Point(84, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(237, 20);
            this.tbUsername.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Password";
            // 
            // tbPass2
            // 
            this.tbPass2.Location = new System.Drawing.Point(84, 117);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.PasswordChar = '*';
            this.tbPass2.Size = new System.Drawing.Size(237, 20);
            this.tbPass2.TabIndex = 7;
            this.tbPass2.TextChanged += new System.EventHandler(this.tbPass2_TextChanged);
            // 
            // tbPass1
            // 
            this.tbPass1.Location = new System.Drawing.Point(84, 73);
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.PasswordChar = '*';
            this.tbPass1.Size = new System.Drawing.Size(237, 20);
            this.tbPass1.TabIndex = 6;
            this.tbPass1.TextChanged += new System.EventHandler(this.tbPass1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "New Password";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRegistration);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1307, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Record";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbRegistration
            // 
            this.tbRegistration.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbRegistration.Controls.Add(this.tpPersonal);
            this.tbRegistration.Controls.Add(this.tpNextOfKin);
            this.tbRegistration.Controls.Add(this.tpDisabilityInfo);
            this.tbRegistration.Controls.Add(this.tpMedicalOfficer);
            this.tbRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRegistration.Location = new System.Drawing.Point(3, 3);
            this.tbRegistration.Name = "tbRegistration";
            this.tbRegistration.SelectedIndex = 0;
            this.tbRegistration.Size = new System.Drawing.Size(1301, 625);
            this.tbRegistration.TabIndex = 0;
            this.tbRegistration.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tpPersonal
            // 
            this.tpPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tpPersonal.Controls.Add(this.statusStrip3);
            this.tpPersonal.Controls.Add(this.tableLayoutPanel14);
            this.tpPersonal.Controls.Add(this.tableLayoutPanel10);
            this.tpPersonal.Controls.Add(this.tableLayoutPanel9);
            this.tpPersonal.Controls.Add(this.label16);
            this.tpPersonal.Controls.Add(this.tableLayoutPanel7);
            this.tpPersonal.Location = new System.Drawing.Point(4, 25);
            this.tpPersonal.Name = "tpPersonal";
            this.tpPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonal.Size = new System.Drawing.Size(1293, 596);
            this.tpPersonal.TabIndex = 0;
            this.tpPersonal.Text = "Personal details Page";
            this.tpPersonal.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // statusStrip3
            // 
            this.statusStrip3.Location = new System.Drawing.Point(3, 571);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(1287, 22);
            this.statusStrip3.TabIndex = 9;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 3;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.49735F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.50265F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel14.Controls.Add(this.button15, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.button16, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.button17, 2, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(248, 423);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(272, 41);
            this.tableLayoutPanel14.TabIndex = 8;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.Location = new System.Drawing.Point(3, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(77, 23);
            this.button15.TabIndex = 0;
            this.button15.Text = "Clear screen";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Top;
            this.button16.Location = new System.Drawing.Point(86, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "save";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(155, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 2;
            this.button17.Text = "close";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.pbPhoto, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.bBrowsePhoto, 0, 1);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(611, 50);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(187, 336);
            this.tableLayoutPanel10.TabIndex = 7;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.Silver;
            this.pbPhoto.Location = new System.Drawing.Point(3, 3);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(181, 156);
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // bBrowsePhoto
            // 
            this.bBrowsePhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.bBrowsePhoto.Location = new System.Drawing.Point(3, 171);
            this.bBrowsePhoto.Name = "bBrowsePhoto";
            this.bBrowsePhoto.Size = new System.Drawing.Size(181, 23);
            this.bBrowsePhoto.TabIndex = 1;
            this.bBrowsePhoto.Text = "Browse";
            this.bBrowsePhoto.UseVisualStyleBackColor = true;
            this.bBrowsePhoto.Click += new System.EventHandler(this.button14_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.34944F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.65056F));
            this.tableLayoutPanel9.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.lfilename, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(44, 393);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(538, 24);
            this.tableLayoutPanel9.TabIndex = 6;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Photo Path";
            // 
            // lfilename
            // 
            this.lfilename.AutoSize = true;
            this.lfilename.Dock = System.Windows.Forms.DockStyle.Top;
            this.lfilename.Location = new System.Drawing.Point(133, 0);
            this.lfilename.Name = "lfilename";
            this.lfilename.Size = new System.Drawing.Size(402, 13);
            this.lfilename.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Personal Details Page";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.66304F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.33696F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel7.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label22, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label23, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label24, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label25, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label26, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.tbLasrraID, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.tbSurname, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.tbFirstname, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.tbOthername, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.tbRessidence, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.tbEmail, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.cbDisabilityID, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label28, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.dtpDOB, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.gbGender, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.label29, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.tbPhonenumber, 3, 2);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(23, 47);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 7;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(563, 340);
            this.tableLayoutPanel7.TabIndex = 0;
            this.tableLayoutPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel7_Paint);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Disability ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "LasrraID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Surname";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 149);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "First Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 194);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Other Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 241);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 26);
            this.label25.TabIndex = 5;
            this.label25.Text = "Residential Address";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 295);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Email Address";
            // 
            // tbLasrraID
            // 
            this.tbLasrraID.Location = new System.Drawing.Point(103, 53);
            this.tbLasrraID.Name = "tbLasrraID";
            this.tbLasrraID.Size = new System.Drawing.Size(126, 20);
            this.tbLasrraID.TabIndex = 9;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(103, 103);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(126, 20);
            this.tbSurname.TabIndex = 10;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(103, 152);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(126, 20);
            this.tbFirstname.TabIndex = 11;
            // 
            // tbOthername
            // 
            this.tbOthername.Location = new System.Drawing.Point(103, 197);
            this.tbOthername.Name = "tbOthername";
            this.tbOthername.Size = new System.Drawing.Size(126, 20);
            this.tbOthername.TabIndex = 12;
            // 
            // tbRessidence
            // 
            this.tbRessidence.Location = new System.Drawing.Point(103, 244);
            this.tbRessidence.Multiline = true;
            this.tbRessidence.Name = "tbRessidence";
            this.tbRessidence.Size = new System.Drawing.Size(128, 48);
            this.tbRessidence.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(103, 298);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(128, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // cbDisabilityID
            // 
            this.cbDisabilityID.Enabled = false;
            this.cbDisabilityID.FormattingEnabled = true;
            this.cbDisabilityID.Location = new System.Drawing.Point(103, 3);
            this.cbDisabilityID.Name = "cbDisabilityID";
            this.cbDisabilityID.Size = new System.Drawing.Size(126, 21);
            this.cbDisabilityID.TabIndex = 16;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(237, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 13);
            this.label28.TabIndex = 18;
            this.label28.Text = "Date of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(323, 3);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 17;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbfemale);
            this.gbGender.Controls.Add(this.rbmale);
            this.gbGender.Location = new System.Drawing.Point(323, 53);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(170, 43);
            this.gbGender.TabIndex = 21;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(79, 19);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(59, 17);
            this.rbfemale.TabIndex = 1;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(6, 19);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(48, 17);
            this.rbmale.TabIndex = 0;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(237, 100);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 13);
            this.label29.TabIndex = 19;
            this.label29.Text = "Phone Number";
            // 
            // tbPhonenumber
            // 
            this.tbPhonenumber.Location = new System.Drawing.Point(323, 103);
            this.tbPhonenumber.Name = "tbPhonenumber";
            this.tbPhonenumber.Size = new System.Drawing.Size(200, 20);
            this.tbPhonenumber.TabIndex = 20;
            this.tbPhonenumber.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tpNextOfKin
            // 
            this.tpNextOfKin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tpNextOfKin.Controls.Add(this.statusStrip4);
            this.tpNextOfKin.Controls.Add(this.tableLayoutPanel15);
            this.tpNextOfKin.Controls.Add(this.tableLayoutPanel11);
            this.tpNextOfKin.Controls.Add(this.label17);
            this.tpNextOfKin.Controls.Add(this.tableLayoutPanel8);
            this.tpNextOfKin.Location = new System.Drawing.Point(4, 25);
            this.tpNextOfKin.Name = "tpNextOfKin";
            this.tpNextOfKin.Padding = new System.Windows.Forms.Padding(3);
            this.tpNextOfKin.Size = new System.Drawing.Size(1293, 596);
            this.tpNextOfKin.TabIndex = 1;
            this.tpNextOfKin.Text = "NextOfKin Info";
            this.tpNextOfKin.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // statusStrip4
            // 
            this.statusStrip4.Location = new System.Drawing.Point(3, 571);
            this.statusStrip4.Name = "statusStrip4";
            this.statusStrip4.Size = new System.Drawing.Size(1287, 22);
            this.statusStrip4.TabIndex = 10;
            this.statusStrip4.Text = "statusStrip4";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.49735F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.50265F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel15.Controls.Add(this.button18, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.button19, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.button20, 2, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(127, 247);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(272, 41);
            this.tableLayoutPanel15.TabIndex = 9;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Top;
            this.button18.Location = new System.Drawing.Point(3, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(77, 23);
            this.button18.TabIndex = 0;
            this.button18.Text = "Clear screen";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Top;
            this.button19.Location = new System.Drawing.Point(86, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(63, 23);
            this.button19.TabIndex = 1;
            this.button19.Text = "save";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(155, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 2;
            this.button20.Text = "close";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.96935F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.03065F));
            this.tableLayoutPanel11.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label36, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.tbKinAddress, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.cbkinRelationship, 1, 1);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(266, 65);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(261, 175);
            this.tableLayoutPanel11.TabIndex = 7;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 26);
            this.label35.TabIndex = 0;
            this.label35.Text = "Residential address";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 87);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(65, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Relationship";
            // 
            // tbKinAddress
            // 
            this.tbKinAddress.Location = new System.Drawing.Point(76, 3);
            this.tbKinAddress.Multiline = true;
            this.tbKinAddress.Name = "tbKinAddress";
            this.tbKinAddress.Size = new System.Drawing.Size(173, 81);
            this.tbKinAddress.TabIndex = 2;
            // 
            // cbkinRelationship
            // 
            this.cbkinRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkinRelationship.FormattingEnabled = true;
            this.cbkinRelationship.Items.AddRange(new object[] {
            "AUNT",
            "BROTHER",
            "CHILD",
            "COUSIN",
            "FATHER",
            "HUSBAND",
            "MOTHER",
            "NEIGHBOUR",
            "NEPHEW",
            "NIECE",
            "NONE",
            "SISTER",
            "UNCLE",
            "WIFE"});
            this.cbkinRelationship.Location = new System.Drawing.Point(76, 90);
            this.cbkinRelationship.Name = "cbkinRelationship";
            this.cbkinRelationship.Size = new System.Drawing.Size(173, 21);
            this.cbkinRelationship.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Next Of Kin Information";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.65421F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.34579F));
            this.tableLayoutPanel8.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label33, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label34, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.tbKinSurname, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tbKinFirstName, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.tbKinOtherName, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.tbKinPhone, 1, 3);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(23, 65);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(214, 176);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Surname";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 45);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "First Name";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 85);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Other Name";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 133);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(78, 13);
            this.label34.TabIndex = 3;
            this.label34.Text = "Phone Number";
            // 
            // tbKinSurname
            // 
            this.tbKinSurname.Location = new System.Drawing.Point(90, 3);
            this.tbKinSurname.Name = "tbKinSurname";
            this.tbKinSurname.Size = new System.Drawing.Size(121, 20);
            this.tbKinSurname.TabIndex = 4;
            // 
            // tbKinFirstName
            // 
            this.tbKinFirstName.Location = new System.Drawing.Point(90, 48);
            this.tbKinFirstName.Name = "tbKinFirstName";
            this.tbKinFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbKinFirstName.TabIndex = 5;
            // 
            // tbKinOtherName
            // 
            this.tbKinOtherName.Location = new System.Drawing.Point(90, 88);
            this.tbKinOtherName.Name = "tbKinOtherName";
            this.tbKinOtherName.Size = new System.Drawing.Size(121, 20);
            this.tbKinOtherName.TabIndex = 6;
            // 
            // tbKinPhone
            // 
            this.tbKinPhone.Location = new System.Drawing.Point(90, 136);
            this.tbKinPhone.Name = "tbKinPhone";
            this.tbKinPhone.Size = new System.Drawing.Size(121, 20);
            this.tbKinPhone.TabIndex = 7;
            // 
            // tpDisabilityInfo
            // 
            this.tpDisabilityInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tpDisabilityInfo.Controls.Add(this.statusStrip5);
            this.tpDisabilityInfo.Controls.Add(this.tableLayoutPanel16);
            this.tpDisabilityInfo.Controls.Add(this.tableLayoutPanel13);
            this.tpDisabilityInfo.Controls.Add(this.tableLayoutPanel12);
            this.tpDisabilityInfo.Controls.Add(this.label18);
            this.tpDisabilityInfo.Location = new System.Drawing.Point(4, 25);
            this.tpDisabilityInfo.Name = "tpDisabilityInfo";
            this.tpDisabilityInfo.Size = new System.Drawing.Size(1293, 596);
            this.tpDisabilityInfo.TabIndex = 2;
            this.tpDisabilityInfo.Text = "Disability Info";
            this.tpDisabilityInfo.Click += new System.EventHandler(this.tpDisabilityInfo_Click);
            // 
            // statusStrip5
            // 
            this.statusStrip5.Location = new System.Drawing.Point(0, 574);
            this.statusStrip5.Name = "statusStrip5";
            this.statusStrip5.Size = new System.Drawing.Size(1293, 22);
            this.statusStrip5.TabIndex = 10;
            this.statusStrip5.Text = "statusStrip5";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.49735F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.50265F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel16.Controls.Add(this.button21, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.bDisabilitySave, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.button23, 2, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(220, 436);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(272, 41);
            this.tableLayoutPanel16.TabIndex = 9;
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Top;
            this.button21.Location = new System.Drawing.Point(3, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(77, 23);
            this.button21.TabIndex = 0;
            this.button21.Text = "Clear screen";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // bDisabilitySave
            // 
            this.bDisabilitySave.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDisabilitySave.Location = new System.Drawing.Point(86, 3);
            this.bDisabilitySave.Name = "bDisabilitySave";
            this.bDisabilitySave.Size = new System.Drawing.Size(63, 23);
            this.bDisabilitySave.TabIndex = 1;
            this.bDisabilitySave.Text = "save";
            this.bDisabilitySave.UseVisualStyleBackColor = true;
            this.bDisabilitySave.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(155, 3);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 2;
            this.button23.Text = "close";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.90429F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.09571F));
            this.tableLayoutPanel13.Controls.Add(this.label43, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label44, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label45, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.cbCause, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.label46, 0, 3);
            this.tableLayoutPanel13.Controls.Add(this.lbNeuro, 1, 3);
            this.tableLayoutPanel13.Controls.Add(this.cbBodyParts, 1, 2);
            this.tableLayoutPanel13.Controls.Add(this.cbSeverity, 1, 1);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(359, 44);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 4;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.78947F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.21053F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(338, 385);
            this.tableLayoutPanel13.TabIndex = 8;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(98, 13);
            this.label43.TabIndex = 0;
            this.label43.Text = "Causes of Disability";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 44);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(101, 13);
            this.label44.TabIndex = 1;
            this.label44.Text = "Severity of Disability";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(3, 123);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(101, 13);
            this.label45.TabIndex = 2;
            this.label45.Text = "Affected Body Parts";
            // 
            // cbCause
            // 
            this.cbCause.DataSource = this.disabilityCauseBindingSource;
            this.cbCause.DisplayMember = "disabilityCauseName";
            this.cbCause.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCause.FormattingEnabled = true;
            this.cbCause.Location = new System.Drawing.Point(148, 3);
            this.cbCause.Name = "cbCause";
            this.cbCause.Size = new System.Drawing.Size(187, 21);
            this.cbCause.TabIndex = 3;
            this.cbCause.ValueMember = "disabilityCauseId";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 253);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 26);
            this.label46.TabIndex = 6;
            this.label46.Text = "Neuro development Disability";
            // 
            // lbNeuro
            // 
            this.lbNeuro.FormattingEnabled = true;
            this.lbNeuro.Items.AddRange(new object[] {
            "Asperger Syndrome",
            "Autism",
            "Cerebral Palsy",
            "Communication Disorder",
            "Down Syndrome",
            "Epilepsy",
            "Klineefelter Syndrome",
            "None"});
            this.lbNeuro.Location = new System.Drawing.Point(148, 256);
            this.lbNeuro.Name = "lbNeuro";
            this.lbNeuro.Size = new System.Drawing.Size(187, 82);
            this.lbNeuro.TabIndex = 7;
            this.lbNeuro.SelectedIndexChanged += new System.EventHandler(this.lbNeuro_SelectedIndexChanged);
            // 
            // cbBodyParts
            // 
            this.cbBodyParts.DataSource = this.affectedBodyPartBindingSource;
            this.cbBodyParts.DisplayMember = "description";
            this.cbBodyParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbBodyParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBodyParts.FormattingEnabled = true;
            this.cbBodyParts.Location = new System.Drawing.Point(148, 126);
            this.cbBodyParts.Name = "cbBodyParts";
            this.cbBodyParts.Size = new System.Drawing.Size(187, 21);
            this.cbBodyParts.TabIndex = 8;
            this.cbBodyParts.ValueMember = "bodypartId";
            // 
            // cbSeverity
            // 
            this.cbSeverity.DataSource = this.disabilitySeverityBindingSource;
            this.cbSeverity.DisplayMember = "severityName";
            this.cbSeverity.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Location = new System.Drawing.Point(148, 47);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(187, 21);
            this.cbSeverity.TabIndex = 9;
            this.cbSeverity.ValueMember = "disabilitySeverityId";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.34177F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.65823F));
            this.tableLayoutPanel12.Controls.Add(this.label37, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label38, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label41, 0, 5);
            this.tableLayoutPanel12.Controls.Add(this.label40, 0, 4);
            this.tableLayoutPanel12.Controls.Add(this.label39, 0, 3);
            this.tableLayoutPanel12.Controls.Add(this.label42, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.cbDisabilityType, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.cbDisabilityDuration, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.cbOnset, 1, 2);
            this.tableLayoutPanel12.Controls.Add(this.cbVisual, 1, 3);
            this.tableLayoutPanel12.Controls.Add(this.cbHearing, 1, 4);
            this.tableLayoutPanel12.Controls.Add(this.lbPsychiatric, 1, 5);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(37, 44);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 6;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(316, 386);
            this.tableLayoutPanel12.TabIndex = 7;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(80, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "Disability Types";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 50);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(91, 13);
            this.label38.TabIndex = 1;
            this.label38.Text = "Disability Duration";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 250);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 39);
            this.label41.TabIndex = 4;
            this.label41.Text = "Psychiatric/ Psycholgical Impairment";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 201);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(98, 13);
            this.label40.TabIndex = 3;
            this.label40.Text = "Hearing Impairment";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 149);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(89, 13);
            this.label39.TabIndex = 2;
            this.label39.Text = "Visual Impairment";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 100);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(91, 13);
            this.label42.TabIndex = 5;
            this.label42.Text = "Onset of Disability";
            // 
            // cbDisabilityType
            // 
            this.cbDisabilityType.DataSource = this.disabilityTypeBindingSource;
            this.cbDisabilityType.DisplayMember = "disabilityTypeName";
            this.cbDisabilityType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDisabilityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisabilityType.FormattingEnabled = true;
            this.cbDisabilityType.Location = new System.Drawing.Point(120, 3);
            this.cbDisabilityType.Name = "cbDisabilityType";
            this.cbDisabilityType.Size = new System.Drawing.Size(193, 21);
            this.cbDisabilityType.TabIndex = 7;
            this.cbDisabilityType.ValueMember = "disabilityTypeId";
            this.cbDisabilityType.SelectedIndexChanged += new System.EventHandler(this.cbDisabilityType_SelectedIndexChanged);
            // 
            // cbDisabilityDuration
            // 
            this.cbDisabilityDuration.DataSource = this.impairmentDurationBindingSource;
            this.cbDisabilityDuration.DisplayMember = "duration";
            this.cbDisabilityDuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDisabilityDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisabilityDuration.FormattingEnabled = true;
            this.cbDisabilityDuration.Location = new System.Drawing.Point(120, 53);
            this.cbDisabilityDuration.Name = "cbDisabilityDuration";
            this.cbDisabilityDuration.Size = new System.Drawing.Size(193, 21);
            this.cbDisabilityDuration.TabIndex = 8;
            this.cbDisabilityDuration.ValueMember = "impairmentDurationId";
            // 
            // cbOnset
            // 
            this.cbOnset.DataSource = this.onsetOfDisabilityBindingSource;
            this.cbOnset.DisplayMember = "onsetDuration";
            this.cbOnset.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOnset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOnset.FormattingEnabled = true;
            this.cbOnset.Location = new System.Drawing.Point(120, 103);
            this.cbOnset.Name = "cbOnset";
            this.cbOnset.Size = new System.Drawing.Size(193, 21);
            this.cbOnset.TabIndex = 9;
            this.cbOnset.ValueMember = "onsetId";
            // 
            // cbVisual
            // 
            this.cbVisual.DataSource = this.visualImpairmentBindingSource;
            this.cbVisual.DisplayMember = "ImpairmentDescription";
            this.cbVisual.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVisual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisual.FormattingEnabled = true;
            this.cbVisual.Location = new System.Drawing.Point(120, 152);
            this.cbVisual.Name = "cbVisual";
            this.cbVisual.Size = new System.Drawing.Size(193, 21);
            this.cbVisual.TabIndex = 10;
            this.cbVisual.ValueMember = "visualImpairmentId";
            // 
            // cbHearing
            // 
            this.cbHearing.DataSource = this.hearingImpairmentBindingSource;
            this.cbHearing.DisplayMember = "hearingImpairmentDescription";
            this.cbHearing.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbHearing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHearing.FormattingEnabled = true;
            this.cbHearing.Location = new System.Drawing.Point(120, 204);
            this.cbHearing.Name = "cbHearing";
            this.cbHearing.Size = new System.Drawing.Size(193, 21);
            this.cbHearing.TabIndex = 11;
            this.cbHearing.ValueMember = "hearingImpairmentId";
            // 
            // lbPsychiatric
            // 
            this.lbPsychiatric.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPsychiatric.FormattingEnabled = true;
            this.lbPsychiatric.Items.AddRange(new object[] {
            "Alzheimer\'s Disease",
            "Anxiety Depression",
            "Bipolar Disorder",
            "Depression",
            "Memory Loss",
            "Obsessive Compulsive Disorder",
            "Others",
            "None"});
            this.lbPsychiatric.Location = new System.Drawing.Point(120, 253);
            this.lbPsychiatric.Name = "lbPsychiatric";
            this.lbPsychiatric.Size = new System.Drawing.Size(193, 95);
            this.lbPsychiatric.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Disability Information";
            // 
            // tpMedicalOfficer
            // 
            this.tpMedicalOfficer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tpMedicalOfficer.Controls.Add(this.statusStrip2);
            this.tpMedicalOfficer.Controls.Add(this.tableLayoutPanel18);
            this.tpMedicalOfficer.Controls.Add(this.tableLayoutPanel17);
            this.tpMedicalOfficer.Controls.Add(this.label19);
            this.tpMedicalOfficer.Location = new System.Drawing.Point(4, 25);
            this.tpMedicalOfficer.Name = "tpMedicalOfficer";
            this.tpMedicalOfficer.Size = new System.Drawing.Size(1293, 596);
            this.tpMedicalOfficer.TabIndex = 3;
            this.tpMedicalOfficer.Text = "Medical Officer Details";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 574);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1293, 22);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 3;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.49735F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.50265F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel18.Controls.Add(this.button24, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.button25, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.button26, 2, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(125, 275);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(272, 41);
            this.tableLayoutPanel18.TabIndex = 10;
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Top;
            this.button24.Location = new System.Drawing.Point(3, 3);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(77, 23);
            this.button24.TabIndex = 0;
            this.button24.Text = "Clear screen";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Dock = System.Windows.Forms.DockStyle.Top;
            this.button25.Location = new System.Drawing.Point(86, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(63, 23);
            this.button25.TabIndex = 1;
            this.button25.Text = "save";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(155, 3);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 2;
            this.button26.Text = "close";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 3;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.17021F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.82979F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel17.Controls.Add(this.label47, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label48, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label49, 0, 2);
            this.tableLayoutPanel17.Controls.Add(this.tbOficerName, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.tbOfficerNumber, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.tbOfficerAddress, 1, 2);
            this.tableLayoutPanel17.Controls.Add(this.tbComment, 2, 1);
            this.tableLayoutPanel17.Controls.Add(this.label50, 2, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(23, 58);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 3;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.38411F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.61589F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(510, 211);
            this.tableLayoutPanel17.TabIndex = 7;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(3, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(35, 13);
            this.label47.TabIndex = 0;
            this.label47.Text = "Name";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 64);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(67, 26);
            this.label48.TabIndex = 1;
            this.label48.Text = "Membership Number";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(3, 151);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(87, 13);
            this.label49.TabIndex = 2;
            this.label49.Text = "Practice Address";
            // 
            // tbOficerName
            // 
            this.tbOficerName.Location = new System.Drawing.Point(109, 3);
            this.tbOficerName.Name = "tbOficerName";
            this.tbOficerName.Size = new System.Drawing.Size(181, 20);
            this.tbOficerName.TabIndex = 3;
            // 
            // tbOfficerNumber
            // 
            this.tbOfficerNumber.Location = new System.Drawing.Point(109, 67);
            this.tbOfficerNumber.Name = "tbOfficerNumber";
            this.tbOfficerNumber.Size = new System.Drawing.Size(181, 20);
            this.tbOfficerNumber.TabIndex = 4;
            // 
            // tbOfficerAddress
            // 
            this.tbOfficerAddress.Location = new System.Drawing.Point(109, 154);
            this.tbOfficerAddress.Multiline = true;
            this.tbOfficerAddress.Name = "tbOfficerAddress";
            this.tbOfficerAddress.Size = new System.Drawing.Size(181, 54);
            this.tbOfficerAddress.TabIndex = 5;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(296, 67);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(162, 77);
            this.tbComment.TabIndex = 6;
            // 
            // label50
            // 
            this.label50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(296, 51);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(91, 13);
            this.label50.TabIndex = 7;
            this.label50.Text = "General Comment";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(190, 20);
            this.label19.TabIndex = 6;
            this.label19.Text = "Medical Officer Details";
            // 
            // tpLasodaMain
            // 
            this.tpLasodaMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tpLasodaMain.Controls.Add(this.panel3);
            this.tpLasodaMain.Controls.Add(this.lbCurrentUser);
            this.tpLasodaMain.Controls.Add(this.label11);
            this.tpLasodaMain.Controls.Add(this.statusStrip1);
            this.tpLasodaMain.Controls.Add(this.label1);
            this.tpLasodaMain.Controls.Add(this.pictureBox5);
            this.tpLasodaMain.Controls.Add(this.tableLayoutPanel2);
            this.tpLasodaMain.Location = new System.Drawing.Point(4, 25);
            this.tpLasodaMain.Name = "tpLasodaMain";
            this.tpLasodaMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpLasodaMain.Size = new System.Drawing.Size(1307, 631);
            this.tpLasodaMain.TabIndex = 0;
            this.tpLasodaMain.Text = "LASODA";
            this.tpLasodaMain.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(206, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 369);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(368, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(146, 122);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Create new Record";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "View Existing Record";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 145);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(205, 150);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(368, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 160);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Generate Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manage user Account";
            // 
            // lbCurrentUser
            // 
            this.lbCurrentUser.AutoSize = true;
            this.lbCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUser.Location = new System.Drawing.Point(88, 25);
            this.lbCurrentUser.Name = "lbCurrentUser";
            this.lbCurrentUser.Size = new System.Drawing.Size(48, 13);
            this.lbCurrentUser.TabIndex = 9;
            this.lbCurrentUser.Text = "label51";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Current User";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1301, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Application Quick Start";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(206, 37);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(627, 98);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.39779F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button5, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(149, 340);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create New Record";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage User";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(3, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "View existing";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(3, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbLasodaApp
            // 
            this.tbLasodaApp.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbLasodaApp.Controls.Add(this.tpLasodaMain);
            this.tbLasodaApp.Controls.Add(this.tabPage2);
            this.tbLasodaApp.Controls.Add(this.tabPage3);
            this.tbLasodaApp.Controls.Add(this.tabPage4);
            this.tbLasodaApp.Controls.Add(this.tpReports);
            this.tbLasodaApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLasodaApp.Location = new System.Drawing.Point(0, 0);
            this.tbLasodaApp.Name = "tbLasodaApp";
            this.tbLasodaApp.SelectedIndex = 0;
            this.tbLasodaApp.Size = new System.Drawing.Size(1315, 660);
            this.tbLasodaApp.TabIndex = 2;
            // 
            // Lasodamanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1315, 660);
            this.Controls.Add(this.tbLasodaApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menustripReports;
            this.Name = "Lasodamanage";
            this.Text = "Lagos State Office For Disability";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lasodamanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disabilityCauseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasodaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectedBodyPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disabilitySeverityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disabilityTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impairmentDurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onsetOfDisabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualImpairmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hearingImpairmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biographicDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lasodaDataSetBiography)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserAccount)).EndInit();
            this.tpReports.ResumeLayout(false);
            this.tpReports.PerformLayout();
            this.menustripReports.ResumeLayout(false);
            this.menustripReports.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbprofileGender.ResumeLayout(false);
            this.gbprofileGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewProfile)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tbRegistration.ResumeLayout(false);
            this.tpPersonal.ResumeLayout(false);
            this.tpPersonal.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.tpNextOfKin.ResumeLayout(false);
            this.tpNextOfKin.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tpDisabilityInfo.ResumeLayout(false);
            this.tpDisabilityInfo.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tpMedicalOfficer.ResumeLayout(false);
            this.tpMedicalOfficer.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tpLasodaMain.ResumeLayout(false);
            this.tpLasodaMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tbLasodaApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epUserAccount;
        private LasodaDataSet lasodaDataSet;
        private System.Windows.Forms.BindingSource disabilityTypeBindingSource;
        private LasodaDataSetTableAdapters.DisabilityTypeTableAdapter disabilityTypeTableAdapter;
        private System.Windows.Forms.BindingSource impairmentDurationBindingSource;
        private LasodaDataSetTableAdapters.ImpairmentDurationTableAdapter impairmentDurationTableAdapter;
        private System.Windows.Forms.BindingSource onsetOfDisabilityBindingSource;
        private LasodaDataSetTableAdapters.OnsetOfDisabilityTableAdapter onsetOfDisabilityTableAdapter;
        private System.Windows.Forms.BindingSource visualImpairmentBindingSource;
        private LasodaDataSetTableAdapters.VisualImpairmentTableAdapter visualImpairmentTableAdapter;
        private System.Windows.Forms.BindingSource disabilityCauseBindingSource;
        private LasodaDataSetTableAdapters.DisabilityCauseTableAdapter disabilityCauseTableAdapter;
        private System.Windows.Forms.BindingSource disabilitySeverityBindingSource;
        private LasodaDataSetTableAdapters.DisabilitySeverityTableAdapter disabilitySeverityTableAdapter;
        private System.Windows.Forms.BindingSource affectedBodyPartBindingSource;
        private LasodaDataSetTableAdapters.AffectedBodyPartTableAdapter affectedBodyPartTableAdapter;
        private System.Windows.Forms.BindingSource hearingImpairmentBindingSource;
        private LasodaDataSetTableAdapters.HearingImpairmentTableAdapter hearingImpairmentTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private LasodaDataSetBiography lasodaDataSetBiography;
        private System.Windows.Forms.BindingSource biographicDetailBindingSource;
        private LasodaDataSetBiographyTableAdapters.BiographicDetailTableAdapter biographicDetailTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tbLasodaApp;
        private System.Windows.Forms.TabPage tpLasodaMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCurrentUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tbRegistration;
        private System.Windows.Forms.TabPage tpPersonal;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button bBrowsePhoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lfilename;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbLasrraID;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbOthername;
        private System.Windows.Forms.TextBox tbRessidence;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbDisabilityID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbPhonenumber;
        private System.Windows.Forms.TabPage tpNextOfKin;
        private System.Windows.Forms.StatusStrip statusStrip4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbKinAddress;
        private System.Windows.Forms.ComboBox cbkinRelationship;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbKinSurname;
        private System.Windows.Forms.TextBox tbKinFirstName;
        private System.Windows.Forms.TextBox tbKinOtherName;
        private System.Windows.Forms.TextBox tbKinPhone;
        private System.Windows.Forms.TabPage tpDisabilityInfo;
        private System.Windows.Forms.StatusStrip statusStrip5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button bDisabilitySave;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cbCause;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ListBox lbNeuro;
        private System.Windows.Forms.ComboBox cbBodyParts;
        private System.Windows.Forms.ComboBox cbSeverity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cbDisabilityType;
        private System.Windows.Forms.ComboBox cbDisabilityDuration;
        private System.Windows.Forms.ComboBox cbOnset;
        private System.Windows.Forms.ComboBox cbVisual;
        private System.Windows.Forms.ComboBox cbHearing;
        private System.Windows.Forms.ListBox lbPsychiatric;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tpMedicalOfficer;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox tbOficerName;
        private System.Windows.Forms.TextBox tbOfficerNumber;
        private System.Windows.Forms.TextBox tbOfficerAddress;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip ssManageUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bUser;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbDeactivate;
        private System.Windows.Forms.RadioButton rbActivate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbProfileVisual;
        private System.Windows.Forms.ComboBox cbProfileKinRelationship;
        private System.Windows.Forms.ComboBox cbProfileOnset;
        private System.Windows.Forms.TextBox tbProfileMedicalAddress;
        private System.Windows.Forms.TextBox tbProfileMedicalNum;
        private System.Windows.Forms.TextBox tbProfileMedicalName;
        private System.Windows.Forms.TextBox tbProfileKinOther;
        private System.Windows.Forms.TextBox tbProfileKinPhone;
        private System.Windows.Forms.ComboBox cbProfilePsycho;
        private System.Windows.Forms.TextBox tbProfileKinFirst;
        private System.Windows.Forms.ComboBox cbProfilePart;
        private System.Windows.Forms.TextBox tbProfileKinAddress;
        private System.Windows.Forms.ComboBox cbProfileHearing;
        private System.Windows.Forms.TextBox tbProfileKinSurname;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbprofileGender;
        private System.Windows.Forms.RadioButton rbProfileFemale;
        private System.Windows.Forms.RadioButton rbProfileMale;
        private System.Windows.Forms.ComboBox cbProfileType;
        private System.Windows.Forms.ComboBox cbProfileNeuro;
        private System.Windows.Forms.DateTimePicker dtpProfileDOB;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox cbProfileCause;
        private System.Windows.Forms.ComboBox cbProfileSeverity;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ComboBox cbProfileDuration;
        private System.Windows.Forms.TextBox tbProfileAddress;
        private System.Windows.Forms.TextBox tbProfilePhone;
        private System.Windows.Forms.TextBox tbProfileSurname;
        private System.Windows.Forms.TextBox tbProfileFirstname;
        private System.Windows.Forms.TextBox tbProfileEmail;
        private System.Windows.Forms.TextBox tbProfileotherName;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.DataGridView dgvViewProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn biodataIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biodataIntegerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasrraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disabilityTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disabilityCauseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disabilitySeverityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impairmentDurationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neuroDisabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psychiatricDisabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affectedBodyPartIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visualImpairmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hearingImpairmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onsetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othernameKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationshipKinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesMedicalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipNumberMedicalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressMedicalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLastModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.MenuStrip menustripReports;
        private System.Windows.Forms.ToolStripMenuItem msReports;
        private System.Windows.Forms.ToolStripMenuItem miSummaryByUser;
        private System.Windows.Forms.ToolStripMenuItem miBasicDetailReport;
        private System.Windows.Forms.ToolStripMenuItem miDetailReportbyDisabilityType;
        private System.Windows.Forms.ToolStripMenuItem miDetailReportByUser;
        private System.Windows.Forms.ToolStripMenuItem miDetailReportbyAgeBracket;
        private System.Windows.Forms.ToolStripMenuItem miDetailReportByAgeandgender;
        private System.Windows.Forms.ToolStripMenuItem miDetailReportByGenderandDisability;
        private System.Windows.Forms.ToolStripMenuItem miDetailReportbyDisabilityCauseandType;
        private System.Windows.Forms.ToolStripMenuItem miDetailReportByDisabilityTypeandSeverity;
        private System.Windows.Forms.ToolStripMenuItem miBasicDetailReportByDate;
        private System.Windows.Forms.ToolStripMenuItem miBasicDetailReportbyCurrentUser;
        





    }
}