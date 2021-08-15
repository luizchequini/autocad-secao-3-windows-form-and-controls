
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
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.CbbOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblTextstyleCount = new System.Windows.Forms.Label();
            this.LblLinetypeCount = new System.Windows.Forms.Label();
            this.LblLayerCount = new System.Windows.Forms.Label();
            this.LstTextstyle = new System.Windows.Forms.ListBox();
            this.LstLinetype = new System.Windows.Forms.ListBox();
            this.LstLayer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnClearAll);
            this.groupBox1.Controls.Add(this.BtnDisplay);
            this.groupBox1.Controls.Add(this.CbbOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options Container";
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Location = new System.Drawing.Point(123, 397);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(111, 23);
            this.BtnClearAll.TabIndex = 3;
            this.BtnClearAll.Text = "Clear All";
            this.BtnClearAll.UseVisualStyleBackColor = true;
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(6, 397);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(111, 23);
            this.BtnDisplay.TabIndex = 2;
            this.BtnDisplay.Text = "Show Items";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // CbbOptions
            // 
            this.CbbOptions.FormattingEnabled = true;
            this.CbbOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "Linetype",
            "Textstyle"});
            this.CbbOptions.Location = new System.Drawing.Point(6, 37);
            this.CbbOptions.Name = "CbbOptions";
            this.CbbOptions.Size = new System.Drawing.Size(275, 24);
            this.CbbOptions.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblTextstyleCount);
            this.groupBox2.Controls.Add(this.LblLinetypeCount);
            this.groupBox2.Controls.Add(this.LblLayerCount);
            this.groupBox2.Controls.Add(this.LstTextstyle);
            this.groupBox2.Controls.Add(this.LstLinetype);
            this.groupBox2.Controls.Add(this.LstLayer);
            this.groupBox2.Location = new System.Drawing.Point(305, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Container";
            // 
            // LblTextstyleCount
            // 
            this.LblTextstyleCount.AutoSize = true;
            this.LblTextstyleCount.Location = new System.Drawing.Point(341, 400);
            this.LblTextstyleCount.Name = "LblTextstyleCount";
            this.LblTextstyleCount.Size = new System.Drawing.Size(17, 16);
            this.LblTextstyleCount.TabIndex = 5;
            this.LblTextstyleCount.Text = "...";
            // 
            // LblLinetypeCount
            // 
            this.LblLinetypeCount.AutoSize = true;
            this.LblLinetypeCount.Location = new System.Drawing.Point(172, 400);
            this.LblLinetypeCount.Name = "LblLinetypeCount";
            this.LblLinetypeCount.Size = new System.Drawing.Size(17, 16);
            this.LblLinetypeCount.TabIndex = 4;
            this.LblLinetypeCount.Text = "...";
            // 
            // LblLayerCount
            // 
            this.LblLayerCount.AutoSize = true;
            this.LblLayerCount.Location = new System.Drawing.Point(6, 400);
            this.LblLayerCount.Name = "LblLayerCount";
            this.LblLayerCount.Size = new System.Drawing.Size(17, 16);
            this.LblLayerCount.TabIndex = 3;
            this.LblLayerCount.Text = "...";
            // 
            // LstTextstyle
            // 
            this.LstTextstyle.FormattingEnabled = true;
            this.LstTextstyle.ItemHeight = 16;
            this.LstTextstyle.Location = new System.Drawing.Point(344, 21);
            this.LstTextstyle.Name = "LstTextstyle";
            this.LstTextstyle.Size = new System.Drawing.Size(163, 372);
            this.LstTextstyle.TabIndex = 2;
            // 
            // LstLinetype
            // 
            this.LstLinetype.FormattingEnabled = true;
            this.LstLinetype.ItemHeight = 16;
            this.LstLinetype.Location = new System.Drawing.Point(175, 21);
            this.LstLinetype.Name = "LstLinetype";
            this.LstLinetype.Size = new System.Drawing.Size(163, 372);
            this.LstLinetype.TabIndex = 1;
            // 
            // LstLayer
            // 
            this.LstLayer.FormattingEnabled = true;
            this.LstLayer.ItemHeight = 16;
            this.LstLayer.Location = new System.Drawing.Point(6, 21);
            this.LstLayer.Name = "LstLayer";
            this.LstLayer.Size = new System.Drawing.Size(163, 372);
            this.LstLayer.TabIndex = 0;
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
        private System.Windows.Forms.ComboBox CbbOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Button BtnClearAll;
        private System.Windows.Forms.ListBox LstTextstyle;
        private System.Windows.Forms.ListBox LstLinetype;
        private System.Windows.Forms.ListBox LstLayer;
        private System.Windows.Forms.Label LblLinetypeCount;
        private System.Windows.Forms.Label LblLayerCount;
        private System.Windows.Forms.Label LblTextstyleCount;
    }
}