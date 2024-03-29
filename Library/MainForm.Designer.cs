
namespace Library
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.checkBookButton = new System.Windows.Forms.Button();
            this.removeABookButton = new System.Windows.Forms.Button();
            this.addABookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(314, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(165, 72);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.returnBookButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnBookButton.Location = new System.Drawing.Point(314, 276);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(165, 72);
            this.returnBookButton.TabIndex = 1;
            this.returnBookButton.Text = "Return book";
            this.returnBookButton.UseVisualStyleBackColor = false;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // checkBookButton
            // 
            this.checkBookButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBookButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBookButton.Location = new System.Drawing.Point(314, 198);
            this.checkBookButton.Name = "checkBookButton";
            this.checkBookButton.Size = new System.Drawing.Size(165, 72);
            this.checkBookButton.TabIndex = 2;
            this.checkBookButton.Text = "Check book";
            this.checkBookButton.UseVisualStyleBackColor = false;
            this.checkBookButton.Click += new System.EventHandler(this.checkBookButton_Click);
            // 
            // removeABookButton
            // 
            this.removeABookButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removeABookButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeABookButton.Location = new System.Drawing.Point(314, 120);
            this.removeABookButton.Name = "removeABookButton";
            this.removeABookButton.Size = new System.Drawing.Size(165, 72);
            this.removeABookButton.TabIndex = 3;
            this.removeABookButton.Text = "Remove a book";
            this.removeABookButton.UseVisualStyleBackColor = false;
            this.removeABookButton.Click += new System.EventHandler(this.removeABookButton_Click);
            // 
            // addABookButton
            // 
            this.addABookButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addABookButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addABookButton.Location = new System.Drawing.Point(314, 42);
            this.addABookButton.Name = "addABookButton";
            this.addABookButton.Size = new System.Drawing.Size(165, 72);
            this.addABookButton.TabIndex = 4;
            this.addABookButton.Text = "Add a button";
            this.addABookButton.UseVisualStyleBackColor = false;
            this.addABookButton.Click += new System.EventHandler(this.addABookButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addABookButton);
            this.Controls.Add(this.removeABookButton);
            this.Controls.Add(this.checkBookButton);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Button checkBookButton;
        private System.Windows.Forms.Button removeABookButton;
        private System.Windows.Forms.Button addABookButton;
    }
}

