namespace Medley.Core.Views
{
    partial class HomeWindow
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
            this.btnReception = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReception
            // 
            this.btnReception.Location = new System.Drawing.Point(108, 110);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(75, 23);
            this.btnReception.TabIndex = 0;
            this.btnReception.Text = "Reception";
            this.btnReception.UseVisualStyleBackColor = true;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(189, 110);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "Stroe";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 262);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnReception);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWindows";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnStore;
    }
}