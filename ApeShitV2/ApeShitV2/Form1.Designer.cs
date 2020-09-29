namespace ApeShitV2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.AttachButton = new System.Windows.Forms.Button();
            this.AttachingLabel = new System.Windows.Forms.Label();
            this.ExecutingBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.TopMostToggle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExecutingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.Gray;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.Location = new System.Drawing.Point(12, 306);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(111, 31);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Gray;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(140, 306);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 31);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.BackColor = System.Drawing.Color.Gray;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Location = new System.Drawing.Point(267, 306);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(114, 31);
            this.SaveFileButton.TabIndex = 3;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.Gray;
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Location = new System.Drawing.Point(401, 306);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(120, 31);
            this.OpenFileButton.TabIndex = 4;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // AttachButton
            // 
            this.AttachButton.BackColor = System.Drawing.Color.Gray;
            this.AttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachButton.Location = new System.Drawing.Point(540, 306);
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(128, 31);
            this.AttachButton.TabIndex = 5;
            this.AttachButton.Text = "Attach";
            this.AttachButton.UseVisualStyleBackColor = false;
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // AttachingLabel
            // 
            this.AttachingLabel.AutoSize = true;
            this.AttachingLabel.BackColor = System.Drawing.Color.Transparent;
            this.AttachingLabel.ForeColor = System.Drawing.Color.Red;
            this.AttachingLabel.Location = new System.Drawing.Point(24, 20);
            this.AttachingLabel.Name = "AttachingLabel";
            this.AttachingLabel.Size = new System.Drawing.Size(37, 13);
            this.AttachingLabel.TabIndex = 6;
            this.AttachingLabel.Text = "Offline";
            // 
            // ExecutingBox
            // 
            this.ExecutingBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ExecutingBox.AutoScrollMinSize = new System.Drawing.Size(195, 14);
            this.ExecutingBox.BackBrush = null;
            this.ExecutingBox.BackColor = System.Drawing.Color.Gray;
            this.ExecutingBox.CharHeight = 14;
            this.ExecutingBox.CharWidth = 8;
            this.ExecutingBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExecutingBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ExecutingBox.FoldingIndicatorColor = System.Drawing.Color.Black;
            this.ExecutingBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ExecutingBox.ForeColor = System.Drawing.Color.White;
            this.ExecutingBox.IndentBackColor = System.Drawing.Color.Silver;
            this.ExecutingBox.IsReplaceMode = false;
            this.ExecutingBox.LineNumberColor = System.Drawing.Color.Black;
            this.ExecutingBox.Location = new System.Drawing.Point(27, 36);
            this.ExecutingBox.Name = "ExecutingBox";
            this.ExecutingBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ExecutingBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ExecutingBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ExecutingBox.ServiceColors")));
            this.ExecutingBox.Size = new System.Drawing.Size(512, 248);
            this.ExecutingBox.TabIndex = 7;
            this.ExecutingBox.Text = "Print(\"Hello World!\")";
            this.ExecutingBox.Zoom = 100;
            // 
            // TopMostToggle
            // 
            this.TopMostToggle.AutoSize = true;
            this.TopMostToggle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TopMostToggle.Location = new System.Drawing.Point(468, 19);
            this.TopMostToggle.Name = "TopMostToggle";
            this.TopMostToggle.Size = new System.Drawing.Size(71, 17);
            this.TopMostToggle.TabIndex = 8;
            this.TopMostToggle.Text = "Top Most";
            this.TopMostToggle.UseVisualStyleBackColor = true;
            this.TopMostToggle.CheckedChanged += new System.EventHandler(this.TopMostToggle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(679, 349);
            this.Controls.Add(this.TopMostToggle);
            this.Controls.Add(this.ExecutingBox);
            this.Controls.Add(this.AttachingLabel);
            this.Controls.Add(this.AttachButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ApeShitV2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExecutingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.Label AttachingLabel;
        private FastColoredTextBoxNS.FastColoredTextBox ExecutingBox;
        private System.Windows.Forms.CheckBox TopMostToggle;
    }
}

