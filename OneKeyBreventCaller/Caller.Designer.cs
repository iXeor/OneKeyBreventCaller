
using System.ComponentModel;
using System.Windows.Forms;

namespace OneKeyBreventCaller
{
    partial class BreventCallerMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreventCallerMain));
            this.Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceInfoStr = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Run.Location = new System.Drawing.Point(410, 92);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "激活";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "设备型号：";
            // 
            // DeviceInfoStr
            // 
            this.DeviceInfoStr.AutoSize = true;
            this.DeviceInfoStr.Location = new System.Drawing.Point(119, 43);
            this.DeviceInfoStr.Name = "DeviceInfoStr";
            this.DeviceInfoStr.Size = new System.Drawing.Size(84, 17);
            this.DeviceInfoStr.TabIndex = 2;
            this.DeviceInfoStr.Text = "DeviceModel";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(329, 92);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "刷新";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // BreventCallerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 127);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeviceInfoStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BreventCallerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "一键激活黑阈 - OneKey Brevent Caller";
            this.Load += new System.EventHandler(this.BreventCallerMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Run;
        private Label label1;
        private Label DeviceInfoStr;
        private Button RefreshButton;
    }
}

