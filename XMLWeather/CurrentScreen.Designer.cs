namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.dayOutput = new System.Windows.Forms.Label();
            this.tempOutput = new System.Windows.Forms.Label();
            this.highOutput = new System.Windows.Forms.Label();
            this.lowOutput = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(0, 88);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(239, 23);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(123, 391);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // dayOutput
            // 
            this.dayOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOutput.ForeColor = System.Drawing.Color.White;
            this.dayOutput.Location = new System.Drawing.Point(8, 49);
            this.dayOutput.Name = "dayOutput";
            this.dayOutput.Size = new System.Drawing.Size(231, 39);
            this.dayOutput.TabIndex = 65;
            this.dayOutput.Text = "Date";
            this.dayOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tempOutput
            // 
            this.tempOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOutput.ForeColor = System.Drawing.Color.White;
            this.tempOutput.Location = new System.Drawing.Point(8, 111);
            this.tempOutput.Name = "tempOutput";
            this.tempOutput.Size = new System.Drawing.Size(231, 39);
            this.tempOutput.TabIndex = 66;
            this.tempOutput.Text = "Temp";
            this.tempOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highOutput
            // 
            this.highOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highOutput.ForeColor = System.Drawing.Color.White;
            this.highOutput.Location = new System.Drawing.Point(23, 150);
            this.highOutput.Name = "highOutput";
            this.highOutput.Size = new System.Drawing.Size(82, 26);
            this.highOutput.TabIndex = 67;
            this.highOutput.Text = "H:";
            this.highOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lowOutput
            // 
            this.lowOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowOutput.ForeColor = System.Drawing.Color.White;
            this.lowOutput.Location = new System.Drawing.Point(130, 150);
            this.lowOutput.Name = "lowOutput";
            this.lowOutput.Size = new System.Drawing.Size(82, 26);
            this.lowOutput.TabIndex = 68;
            this.lowOutput.Text = "L:";
            this.lowOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 69;
            this.searchBox.Text = "Search City...";
///            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.searchBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // CurrentScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.lowOutput);
            this.Controls.Add(this.highOutput);
            this.Controls.Add(this.tempOutput);
            this.Controls.Add(this.dayOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentOutput);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(255, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label dayOutput;
        private System.Windows.Forms.Label tempOutput;
        private System.Windows.Forms.Label highOutput;
        private System.Windows.Forms.Label lowOutput;
        private System.Windows.Forms.TextBox searchBox;
    }
}
