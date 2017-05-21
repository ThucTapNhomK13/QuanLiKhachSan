namespace GUI
{
    partial class Form_HoaDon
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
            this.txtBillId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.txtPayments = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPay = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtIdStaff = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtStatus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBillId
            // 
            // 
            // 
            // 
            this.txtBillId.CustomButton.Image = null;
            this.txtBillId.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtBillId.CustomButton.Name = "";
            this.txtBillId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBillId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillId.CustomButton.TabIndex = 1;
            this.txtBillId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillId.CustomButton.UseSelectable = true;
            this.txtBillId.CustomButton.Visible = false;
            this.txtBillId.Lines = new string[0];
            this.txtBillId.Location = new System.Drawing.Point(173, 92);
            this.txtBillId.MaxLength = 32767;
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.PasswordChar = '\0';
            this.txtBillId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillId.SelectedText = "";
            this.txtBillId.SelectionLength = 0;
            this.txtBillId.SelectionStart = 0;
            this.txtBillId.ShortcutsEnabled = true;
            this.txtBillId.Size = new System.Drawing.Size(154, 23);
            this.txtBillId.TabIndex = 0;
            this.txtBillId.UseSelectable = true;
            this.txtBillId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Mã hóa đơn";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(669, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Bill";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(54, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(544, 135);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 29);
            this.dtpDate.TabIndex = 4;
            // 
            // txtPayments
            // 
            // 
            // 
            // 
            this.txtPayments.CustomButton.Image = null;
            this.txtPayments.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtPayments.CustomButton.Name = "";
            this.txtPayments.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPayments.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayments.CustomButton.TabIndex = 1;
            this.txtPayments.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayments.CustomButton.UseSelectable = true;
            this.txtPayments.CustomButton.Visible = false;
            this.txtPayments.Lines = new string[0];
            this.txtPayments.Location = new System.Drawing.Point(173, 141);
            this.txtPayments.MaxLength = 32767;
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.PasswordChar = '\0';
            this.txtPayments.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayments.SelectedText = "";
            this.txtPayments.SelectionLength = 0;
            this.txtPayments.SelectionStart = 0;
            this.txtPayments.ShortcutsEnabled = true;
            this.txtPayments.Size = new System.Drawing.Size(154, 23);
            this.txtPayments.TabIndex = 1;
            this.txtPayments.UseSelectable = true;
            this.txtPayments.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayments.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Só tiền trả trước";
            // 
            // txtPay
            // 
            // 
            // 
            // 
            this.txtPay.CustomButton.Image = null;
            this.txtPay.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtPay.CustomButton.Name = "";
            this.txtPay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPay.CustomButton.TabIndex = 1;
            this.txtPay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPay.CustomButton.UseSelectable = true;
            this.txtPay.CustomButton.Visible = false;
            this.txtPay.Lines = new string[0];
            this.txtPay.Location = new System.Drawing.Point(173, 187);
            this.txtPay.MaxLength = 32767;
            this.txtPay.Name = "txtPay";
            this.txtPay.PasswordChar = '\0';
            this.txtPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPay.SelectedText = "";
            this.txtPay.SelectionLength = 0;
            this.txtPay.SelectionStart = 0;
            this.txtPay.ShortcutsEnabled = true;
            this.txtPay.Size = new System.Drawing.Size(154, 23);
            this.txtPay.TabIndex = 2;
            this.txtPay.UseSelectable = true;
            this.txtPay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(54, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Số tiền trả sau";
            // 
            // txtIdStaff
            // 
            // 
            // 
            // 
            this.txtIdStaff.CustomButton.Image = null;
            this.txtIdStaff.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtIdStaff.CustomButton.Name = "";
            this.txtIdStaff.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdStaff.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdStaff.CustomButton.TabIndex = 1;
            this.txtIdStaff.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdStaff.CustomButton.UseSelectable = true;
            this.txtIdStaff.CustomButton.Visible = false;
            this.txtIdStaff.Lines = new string[0];
            this.txtIdStaff.Location = new System.Drawing.Point(544, 92);
            this.txtIdStaff.MaxLength = 32767;
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.PasswordChar = '\0';
            this.txtIdStaff.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdStaff.SelectedText = "";
            this.txtIdStaff.SelectionLength = 0;
            this.txtIdStaff.SelectionStart = 0;
            this.txtIdStaff.ShortcutsEnabled = true;
            this.txtIdStaff.Size = new System.Drawing.Size(200, 23);
            this.txtIdStaff.TabIndex = 3;
            this.txtIdStaff.UseSelectable = true;
            this.txtIdStaff.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdStaff.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(425, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Mã nhân viên";
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.CustomButton.Image = null;
            this.txtStatus.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtStatus.CustomButton.Name = "";
            this.txtStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus.CustomButton.TabIndex = 1;
            this.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus.CustomButton.UseSelectable = true;
            this.txtStatus.CustomButton.Visible = false;
            this.txtStatus.Lines = new string[0];
            this.txtStatus.Location = new System.Drawing.Point(544, 187);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.ShortcutsEnabled = true;
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.UseSelectable = true;
            this.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(428, 191);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Trạng thái";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(428, 145);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Ngày trả";
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdStaff);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtPayments);
            this.Controls.Add(this.txtBillId);
            this.Name = "Form_HoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Form_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBillId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroTextBox txtPayments;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPay;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtIdStaff;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}