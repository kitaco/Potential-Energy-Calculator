namespace PotentialEnergy
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
            this.massLabel = new System.Windows.Forms.Label();
            this.massTextbox = new System.Windows.Forms.TextBox();
            this.heighLabel = new System.Windows.Forms.Label();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.potentialenergyLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massLabel.Location = new System.Drawing.Point(29, 22);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(70, 26);
            this.massLabel.TabIndex = 0;
            this.massLabel.Text = "Mass:";
            // 
            // massTextbox
            // 
            this.massTextbox.Location = new System.Drawing.Point(105, 24);
            this.massTextbox.Name = "massTextbox";
            this.massTextbox.Size = new System.Drawing.Size(100, 26);
            this.massTextbox.TabIndex = 1;
            // 
            // heighLabel
            // 
            this.heighLabel.AutoSize = true;
            this.heighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heighLabel.Location = new System.Drawing.Point(29, 64);
            this.heighLabel.Name = "heighLabel";
            this.heighLabel.Size = new System.Drawing.Size(81, 26);
            this.heighLabel.TabIndex = 2;
            this.heighLabel.Text = "Height:";
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(116, 66);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(100, 26);
            this.heightTextbox.TabIndex = 3;
            // 
            // potentialenergyLabel
            // 
            this.potentialenergyLabel.AutoSize = true;
            this.potentialenergyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potentialenergyLabel.Location = new System.Drawing.Point(29, 106);
            this.potentialenergyLabel.Name = "potentialenergyLabel";
            this.potentialenergyLabel.Size = new System.Drawing.Size(178, 26);
            this.potentialenergyLabel.TabIndex = 4;
            this.potentialenergyLabel.Text = "Potential Energy:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Crimson;
            this.outputLabel.Location = new System.Drawing.Point(213, 105);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 34);
            this.outputLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(34, 153);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(91, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(133, 153);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 35);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(230, 153);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 216);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.potentialenergyLabel);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.heighLabel);
            this.Controls.Add(this.massTextbox);
            this.Controls.Add(this.massLabel);
            this.Name = "Form1";
            this.Text = "Potential Energy Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.TextBox massTextbox;
        private System.Windows.Forms.Label heighLabel;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Label potentialenergyLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

