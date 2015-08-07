namespace Medley.UI.Views
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReception
            // 
            this.btnReception.Location = new System.Drawing.Point(144, 135);
            this.btnReception.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(100, 28);
            this.btnReception.TabIndex = 0;
            this.btnReception.Text = "Reception";
            this.btnReception.UseVisualStyleBackColor = true;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(252, 135);
            this.btnStore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(100, 28);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "Stroe";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnReception);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeWindows";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button button1;
    }
}