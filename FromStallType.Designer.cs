namespace StaffandStallManagementSystem
{
    partial class FromStallType
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromStallType));
            btnclose = new Button();
            updatebtn = new Button();
            btnnew = new Button();
            btnlogout = new Button();
            btnsave = new Button();
            label10 = new Label();
            txtid = new TextBox();
            label2 = new Label();
            textsearch = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtprice = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            txtname = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            txtmessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(710, 693);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 37;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(255, 255, 128);
            updatebtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(211, 693);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(128, 47);
            updatebtn.TabIndex = 36;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 255, 255);
            btnnew.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(387, 693);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(128, 47);
            btnnew.TabIndex = 35;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.LightCoral;
            btnlogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(550, 693);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(128, 47);
            btnlogout.TabIndex = 34;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 255, 128);
            btnsave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(55, 693);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(128, 47);
            btnsave.TabIndex = 33;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(372, 62);
            label10.Name = "label10";
            label10.Size = new Size(236, 34);
            label10.TabIndex = 32;
            label10.Text = "Staff's Information";
            // 
            // txtid
            // 
            txtid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.Location = new Point(249, 148);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(261, 34);
            txtid.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(62, 151);
            label2.Name = "label2";
            label2.Size = new Size(129, 26);
            label2.TabIndex = 30;
            label2.Text = "StallType ID";
            label2.Click += label2_Click;
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textsearch.Location = new Point(55, 434);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(272, 34);
            textsearch.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(55, 396);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 27;
            label1.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(62, 249);
            label3.Name = "label3";
            label3.Size = new Size(159, 26);
            label3.TabIndex = 38;
            label3.Text = "StallType Name";
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Location = new Point(249, 332);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(261, 34);
            txtprice.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(62, 340);
            label4.Name = "label4";
            label4.Size = new Size(104, 26);
            label4.TabIndex = 40;
            label4.Text = "Unit Price";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 485);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(767, 188);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtname
            // 
            txtname.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(249, 249);
            txtname.Name = "txtname";
            txtname.Size = new Size(261, 34);
            txtname.TabIndex = 43;
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
            txtmessage.Location = new Point(372, 552);
            txtmessage.Name = "txtmessage";
            txtmessage.Size = new Size(0, 39);
            txtmessage.TabIndex = 44;
            // 
            // FromStallType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtmessage);
            Controls.Add(txtname);
            Controls.Add(dataGridView1);
            Controls.Add(txtprice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(updatebtn);
            Controls.Add(btnnew);
            Controls.Add(btnlogout);
            Controls.Add(btnsave);
            Controls.Add(label10);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(textsearch);
            Controls.Add(label1);
            Name = "FromStallType";
            Size = new Size(1080, 911);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnclose;
        private Button updatebtn;
        private Button btnnew;
        private Button btnlogout;
        private Button btnsave;
        private Label label10;
        private TextBox txtid;
        private Label label2;
        private TextBox textsearch;
        private Label label1;
        private Label label3;
        private TextBox txtprice;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtname;
        private ErrorProvider errorProvider1;
        private Label txtmessage;
    }
}
