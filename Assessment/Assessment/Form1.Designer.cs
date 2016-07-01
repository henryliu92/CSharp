namespace Assessment
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTitle2 = new System.Windows.Forms.TextBox();
            this.textBoxAuthor2 = new System.Windows.Forms.TextBox();
            this.textBoxISBN2 = new System.Windows.Forms.TextBox();
            this.textBoxPrice2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(76, 357);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 41);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(307, 357);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(101, 41);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "View Books";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(518, 357);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 41);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete Book";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(37, 81);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(69, 20);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Book Title";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(37, 137);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(83, 20);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Book Author";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(37, 189);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(75, 20);
            this.labelISBN.TabIndex = 5;
            this.labelISBN.Text = "Book ISBN";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(37, 242);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(76, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Book Price";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(131, 81);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(131, 137);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(131, 191);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxISBN.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(131, 244);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 10;
            // 
            // textBoxTitle2
            // 
            this.textBoxTitle2.Location = new System.Drawing.Point(370, 81);
            this.textBoxTitle2.Name = "textBoxTitle2";
            this.textBoxTitle2.Size = new System.Drawing.Size(183, 20);
            this.textBoxTitle2.TabIndex = 11;
            // 
            // textBoxAuthor2
            // 
            this.textBoxAuthor2.Location = new System.Drawing.Point(370, 139);
            this.textBoxAuthor2.Name = "textBoxAuthor2";
            this.textBoxAuthor2.Size = new System.Drawing.Size(183, 20);
            this.textBoxAuthor2.TabIndex = 12;
            // 
            // textBoxISBN2
            // 
            this.textBoxISBN2.Location = new System.Drawing.Point(370, 189);
            this.textBoxISBN2.Name = "textBoxISBN2";
            this.textBoxISBN2.Size = new System.Drawing.Size(183, 20);
            this.textBoxISBN2.TabIndex = 13;
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.Location = new System.Drawing.Point(370, 244);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(183, 20);
            this.textBoxPrice2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 429);
            this.Controls.Add(this.textBoxPrice2);
            this.Controls.Add(this.textBoxISBN2);
            this.Controls.Add(this.textBoxAuthor2);
            this.Controls.Add(this.textBoxTitle2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxLBooks;
        private System.Windows.Forms.TextBox textBoxTitle2;
        private System.Windows.Forms.TextBox textBoxAuthor2;
        private System.Windows.Forms.TextBox textBoxISBN2;
        private System.Windows.Forms.TextBox textBoxPrice2;
    }
}

