namespace InternetCafeManagement.AdminForm
{
    partial class ComputerRoomManageForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.panelAdminControl = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelComputerGrid = new System.Windows.Forms.Panel();
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelAdminControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRoomInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonReload);
            this.panelMain.Controls.Add(this.panelAdminControl);
            this.panelMain.Controls.Add(this.panelComputerGrid);
            this.panelMain.Controls.Add(this.panelRoomInformation);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1371, 698);
            this.panelMain.TabIndex = 0;
            // 
            // buttonReload
            // 
            this.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReload.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReload.BackgroundImage = global::InternetCafeManagement.Properties.Resources.reload;
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.Color.RosyBrown;
            this.buttonReload.Location = new System.Drawing.Point(785, 56);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(28, 29);
            this.buttonReload.TabIndex = 89;
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // panelAdminControl
            // 
            this.panelAdminControl.Controls.Add(this.dataGridView1);
            this.panelAdminControl.Controls.Add(this.buttonUpdate);
            this.panelAdminControl.Location = new System.Drawing.Point(819, 92);
            this.panelAdminControl.Name = "panelAdminControl";
            this.panelAdminControl.Size = new System.Drawing.Size(540, 642);
            this.panelAdminControl.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 601);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(3, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(537, 35);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "ADD NEW COMPUTER";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelComputerGrid
            // 
            this.panelComputerGrid.Location = new System.Drawing.Point(3, 92);
            this.panelComputerGrid.Name = "panelComputerGrid";
            this.panelComputerGrid.Size = new System.Drawing.Size(810, 842);
            this.panelComputerGrid.TabIndex = 1;
            // 
            // panelRoomInformation
            // 
            this.panelRoomInformation.Controls.Add(this.labelComputerNumber);
            this.panelRoomInformation.Controls.Add(this.labelRoomID);
            this.panelRoomInformation.Location = new System.Drawing.Point(3, 3);
            this.panelRoomInformation.Name = "panelRoomInformation";
            this.panelRoomInformation.Size = new System.Drawing.Size(452, 72);
            this.panelRoomInformation.TabIndex = 0;
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelComputerNumber.Location = new System.Drawing.Point(9, 31);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(195, 25);
            this.labelComputerNumber.TabIndex = 1;
            this.labelComputerNumber.Text = "Computers Number:";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelRoomID.Location = new System.Drawing.Point(9, 6);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(91, 25);
            this.labelRoomID.TabIndex = 0;
            this.labelRoomID.Text = "Room 01";
            // 
            // ComputerRoomManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 698);
            this.Controls.Add(this.panelMain);
            this.Name = "ComputerRoomManageForm";
            this.Load += new System.EventHandler(this.ComputerRoomManageForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelAdminControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelRoomInformation.ResumeLayout(false);
            this.panelRoomInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRoomInformation;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.Panel panelComputerGrid;
        private System.Windows.Forms.Panel panelAdminControl;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReload;
    }
}