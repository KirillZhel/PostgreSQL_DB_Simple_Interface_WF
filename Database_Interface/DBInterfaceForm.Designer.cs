
namespace Database_Interface
{
    partial class DBInterfaceForm
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
            this.authorizationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ShowTableButton = new System.Windows.Forms.Button();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.showDeletedButton = new System.Windows.Forms.Button();
            this.deleteIdTextBox = new System.Windows.Forms.TextBox();
            this.tableListComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.selectPage = new System.Windows.Forms.TabPage();
            this.insertPage = new System.Windows.Forms.TabPage();
            this.insertTypeComboBox = new System.Windows.Forms.ComboBox();
            this.insertLabel5 = new System.Windows.Forms.Label();
            this.insertLabel4 = new System.Windows.Forms.Label();
            this.insertTextBox4 = new System.Windows.Forms.TextBox();
            this.insertLabel3 = new System.Windows.Forms.Label();
            this.insertTextBox3 = new System.Windows.Forms.TextBox();
            this.insertLabel2 = new System.Windows.Forms.Label();
            this.insertTextBox2 = new System.Windows.Forms.TextBox();
            this.insertLabel1 = new System.Windows.Forms.Label();
            this.insertTextBox1 = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.showUpdatededButton = new System.Windows.Forms.Button();
            this.updateLabel6 = new System.Windows.Forms.Label();
            this.updateTextBox6 = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.selectPage.SuspendLayout();
            this.insertPage.SuspendLayout();
            this.updatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.deletePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationButton
            // 
            this.authorizationButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorizationButton.Location = new System.Drawing.Point(469, 50);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(190, 45);
            this.authorizationButton.TabIndex = 3;
            this.authorizationButton.Text = "авторизация";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTextBox.Location = new System.Drawing.Point(12, 50);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(249, 45);
            this.userNameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(267, 50);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(196, 45);
            this.passwordTextBox.TabIndex = 7;
            // 
            // ShowTableButton
            // 
            this.ShowTableButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowTableButton.Location = new System.Drawing.Point(12, 8);
            this.ShowTableButton.Name = "ShowTableButton";
            this.ShowTableButton.Size = new System.Drawing.Size(260, 45);
            this.ShowTableButton.TabIndex = 4;
            this.ShowTableButton.Text = "показать таблицу";
            this.ShowTableButton.UseVisualStyleBackColor = true;
            this.ShowTableButton.Click += new System.EventHandler(this.ShowTableButton_Click);
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AllowUserToAddRows = false;
            this.dataGridViewSelect.AllowUserToDeleteRows = false;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 59);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.ReadOnly = true;
            this.dataGridViewSelect.RowHeadersWidth = 62;
            this.dataGridViewSelect.RowTemplate.Height = 33;
            this.dataGridViewSelect.Size = new System.Drawing.Size(964, 329);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // showDeletedButton
            // 
            this.showDeletedButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showDeletedButton.Location = new System.Drawing.Point(163, 50);
            this.showDeletedButton.Name = "showDeletedButton";
            this.showDeletedButton.Size = new System.Drawing.Size(250, 45);
            this.showDeletedButton.TabIndex = 2;
            this.showDeletedButton.Text = "показать строку";
            this.showDeletedButton.UseVisualStyleBackColor = true;
            this.showDeletedButton.Click += new System.EventHandler(this.showDeletedButton_Click);
            // 
            // deleteIdTextBox
            // 
            this.deleteIdTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteIdTextBox.Location = new System.Drawing.Point(7, 50);
            this.deleteIdTextBox.Name = "deleteIdTextBox";
            this.deleteIdTextBox.Size = new System.Drawing.Size(150, 45);
            this.deleteIdTextBox.TabIndex = 1;
            // 
            // tableListComboBox
            // 
            this.tableListComboBox.Enabled = false;
            this.tableListComboBox.FormattingEnabled = true;
            this.tableListComboBox.Location = new System.Drawing.Point(7, 155);
            this.tableListComboBox.Name = "tableListComboBox";
            this.tableListComboBox.Size = new System.Drawing.Size(218, 33);
            this.tableListComboBox.TabIndex = 12;
            this.tableListComboBox.SelectedIndexChanged += new System.EventHandler(this.tableListComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "Выбор таблицы";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.selectPage);
            this.tabControl1.Controls.Add(this.insertPage);
            this.tabControl1.Controls.Add(this.updatePage);
            this.tabControl1.Controls.Add(this.deletePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 215);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 429);
            this.tabControl1.TabIndex = 14;
            // 
            // selectPage
            // 
            this.selectPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectPage.Controls.Add(this.dataGridViewSelect);
            this.selectPage.Controls.Add(this.ShowTableButton);
            this.selectPage.Location = new System.Drawing.Point(4, 34);
            this.selectPage.Name = "selectPage";
            this.selectPage.Padding = new System.Windows.Forms.Padding(3);
            this.selectPage.Size = new System.Drawing.Size(970, 391);
            this.selectPage.TabIndex = 0;
            this.selectPage.Text = "ВЫБОРКА";
            // 
            // insertPage
            // 
            this.insertPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.insertPage.Controls.Add(this.insertTypeComboBox);
            this.insertPage.Controls.Add(this.insertLabel5);
            this.insertPage.Controls.Add(this.insertLabel4);
            this.insertPage.Controls.Add(this.insertTextBox4);
            this.insertPage.Controls.Add(this.insertLabel3);
            this.insertPage.Controls.Add(this.insertTextBox3);
            this.insertPage.Controls.Add(this.insertLabel2);
            this.insertPage.Controls.Add(this.insertTextBox2);
            this.insertPage.Controls.Add(this.insertLabel1);
            this.insertPage.Controls.Add(this.insertTextBox1);
            this.insertPage.Controls.Add(this.InsertButton);
            this.insertPage.Location = new System.Drawing.Point(4, 34);
            this.insertPage.Name = "insertPage";
            this.insertPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertPage.Size = new System.Drawing.Size(970, 391);
            this.insertPage.TabIndex = 1;
            this.insertPage.Text = "ВСТАВКА";
            // 
            // insertTypeComboBox
            // 
            this.insertTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertTypeComboBox.FormattingEnabled = true;
            this.insertTypeComboBox.Items.AddRange(new object[] {
            "S",
            "P"});
            this.insertTypeComboBox.Location = new System.Drawing.Point(333, 144);
            this.insertTypeComboBox.Name = "insertTypeComboBox";
            this.insertTypeComboBox.Size = new System.Drawing.Size(150, 46);
            this.insertTypeComboBox.TabIndex = 11;
            this.insertTypeComboBox.Visible = false;
            // 
            // insertLabel5
            // 
            this.insertLabel5.AutoSize = true;
            this.insertLabel5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertLabel5.Location = new System.Drawing.Point(333, 103);
            this.insertLabel5.Name = "insertLabel5";
            this.insertLabel5.Size = new System.Drawing.Size(60, 38);
            this.insertLabel5.TabIndex = 10;
            this.insertLabel5.Text = "тип";
            this.insertLabel5.Visible = false;
            // 
            // insertLabel4
            // 
            this.insertLabel4.AutoSize = true;
            this.insertLabel4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertLabel4.Location = new System.Drawing.Point(177, 103);
            this.insertLabel4.Name = "insertLabel4";
            this.insertLabel4.Size = new System.Drawing.Size(104, 38);
            this.insertLabel4.TabIndex = 8;
            this.insertLabel4.Text = "группа";
            this.insertLabel4.Visible = false;
            // 
            // insertTextBox4
            // 
            this.insertTextBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertTextBox4.Location = new System.Drawing.Point(177, 144);
            this.insertTextBox4.Name = "insertTextBox4";
            this.insertTextBox4.Size = new System.Drawing.Size(150, 45);
            this.insertTextBox4.TabIndex = 7;
            this.insertTextBox4.Visible = false;
            // 
            // insertLabel3
            // 
            this.insertLabel3.AutoSize = true;
            this.insertLabel3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertLabel3.Location = new System.Drawing.Point(489, 14);
            this.insertLabel3.Name = "insertLabel3";
            this.insertLabel3.Size = new System.Drawing.Size(130, 38);
            this.insertLabel3.TabIndex = 6;
            this.insertLabel3.Text = "отчество";
            this.insertLabel3.Visible = false;
            // 
            // insertTextBox3
            // 
            this.insertTextBox3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertTextBox3.Location = new System.Drawing.Point(489, 55);
            this.insertTextBox3.Name = "insertTextBox3";
            this.insertTextBox3.Size = new System.Drawing.Size(150, 45);
            this.insertTextBox3.TabIndex = 5;
            this.insertTextBox3.Visible = false;
            // 
            // insertLabel2
            // 
            this.insertLabel2.AutoSize = true;
            this.insertLabel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertLabel2.Location = new System.Drawing.Point(333, 14);
            this.insertLabel2.Name = "insertLabel2";
            this.insertLabel2.Size = new System.Drawing.Size(67, 38);
            this.insertLabel2.TabIndex = 4;
            this.insertLabel2.Text = "имя";
            this.insertLabel2.Visible = false;
            // 
            // insertTextBox2
            // 
            this.insertTextBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertTextBox2.Location = new System.Drawing.Point(333, 55);
            this.insertTextBox2.Name = "insertTextBox2";
            this.insertTextBox2.Size = new System.Drawing.Size(150, 45);
            this.insertTextBox2.TabIndex = 3;
            this.insertTextBox2.Visible = false;
            // 
            // insertLabel1
            // 
            this.insertLabel1.AutoSize = true;
            this.insertLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertLabel1.Location = new System.Drawing.Point(175, 14);
            this.insertLabel1.Name = "insertLabel1";
            this.insertLabel1.Size = new System.Drawing.Size(131, 38);
            this.insertLabel1.TabIndex = 2;
            this.insertLabel1.Text = "фамилия";
            this.insertLabel1.Visible = false;
            // 
            // insertTextBox1
            // 
            this.insertTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertTextBox1.Location = new System.Drawing.Point(177, 55);
            this.insertTextBox1.Name = "insertTextBox1";
            this.insertTextBox1.Size = new System.Drawing.Size(150, 45);
            this.insertTextBox1.TabIndex = 1;
            this.insertTextBox1.Visible = false;
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertButton.Location = new System.Drawing.Point(6, 55);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(165, 45);
            this.InsertButton.TabIndex = 0;
            this.InsertButton.Text = "вставка";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // updatePage
            // 
            this.updatePage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updatePage.Controls.Add(this.dataGridViewUpdate);
            this.updatePage.Controls.Add(this.showUpdatededButton);
            this.updatePage.Controls.Add(this.updateLabel6);
            this.updatePage.Controls.Add(this.updateTextBox6);
            this.updatePage.Controls.Add(this.updateButton);
            this.updatePage.Location = new System.Drawing.Point(4, 34);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(970, 391);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "ОБНОВЛЕНИЕ";
            // 
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUpdate.Location = new System.Drawing.Point(0, 116);
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.RowHeadersWidth = 62;
            this.dataGridViewUpdate.RowTemplate.Height = 33;
            this.dataGridViewUpdate.Size = new System.Drawing.Size(970, 275);
            this.dataGridViewUpdate.TabIndex = 26;
            this.dataGridViewUpdate.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdate_CellValueChanged);
            // 
            // showUpdatededButton
            // 
            this.showUpdatededButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showUpdatededButton.Location = new System.Drawing.Point(163, 50);
            this.showUpdatededButton.Name = "showUpdatededButton";
            this.showUpdatededButton.Size = new System.Drawing.Size(250, 45);
            this.showUpdatededButton.TabIndex = 25;
            this.showUpdatededButton.Text = "показать строку";
            this.showUpdatededButton.UseVisualStyleBackColor = true;
            this.showUpdatededButton.Click += new System.EventHandler(this.showUpdatededButton_Click);
            // 
            // updateLabel6
            // 
            this.updateLabel6.AutoSize = true;
            this.updateLabel6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateLabel6.Location = new System.Drawing.Point(8, 9);
            this.updateLabel6.Name = "updateLabel6";
            this.updateLabel6.Size = new System.Drawing.Size(44, 38);
            this.updateLabel6.TabIndex = 24;
            this.updateLabel6.Text = "ID";
            // 
            // updateTextBox6
            // 
            this.updateTextBox6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateTextBox6.Location = new System.Drawing.Point(7, 50);
            this.updateTextBox6.Name = "updateTextBox6";
            this.updateTextBox6.Size = new System.Drawing.Size(150, 45);
            this.updateTextBox6.TabIndex = 23;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(420, 50);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(205, 45);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "обновление";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deletePage
            // 
            this.deletePage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deletePage.Controls.Add(this.label4);
            this.deletePage.Controls.Add(this.deleteButton);
            this.deletePage.Controls.Add(this.dataGridViewDelete);
            this.deletePage.Controls.Add(this.deleteIdTextBox);
            this.deletePage.Controls.Add(this.showDeletedButton);
            this.deletePage.Location = new System.Drawing.Point(4, 34);
            this.deletePage.Name = "deletePage";
            this.deletePage.Size = new System.Drawing.Size(970, 391);
            this.deletePage.TabIndex = 3;
            this.deletePage.Text = "УДАЛЕНИЕ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 38);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID";
            this.label4.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(420, 50);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 45);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDelete.Location = new System.Drawing.Point(0, 116);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.RowHeadersWidth = 62;
            this.dataGridViewDelete.RowTemplate.Height = 33;
            this.dataGridViewDelete.Size = new System.Drawing.Size(970, 275);
            this.dataGridViewDelete.TabIndex = 3;
            // 
            // DBInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableListComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorizationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DBInterfaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBInterfaceForm";
            this.Load += new System.EventHandler(this.DBInterfaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.selectPage.ResumeLayout(false);
            this.insertPage.ResumeLayout(false);
            this.insertPage.PerformLayout();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.ComboBox tableListComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowTableButton;
        private System.Windows.Forms.Button showDeletedButton;
        private System.Windows.Forms.TextBox deleteIdTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage selectPage;
        private System.Windows.Forms.TabPage insertPage;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.Label insertLabel5;
        private System.Windows.Forms.Label insertLabel4;
        private System.Windows.Forms.TextBox insertTextBox4;
        private System.Windows.Forms.Label insertLabel3;
        private System.Windows.Forms.TextBox insertTextBox3;
        private System.Windows.Forms.Label insertLabel2;
        private System.Windows.Forms.TextBox insertTextBox2;
        private System.Windows.Forms.Label insertLabel1;
        private System.Windows.Forms.TextBox insertTextBox1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ComboBox insertTypeComboBox;
        private System.Windows.Forms.Label updateLabel6;
        private System.Windows.Forms.TextBox updateTextBox6;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button showUpdatededButton;
        private System.Windows.Forms.DataGridView dataGridViewUpdate;
        private System.Windows.Forms.Label label4;
    }
}