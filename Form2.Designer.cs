namespace LogIn
{
    partial class MainSchedule
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSche = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSche);
            this.groupBox2.Controls.Add(this.btnRoom);
            this.groupBox2.Controls.Add(this.btnIns);
            this.groupBox2.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(373, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(480, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose an options:";
            // 
            // btnSche
            // 
            this.btnSche.BackgroundImage = global::LogIn.Properties.Resources.download__3_1;
            this.btnSche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSche.Location = new System.Drawing.Point(157, 187);
            this.btnSche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSche.Name = "btnSche";
            this.btnSche.Size = new System.Drawing.Size(184, 134);
            this.btnSche.TabIndex = 4;
            this.btnSche.UseVisualStyleBackColor = true;
            this.btnSche.Click += new System.EventHandler(this.btnSche_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackgroundImage = global::LogIn.Properties.Resources.download__2_1;
            this.btnRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoom.Location = new System.Drawing.Point(50, 43);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(184, 134);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackgroundImage = global::LogIn.Properties.Resources.images__1_1;
            this.btnIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIns.Location = new System.Drawing.Point(279, 43);
            this.btnIns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(184, 134);
            this.btnIns.TabIndex = 0;
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 159);
            this.label1.TabIndex = 3;
            this.label1.Text = "Class \r\n     Schedule \r\n              System";
            // 
            // MainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogIn.Properties.Resources.download__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainSchedule";
            this.Text = "Main Schedule";
            this.Load += new System.EventHandler(this.MainSchedule_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSche;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label label1;
    }
}

