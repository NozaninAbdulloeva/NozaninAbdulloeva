namespace MyRestourantSHef_1999_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DrinkComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityEggTextBox = new System.Windows.Forms.TextBox();
            this.QuantityChickenTextBox = new System.Windows.Forms.TextBox();
            this.SubmitNewRequestButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.inspactionLabel = new System.Windows.Forms.Label();
            this.PrepareFoodButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DrinkComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.QuantityEggTextBox);
            this.groupBox1.Controls.Add(this.QuantityChickenTextBox);
            this.groupBox1.Controls.Add(this.SubmitNewRequestButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "M e n u";
            // 
            // DrinkComboBox
            // 
            this.DrinkComboBox.FormattingEnabled = true;
            this.DrinkComboBox.Items.AddRange(new object[] {
            "NoDrink",
            "Tea",
            "Coffee",
            "RC_Cola",
            "PepsiCola"});
            this.DrinkComboBox.Location = new System.Drawing.Point(181, 35);
            this.DrinkComboBox.Name = "DrinkComboBox";
            this.DrinkComboBox.Size = new System.Drawing.Size(109, 26);
            this.DrinkComboBox.TabIndex = 6;
            this.DrinkComboBox.Text = "NoDrink";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "How many egg:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many chicken:";
            // 
            // QuantityEggTextBox
            // 
            this.QuantityEggTextBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityEggTextBox.Location = new System.Drawing.Point(138, 53);
            this.QuantityEggTextBox.Name = "QuantityEggTextBox";
            this.QuantityEggTextBox.Size = new System.Drawing.Size(36, 25);
            this.QuantityEggTextBox.TabIndex = 3;
            this.QuantityEggTextBox.Text = "0";
            // 
            // QuantityChickenTextBox
            // 
            this.QuantityChickenTextBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityChickenTextBox.Location = new System.Drawing.Point(138, 21);
            this.QuantityChickenTextBox.Name = "QuantityChickenTextBox";
            this.QuantityChickenTextBox.Size = new System.Drawing.Size(36, 25);
            this.QuantityChickenTextBox.TabIndex = 2;
            this.QuantityChickenTextBox.Text = "0";
            // 
            // SubmitNewRequestButton
            // 
            this.SubmitNewRequestButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitNewRequestButton.Location = new System.Drawing.Point(9, 81);
            this.SubmitNewRequestButton.Name = "SubmitNewRequestButton";
            this.SubmitNewRequestButton.Size = new System.Drawing.Size(281, 28);
            this.SubmitNewRequestButton.TabIndex = 3;
            this.SubmitNewRequestButton.Text = "Receive this request from a Customer";
            this.SubmitNewRequestButton.UseVisualStyleBackColor = true;
            this.SubmitNewRequestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(48, 157);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(256, 29);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Send all Customer requests to the Cook";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // inspactionLabel
            // 
            this.inspactionLabel.AutoSize = true;
            this.inspactionLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspactionLabel.Location = new System.Drawing.Point(29, 193);
            this.inspactionLabel.Name = "inspactionLabel";
            this.inspactionLabel.Size = new System.Drawing.Size(0, 18);
            this.inspactionLabel.TabIndex = 5;
            // 
            // PrepareFoodButton
            // 
            this.PrepareFoodButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrepareFoodButton.Location = new System.Drawing.Point(29, 218);
            this.PrepareFoodButton.Name = "PrepareFoodButton";
            this.PrepareFoodButton.Size = new System.Drawing.Size(299, 31);
            this.PrepareFoodButton.TabIndex = 6;
            this.PrepareFoodButton.Text = "Serve prepared food to the Customers";
            this.PrepareFoodButton.UseVisualStyleBackColor = true;
            this.PrepareFoodButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Results:";
            // 
            // ResultList
            // 
            this.ResultList.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultList.FormattingEnabled = true;
            this.ResultList.ItemHeight = 18;
            this.ResultList.Location = new System.Drawing.Point(26, 275);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(298, 184);
            this.ResultList.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(349, 454);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrepareFoodButton);
            this.Controls.Add(this.inspactionLabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MyRestourantSHef_1999_2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox QuantityChickenTextBox;
        private System.Windows.Forms.Button SubmitNewRequestButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label inspactionLabel;
        private System.Windows.Forms.Button PrepareFoodButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ResultList;
        private System.Windows.Forms.TextBox QuantityEggTextBox;
        private System.Windows.Forms.ComboBox DrinkComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

