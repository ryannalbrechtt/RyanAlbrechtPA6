namespace PA6
{
    partial class frmMAIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.txtAuthorData = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtGenreData = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtLengthData = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtIsbnData = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtCopiesData = new System.Windows.Forms.TextBox();
            this.lblCopiesAvailable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(312, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(307, 51);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(223, 29);
            this.txtTitleData.TabIndex = 3;
            // 
            // txtAuthorData
            // 
            this.txtAuthorData.Location = new System.Drawing.Point(307, 160);
            this.txtAuthorData.Name = "txtAuthorData";
            this.txtAuthorData.Size = new System.Drawing.Size(223, 29);
            this.txtAuthorData.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(312, 109);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 24);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // txtGenreData
            // 
            this.txtGenreData.Location = new System.Drawing.Point(307, 279);
            this.txtGenreData.Name = "txtGenreData";
            this.txtGenreData.Size = new System.Drawing.Size(223, 29);
            this.txtGenreData.TabIndex = 7;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(312, 228);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(63, 24);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            this.lblGenre.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLengthData
            // 
            this.txtLengthData.Location = new System.Drawing.Point(307, 636);
            this.txtLengthData.Name = "txtLengthData";
            this.txtLengthData.Size = new System.Drawing.Size(223, 29);
            this.txtLengthData.TabIndex = 14;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(312, 585);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 24);
            this.lblLength.TabIndex = 13;
            this.lblLength.Text = "Length";
            // 
            // txtIsbnData
            // 
            this.txtIsbnData.Location = new System.Drawing.Point(307, 509);
            this.txtIsbnData.Name = "txtIsbnData";
            this.txtIsbnData.Size = new System.Drawing.Size(223, 29);
            this.txtIsbnData.TabIndex = 12;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(312, 458);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(52, 24);
            this.lblIsbn.TabIndex = 11;
            this.lblIsbn.Text = "ISBN";
            // 
            // txtCopiesData
            // 
            this.txtCopiesData.Location = new System.Drawing.Point(307, 388);
            this.txtCopiesData.Name = "txtCopiesData";
            this.txtCopiesData.Size = new System.Drawing.Size(223, 29);
            this.txtCopiesData.TabIndex = 10;
            // 
            // lblCopiesAvailable
            // 
            this.lblCopiesAvailable.AutoSize = true;
            this.lblCopiesAvailable.Location = new System.Drawing.Point(312, 337);
            this.lblCopiesAvailable.Name = "lblCopiesAvailable";
            this.lblCopiesAvailable.Size = new System.Drawing.Size(111, 24);
            this.lblCopiesAvailable.TabIndex = 9;
            this.lblCopiesAvailable.Text = "Copies Avlb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 8;
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 24;
            this.lstBooks.Location = new System.Drawing.Point(12, 51);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(277, 508);
            this.lstBooks.TabIndex = 15;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(579, 83);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(322, 402);
            this.pbCover.TabIndex = 16;
            this.pbCover.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(563, 543);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(171, 61);
            this.btnRent.TabIndex = 17;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(758, 543);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 61);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(243, 712);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(205, 84);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(465, 712);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(209, 84);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(692, 712);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 84);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(921, 712);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(209, 84);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.txtLengthData);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtIsbnData);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtCopiesData);
            this.Controls.Add(this.lblCopiesAvailable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGenreData);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAuthorData);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitleData);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMAIN";
            this.Text = "Audio Book Rental System";
            this.Load += new System.EventHandler(this.frmMAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.TextBox txtAuthorData;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtGenreData;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtLengthData;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtIsbnData;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtCopiesData;
        private System.Windows.Forms.Label lblCopiesAvailable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}