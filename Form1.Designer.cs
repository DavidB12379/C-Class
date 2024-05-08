namespace Car_Acceleration_and_Braking
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
            this.btnAccel = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.lblCarStuff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccel
            // 
            this.btnAccel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccel.Location = new System.Drawing.Point(164, 181);
            this.btnAccel.Name = "btnAccel";
            this.btnAccel.Size = new System.Drawing.Size(181, 48);
            this.btnAccel.TabIndex = 0;
            this.btnAccel.Text = "Accelerate";
            this.btnAccel.UseVisualStyleBackColor = true;
            this.btnAccel.Click += new System.EventHandler(this.btnAccel_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrake.Location = new System.Drawing.Point(444, 181);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(181, 48);
            this.btnBrake.TabIndex = 0;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // lblCarStuff
            // 
            this.lblCarStuff.BackColor = System.Drawing.Color.White;
            this.lblCarStuff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarStuff.Location = new System.Drawing.Point(58, 72);
            this.lblCarStuff.Name = "lblCarStuff";
            this.lblCarStuff.Size = new System.Drawing.Size(739, 50);
            this.lblCarStuff.TabIndex = 1;
            this.lblCarStuff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarStuff.Click += new System.EventHandler(this.lblCarStuff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 274);
            this.Controls.Add(this.lblCarStuff);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAccel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccel;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Label lblCarStuff;
    }
}

