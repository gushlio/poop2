﻿namespace ZooBazarDesktopApp
{
    partial class ContractHistoryForm
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
            label1 = new Label();
            flpHistory = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(188, 44);
            label1.Name = "label1";
            label1.Size = new Size(415, 41);
            label1.TabIndex = 0;
            label1.Text = "Employee's Contract Hisotry";
            // 
            // flpHistory
            // 
            flpHistory.Location = new Point(49, 108);
            flpHistory.Name = "flpHistory";
            flpHistory.Size = new Size(739, 508);
            flpHistory.TabIndex = 1;
            // 
            // ContractHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(842, 628);
            Controls.Add(flpHistory);
            Controls.Add(label1);
            Name = "ContractHistoryForm";
            Text = "ContractHistoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpHistory;
    }
}