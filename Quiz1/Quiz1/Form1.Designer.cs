namespace Quiz1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxQ1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQ1A3 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ1A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ1A1 = new System.Windows.Forms.RadioButton();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.labelQandA = new System.Windows.Forms.Label();
            this.labelQ1feedback = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxQ2 = new System.Windows.Forms.GroupBox();
            this.radioButtonQ2A1 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ2A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ2A3 = new System.Windows.Forms.RadioButton();
            this.groupBoxQ3 = new System.Windows.Forms.GroupBox();
            this.radioButtonQ3A3 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ3A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ3A1 = new System.Windows.Forms.RadioButton();
            this.labelQ2Feedback = new System.Windows.Forms.Label();
            this.labelQ3Feedback = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxQ1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxQ2.SuspendLayout();
            this.groupBoxQ3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.30753F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.56652F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.12594F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxQ1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRemainingTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelQandA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelQ1feedback, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxQ2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxQ3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelQ2Feedback, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelQ3Feedback, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.259258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.92199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.53901F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxQ1
            // 
            this.groupBoxQ1.Controls.Add(this.radioButtonQ1A3);
            this.groupBoxQ1.Controls.Add(this.radioButtonQ1A2);
            this.groupBoxQ1.Controls.Add(this.radioButtonQ1A1);
            this.groupBoxQ1.Location = new System.Drawing.Point(128, 55);
            this.groupBoxQ1.Name = "groupBoxQ1";
            this.groupBoxQ1.Size = new System.Drawing.Size(290, 98);
            this.groupBoxQ1.TabIndex = 0;
            this.groupBoxQ1.TabStop = false;
            this.groupBoxQ1.Text = "Which language did anders hejlsberg create?";
            // 
            // radioButtonQ1A3
            // 
            this.radioButtonQ1A3.AutoSize = true;
            this.radioButtonQ1A3.Location = new System.Drawing.Point(6, 81);
            this.radioButtonQ1A3.Name = "radioButtonQ1A3";
            this.radioButtonQ1A3.Size = new System.Drawing.Size(73, 17);
            this.radioButtonQ1A3.TabIndex = 2;
            this.radioButtonQ1A3.TabStop = true;
            this.radioButtonQ1A3.Text = "Experanto";
            this.radioButtonQ1A3.UseVisualStyleBackColor = true;
            this.radioButtonQ1A3.CheckedChanged += new System.EventHandler(this.radioButtonQ1A3_CheckedChanged);
            // 
            // radioButtonQ1A2
            // 
            this.radioButtonQ1A2.AutoSize = true;
            this.radioButtonQ1A2.Location = new System.Drawing.Point(7, 59);
            this.radioButtonQ1A2.Name = "radioButtonQ1A2";
            this.radioButtonQ1A2.Size = new System.Drawing.Size(39, 17);
            this.radioButtonQ1A2.TabIndex = 1;
            this.radioButtonQ1A2.TabStop = true;
            this.radioButtonQ1A2.Text = "C#";
            this.radioButtonQ1A2.UseVisualStyleBackColor = true;
            this.radioButtonQ1A2.CheckedChanged += new System.EventHandler(this.radioButtonQ1A2_CheckedChanged);
            // 
            // radioButtonQ1A1
            // 
            this.radioButtonQ1A1.AutoSize = true;
            this.radioButtonQ1A1.Location = new System.Drawing.Point(7, 35);
            this.radioButtonQ1A1.Name = "radioButtonQ1A1";
            this.radioButtonQ1A1.Size = new System.Drawing.Size(61, 17);
            this.radioButtonQ1A1.TabIndex = 0;
            this.radioButtonQ1A1.TabStop = true;
            this.radioButtonQ1A1.Text = "COBOL";
            this.radioButtonQ1A1.UseVisualStyleBackColor = true;
            this.radioButtonQ1A1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelRemainingTime
            // 
            this.labelRemainingTime.AutoSize = true;
            this.labelRemainingTime.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingTime.Location = new System.Drawing.Point(424, 0);
            this.labelRemainingTime.Name = "labelRemainingTime";
            this.labelRemainingTime.Size = new System.Drawing.Size(129, 31);
            this.labelRemainingTime.TabIndex = 3;
            this.labelRemainingTime.Text = "60 Seconds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClose);
            this.groupBox2.Controls.Add(this.buttonstart);
            this.groupBox2.Location = new System.Drawing.Point(128, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(170, 19);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 48);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Exit";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(41, 19);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(93, 48);
            this.buttonstart.TabIndex = 4;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // labelQandA
            // 
            this.labelQandA.AutoSize = true;
            this.labelQandA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQandA.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQandA.Location = new System.Drawing.Point(128, 0);
            this.labelQandA.Name = "labelQandA";
            this.labelQandA.Size = new System.Drawing.Size(290, 52);
            this.labelQandA.TabIndex = 2;
            this.labelQandA.Text = "Questions and Answer Options:";
            // 
            // labelQ1feedback
            // 
            this.labelQ1feedback.AutoSize = true;
            this.labelQ1feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQ1feedback.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelQ1feedback.Location = new System.Drawing.Point(424, 52);
            this.labelQ1feedback.Name = "labelQ1feedback";
            this.labelQ1feedback.Size = new System.Drawing.Size(160, 104);
            this.labelQ1feedback.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxQ2
            // 
            this.groupBoxQ2.Controls.Add(this.radioButtonQ2A3);
            this.groupBoxQ2.Controls.Add(this.radioButtonQ2A2);
            this.groupBoxQ2.Controls.Add(this.radioButtonQ2A1);
            this.groupBoxQ2.Location = new System.Drawing.Point(128, 159);
            this.groupBoxQ2.Name = "groupBoxQ2";
            this.groupBoxQ2.Size = new System.Drawing.Size(290, 98);
            this.groupBoxQ2.TabIndex = 7;
            this.groupBoxQ2.TabStop = false;
            this.groupBoxQ2.Text = "Who were the Developers of Visual Studio Software?";
            // 
            // radioButtonQ2A1
            // 
            this.radioButtonQ2A1.AutoSize = true;
            this.radioButtonQ2A1.Location = new System.Drawing.Point(6, 32);
            this.radioButtonQ2A1.Name = "radioButtonQ2A1";
            this.radioButtonQ2A1.Size = new System.Drawing.Size(68, 17);
            this.radioButtonQ2A1.TabIndex = 0;
            this.radioButtonQ2A1.TabStop = true;
            this.radioButtonQ2A1.Text = "Microsoft";
            this.radioButtonQ2A1.UseVisualStyleBackColor = true;
            this.radioButtonQ2A1.CheckedChanged += new System.EventHandler(this.radioButtonQ2A1_CheckedChanged);
            // 
            // radioButtonQ2A2
            // 
            this.radioButtonQ2A2.AutoSize = true;
            this.radioButtonQ2A2.Location = new System.Drawing.Point(6, 55);
            this.radioButtonQ2A2.Name = "radioButtonQ2A2";
            this.radioButtonQ2A2.Size = new System.Drawing.Size(52, 17);
            this.radioButtonQ2A2.TabIndex = 1;
            this.radioButtonQ2A2.TabStop = true;
            this.radioButtonQ2A2.Text = "Apple";
            this.radioButtonQ2A2.UseVisualStyleBackColor = true;
            this.radioButtonQ2A2.CheckedChanged += new System.EventHandler(this.radioButtonQ2A2_CheckedChanged);
            // 
            // radioButtonQ2A3
            // 
            this.radioButtonQ2A3.AutoSize = true;
            this.radioButtonQ2A3.Location = new System.Drawing.Point(6, 78);
            this.radioButtonQ2A3.Name = "radioButtonQ2A3";
            this.radioButtonQ2A3.Size = new System.Drawing.Size(59, 17);
            this.radioButtonQ2A3.TabIndex = 2;
            this.radioButtonQ2A3.TabStop = true;
            this.radioButtonQ2A3.Text = "Google";
            this.radioButtonQ2A3.UseVisualStyleBackColor = true;
            this.radioButtonQ2A3.CheckedChanged += new System.EventHandler(this.radioButtonQ2A3_CheckedChanged);
            // 
            // groupBoxQ3
            // 
            this.groupBoxQ3.Controls.Add(this.radioButtonQ3A3);
            this.groupBoxQ3.Controls.Add(this.radioButtonQ3A2);
            this.groupBoxQ3.Controls.Add(this.radioButtonQ3A1);
            this.groupBoxQ3.Location = new System.Drawing.Point(128, 263);
            this.groupBoxQ3.Name = "groupBoxQ3";
            this.groupBoxQ3.Size = new System.Drawing.Size(290, 98);
            this.groupBoxQ3.TabIndex = 8;
            this.groupBoxQ3.TabStop = false;
            this.groupBoxQ3.Text = "Which one is true?       1. C# is used in Visual Studio.       2. C++ is used in " +
    "Visual Studio";
            // 
            // radioButtonQ3A3
            // 
            this.radioButtonQ3A3.AutoSize = true;
            this.radioButtonQ3A3.Location = new System.Drawing.Point(6, 78);
            this.radioButtonQ3A3.Name = "radioButtonQ3A3";
            this.radioButtonQ3A3.Size = new System.Drawing.Size(86, 17);
            this.radioButtonQ3A3.TabIndex = 2;
            this.radioButtonQ3A3.TabStop = true;
            this.radioButtonQ3A3.Text = "Both are true";
            this.radioButtonQ3A3.UseVisualStyleBackColor = true;
            this.radioButtonQ3A3.CheckedChanged += new System.EventHandler(this.radioButtonQ3A3_CheckedChanged);
            // 
            // radioButtonQ3A2
            // 
            this.radioButtonQ3A2.AutoSize = true;
            this.radioButtonQ3A2.Location = new System.Drawing.Point(6, 55);
            this.radioButtonQ3A2.Name = "radioButtonQ3A2";
            this.radioButtonQ3A2.Size = new System.Drawing.Size(55, 17);
            this.radioButtonQ3A2.TabIndex = 1;
            this.radioButtonQ3A2.TabStop = true;
            this.radioButtonQ3A2.Text = "2 Only";
            this.radioButtonQ3A2.UseVisualStyleBackColor = true;
            this.radioButtonQ3A2.CheckedChanged += new System.EventHandler(this.radioButtonQ3A2_CheckedChanged);
            // 
            // radioButtonQ3A1
            // 
            this.radioButtonQ3A1.AutoSize = true;
            this.radioButtonQ3A1.Location = new System.Drawing.Point(6, 32);
            this.radioButtonQ3A1.Name = "radioButtonQ3A1";
            this.radioButtonQ3A1.Size = new System.Drawing.Size(55, 17);
            this.radioButtonQ3A1.TabIndex = 0;
            this.radioButtonQ3A1.TabStop = true;
            this.radioButtonQ3A1.Text = "1 Only";
            this.radioButtonQ3A1.UseVisualStyleBackColor = true;
            this.radioButtonQ3A1.CheckedChanged += new System.EventHandler(this.radioButtonQ3A1_CheckedChanged);
            // 
            // labelQ2Feedback
            // 
            this.labelQ2Feedback.AutoSize = true;
            this.labelQ2Feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQ2Feedback.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelQ2Feedback.Location = new System.Drawing.Point(424, 156);
            this.labelQ2Feedback.Name = "labelQ2Feedback";
            this.labelQ2Feedback.Size = new System.Drawing.Size(160, 104);
            this.labelQ2Feedback.TabIndex = 9;
            // 
            // labelQ3Feedback
            // 
            this.labelQ3Feedback.AutoSize = true;
            this.labelQ3Feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQ3Feedback.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelQ3Feedback.Location = new System.Drawing.Point(424, 260);
            this.labelQ3Feedback.Name = "labelQ3Feedback";
            this.labelQ3Feedback.Size = new System.Drawing.Size(160, 104);
            this.labelQ3Feedback.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxQ1.ResumeLayout(false);
            this.groupBoxQ1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxQ2.ResumeLayout(false);
            this.groupBoxQ2.PerformLayout();
            this.groupBoxQ3.ResumeLayout(false);
            this.groupBoxQ3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxQ1;
        private System.Windows.Forms.RadioButton radioButtonQ1A3;
        private System.Windows.Forms.RadioButton radioButtonQ1A2;
        private System.Windows.Forms.RadioButton radioButtonQ1A1;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Label labelQandA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelQ1feedback;
        private System.Windows.Forms.GroupBox groupBoxQ2;
        private System.Windows.Forms.RadioButton radioButtonQ2A3;
        private System.Windows.Forms.RadioButton radioButtonQ2A2;
        private System.Windows.Forms.RadioButton radioButtonQ2A1;
        private System.Windows.Forms.GroupBox groupBoxQ3;
        private System.Windows.Forms.RadioButton radioButtonQ3A3;
        private System.Windows.Forms.RadioButton radioButtonQ3A2;
        private System.Windows.Forms.RadioButton radioButtonQ3A1;
        private System.Windows.Forms.Label labelQ2Feedback;
        private System.Windows.Forms.Label labelQ3Feedback;
    }
}

