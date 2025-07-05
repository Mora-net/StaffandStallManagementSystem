namespace StaffandStallManagementSystem
{
    partial class FormStall
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStall));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            errorProvider1 = new ErrorProvider(components);
            txtmessage = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            btnclose = new Button();
            updatebtn = new Button();
            btnnew = new Button();
            btnlogout = new Button();
            btnsave = new Button();
            label10 = new Label();
            txtno = new TextBox();
            label2 = new Label();
            textsearch = new TextBox();
            label1 = new Label();
            txtname = new TextBox();
            label5 = new Label();
            cbid = new ComboBox();
            cbst = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // txtmessage
            // 
            txtmessage.AutoSize = true;
            txtmessage.BackColor = SystemColors.ButtonHighlight;
            txtmessage.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmessage.ForeColor = SystemColors.ActiveCaptionText;
            txtmessage.Location = new Point(466, 606);
            txtmessage.Name = "txtmessage";
            txtmessage.Size = new Size(0, 39);
            txtmessage.TabIndex = 60;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(149, 539);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(767, 188);
            dataGridView1.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(156, 394);
            label4.Name = "label4";
            label4.Size = new Size(68, 26);
            label4.TabIndex = 56;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(156, 323);
            label3.Name = "label3";
            label3.Size = new Size(159, 26);
            label3.TabIndex = 55;
            label3.Text = "StallType Name";
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(804, 747);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 54;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(255, 255, 128);
            updatebtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(305, 747);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(128, 47);
            updatebtn.TabIndex = 53;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 255, 255);
            btnnew.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(481, 747);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(128, 47);
            btnnew.TabIndex = 52;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.LightCoral;
            btnlogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(644, 747);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(128, 47);
            btnlogout.TabIndex = 51;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 255, 128);
            btnsave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(149, 747);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(128, 47);
            btnsave.TabIndex = 50;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(466, 116);
            label10.Name = "label10";
            label10.Size = new Size(236, 34);
            label10.TabIndex = 49;
            label10.Text = "Staff's Information";
            // 
            // txtno
            // 
            txtno.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtno.Location = new Point(343, 202);
            txtno.Name = "txtno";
            txtno.ReadOnly = true;
            txtno.Size = new Size(261, 34);
            txtno.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(156, 205);
            label2.Name = "label2";
            label2.Size = new Size(87, 26);
            label2.TabIndex = 47;
            label2.Text = "Stall No";
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textsearch.Location = new Point(149, 488);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(272, 34);
            textsearch.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(149, 450);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 45;
            label1.Text = "Search";
            // 
            // txtname
            // 
            txtname.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(343, 320);
            txtname.Name = "txtname";
            txtname.ReadOnly = true;
            txtname.Size = new Size(261, 34);
            txtname.TabIndex = 62;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(156, 257);
            label5.Name = "label5";
            label5.Size = new Size(129, 26);
            label5.TabIndex = 61;
            label5.Text = "StallType ID";
            // 
            // cbid
            // 
            cbid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbid.FormattingEnabled = true;
            cbid.Location = new Point(343, 257);
            cbid.Name = "cbid";
            cbid.Size = new Size(261, 34);
            cbid.TabIndex = 63;
            // 
            // cbst
            // 
            cbst.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbst.FormattingEnabled = true;
            cbst.Items.AddRange(new object[] { "Rented", "Inactive" });
            cbst.Location = new Point(343, 394);
            cbst.Name = "cbst";
            cbst.Size = new Size(261, 34);
            cbst.TabIndex = 64;
            // 
            // FormStall
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(cbst);
            Controls.Add(cbid);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(txtmessage);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(updatebtn);
            Controls.Add(btnnew);
            Controls.Add(btnlogout);
            Controls.Add(btnsave);
            Controls.Add(label10);
            Controls.Add(txtno);
            Controls.Add(label2);
            Controls.Add(textsearch);
            Controls.Add(label1);
            Name = "FormStall";
            Size = new Size(1080, 911);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ComboBox cbst;
        private ComboBox cbid;
        private TextBox txtname;
        private Label label5;
        private Label txtmessage;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Button btnclose;
        private Button updatebtn;
        private Button btnnew;
        private Button btnlogout;
        private Button btnsave;
        private Label label10;
        private TextBox txtno;
        private Label label2;
        private TextBox textsearch;
        private Label label1;
    }
}
