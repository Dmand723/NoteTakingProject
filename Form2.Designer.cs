namespace NoteTakingProject
{
    partial class Form2
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
            goBack = new Button();
            titleTxt = new TextBox();
            msgTxt = new TextBox();
            SuspendLayout();
            // 
            // goBack
            // 
            goBack.AutoSize = true;
            goBack.Location = new Point(0, 0);
            goBack.Name = "goBack";
            goBack.Size = new Size(94, 30);
            goBack.TabIndex = 0;
            goBack.Text = "Go back";
            goBack.UseVisualStyleBackColor = true;
            goBack.Click += goBack_Click;
            // 
            // titleTxt
            // 
            titleTxt.Location = new Point(100, 53);
            titleTxt.Name = "titleTxt";
            titleTxt.ReadOnly = true;
            titleTxt.Size = new Size(236, 27);
            titleTxt.TabIndex = 1;
            // 
            // msgTxt
            // 
            msgTxt.Location = new Point(100, 109);
            msgTxt.Multiline = true;
            msgTxt.Name = "msgTxt";
            msgTxt.ReadOnly = true;
            msgTxt.Size = new Size(236, 168);
            msgTxt.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 329);
            Controls.Add(msgTxt);
            Controls.Add(titleTxt);
            Controls.Add(goBack);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBack;
        private TextBox titleTxt;
        private TextBox msgTxt;
    }
}