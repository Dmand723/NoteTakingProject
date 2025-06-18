namespace NoteTakingProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titleLbl = new Label();
            messageLbl = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            newBtn = new Button();
            saveBtn = new Button();
            readBtn = new Button();
            deleteBtn = new Button();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Location = new Point(35, 42);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(38, 20);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Title";
            // 
            // messageLbl
            // 
            messageLbl.AutoSize = true;
            messageLbl.Location = new Point(23, 88);
            messageLbl.Name = "messageLbl";
            messageLbl.Size = new Size(67, 20);
            messageLbl.TabIndex = 1;
            messageLbl.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(92, 42);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(92, 85);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(125, 126);
            txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(192, 188);
            dataGridView1.TabIndex = 4;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(27, 269);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(94, 29);
            newBtn.TabIndex = 5;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(151, 269);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // readBtn
            // 
            readBtn.Location = new Point(290, 269);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(94, 29);
            readBtn.TabIndex = 7;
            readBtn.Text = "Read";
            toolTip1.SetToolTip(readBtn, "This will open a new page");
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(436, 269);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Info";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 365);
            Controls.Add(deleteBtn);
            Controls.Add(readBtn);
            Controls.Add(saveBtn);
            Controls.Add(newBtn);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Controls.Add(messageLbl);
            Controls.Add(titleLbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label messageLbl;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView dataGridView1;
        private Button newBtn;
        private Button saveBtn;
        private Button readBtn;
        private Button deleteBtn;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1;
    }
}
