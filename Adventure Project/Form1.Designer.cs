namespace Adventure_Project
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
            this.btnTown = new System.Windows.Forms.Button();
            this.btnForest = new System.Windows.Forms.Button();
            this.btnMountain = new System.Windows.Forms.Button();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShopkeeper = new System.Windows.Forms.Button();
            this.lblNPCInteraction = new System.Windows.Forms.Label();
            this.btnReturnToMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTown
            // 
            this.btnTown.Location = new System.Drawing.Point(544, 62);
            this.btnTown.Name = "btnTown";
            this.btnTown.Size = new System.Drawing.Size(75, 23);
            this.btnTown.TabIndex = 0;
            this.btnTown.Text = "Town";
            this.btnTown.UseVisualStyleBackColor = true;
            this.btnTown.Click += new System.EventHandler(this.btnTown_Click);
            // 
            // btnForest
            // 
            this.btnForest.Location = new System.Drawing.Point(587, 142);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(75, 23);
            this.btnForest.TabIndex = 1;
            this.btnForest.Text = "Forest";
            this.btnForest.UseVisualStyleBackColor = true;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // btnMountain
            // 
            this.btnMountain.Location = new System.Drawing.Point(403, 257);
            this.btnMountain.Name = "btnMountain";
            this.btnMountain.Size = new System.Drawing.Size(75, 23);
            this.btnMountain.TabIndex = 2;
            this.btnMountain.Text = "Mountain";
            this.btnMountain.UseVisualStyleBackColor = true;
            this.btnMountain.Click += new System.EventHandler(this.btnMountain_Click);
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(159, 16);
            this.lblCurrentLocation.TabIndex = 3;
            this.lblCurrentLocation.Text = "You are currently in: None";
            this.lblCurrentLocation.Click += new System.EventHandler(this.lblCurrentLocation_Click);
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.Location = new System.Drawing.Point(690, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(98, 16);
            this.lblInGameTime.TabIndex = 4;
            this.lblInGameTime.Text = "Time: 12:00 PM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShopkeeper
            // 
            this.btnShopkeeper.Location = new System.Drawing.Point(15, 141);
            this.btnShopkeeper.Name = "btnShopkeeper";
            this.btnShopkeeper.Size = new System.Drawing.Size(75, 23);
            this.btnShopkeeper.TabIndex = 5;
            this.btnShopkeeper.Text = "Shop";
            this.btnShopkeeper.UseVisualStyleBackColor = true;
            this.btnShopkeeper.Visible = false;
            this.btnShopkeeper.Click += new System.EventHandler(this.btnShopkeeper_Click_1);
            // 
            // lblNPCInteraction
            // 
            this.lblNPCInteraction.AutoSize = true;
            this.lblNPCInteraction.Location = new System.Drawing.Point(15, 68);
            this.lblNPCInteraction.Name = "lblNPCInteraction";
            this.lblNPCInteraction.Size = new System.Drawing.Size(34, 16);
            this.lblNPCInteraction.TabIndex = 6;
            this.lblNPCInteraction.Text = "Test";
            // 
            // btnReturnToMap
            // 
            this.btnReturnToMap.Location = new System.Drawing.Point(15, 29);
            this.btnReturnToMap.Name = "btnReturnToMap";
            this.btnReturnToMap.Size = new System.Drawing.Size(156, 23);
            this.btnReturnToMap.TabIndex = 7;
            this.btnReturnToMap.Text = "Return to Map";
            this.btnReturnToMap.UseVisualStyleBackColor = true;
            this.btnReturnToMap.Visible = false;
            this.btnReturnToMap.Click += new System.EventHandler(this.btnReturnToMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnReturnToMap);
            this.Controls.Add(this.lblNPCInteraction);
            this.Controls.Add(this.btnShopkeeper);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.btnMountain);
            this.Controls.Add(this.btnForest);
            this.Controls.Add(this.btnTown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTown;
        private System.Windows.Forms.Button btnForest;
        private System.Windows.Forms.Button btnMountain;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShopkeeper;
        private System.Windows.Forms.Label lblNPCInteraction;
        private System.Windows.Forms.Button btnReturnToMap;
    }
}

