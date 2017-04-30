namespace ExampleAzureDB
{
    partial class frmAzureExample
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
            this.lblSQL = new System.Windows.Forms.Label();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSQL
            // 
            this.lblSQL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQL.Location = new System.Drawing.Point(14, 14);
            this.lblSQL.Margin = new System.Windows.Forms.Padding(5);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(100, 18);
            this.lblSQL.TabIndex = 0;
            this.lblSQL.Text = "SQL Output";
            // 
            // btnTest1
            // 
            this.btnTest1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest1.Location = new System.Drawing.Point(14, 523);
            this.btnTest1.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(240, 25);
            this.btnTest1.TabIndex = 2;
            this.btnTest1.Text = "Pull All Contacts";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(14, 42);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(5);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(755, 16);
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "remarks";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(15, 68);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(755, 440);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "result";
            // 
            // btnTest2
            // 
            this.btnTest2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest2.Location = new System.Drawing.Point(264, 523);
            this.btnTest2.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(240, 25);
            this.btnTest2.TabIndex = 6;
            this.btnTest2.Text = "Pull Contacts - First Like \'R%\'";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest3.Location = new System.Drawing.Point(514, 523);
            this.btnTest3.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(240, 25);
            this.btnTest3.TabIndex = 7;
            this.btnTest3.Text = "Pull Contacts - State = \'KS\'";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // frmAzureExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.lblSQL);
            this.Name = "frmAzureExample";
            this.Text = "Azure DB Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
    }
}

