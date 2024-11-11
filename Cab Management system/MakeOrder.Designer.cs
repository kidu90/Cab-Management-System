namespace CB011943
{
    partial class MakeOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.dropOffLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.availableCars = new System.Windows.Forms.DataGridView();
            this.availableDrivers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDriverId = new System.Windows.Forms.TextBox();
            this.textBoxVehicleId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availableCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick-up Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drop-off Location";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(204, 45);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(140, 22);
            this.textBoxLocation.TabIndex = 2;
            // 
            // dropOffLocation
            // 
            this.dropOffLocation.Location = new System.Drawing.Point(204, 109);
            this.dropOffLocation.Name = "dropOffLocation";
            this.dropOffLocation.Size = new System.Drawing.Size(140, 22);
            this.dropOffLocation.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(60, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Make order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // availableCars
            // 
            this.availableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableCars.Location = new System.Drawing.Point(390, 45);
            this.availableCars.Name = "availableCars";
            this.availableCars.RowHeadersWidth = 51;
            this.availableCars.RowTemplate.Height = 24;
            this.availableCars.Size = new System.Drawing.Size(471, 437);
            this.availableCars.TabIndex = 6;
            // 
            // availableDrivers
            // 
            this.availableDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableDrivers.Location = new System.Drawing.Point(948, 45);
            this.availableDrivers.Name = "availableDrivers";
            this.availableDrivers.RowHeadersWidth = 51;
            this.availableDrivers.RowTemplate.Height = 24;
            this.availableDrivers.Size = new System.Drawing.Size(431, 437);
            this.availableDrivers.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pick a driver:";
            // 
            // textBoxDriverId
            // 
            this.textBoxDriverId.Location = new System.Drawing.Point(266, 255);
            this.textBoxDriverId.Name = "textBoxDriverId";
            this.textBoxDriverId.Size = new System.Drawing.Size(78, 22);
            this.textBoxDriverId.TabIndex = 9;
            // 
            // textBoxVehicleId
            // 
            this.textBoxVehicleId.Location = new System.Drawing.Point(266, 303);
            this.textBoxVehicleId.Name = "textBoxVehicleId";
            this.textBoxVehicleId.Size = new System.Drawing.Size(78, 22);
            this.textBoxVehicleId.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pick a vehicle:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(166, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVehicleId);
            this.Controls.Add(this.textBoxDriverId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availableDrivers);
            this.Controls.Add(this.availableCars);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dropOffLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MakeOrder";
            this.Text = "MakeOrder";
            this.Load += new System.EventHandler(this.MakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox dropOffLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView availableCars;
        private System.Windows.Forms.DataGridView availableDrivers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDriverId;
        private System.Windows.Forms.TextBox textBoxVehicleId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}