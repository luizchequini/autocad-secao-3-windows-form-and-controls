
namespace ControlsDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lstLayer = new System.Windows.Forms.ListBox();
            this.lstLinetype = new System.Windows.Forms.ListBox();
            this.lstTextstyle = new System.Windows.Forms.ListBox();
            this.lblLayerCount = new System.Windows.Forms.Label();
            this.lblLinetypeCount = new System.Windows.Forms.Label();
            this.lblTextstyleCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.cbOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options Container";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTextstyleCount);
            this.groupBox2.Controls.Add(this.lblLinetypeCount);
            this.groupBox2.Controls.Add(this.lblLayerCount);
            this.groupBox2.Controls.Add(this.lstTextstyle);
            this.groupBox2.Controls.Add(this.lstLinetype);
            this.groupBox2.Controls.Add(this.lstLayer);
            this.groupBox2.Location = new System.Drawing.Point(305, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Container";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select item to display:";
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "Linetype",
            "Textstyle"});
            this.cbOptions.Location = new System.Drawing.Point(6, 37);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(275, 24);
            this.cbOptions.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(6, 397);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Show Items";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(87, 397);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // lstLayer
            // 
            this.lstLayer.FormattingEnabled = true;
            this.lstLayer.ItemHeight = 16;
            this.lstLayer.Location = new System.Drawing.Point(6, 21);
            this.lstLayer.Name = "lstLayer";
            this.lstLayer.Size = new System.Drawing.Size(163, 372);
            this.lstLayer.TabIndex = 0;
            // 
            // lstLinetype
            // 
            this.lstLinetype.FormattingEnabled = true;
            this.lstLinetype.ItemHeight = 16;
            this.lstLinetype.Location = new System.Drawing.Point(175, 21);
            this.lstLinetype.Name = "lstLinetype";
            this.lstLinetype.Size = new System.Drawing.Size(163, 372);
            this.lstLinetype.TabIndex = 1;
            // 
            // lstTextstyle
            // 
            this.lstTextstyle.FormattingEnabled = true;
            this.lstTextstyle.ItemHeight = 16;
            this.lstTextstyle.Location = new System.Drawing.Point(344, 21);
            this.lstTextstyle.Name = "lstTextstyle";
            this.lstTextstyle.Size = new System.Drawing.Size(163, 372);
            this.lstTextstyle.TabIndex = 2;
            // 
            // lblLayerCount
            // 
            this.lblLayerCount.AutoSize = true;
            this.lblLayerCount.Location = new System.Drawing.Point(6, 400);
            this.lblLayerCount.Name = "lblLayerCount";
            this.lblLayerCount.Size = new System.Drawing.Size(17, 16);
            this.lblLayerCount.TabIndex = 3;
            this.lblLayerCount.Text = "...";
            // 
            // lblLinetypeCount
            // 
            this.lblLinetypeCount.AutoSize = true;
            this.lblLinetypeCount.Location = new System.Drawing.Point(172, 400);
            this.lblLinetypeCount.Name = "lblLinetypeCount";
            this.lblLinetypeCount.Size = new System.Drawing.Size(17, 16);
            this.lblLinetypeCount.TabIndex = 4;
            this.lblLinetypeCount.Text = "...";
            // 
            // lblTextstyleCount
            // 
            this.lblTextstyleCount.AutoSize = true;
            this.lblTextstyleCount.Location = new System.Drawing.Point(341, 400);
            this.lblTextstyleCount.Name = "lblTextstyleCount";
            this.lblTextstyleCount.Size = new System.Drawing.Size(17, 16);
            this.lblTextstyleCount.TabIndex = 5;
            this.lblTextstyleCount.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ListBox lstTextstyle;
        private System.Windows.Forms.ListBox lstLinetype;
        private System.Windows.Forms.ListBox lstLayer;
        private System.Windows.Forms.Label lblLinetypeCount;
        private System.Windows.Forms.Label lblLayerCount;
        private System.Windows.Forms.Label lblTextstyleCount;
    }
}