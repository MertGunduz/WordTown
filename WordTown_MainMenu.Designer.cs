
namespace WordTown
{
    partial class WordTown_MainMenu
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
            this.Top_Border = new System.Windows.Forms.Panel();
            this.Bottom_Border = new System.Windows.Forms.Panel();
            this.Left_Border = new System.Windows.Forms.Panel();
            this.Right_Border = new System.Windows.Forms.Panel();
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Header_PictureBox = new System.Windows.Forms.PictureBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Mid_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Header_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Border
            // 
            this.Top_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Top_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Border.Location = new System.Drawing.Point(0, 0);
            this.Top_Border.Name = "Top_Border";
            this.Top_Border.Size = new System.Drawing.Size(800, 2);
            this.Top_Border.TabIndex = 1;
            // 
            // Bottom_Border
            // 
            this.Bottom_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Bottom_Border.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Border.Location = new System.Drawing.Point(2, 324);
            this.Bottom_Border.Name = "Bottom_Border";
            this.Bottom_Border.Size = new System.Drawing.Size(796, 2);
            this.Bottom_Border.TabIndex = 2;
            // 
            // Left_Border
            // 
            this.Left_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Left_Border.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Border.Location = new System.Drawing.Point(0, 2);
            this.Left_Border.Name = "Left_Border";
            this.Left_Border.Size = new System.Drawing.Size(2, 324);
            this.Left_Border.TabIndex = 2;
            // 
            // Right_Border
            // 
            this.Right_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Right_Border.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Border.Location = new System.Drawing.Point(798, 2);
            this.Right_Border.Name = "Right_Border";
            this.Right_Border.Size = new System.Drawing.Size(2, 324);
            this.Right_Border.TabIndex = 2;
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Mid_Panel.Controls.Add(this.Exit_Button);
            this.Mid_Panel.Controls.Add(this.Header_PictureBox);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(2, 2);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(796, 322);
            this.Mid_Panel.TabIndex = 3;
            // 
            // Header_PictureBox
            // 
            this.Header_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_PictureBox.Image = global::WordTown.Properties.Resources.WordTown_Header;
            this.Header_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Header_PictureBox.Name = "Header_PictureBox";
            this.Header_PictureBox.Size = new System.Drawing.Size(796, 90);
            this.Header_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Header_PictureBox.TabIndex = 0;
            this.Header_PictureBox.TabStop = false;
            // 
            // Exit_Button
            // 
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Image = global::WordTown.Properties.Resources.WordTown_NonHoveredExitIcon;
            this.Exit_Button.Location = new System.Drawing.Point(744, 2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(50, 50);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            this.Exit_Button.MouseEnter += new System.EventHandler(this.Exit_Button_MouseEnter);
            this.Exit_Button.MouseLeave += new System.EventHandler(this.Exit_Button_MouseLeave);
            // 
            // WordTown_MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.Mid_Panel);
            this.Controls.Add(this.Bottom_Border);
            this.Controls.Add(this.Left_Border);
            this.Controls.Add(this.Right_Border);
            this.Controls.Add(this.Top_Border);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordTown_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordTown";
            this.Mid_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Header_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_Border;
        private System.Windows.Forms.Panel Bottom_Border;
        private System.Windows.Forms.Panel Left_Border;
        private System.Windows.Forms.Panel Right_Border;
        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.PictureBox Header_PictureBox;
        private System.Windows.Forms.Button Exit_Button;
    }
}

