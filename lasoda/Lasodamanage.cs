using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.IO;


namespace lasoda
{
    public partial class Lasodamanage : Form
    {
        string ConString;

        DataTable tableUser;
        int userId, profileId;
        string password1, passsword2, username, category;
        string status = "";

        string disability, lassraId, surname, firstname, othername, residence, email, phonenumber, DOB;
        string gender = "";

        string kinSurname, kinFirstname, KinOthername, kinPhone, kinResidence, kinRelation;

        int typeId, durationId, onsetId, visualId, hearingId, causeId, severityId, partsId;

        string  psychoDisability, neuroDisability;
      
        string officerName, officernumber, officerAddress, officerComment;

        //Image curlImage;
        string photoLink;
        byte[] rawdata;

        /*tableUser.Rows[0][0] = id
         tableUser.Rows[][1] = username
         tableUser.Rows[][2] = password
         tableUser.Rows[][3] = datecreated
         tableUser.Rows[][3] = usercategory
         tableUser.Rows[][3] = status
         
         */

        public Lasodamanage(DataTable dt)
        {
            InitializeComponent();
            ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            tableUser = dt;
            lbCurrentUser.Text = tableUser.Rows[0][1].ToString();
            userId = (int)tableUser.Rows[0][0];

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open Photo Image";
                //dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    photoLink = dlg.FileName;
                    lfilename.Text = photoLink;
                    pbPhoto.Image = new Bitmap(dlg.FileName);
                    //this.Controls.Add(pbPhoto);
                    if(lfilename.Text != "")
                    {
                        FileStream file = new FileStream(photoLink, FileMode.OpenOrCreate, FileAccess.Read);
                        rawdata = new byte[file.Length];
                        file.Read(rawdata, 0, System.Convert.ToInt32(file.Length));
                        file.Close();

                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error didplaying Image");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadCombo()
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            //disability = cbDisability.GetItemText(cbDisability.SelectedItem);
            lassraId = tbLasrraID.Text;
            surname = tbSurname.Text;
            firstname = tbFirstname.Text;
            othername = tbOthername.Text;
            residence = tbRessidence.Text;
            email = tbEmail.Text;
            if (rbmale.Checked)
                status = "male";
            if (rbfemale.Checked)
                status = "female";
            phonenumber = tbPhonenumber.Text;
            DOB = dtpDOB.Value.ToString("MM/dd/yyyy");
            photoLink = lfilename.Text;
            

            
                
            if(ValidatePersonalPage() == 0)
            {
                epUserAccount.Clear();
                tbRegistration.SelectTab(tpNextOfKin);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Today;
            string date;
            date = Date.ToString("MM/dd/yyyy");
            //string date = DateTime.Parse(DateTime.Today);
            
            password1 = tbPass1.Text;
            passsword2 = tbPass2.Text;
            username = tbUsername.Text.Trim();
            //category = (string)cbCategory.SelectedValue;
            category = cbCategory.GetItemText(cbCategory.SelectedItem);
            if (rbActivate.Checked)
                status = "activated";
            if (rbDeactivate.Checked)
                status = "deactivated";

            string query = "Insert Into" +
                " [User]([username], [password], [datecreated], [usercategory], [status])" +
                " Values ('" + username + "','" + password1 + "','" + date + "','" + category + "','" + status + "')";

            if(ValidateData() == 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = new SqlConnection(ConString);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        epUserAccount.Clear();
                        MessageBox.Show("New user Created");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Operation due to \n" + ex.Message );
                }
                finally
                {
                    tbUsername.Text = "";
                    tbPass1.Text = "";
                    tbPass2.Text = "";
                    tbUsername.Text = "";
                    cbCategory.SelectedIndex = -1;
                    rbActivate.Checked = false;
                    rbDeactivate.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Correct The Errors");
            }
         
        }

        private void bClose_Click(object sender, EventArgs e)
        {

        }

        private void tbUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private int ValidateData()
        {
            //string userId, password1, passsword2, username, category, status;
            int flag = 0;

            if (tbPass1.Text == "")
            {
                tbPass1.Focus();
                epUserAccount.SetError(tbPass1, "Fill in The password");
                flag = 1;

            }
            if (tbPass2.Text == "")
            {
                tbPass2.Focus();
                epUserAccount.SetError(tbPass2, "Fill in The password");
                flag = 1;

            }
            if (tbUsername.Text.Trim() == "")
            {
                tbUsername.Focus();
                epUserAccount.SetError(tbUsername, "Fill in The username");
                flag = 1;

            }
            if(cbCategory.SelectedIndex < -1){
                cbCategory.Focus();
                epUserAccount.SetError(cbCategory, "Requires a Category");
                flag = 1;

            }
            if ((rbActivate.Checked == false) && (rbDeactivate.Checked == false))
            {
                gbStatus.Focus();
                epUserAccount.SetError(gbStatus, "Select a Status");
                flag = 1;

            }
            if(tbPass1.Text != tbPass2.Text)
            {
                tbPass1.Focus();
                epUserAccount.SetError(tbPass1, "The password strings are not the same");
                flag = 1;
            }
                
            return flag;
        }

        private int ValidatePersonalPage()
        {
            int flag = 0;
            if (surname.Trim() == "")
            {
                tbSurname.Focus();
                epUserAccount.SetError(tbSurname, "Fill in The surname");
                flag = 1;
            }
            if (firstname.Trim() == "")
            {
                tbFirstname.Focus();
                epUserAccount.SetError(tbFirstname, "Fill in The firstname");
                flag = 1;
            }
            if (othername.Trim() == "")
            {
                tbUsername.Focus();
                epUserAccount.SetError(tbUsername, "Fill in The username");
                flag = 1;
            }
            if (residence.Trim() == "")
            {
                tbRessidence.Focus();
                epUserAccount.SetError(tbRessidence, "Requires a Category");
                flag = 1;
            }
            if ((rbfemale.Checked == false) && (rbmale.Checked == false))
            {
                gbGender.Focus();
                epUserAccount.SetError(gbGender, "Select a Gender");
                flag = 1;
            }
            if (phonenumber.Trim() == "")
            {
                tbPhonenumber.Focus();
                epUserAccount.SetError(tbPhonenumber, "Requires Phonenumber");
                flag = 1;
            }
            if (DOB.Trim() == "")
            {
                dtpDOB.Focus();
                epUserAccount.SetError(dtpDOB, "Requires Date of Birth");
                flag = 1;
            }
            return flag;
        }

        private int ValidateKinInfo()
        {
            int flag = 0;
            if (kinSurname == "")
            {
                tbKinSurname.Focus();
                epUserAccount.SetError(tbSurname, "Fill in The surname");
                flag = 1;
            }
            if (kinFirstname == "")
            {
                tbKinFirstName.Focus();
                epUserAccount.SetError(tbKinFirstName, "Fill in The firstname");
                flag = 1;
            }
            if (KinOthername == "")
            {
                tbKinOtherName.Focus();
                epUserAccount.SetError(tbKinOtherName, "Fill in The username");
                flag = 1;
            }
            if (kinResidence == "")
            {
                tbKinAddress.Focus();
                epUserAccount.SetError(tbKinAddress, "Requires an Address");
                flag = 1;
            }
            if (cbkinRelationship.SelectedIndex < -1)
            {
                cbkinRelationship.Focus();
                epUserAccount.SetError(cbkinRelationship, "Requires a Category");
                flag = 1;

            }
            
            return flag;
        }


        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbDeactivate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPass1.Text = "";
            tbPass2.Text = "";
            tbUsername.Text = "";
            cbCategory.SelectedIndex = -1;
            rbActivate.Checked = false;
            rbDeactivate.Checked = false;
        }

        private void tbPass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            cbDisabilityID.SelectedIndex = -1;
            tbLasrraID.Text = "";
            tbSurname.Text = "";
            tbFirstname.Text = "";
            tbOthername.Text = "";
            tbRessidence.Text = "";
            tbEmail.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            tbPhonenumber.Text = "";
            pbPhoto.Image = null;

            epUserAccount.Clear();
            tbLasodaApp.SelectTab(tpLasodaMain);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            cbDisabilityID.SelectedIndex = -1;
            tbLasrraID.Text = "";
            tbSurname.Text = "";
            tbFirstname.Text = "";
            tbOthername.Text = "";
            tbRessidence.Text = "";
            tbEmail.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            tbPhonenumber.Text="";
            pbPhoto.Image = null;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            epUserAccount.Clear();
            tbLasodaApp.SelectTab(tpLasodaMain);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            epUserAccount.Clear();
            tbLasodaApp.SelectTab(tpLasodaMain);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            epUserAccount.Clear();
            tbLasodaApp.SelectTab(tpLasodaMain);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //string kinSurname, kinFirstname, KinOthername, kinPhone, kinResidence, kinRelation;
            kinSurname = tbKinSurname.Text;
            kinFirstname = tbKinFirstName.Text;
            KinOthername = tbKinOtherName.Text;
            kinResidence = tbKinAddress.Text;
            kinRelation = cbkinRelationship.GetItemText(cbkinRelationship.SelectedItem);
            kinPhone = tbKinPhone.Text;

            if (ValidateKinInfo() == 0)
            {
                epUserAccount.Clear();
                tbRegistration.SelectTab(tpDisabilityInfo);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbKinSurname.Clear();
            tbKinFirstName.Clear();
            tbKinOtherName.Clear();
            tbKinAddress.Clear();
            cbkinRelationship.SelectedIndex = -1;
            tbKinPhone.Clear();

        }

        private void Lasodamanage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lasodaDataSetBiography.BiographicDetail' table. You can move, or remove it, as needed.
            this.biographicDetailTableAdapter.Fill(this.lasodaDataSetBiography.BiographicDetail);
            // TODO: This line of code loads data into the 'lasodaDataSet.HearingImpairment' table. You can move, or remove it, as needed.
            this.hearingImpairmentTableAdapter.Fill(this.lasodaDataSet.HearingImpairment);
            // TODO: This line of code loads data into the 'lasodaDataSet.AffectedBodyPart' table. You can move, or remove it, as needed.
            this.affectedBodyPartTableAdapter.Fill(this.lasodaDataSet.AffectedBodyPart);
            // TODO: This line of code loads data into the 'lasodaDataSet.DisabilitySeverity' table. You can move, or remove it, as needed.
            this.disabilitySeverityTableAdapter.Fill(this.lasodaDataSet.DisabilitySeverity);
            // TODO: This line of code loads data into the 'lasodaDataSet.DisabilityCause' table. You can move, or remove it, as needed.
            this.disabilityCauseTableAdapter.Fill(this.lasodaDataSet.DisabilityCause);
            // TODO: This line of code loads data into the 'lasodaDataSet.VisualImpairment' table. You can move, or remove it, as needed.
            this.visualImpairmentTableAdapter.Fill(this.lasodaDataSet.VisualImpairment);
            // TODO: This line of code loads data into the 'lasodaDataSet.OnsetOfDisability' table. You can move, or remove it, as needed.
            this.onsetOfDisabilityTableAdapter.Fill(this.lasodaDataSet.OnsetOfDisability);
            // TODO: This line of code loads data into the 'lasodaDataSet.ImpairmentDuration' table. You can move, or remove it, as needed.
            this.impairmentDurationTableAdapter.Fill(this.lasodaDataSet.ImpairmentDuration);
            // TODO: This line of code loads data into the 'lasodaDataSet.DisabilityType' table. You can move, or remove it, as needed.
            this.disabilityTypeTableAdapter.Fill(this.lasodaDataSet.DisabilityType);
            
            /*
            MyWorkerClass obj = new MyWorkerClass();
            if (!backgroundWorker1.IsBusy)
            {

                backgroundWorker1.RunWorkerAsync(obj);

                bDisabilitySave.Enabled = false;

                bDisabilitySave.Text = "Loading...";

            }
             * */
            
        }
        /*

        private void LoadData(MyWorkerClass obj)
        {
            
            OleDbConnection cnn;
            OleDbCommand cmd;
            string query = "Select" +
           "* From AffectedBodyPart, DisabilityCause, DisabilitySeverity, DisabilityType, HearingImpairment,"
           + "ImpairmentDuration, Onset_of_Disability, VisualImpairment";

            cnn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Lasoda.accdb");
            try
            {
                cnn.Open();
                cmd = new OleDbCommand(query, cnn);
                reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    obj.DisabilityTypeName = reader["DisabilityTypeName"].ToString();
                    obj.DisabilityTypeId = int.Parse(reader["DisabilityTypeId"].ToString());

                    obj.Duration = reader["Duration"].ToString();
                    obj.ImpairmentDurationId = int.Parse(reader["ImpairmentDurationId"].ToString());

                    obj.Onset_Duration = reader["Onset_Duration"].ToString();
                    obj.Onset_Id = int.Parse(reader["Onset_Id"].ToString());

                    obj.ImpairmentDescription = reader["ImpairmentDescription"].ToString();
                    obj.DisabilityTypeId = int.Parse(reader["VisualImpairmentId"].ToString());

                    obj.HearingImpairmentName = reader["HearingImpairmentName"].ToString();
                    obj.HearingImpairmentId = int.Parse(reader["HearingImpairmentId"].ToString());

                    obj.DisabilityCauseName = reader["DisabilityCauseName"].ToString();
                    obj.DisabilityCauseId = int.Parse(reader["DisabilityCauseId"].ToString());

                    obj.SeverityName = reader["SeverityName"].ToString();
                    obj.DisabilitySeverityId = int.Parse(reader["DisabilitySeverityId"].ToString());

                    obj.Description = reader["Description"].ToString();
                    obj.BodyPartId = int.Parse(reader["BodyPartId"].ToString());

                    backgroundWorker1.ReportProgress(i, obj);
                    i++;
                    Thread.Sleep(10);
                }
                reader.Close();
                cmd.Dispose();
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erros \n" + ex);
            }
            /*
            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                string query = "Select" +
           "* From AffectedBodyPart, DisabilityCause, DisabilitySeverity, DisabilityType, HearingImpairment,"
           + "ImpairmentDuration, Onset_of_Disability, VisualImpairment";

                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Lasoda.accdb");
                //oleDbDataAdapter.SelectCommand.Connection.Open();
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                oleDbDataAdapter.SelectCommand.CommandText = query;
                reader = oleDbDataAdapter.SelectCommand.ExecuteReader();
                
            }
            

        
        }
         *  * */

        private void tpDisabilityInfo_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            typeId = (int)cbDisabilityType.SelectedValue;
            durationId = (int)cbDisabilityDuration.SelectedValue;
            onsetId = (int)cbOnset.SelectedValue;
            visualId = (int)cbVisual.SelectedValue;
            hearingId = (int)cbHearing.SelectedValue;
            causeId = (int)cbCause.SelectedValue;
            severityId = (int)cbSeverity.SelectedValue;
            partsId = (int)cbBodyParts.SelectedValue;

            psychoDisability = lbPsychiatric.GetItemText(lbPsychiatric.SelectedItem);
            neuroDisability = lbNeuro.GetItemText(lbNeuro.SelectedItem);
            
            if (ValidateDisability() == 0)
            {
                epUserAccount.Clear();
                tbRegistration.SelectTab(tpMedicalOfficer);
            }
        }
        
        private int ValidateDisability()
        {
            int flag = 0;

            
            if((cbDisabilityType.SelectedIndex < -1) || (cbDisabilityDuration.SelectedIndex < -1) 
                || (cbOnset.SelectedIndex < -1) || (cbVisual.SelectedIndex < -1)
                || (cbHearing.SelectedIndex < -1) || (cbCause.SelectedIndex < -1)
                || (cbSeverity.SelectedIndex < -1) || (cbBodyParts.SelectedIndex < -1)
                || (lbPsychiatric.SelectedIndex < -1) || (lbNeuro.SelectedIndex < -1))
            
            {
                cbDisabilityType.Focus();
                epUserAccount.SetError(cbDisabilityType, "Disability Information Missing");
                flag = 1;

            }
            
                
            return flag;
        }

        private void button21_Click(object sender, EventArgs e)
        {

            
        }



        private void button25_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            string dateString = Date.ToString("MM/dd/yyyy");
            officerName = tbOficerName.Text;
            officernumber = tbOfficerNumber.Text;
            officerAddress = tbOfficerAddress.Text;
            officerComment = tbComment.Text;

            
            string query = "Insert Into" +
            " [BiographicDetail] ([lasrraId], [surname], [firstname], [othername]," +
            " [birthday], [gender], [homeAddress], [email], [contactPhone], [disabilityTypeId]," +
            " [disabilityCauseId], [disabilitySeverityId], [impairmentDurationId], [neuroDisability]," +
            " [psychiatricDisability], [affectedBodyPartId], [visualImpairmentId], [hearingImpairmentId]," +
            " [onsetId], [surnameKin], [firstnameKin], [othernameKin], [phoneKin], [addressKin]," +
            " [relationshipKin], [namesMedical], [membershipNumberMedical], [addressMedical], [userId], " +
            " [dateCreated], [dateLastModified], [photoLink], [photo])" +
            " Values ('" + lassraId + "','" + surname + "','" + firstname + "','" + othername + "','" + DOB + "','" +
            gender + "','" + residence + "','" + email + "','" + phonenumber + "','" + typeId + "','" +
            causeId + "','" + severityId + "','" + durationId + "','" + neuroDisability + "','" + psychoDisability + "','" +
            partsId + "','" + visualId + "','" + hearingId + "','" + onsetId + "','" + kinSurname + "','" +
            kinFirstname + "','" + KinOthername + "','" + kinPhone + "','" + kinResidence + "','" + kinRelation + "','" +
            officerName + "','" + officernumber + "','" + officerAddress + "','" + userId + "','" + dateString + "','" +
            dateString + "','" + photoLink + "'," + "@rawdata)";

            //int typeId, durationId, onsetId, visualId, hearingId, causeId, severityId, partsId;
            if (ValidateMedicalOfficer() == 0)
            {
                epUserAccount.Clear();

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.Add("@rawdata", SqlDbType.VarBinary).Value = rawdata;
                        cmd.Connection = new SqlConnection(ConString);
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        epUserAccount.Clear();
                        MessageBox.Show("Data Created");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Operation due to \n" + ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    tbUsername.Text = "";
                    tbPass1.Text = "";
                    tbPass2.Text = "";
                    tbUsername.Text = "";
                    cbCategory.SelectedIndex = -1;
                    rbActivate.Checked = false;
                    rbDeactivate.Checked = false;
                }



            }
        }

        private int ValidateMedicalOfficer()
        {
            int flag = 0;


            if ((tbOficerName.Text == "") || (tbOficerName.Text == "")
                || (tbOfficerAddress.Text == "") || (tbComment.Text == ""))
            {
                tbOficerName.Focus();
                epUserAccount.SetError(tbOficerName, "Medical Information Missing");
                flag = 1;

            }
            return flag;
        }

        private void cbDisabilityType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
                    }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvViewProfile_SelectionChanged(object sender, EventArgs e)
        {
            /*
              int userId;
                string password1, passsword2, username, category;
                string status = "";
                string disability, lassraId, surname, firstname, othername, residence, email, phonenumber, DOB;
                string gender = "";
                string kinSurname, kinFirstname, KinOthername, kinPhone, kinResidence, kinRelation;
                int typeId, durationId, onsetId, visualId, hearingId, causeId, severityId, partsId;
                string  psychoDisability, neuroDisability;
                string officerName, officernumber, officerAddress, officerComment;
             
             */
            
            DataGridView dgv = (DataGridView)sender;
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    //if (profileId == null) profileId = -1;
                    profileId = (int)dgv.SelectedRows[0].Cells[0].Value;
                    tbProfileSurname.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                    tbProfileFirstname.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
                    tbProfileotherName.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();

                    if (dgv.SelectedRows[0].Cells[7].Value.ToString() == "male")
                        rbProfileMale.Checked = true;
                    else rbProfileFemale.Checked = true;
                    dtpProfileDOB.Value = Convert.ToDateTime(dgv.SelectedRows[0].Cells[6].Value);
                    tbProfileAddress.Text = dgv.SelectedRows[0].Cells[8].Value.ToString();
                    tbProfileEmail.Text = dgv.SelectedRows[0].Cells[9].Value.ToString();
                    tbProfilePhone.Text = dgv.SelectedRows[0].Cells[10].Value.ToString();

                    cbProfileType.SelectedValue = (int)dgv.SelectedRows[0].Cells[11].Value;
                    cbProfileCause.SelectedValue = (int)dgv.SelectedRows[0].Cells[12].Value;
                    cbProfileSeverity.SelectedValue = (int)dgv.SelectedRows[0].Cells[13].Value;
                    cbProfileDuration.SelectedValue = (int)dgv.SelectedRows[0].Cells[14].Value;
                    cbProfileVisual.SelectedValue = (int)dgv.SelectedRows[0].Cells[18].Value;
                    cbProfileHearing.SelectedValue = (int)dgv.SelectedRows[0].Cells[19].Value;
                    cbProfileOnset.SelectedValue = (int)dgv.SelectedRows[0].Cells[20].Value;
                    cbProfilePart.SelectedValue = (int)dgv.SelectedRows[0].Cells[17].Value; 
                    cbProfileNeuro.SelectedIndex = cbProfileNeuro.FindStringExact(dgv.SelectedRows[0].Cells[15].Value.ToString());
                    cbProfilePsycho.SelectedIndex = cbProfilePsycho.FindStringExact(dgv.SelectedRows[0].Cells[16].Value.ToString()); 
                       

                    tbProfileKinSurname.Text = dgv.SelectedRows[0].Cells[21].Value.ToString();
                    tbProfileKinFirst.Text = dgv.SelectedRows[0].Cells[22].Value.ToString();
                    tbProfileKinOther.Text = dgv.SelectedRows[0].Cells[23].Value.ToString();
                    tbProfileKinPhone.Text = dgv.SelectedRows[0].Cells[24].Value.ToString();
                    tbProfileKinAddress.Text = dgv.SelectedRows[0].Cells[25].Value.ToString();

                    cbProfileKinRelationship.SelectedIndex = cbProfileKinRelationship.FindStringExact(dgv.SelectedRows[0].Cells[26].Value.ToString()); 
                    tbProfileMedicalName.Text = dgv.SelectedRows[0].Cells[27].Value.ToString();
                    tbProfileMedicalNum.Text = dgv.SelectedRows[0].Cells[28].Value.ToString();
                    tbProfileMedicalAddress.Text = dgv.SelectedRows[0].Cells[29].Value.ToString();



                    //int profileId = int.Parse(dataprofileId);
                    
                    //string clubMemberId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    //memberId = int.Parse(clubMemberId);
                    //biographicDetailBindingSource
                    
                    /*
                    DataRow dataRow = dgvViewProfile.Rows[0];

                    txt2Name.Text = dataRow["Name"].ToString();
                    dt2DateOfBirth.Value = Convert.ToDateTime(dataRow["DateOfBirth"]);
                    cmb2Occupation.SelectedItem = (Occupation)dataRow["Occupation"];
                    cmb2MaritalStatus.SelectedItem = (MaritalStatus)dataRow["MaritalStatus"];
                    cmb2HealthStatus.SelectedItem = (HealthStatus)dataRow["HealthStatus"];
                    txt2Salary.Text = dataRow["Salary"].ToString() == "0.0000" ? string.Empty : dataRow["Salary"].ToString();
                    txt2NoOfChildren.Text = dataRow["NumberOfChildren"].ToString();
                    */ 
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void dgvViewProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbProfileAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNeuro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbProfileotherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = "delete from BiographicDetail where (biodataId ='" + profileId + ")";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = new SqlConnection(ConString);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    epUserAccount.Clear();
                    MessageBox.Show("Data Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed Operation due to \n" + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malefemale;
            //DateTime.Today.ToString("MM/dd/yyyy")
            if (rbProfileMale.Checked == true)
                malefemale = "male";
            else malefemale = "female";


            string query = "Update BiographicDetail " +
            " Set [surname] = '" + tbProfileSurname.Text + "', [firstname] = '" + tbProfileSurname.Text + "', [othername] = '" + tbProfileotherName.Text + "' , [birthday] = '" + dtpProfileDOB.Value.ToString("MM/dd/yyyy") +
            "' ,[gender] = '" + malefemale + "', [homeAddress] = '" + tbProfileAddress.Text + "', [email] = '" + tbProfileEmail.Text + "', [contactPhone] = '" + tbProfilePhone.Text + "', [disabilityTypeId] = '" + cbProfileType.SelectedValue +
            "',[disabilityCauseId] = '" + cbProfileCause.SelectedValue + "', [disabilitySeverityId] = '" + cbProfileSeverity.SelectedValue + "', [impairmentDurationId] = '" + cbProfileDuration.SelectedValue + "', [neuroDisability] = '" + cbProfileNeuro.SelectedItem.ToString() + "', [psychiatricDisability] = '" + cbProfilePsycho.SelectedItem.ToString() + "'," +
            " [affectedBodyPartId] = '" + cbProfilePart.SelectedValue + "', [visualImpairmentId] = '" + cbProfileVisual.SelectedValue + "', [hearingImpairmentId] = '" + cbProfileHearing.SelectedValue + "', [onsetId] = '" + cbProfileOnset.SelectedValue + "', [surnameKin] = '" + tbProfileKinSurname.Text + "'," +
            " [firstnameKin] = '" + tbProfileKinFirst.Text + "', [othernameKin] = '" + tbProfileKinOther.Text + "', [phoneKin] = '" + tbProfileKinPhone.Text + "', [addressKin] = '" + tbProfileKinAddress.Text + "', [relationshipKin] = '" + cbProfileKinRelationship.SelectedItem.ToString() + "'," +
            " [namesMedical] = '" + tbProfileMedicalName.Text + "', [membershipNumberMedical] = '" + tbProfileMedicalNum.Text + "', [addressMedical] = '" + tbProfileMedicalAddress.Text + "', [dateLastModified] = '" + DateTime.Today.ToString("MM/dd/yyyy") +
            "' Where ([biodataId] = '" + profileId + "')";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = new SqlConnection(ConString);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    epUserAccount.Clear();
                    MessageBox.Show("Data Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed Operation due to \n" + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dgvViewProfile.SelectAll();
            DataObject dataObj = dgvViewProfile.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);    


        }

        private void fssefvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryReportbyUser summaryReportbyUser = new SummaryReportbyUser();
            //summaryReportbyUser.MdiParent = this;
            summaryReportbyUser.Show();
        }

        private void fgdvfdbgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDetailReport bdr = new BasicDetailReport();
            //bdr.MdiParent = this;
            bdr.Show();
        }

        private void miDetailReportbyDisabilityType_Click(object sender, EventArgs e)
        {
            DetailedReportbyDisabilityType bdrbdt = new DetailedReportbyDisabilityType();
            //bdrbdt.MdiParent = this;
            bdrbdt.Show();
        }

        private void miDetailReportByUser_Click(object sender, EventArgs e)
        {
            DetailedReportbyUser drbu = new DetailedReportbyUser();
            //drbu.MdiParent = this;
            drbu.Show();
        }

        private void miDetailReportbyAgeBracket_Click(object sender, EventArgs e)
        {
            DetailedReportbyAgeBracket drbab = new DetailedReportbyAgeBracket();
            //drbab.MdiParent = this;
            drbab.Show();
        }

        private void miDetailReportByAgeandgender_Click(object sender, EventArgs e)
        {
            DetailedReportbyAgeandGender drbaag = new DetailedReportbyAgeandGender();
            //drbaag.MdiParent = this;
            drbaag.Show();
        }

        private void miDetailReportByGenderandDisability_Click(object sender, EventArgs e)
        {
            DetailedReportbyGenderandDisabilityType drbgad = new DetailedReportbyGenderandDisabilityType();
            //drbgad.MdiParent = this;
            drbgad.Show();
        }

        private void miDetailReportbyDisabilityCauseandType_Click(object sender, EventArgs e)
        {
            DetailedReportbyDisabilitycauseandDisabilityType drbdcadt = new DetailedReportbyDisabilitycauseandDisabilityType();
            //drbdcadt.MdiParent = this;
            drbdcadt.Show();
        }

        private void miDetailReportByDisabilityTypeandSeverity_Click(object sender, EventArgs e)
        {
            DetailedReportbyDisabilityTypeandSeverity drbdtas = new DetailedReportbyDisabilityTypeandSeverity();
            //drbdtas.MdiParent = this;
            drbdtas.Show();
        }

        private void miBasicDetailReportByDate_Click(object sender, EventArgs e)
        {
            BasicDetailedReportbyDate bdrbd = new BasicDetailedReportbyDate();
            //bdrbd.MdiParent = this;
            bdrbd.Show();
        }

        private void miBasicDetailReportbyCurrentUser_Click(object sender, EventArgs e)
        {
            BasicDetailedReportbyCurrentLoggedinUser bdrbcliu = new BasicDetailedReportbyCurrentLoggedinUser();
            //bdrbcliu.MdiParent = this;
            bdrbcliu.Show();
        }

        private void msReports_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            tbLasodaApp.SelectTab(tabPage2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbLasodaApp.SelectTab(tabPage3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbLasodaApp.SelectTab(tabPage4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tbLasodaApp.SelectTab(tpReports);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbLasodaApp.SelectTab(tabPage3);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tbLasodaApp.SelectTab(tabPage4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tbLasodaApp.SelectTab(tabPage2);
        }
       

    }

    
}


