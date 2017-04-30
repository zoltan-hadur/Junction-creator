namespace Junction_creator
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
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCreateJunctions = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(13, 13);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(150, 23);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Select input directory";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(13, 42);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(150, 23);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "Select output directory";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(169, 16);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(24, 16);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "C:\\";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(169, 45);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(24, 16);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "C:\\";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreateJunctions
            // 
            this.btnCreateJunctions.Enabled = false;
            this.btnCreateJunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateJunctions.Location = new System.Drawing.Point(13, 72);
            this.btnCreateJunctions.Name = "btnCreateJunctions";
            this.btnCreateJunctions.Size = new System.Drawing.Size(150, 23);
            this.btnCreateJunctions.TabIndex = 4;
            this.btnCreateJunctions.Text = "Create junctions";
            this.btnCreateJunctions.UseVisualStyleBackColor = true;
            this.btnCreateJunctions.Click += new System.EventHandler(this.btnCreateJunctions_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(172, 72);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(297, 22);
            this.ProgressBar.TabIndex = 5;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(475, 75);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(36, 16);
            this.lblCurrent.TabIndex = 6;
            this.lblCurrent.Text = "0";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(517, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "9999";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 106);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btnCreateJunctions);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "Junction creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCreateJunctions;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}

