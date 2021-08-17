
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
            this.components = new System.ComponentModel.Container();
            this.Top_Border = new System.Windows.Forms.Panel();
            this.Bottom_Border = new System.Windows.Forms.Panel();
            this.Left_Border = new System.Windows.Forms.Panel();
            this.Right_Border = new System.Windows.Forms.Panel();
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.FirstDigit_PictureBox = new System.Windows.Forms.PictureBox();
            this.SecondDigit_PictureBox = new System.Windows.Forms.PictureBox();
            this.Container_Panel = new System.Windows.Forms.Panel();
            this.StartGame_Button = new System.Windows.Forms.Button();
            this.IDontKnowAnswer_Button = new System.Windows.Forms.Button();
            this.SubmitAnswer_Button = new System.Windows.Forms.Button();
            this.TurkishWord_TextBox = new System.Windows.Forms.TextBox();
            this.EnglishWord_TextBox = new System.Windows.Forms.TextBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Header_PictureBox = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Mid_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstDigit_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDigit_PictureBox)).BeginInit();
            this.Container_Panel.SuspendLayout();
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
            this.Bottom_Border.Location = new System.Drawing.Point(2, 297);
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
            this.Left_Border.Size = new System.Drawing.Size(2, 297);
            this.Left_Border.TabIndex = 2;
            // 
            // Right_Border
            // 
            this.Right_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Right_Border.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Border.Location = new System.Drawing.Point(798, 2);
            this.Right_Border.Name = "Right_Border";
            this.Right_Border.Size = new System.Drawing.Size(2, 297);
            this.Right_Border.TabIndex = 2;
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Mid_Panel.Controls.Add(this.FirstDigit_PictureBox);
            this.Mid_Panel.Controls.Add(this.SecondDigit_PictureBox);
            this.Mid_Panel.Controls.Add(this.Container_Panel);
            this.Mid_Panel.Controls.Add(this.Exit_Button);
            this.Mid_Panel.Controls.Add(this.Header_PictureBox);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(2, 2);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(796, 295);
            this.Mid_Panel.TabIndex = 3;
            // 
            // FirstDigit_PictureBox
            // 
            this.FirstDigit_PictureBox.Image = global::WordTown.Properties.Resources._0;
            this.FirstDigit_PictureBox.Location = new System.Drawing.Point(60, 15);
            this.FirstDigit_PictureBox.Name = "FirstDigit_PictureBox";
            this.FirstDigit_PictureBox.Size = new System.Drawing.Size(50, 60);
            this.FirstDigit_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FirstDigit_PictureBox.TabIndex = 3;
            this.FirstDigit_PictureBox.TabStop = false;
            // 
            // SecondDigit_PictureBox
            // 
            this.SecondDigit_PictureBox.Image = global::WordTown.Properties.Resources._9;
            this.SecondDigit_PictureBox.Location = new System.Drawing.Point(10, 15);
            this.SecondDigit_PictureBox.Name = "SecondDigit_PictureBox";
            this.SecondDigit_PictureBox.Size = new System.Drawing.Size(50, 60);
            this.SecondDigit_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SecondDigit_PictureBox.TabIndex = 1;
            this.SecondDigit_PictureBox.TabStop = false;
            // 
            // Container_Panel
            // 
            this.Container_Panel.Controls.Add(this.StartGame_Button);
            this.Container_Panel.Controls.Add(this.IDontKnowAnswer_Button);
            this.Container_Panel.Controls.Add(this.SubmitAnswer_Button);
            this.Container_Panel.Controls.Add(this.TurkishWord_TextBox);
            this.Container_Panel.Controls.Add(this.EnglishWord_TextBox);
            this.Container_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Panel.Location = new System.Drawing.Point(0, 90);
            this.Container_Panel.Name = "Container_Panel";
            this.Container_Panel.Size = new System.Drawing.Size(796, 205);
            this.Container_Panel.TabIndex = 2;
            // 
            // StartGame_Button
            // 
            this.StartGame_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.StartGame_Button.FlatAppearance.BorderSize = 0;
            this.StartGame_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartGame_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.StartGame_Button.Image = global::WordTown.Properties.Resources.WordTown_StartIcon;
            this.StartGame_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartGame_Button.Location = new System.Drawing.Point(33, 142);
            this.StartGame_Button.Name = "StartGame_Button";
            this.StartGame_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.StartGame_Button.Size = new System.Drawing.Size(730, 34);
            this.StartGame_Button.TabIndex = 4;
            this.StartGame_Button.Text = "Start The Game";
            this.StartGame_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartGame_Button.UseVisualStyleBackColor = false;
            this.StartGame_Button.Click += new System.EventHandler(this.StartGame_Button_Click);
            // 
            // IDontKnowAnswer_Button
            // 
            this.IDontKnowAnswer_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.IDontKnowAnswer_Button.FlatAppearance.BorderSize = 0;
            this.IDontKnowAnswer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDontKnowAnswer_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDontKnowAnswer_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.IDontKnowAnswer_Button.Image = global::WordTown.Properties.Resources.WordTown_IDontKnowIcon;
            this.IDontKnowAnswer_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IDontKnowAnswer_Button.Location = new System.Drawing.Point(403, 142);
            this.IDontKnowAnswer_Button.Name = "IDontKnowAnswer_Button";
            this.IDontKnowAnswer_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.IDontKnowAnswer_Button.Size = new System.Drawing.Size(360, 34);
            this.IDontKnowAnswer_Button.TabIndex = 3;
            this.IDontKnowAnswer_Button.Text = "I Don\'t Know The Answer";
            this.IDontKnowAnswer_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IDontKnowAnswer_Button.UseVisualStyleBackColor = false;
            this.IDontKnowAnswer_Button.Click += new System.EventHandler(this.IDontKnowAnswer_Button_Click);
            // 
            // SubmitAnswer_Button
            // 
            this.SubmitAnswer_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.SubmitAnswer_Button.FlatAppearance.BorderSize = 0;
            this.SubmitAnswer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitAnswer_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SubmitAnswer_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.SubmitAnswer_Button.Image = global::WordTown.Properties.Resources.WordTown_SubmitAnswerIcon;
            this.SubmitAnswer_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SubmitAnswer_Button.Location = new System.Drawing.Point(33, 142);
            this.SubmitAnswer_Button.Name = "SubmitAnswer_Button";
            this.SubmitAnswer_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.SubmitAnswer_Button.Size = new System.Drawing.Size(360, 34);
            this.SubmitAnswer_Button.TabIndex = 2;
            this.SubmitAnswer_Button.Text = "Submit Answer";
            this.SubmitAnswer_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitAnswer_Button.UseVisualStyleBackColor = false;
            this.SubmitAnswer_Button.Click += new System.EventHandler(this.SubmitAnswer_Button_Click);
            // 
            // TurkishWord_TextBox
            // 
            this.TurkishWord_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.TurkishWord_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TurkishWord_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.TurkishWord_TextBox.Location = new System.Drawing.Point(33, 85);
            this.TurkishWord_TextBox.Name = "TurkishWord_TextBox";
            this.TurkishWord_TextBox.Size = new System.Drawing.Size(730, 27);
            this.TurkishWord_TextBox.TabIndex = 1;
            this.TurkishWord_TextBox.Text = "  Turkish Word:";
            this.TurkishWord_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TurkishWord_TextBox_MouseClick);
            // 
            // EnglishWord_TextBox
            // 
            this.EnglishWord_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.EnglishWord_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnglishWord_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.EnglishWord_TextBox.Location = new System.Drawing.Point(33, 28);
            this.EnglishWord_TextBox.Name = "EnglishWord_TextBox";
            this.EnglishWord_TextBox.Size = new System.Drawing.Size(730, 27);
            this.EnglishWord_TextBox.TabIndex = 0;
            this.EnglishWord_TextBox.Text = "  English Word:";
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
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // WordTown_MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 299);
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
            this.Load += new System.EventHandler(this.WordTown_MainMenu_Load);
            this.Mid_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstDigit_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDigit_PictureBox)).EndInit();
            this.Container_Panel.ResumeLayout(false);
            this.Container_Panel.PerformLayout();
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
        private System.Windows.Forms.Panel Container_Panel;
        private System.Windows.Forms.PictureBox SecondDigit_PictureBox;
        private System.Windows.Forms.TextBox EnglishWord_TextBox;
        private System.Windows.Forms.PictureBox FirstDigit_PictureBox;
        private System.Windows.Forms.Button IDontKnowAnswer_Button;
        private System.Windows.Forms.Button SubmitAnswer_Button;
        private System.Windows.Forms.TextBox TurkishWord_TextBox;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button StartGame_Button;
    }
}

