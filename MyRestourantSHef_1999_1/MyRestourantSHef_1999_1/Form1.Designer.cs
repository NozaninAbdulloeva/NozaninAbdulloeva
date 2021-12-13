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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "M e n u";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(109, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Egg";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Chicken";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(90, 91);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(57, 25);
            this.QuantityTextBox.TabIndex = 2;
            // 
            // SubmitNewRequestButton
            // 
            this.SubmitNewRequestButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitNewRequestButton.Location = new System.Drawing.Point(153, 90);
            this.SubmitNewRequestButton.Name = "SubmitNewRequestButton";
            this.SubmitNewRequestButton.Size = new System.Drawing.Size(172, 32);
            this.SubmitNewRequestButton.TabIndex = 3;
            this.SubmitNewRequestButton.Text = "Submit new request";
            this.SubmitNewRequestButton.UseVisualStyleBackColor = true;
            this.SubmitNewRequestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(25, 130);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(305, 29);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "C o p y   t h e   p r e v i o u s    r e q u e s t";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // inspactionLabel
            // 
            this.inspactionLabel.AutoSize = true;
            this.inspactionLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspactionLabel.Location = new System.Drawing.Point(27, 170);
            this.inspactionLabel.Name = "inspactionLabel";
            this.inspactionLabel.Size = new System.Drawing.Size(0, 18);
            this.inspactionLabel.TabIndex = 5;
            // 
            // PrepareFoodButton
            // 
            this.PrepareFoodButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrepareFoodButton.Location = new System.Drawing.Point(23, 196);
            this.PrepareFoodButton.Name = "PrepareFoodButton";
            this.PrepareFoodButton.Size = new System.Drawing.Size(305, 31);
            this.PrepareFoodButton.TabIndex = 6;
            this.PrepareFoodButton.Text = "P r e p a r e    F o o d  ";
            this.PrepareFoodButton.UseVisualStyleBackColor = true;
            this.PrepareFoodButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 230);
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
            this.ResultList.Location = new System.Drawing.Point(26, 251);
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
            this.Controls.Add(this.SubmitNewRequestButton);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "M";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button SubmitNewRequestButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label inspactionLabel;
        private System.Windows.Forms.Button PrepareFoodButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ResultList;
    }
}

