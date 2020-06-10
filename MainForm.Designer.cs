namespace SimplePasswordGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkedListBoxPassword = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.numericUpDownPassword = new System.Windows.Forms.NumericUpDown();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxPassword
            // 
            this.checkedListBoxPassword.CheckOnClick = true;
            this.checkedListBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxPassword.FormattingEnabled = true;
            this.checkedListBoxPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: % * ) ? # $ ^ & ~"});
            this.checkedListBoxPassword.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxPassword.Name = "checkedListBoxPassword";
            this.checkedListBoxPassword.Size = new System.Drawing.Size(315, 72);
            this.checkedListBoxPassword.TabIndex = 0;
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreatePassword.Location = new System.Drawing.Point(12, 150);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(315, 28);
            this.btnCreatePassword.TabIndex = 1;
            this.btnCreatePassword.Text = "Создать пароль";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.CreatePassword);
            // 
            // lblPwd
            // 
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPwd.Location = new System.Drawing.Point(12, 109);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(236, 19);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Длина пароля (макс. 30 символов) :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(12, 200);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(315, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownPassword
            // 
            this.numericUpDownPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPassword.Location = new System.Drawing.Point(254, 108);
            this.numericUpDownPassword.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownPassword.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPassword.Name = "numericUpDownPassword";
            this.numericUpDownPassword.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownPassword.TabIndex = 4;
            this.numericUpDownPassword.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(26, 225);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(279, 23);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "* Пароль автоматически копируется в буфер обмена";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.numericUpDownPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.btnCreatePassword);
            this.Controls.Add(this.checkedListBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCreatePassword;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.NumericUpDown numericUpDownPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblInfo;
    }
}

