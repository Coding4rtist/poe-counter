namespace AlwaysOnTopTest {
    partial class CounterForm {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterForm));
            this.counter1Label = new System.Windows.Forms.Label();
            this.reset1Button = new System.Windows.Forms.Button();
            this.bcMapButton = new System.Windows.Forms.PictureBox();
            this.doctorCardButton = new System.Windows.Forms.PictureBox();
            this.counter2Label = new System.Windows.Forms.Label();
            this.reset2Button = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bcMapButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorCardButton)).BeginInit();
            this.SuspendLayout();
            // 
            // counter1Label
            // 
            this.counter1Label.AutoSize = true;
            this.counter1Label.BackColor = System.Drawing.Color.Transparent;
            this.counter1Label.Enabled = false;
            this.counter1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.counter1Label.Location = new System.Drawing.Point(20, 88);
            this.counter1Label.Name = "counter1Label";
            this.counter1Label.Size = new System.Drawing.Size(21, 24);
            this.counter1Label.TabIndex = 1;
            this.counter1Label.Text = "0";
            // 
            // reset1Button
            // 
            this.reset1Button.BackColor = System.Drawing.Color.Transparent;
            this.reset1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset1Button.BackgroundImage")));
            this.reset1Button.FlatAppearance.BorderSize = 0;
            this.reset1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(203)))), ((int)(((byte)(144)))));
            this.reset1Button.Location = new System.Drawing.Point(12, 116);
            this.reset1Button.Name = "reset1Button";
            this.reset1Button.Size = new System.Drawing.Size(50, 25);
            this.reset1Button.TabIndex = 2;
            this.reset1Button.Text = "Reset";
            this.reset1Button.UseVisualStyleBackColor = false;
            this.reset1Button.Click += new System.EventHandler(this.reset1Button_Click);
            // 
            // bcMapButton
            // 
            this.bcMapButton.BackColor = System.Drawing.Color.Transparent;
            this.bcMapButton.BackgroundImage = global::PoeCounter.Properties.Resources.Burial_Chambers_Map__War_for_the_Atlas__inventory_icon;
            this.bcMapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bcMapButton.Location = new System.Drawing.Point(12, 34);
            this.bcMapButton.Name = "bcMapButton";
            this.bcMapButton.Size = new System.Drawing.Size(50, 50);
            this.bcMapButton.TabIndex = 3;
            this.bcMapButton.TabStop = false;
            this.bcMapButton.Click += new System.EventHandler(this.bcMapButton_Click);
            // 
            // doctorCardButton
            // 
            this.doctorCardButton.BackColor = System.Drawing.Color.Transparent;
            this.doctorCardButton.BackgroundImage = global::PoeCounter.Properties.Resources.InventoryIcon;
            this.doctorCardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doctorCardButton.Location = new System.Drawing.Point(77, 34);
            this.doctorCardButton.Name = "doctorCardButton";
            this.doctorCardButton.Size = new System.Drawing.Size(50, 50);
            this.doctorCardButton.TabIndex = 4;
            this.doctorCardButton.TabStop = false;
            this.doctorCardButton.Click += new System.EventHandler(this.doctorCardButton_Click);
            // 
            // counter2Label
            // 
            this.counter2Label.AutoSize = true;
            this.counter2Label.BackColor = System.Drawing.Color.Transparent;
            this.counter2Label.Enabled = false;
            this.counter2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.counter2Label.Location = new System.Drawing.Point(89, 88);
            this.counter2Label.Name = "counter2Label";
            this.counter2Label.Size = new System.Drawing.Size(21, 24);
            this.counter2Label.TabIndex = 5;
            this.counter2Label.Text = "0";
            // 
            // reset2Button
            // 
            this.reset2Button.BackColor = System.Drawing.Color.Transparent;
            this.reset2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset2Button.BackgroundImage")));
            this.reset2Button.FlatAppearance.BorderSize = 0;
            this.reset2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(203)))), ((int)(((byte)(144)))));
            this.reset2Button.Location = new System.Drawing.Point(77, 117);
            this.reset2Button.Name = "reset2Button";
            this.reset2Button.Size = new System.Drawing.Size(50, 25);
            this.reset2Button.TabIndex = 6;
            this.reset2Button.Text = "Reset";
            this.reset2Button.UseVisualStyleBackColor = false;
            this.reset2Button.Click += new System.EventHandler(this.reset2Button_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::PoeCounter.Properties.Resources.close_button;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(122, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 7;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.BackColor = System.Drawing.Color.Transparent;
            this.formTitle.Enabled = false;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formTitle.Location = new System.Drawing.Point(12, 9);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(75, 15);
            this.formTitle.TabIndex = 8;
            this.formTitle.Text = "Poe Counter";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoeCounter.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(150, 150);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reset2Button);
            this.Controls.Add(this.counter2Label);
            this.Controls.Add(this.doctorCardButton);
            this.Controls.Add(this.bcMapButton);
            this.Controls.Add(this.reset1Button);
            this.Controls.Add(this.counter1Label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CounterForm";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Counter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CounterForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CounterForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.bcMapButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorCardButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label counter1Label;
        private System.Windows.Forms.Button reset1Button;
        private System.Windows.Forms.PictureBox bcMapButton;
        private System.Windows.Forms.PictureBox doctorCardButton;
        private System.Windows.Forms.Label counter2Label;
        private System.Windows.Forms.Button reset2Button;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label formTitle;
    }
}

