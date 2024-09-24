using System;

namespace SkinPackCreator
{
    partial class Form1
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuNewMcpack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenMcpack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenInstallFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInstall = new System.Windows.Forms.ToolStripMenuItem();
            this.listSkins = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSkinList = new System.Windows.Forms.Label();
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.textBoxPackDescription = new System.Windows.Forms.TextBox();
            this.textBoxPackName = new System.Windows.Forms.TextBox();
            this.labelPackDescription = new System.Windows.Forms.Label();
            this.labelPackName = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelTexture = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTexture = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.buttonBrowseSkin = new System.Windows.Forms.Button();
            this.pictureBoxSkin = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.buttonImportMultiple = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkin)).BeginInit();
            this.statusLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Window;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewMcpack,
            this.menuOpenMcpack,
            this.menuOpenInstallFolder,
            this.menuSave,
            this.menuInstall});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1156, 30);
            this.menuStripMain.TabIndex = 0;
            // 
            // menuNewMcpack
            // 
            this.menuNewMcpack.Name = "menuNewMcpack";
            this.menuNewMcpack.Size = new System.Drawing.Size(113, 26);
            this.menuNewMcpack.Text = "New SkinPack";
            this.menuNewMcpack.Click += new System.EventHandler(this.MenuNewMcpack_Click);
            // 
            // menuOpenMcpack
            // 
            this.menuOpenMcpack.Name = "menuOpenMcpack";
            this.menuOpenMcpack.Size = new System.Drawing.Size(119, 26);
            this.menuOpenMcpack.Text = "Open SkinPack";
            this.menuOpenMcpack.Click += new System.EventHandler(this.MenuOpenMcpack_Click);
            // 
            // menuOpenInstallFolder
            // 
            this.menuOpenInstallFolder.Name = "menuOpenInstallFolder";
            this.menuOpenInstallFolder.Size = new System.Drawing.Size(118, 26);
            this.menuOpenInstallFolder.Text = "Installed Packs";
            this.menuOpenInstallFolder.Click += new System.EventHandler(this.MenuInstalledSkinPacks_Click);
            // 
            // menuSave
            // 
            this.menuSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuSave.ForeColor = System.Drawing.Color.White;
            this.menuSave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuSave.Name = "menuSave";
            this.menuSave.Padding = new System.Windows.Forms.Padding(0);
            this.menuSave.Size = new System.Drawing.Size(45, 26);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // menuInstall
            // 
            this.menuInstall.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuInstall.ForeColor = System.Drawing.Color.White;
            this.menuInstall.Name = "menuInstall";
            this.menuInstall.Padding = new System.Windows.Forms.Padding(0);
            this.menuInstall.Size = new System.Drawing.Size(150, 26);
            this.menuInstall.Text = "Export to Minecraft";
            this.menuInstall.Click += new System.EventHandler(this.MenuInstall_Click);
            // 
            // listSkins
            // 
            this.listSkins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listSkins.FormattingEnabled = true;
            this.listSkins.ItemHeight = 16;
            this.listSkins.Location = new System.Drawing.Point(33, 138);
            this.listSkins.Margin = new System.Windows.Forms.Padding(4);
            this.listSkins.Name = "listSkins";
            this.listSkins.Size = new System.Drawing.Size(235, 388);
            this.listSkins.TabIndex = 100;
            this.listSkins.SelectedIndexChanged += new System.EventHandler(this.ListSkins_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(476, 138);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Skin Name";
            // 
            // labelSkinList
            // 
            this.labelSkinList.AutoSize = true;
            this.labelSkinList.Location = new System.Drawing.Point(33, 116);
            this.labelSkinList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSkinList.Name = "labelSkinList";
            this.labelSkinList.Size = new System.Drawing.Size(63, 16);
            this.labelSkinList.TabIndex = 2;
            this.labelSkinList.Text = "Skins List";
            // 
            // groupSettings
            // 
            this.groupSettings.Controls.Add(this.textBoxPackDescription);
            this.groupSettings.Controls.Add(this.textBoxPackName);
            this.groupSettings.Controls.Add(this.labelPackDescription);
            this.groupSettings.Controls.Add(this.labelPackName);
            this.groupSettings.Location = new System.Drawing.Point(33, 38);
            this.groupSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupSettings.Size = new System.Drawing.Size(844, 62);
            this.groupSettings.TabIndex = 3;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "General Settings";
            // 
            // textBoxPackDescription
            // 
            this.textBoxPackDescription.Location = new System.Drawing.Point(436, 21);
            this.textBoxPackDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPackDescription.Name = "textBoxPackDescription";
            this.textBoxPackDescription.Size = new System.Drawing.Size(384, 22);
            this.textBoxPackDescription.TabIndex = 20;
            // 
            // textBoxPackName
            // 
            this.textBoxPackName.Location = new System.Drawing.Point(97, 21);
            this.textBoxPackName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPackName.Name = "textBoxPackName";
            this.textBoxPackName.Size = new System.Drawing.Size(191, 22);
            this.textBoxPackName.TabIndex = 10;
            // 
            // labelPackDescription
            // 
            this.labelPackDescription.AutoSize = true;
            this.labelPackDescription.Location = new System.Drawing.Point(320, 25);
            this.labelPackDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPackDescription.Name = "labelPackDescription";
            this.labelPackDescription.Size = new System.Drawing.Size(109, 16);
            this.labelPackDescription.TabIndex = 1;
            this.labelPackDescription.Text = "Pack Description";
            // 
            // labelPackName
            // 
            this.labelPackName.AutoSize = true;
            this.labelPackName.Location = new System.Drawing.Point(13, 25);
            this.labelPackName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPackName.Name = "labelPackName";
            this.labelPackName.Size = new System.Drawing.Size(78, 16);
            this.labelPackName.TabIndex = 0;
            this.labelPackName.Text = "Pack Name";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(476, 170);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(49, 16);
            this.labelFormat.TabIndex = 0;
            this.labelFormat.Text = "Format";
            // 
            // labelTexture
            // 
            this.labelTexture.AutoSize = true;
            this.labelTexture.Location = new System.Drawing.Point(476, 202);
            this.labelTexture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTexture.Name = "labelTexture";
            this.labelTexture.Size = new System.Drawing.Size(77, 16);
            this.labelTexture.TabIndex = 0;
            this.labelTexture.Text = "Texture File";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(476, 234);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(39, 16);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(557, 129);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 22);
            this.textBoxName.TabIndex = 50;
            this.textBoxName.LostFocus += new System.EventHandler(this.TextBoxName_LostFocus);
            // 
            // textBoxTexture
            // 
            this.textBoxTexture.Location = new System.Drawing.Point(557, 193);
            this.textBoxTexture.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTexture.Name = "textBoxTexture";
            this.textBoxTexture.Size = new System.Drawing.Size(228, 22);
            this.textBoxTexture.TabIndex = 70;
            // 
            // textBoxType
            // 
            this.textBoxType.Enabled = false;
            this.textBoxType.Location = new System.Drawing.Point(557, 225);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(228, 22);
            this.textBoxType.TabIndex = 90;
            // 
            // buttonBrowseSkin
            // 
            this.buttonBrowseSkin.Location = new System.Drawing.Point(793, 193);
            this.buttonBrowseSkin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowseSkin.Name = "buttonBrowseSkin";
            this.buttonBrowseSkin.Size = new System.Drawing.Size(84, 26);
            this.buttonBrowseSkin.TabIndex = 80;
            this.buttonBrowseSkin.Text = "Browse";
            this.buttonBrowseSkin.UseVisualStyleBackColor = true;
            this.buttonBrowseSkin.Click += new System.EventHandler(this.ButtonBrowseSkin_Click);
            // 
            // pictureBoxSkin
            // 
            this.pictureBoxSkin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxSkin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSkin.Location = new System.Drawing.Point(476, 268);
            this.pictureBoxSkin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSkin.Name = "pictureBoxSkin";
            this.pictureBoxSkin.Size = new System.Drawing.Size(311, 290);
            this.pictureBoxSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSkin.TabIndex = 9;
            this.pictureBoxSkin.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusLabel.Location = new System.Drawing.Point(0, 577);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusLabel.Size = new System.Drawing.Size(1156, 22);
            this.statusLabel.TabIndex = 10;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(276, 138);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 25);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(276, 175);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(81, 25);
            this.buttonRemove.TabIndex = 40;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F);
            this.buttonMoveUp.Location = new System.Drawing.Point(276, 212);
            this.buttonMoveUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonMoveUp.Size = new System.Drawing.Size(45, 35);
            this.buttonMoveUp.TabIndex = 60;
            this.buttonMoveUp.Text = "▲";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.ButtonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F);
            this.buttonMoveDown.Location = new System.Drawing.Point(276, 255);
            this.buttonMoveDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonMoveDown.Size = new System.Drawing.Size(45, 35);
            this.buttonMoveDown.TabIndex = 60;
            this.buttonMoveDown.Text = "▼";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.ButtonMoveDown_Click);
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "geometry.humanoid.custom",
            "geometry.humanoid.customSlim"});
            this.comboBoxFormat.Location = new System.Drawing.Point(557, 161);
            this.comboBoxFormat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(228, 24);
            this.comboBoxFormat.TabIndex = 60;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFormat_SelectedIndexChanged);
            // 
            // buttonDonate
            // 
            this.buttonDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDonate.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDonate.FlatAppearance.BorderSize = 0;
            this.buttonDonate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonDonate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDonate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.buttonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDonate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDonate.Location = new System.Drawing.Point(787, 0);
            this.buttonDonate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(364, 30);
            this.buttonDonate.TabIndex = 101;
            this.buttonDonate.Text = "Did you like it? Wanna buy me a cup of coffee?";
            this.buttonDonate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDonate.UseVisualStyleBackColor = false;
            this.buttonDonate.Click += new System.EventHandler(this.ButtonDonate_Click);
            // 
            // buttonImportMultiple
            // 
            this.buttonImportMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImportMultiple.Location = new System.Drawing.Point(33, 534);
            this.buttonImportMultiple.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImportMultiple.Name = "buttonImportMultiple";
            this.buttonImportMultiple.Size = new System.Drawing.Size(236, 25);
            this.buttonImportMultiple.TabIndex = 102;
            this.buttonImportMultiple.Text = "Import Multiple PNGs";
            this.buttonImportMultiple.UseVisualStyleBackColor = true;
            this.buttonImportMultiple.Click += new System.EventHandler(this.buttonImportMultiple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 599);
            this.Controls.Add(this.buttonImportMultiple);
            this.Controls.Add(this.buttonDonate);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pictureBoxSkin);
            this.Controls.Add(this.buttonBrowseSkin);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxTexture);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTexture);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.groupSettings);
            this.Controls.Add(this.labelSkinList);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listSkins);
            this.Controls.Add(this.menuStripMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Minecraft Skin Pack Creator for Bedrock Edition - v1.1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupSettings.ResumeLayout(false);
            this.groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkin)).EndInit();
            this.statusLabel.ResumeLayout(false);
            this.statusLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuNewMcpack;
        private System.Windows.Forms.ToolStripMenuItem menuOpenMcpack;
        private System.Windows.Forms.ListBox listSkins;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSkinList;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelTexture;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTexture;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button buttonBrowseSkin;
        private System.Windows.Forms.PictureBox pictureBoxSkin;
        private System.Windows.Forms.StatusStrip statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuInstall;
        private System.Windows.Forms.TextBox textBoxPackDescription;
        private System.Windows.Forms.TextBox textBoxPackName;
        private System.Windows.Forms.Label labelPackDescription;
        private System.Windows.Forms.Label labelPackName;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonDonate;
        private System.Windows.Forms.ToolStripMenuItem menuOpenInstallFolder;
        private System.Windows.Forms.Button buttonImportMultiple;
    }
}

