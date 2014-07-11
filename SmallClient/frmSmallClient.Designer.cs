namespace SmallClient
{
    partial class frmSmallClient
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
            this.txtClientLive = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClientLive
            // 
            this.txtClientLive.Location = new System.Drawing.Point(13, 13);
            this.txtClientLive.Multiline = true;
            this.txtClientLive.Name = "txtClientLive";
            this.txtClientLive.ReadOnly = true;
            this.txtClientLive.Size = new System.Drawing.Size(259, 83);
            this.txtClientLive.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 137);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(259, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "Enter command:";
            // 
            // frmSmallClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtClientLive);
            this.Name = "frmSmallClient";
            this.Text = "SmallClient";
            this.Load += new System.EventHandler(this.frmSmallClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientLive;
        private System.Windows.Forms.TextBox txtInput;
    }
}

