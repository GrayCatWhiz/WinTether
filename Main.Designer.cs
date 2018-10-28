namespace WinTether
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.HotspotNameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Controller = new MaterialSkin.Controls.MaterialRaisedButton();
            this.WindowDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Passwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(439, 26);
            this.TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "WinTether v1.4 by Maki ";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(409, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 26);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 0;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HotspotNameField
            // 
            this.HotspotNameField.Depth = 0;
            this.HotspotNameField.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotspotNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.HotspotNameField.Hint = "ENTER SSID NAME";
            this.HotspotNameField.Location = new System.Drawing.Point(76, 93);
            this.HotspotNameField.MaxLength = 32767;
            this.HotspotNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.HotspotNameField.Name = "HotspotNameField";
            this.HotspotNameField.PasswordChar = '\0';
            this.HotspotNameField.SelectedText = "";
            this.HotspotNameField.SelectionLength = 0;
            this.HotspotNameField.SelectionStart = 0;
            this.HotspotNameField.Size = new System.Drawing.Size(290, 23);
            this.HotspotNameField.TabIndex = 3;
            this.HotspotNameField.TabStop = false;
            this.HotspotNameField.UseSystemPasswordChar = false;
            // 
            // Controller
            // 
            this.Controller.AutoSize = true;
            this.Controller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Controller.Depth = 0;
            this.Controller.Icon = null;
            this.Controller.Location = new System.Drawing.Point(144, 238);
            this.Controller.MouseState = MaterialSkin.MouseState.HOVER;
            this.Controller.Name = "Controller";
            this.Controller.Primary = true;
            this.Controller.Size = new System.Drawing.Size(141, 36);
            this.Controller.TabIndex = 5;
            this.Controller.Text = "START TETHERING";
            this.Controller.UseVisualStyleBackColor = true;
            this.Controller.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // WindowDrag
            // 
            this.WindowDrag.Fixed = true;
            this.WindowDrag.Horizontal = true;
            this.WindowDrag.TargetControl = this.TopPanel;
            this.WindowDrag.Vertical = true;
            // 
            // Passwd
            // 
            this.Passwd.Depth = 0;
            this.Passwd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Passwd.Hint = "Enter Hotspot Password";
            this.Passwd.Location = new System.Drawing.Point(76, 182);
            this.Passwd.MaxLength = 32767;
            this.Passwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.Passwd.Name = "Passwd";
            this.Passwd.PasswordChar = '*';
            this.Passwd.SelectedText = "";
            this.Passwd.SelectionLength = 0;
            this.Passwd.SelectionStart = 0;
            this.Passwd.Size = new System.Drawing.Size(290, 23);
            this.Passwd.TabIndex = 7;
            this.Passwd.TabStop = false;
            this.Passwd.UseSystemPasswordChar = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(168, 61);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "SSID NAME";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(178, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Password";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(439, 302);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.Controller);
            this.Controls.Add(this.HotspotNameField);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinTether v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField HotspotNameField;
        private MaterialSkin.Controls.MaterialRaisedButton Controller;
        private Bunifu.Framework.UI.BunifuDragControl WindowDrag;
        private MaterialSkin.Controls.MaterialSingleLineTextField Passwd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label1;
    }
}

