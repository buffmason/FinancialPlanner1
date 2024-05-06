namespace FinancialPlanner1
{
    partial class MainForm
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
            this.lblAnnualAmount = new System.Windows.Forms.Label();
            this.txtAnnualAmount = new System.Windows.Forms.TextBox();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.cmbRetirementPlan = new System.Windows.Forms.ComboBox();
            this.lblRetirementPlan = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnnualAmount
            // 
            this.lblAnnualAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnualAmount.Location = new System.Drawing.Point(96, 58);
            this.lblAnnualAmount.Name = "lblAnnualAmount";
            this.lblAnnualAmount.Size = new System.Drawing.Size(144, 30);
            this.lblAnnualAmount.TabIndex = 0;
            this.lblAnnualAmount.Text = "Annual Amount";
            // 
            // txtAnnualAmount
            // 
            this.txtAnnualAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualAmount.Location = new System.Drawing.Point(276, 46);
            this.txtAnnualAmount.Multiline = true;
            this.txtAnnualAmount.Name = "txtAnnualAmount";
            this.txtAnnualAmount.Size = new System.Drawing.Size(124, 42);
            this.txtAnnualAmount.TabIndex = 1;
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetAmount.Location = new System.Drawing.Point(96, 141);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(144, 30);
            this.lblTargetAmount.TabIndex = 2;
            this.lblTargetAmount.Text = "Target Amount";
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetAmount.Location = new System.Drawing.Point(276, 129);
            this.txtTargetAmount.Multiline = true;
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(124, 42);
            this.txtTargetAmount.TabIndex = 3;
            // 
            // cmbRetirementPlan
            // 
            this.cmbRetirementPlan.FormattingEnabled = true;
            this.cmbRetirementPlan.Items.AddRange(new object[] {
            "Retirement Plan 2050",
            "Retirement Plan 2060"});
            this.cmbRetirementPlan.Location = new System.Drawing.Point(256, 223);
            this.cmbRetirementPlan.Name = "cmbRetirementPlan";
            this.cmbRetirementPlan.Size = new System.Drawing.Size(163, 28);
            this.cmbRetirementPlan.TabIndex = 4;
            // 
            // lblRetirementPlan
            // 
            this.lblRetirementPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirementPlan.Location = new System.Drawing.Point(106, 224);
            this.lblRetirementPlan.Name = "lblRetirementPlan";
            this.lblRetirementPlan.Size = new System.Drawing.Size(144, 30);
            this.lblRetirementPlan.TabIndex = 5;
            this.lblRetirementPlan.Text = "Select Plan";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(191, 286);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 54);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "How Long?";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(96, 387);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(144, 30);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Time Taken";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(276, 375);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(124, 42);
            this.txtResult.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRetirementPlan);
            this.Controls.Add(this.cmbRetirementPlan);
            this.Controls.Add(this.txtTargetAmount);
            this.Controls.Add(this.lblTargetAmount);
            this.Controls.Add(this.txtAnnualAmount);
            this.Controls.Add(this.lblAnnualAmount);
            this.Name = "MainForm";
            this.Text = "Financial Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnnualAmount;
        private System.Windows.Forms.TextBox txtAnnualAmount;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.TextBox txtTargetAmount;
        private System.Windows.Forms.ComboBox cmbRetirementPlan;
        private System.Windows.Forms.Label lblRetirementPlan;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}

