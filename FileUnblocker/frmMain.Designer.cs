namespace FileUnblocker
{
    partial class frmMain
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
            btnDirectory = new Button();
            grpDropArea = new GroupBox();
            label2 = new Label();
            grpDropArea.SuspendLayout();
            SuspendLayout();
            // 
            // btnDirectory
            // 
            btnDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDirectory.Location = new Point(12, 9);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new Size(269, 25);
            btnDirectory.TabIndex = 2;
            btnDirectory.Text = "Select Directory and Unblock Files";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // grpDropArea
            // 
            grpDropArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDropArea.Controls.Add(label2);
            grpDropArea.Location = new Point(12, 37);
            grpDropArea.Name = "grpDropArea";
            grpDropArea.Size = new Size(268, 78);
            grpDropArea.TabIndex = 3;
            grpDropArea.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(8, 17);
            label2.Name = "label2";
            label2.Size = new Size(252, 52);
            label2.TabIndex = 0;
            label2.Text = "Please select directory or drop files or directories in this area to unblock files!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 127);
            Controls.Add(grpDropArea);
            Controls.Add(btnDirectory);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileUnblocker";
            DragDrop += frmMain_DragDrop;
            DragEnter += frmMain_DragEnter;
            grpDropArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDirectory;
        private GroupBox grpDropArea;
        private Label label2;
    }
}