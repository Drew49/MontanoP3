namespace MontanoP3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblNumberItems = new System.Windows.Forms.Label();
            this.txbOrderNum = new System.Windows.Forms.TextBox();
            this.txbNumberOfItems = new System.Windows.Forms.TextBox();
            this.gbxItemType = new System.Windows.Forms.GroupBox();
            this.rbMug = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.lblUserText = new System.Windows.Forms.Label();
            this.txbUserText = new System.Windows.Forms.TextBox();
            this.cbxHasLogo = new System.Windows.Forms.CheckBox();
            this.lblNumColors = new System.Windows.Forms.Label();
            this.txbNumColors = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.gbxItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(63, 59);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(84, 15);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "Order Number";
            // 
            // lblNumberItems
            // 
            this.lblNumberItems.AutoSize = true;
            this.lblNumberItems.Location = new System.Drawing.Point(63, 113);
            this.lblNumberItems.Name = "lblNumberItems";
            this.lblNumberItems.Size = new System.Drawing.Size(97, 15);
            this.lblNumberItems.TabIndex = 2;
            this.lblNumberItems.Text = "Number of Items";
            // 
            // txbOrderNum
            // 
            this.txbOrderNum.Location = new System.Drawing.Point(215, 59);
            this.txbOrderNum.Name = "txbOrderNum";
            this.txbOrderNum.Size = new System.Drawing.Size(110, 23);
            this.txbOrderNum.TabIndex = 3;
            // 
            // txbNumberOfItems
            // 
            this.txbNumberOfItems.Location = new System.Drawing.Point(215, 113);
            this.txbNumberOfItems.Name = "txbNumberOfItems";
            this.txbNumberOfItems.Size = new System.Drawing.Size(110, 23);
            this.txbNumberOfItems.TabIndex = 4;
            // 
            // gbxItemType
            // 
            this.gbxItemType.Controls.Add(this.rbMug);
            this.gbxItemType.Controls.Add(this.rbPen);
            this.gbxItemType.Controls.Add(this.rbUSB);
            this.gbxItemType.Location = new System.Drawing.Point(215, 156);
            this.gbxItemType.Name = "gbxItemType";
            this.gbxItemType.Size = new System.Drawing.Size(110, 138);
            this.gbxItemType.TabIndex = 5;
            this.gbxItemType.TabStop = false;
            this.gbxItemType.Text = "Item Type";
            // 
            // rbMug
            // 
            this.rbMug.AutoSize = true;
            this.rbMug.Location = new System.Drawing.Point(6, 104);
            this.rbMug.Name = "rbMug";
            this.rbMug.Size = new System.Drawing.Size(50, 19);
            this.rbMug.TabIndex = 2;
            this.rbMug.TabStop = true;
            this.rbMug.Text = "Mug";
            this.rbMug.UseVisualStyleBackColor = true;
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(6, 69);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(45, 19);
            this.rbPen.TabIndex = 1;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(6, 36);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(46, 19);
            this.rbUSB.TabIndex = 0;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // lblUserText
            // 
            this.lblUserText.AutoSize = true;
            this.lblUserText.Location = new System.Drawing.Point(63, 322);
            this.lblUserText.Name = "lblUserText";
            this.lblUserText.Size = new System.Drawing.Size(117, 15);
            this.lblUserText.TabIndex = 6;
            this.lblUserText.Text = "Text to engrave/print";
            // 
            // txbUserText
            // 
            this.txbUserText.Location = new System.Drawing.Point(63, 353);
            this.txbUserText.Multiline = true;
            this.txbUserText.Name = "txbUserText";
            this.txbUserText.Size = new System.Drawing.Size(249, 33);
            this.txbUserText.TabIndex = 7;
            // 
            // cbxHasLogo
            // 
            this.cbxHasLogo.AutoSize = true;
            this.cbxHasLogo.Location = new System.Drawing.Point(219, 404);
            this.cbxHasLogo.Name = "cbxHasLogo";
            this.cbxHasLogo.Size = new System.Drawing.Size(58, 19);
            this.cbxHasLogo.TabIndex = 8;
            this.cbxHasLogo.Text = "Logo?";
            this.cbxHasLogo.UseVisualStyleBackColor = true;
            this.cbxHasLogo.CheckedChanged += new System.EventHandler(this.cbxHasLogo_CheckedChanged);
            // 
            // lblNumColors
            // 
            this.lblNumColors.AutoSize = true;
            this.lblNumColors.Location = new System.Drawing.Point(63, 447);
            this.lblNumColors.Name = "lblNumColors";
            this.lblNumColors.Size = new System.Drawing.Size(100, 15);
            this.lblNumColors.TabIndex = 9;
            this.lblNumColors.Text = "Number of colors";
            // 
            // txbNumColors
            // 
            this.txbNumColors.Enabled = false;
            this.txbNumColors.Location = new System.Drawing.Point(215, 444);
            this.txbNumColors.Name = "txbNumColors";
            this.txbNumColors.Size = new System.Drawing.Size(100, 23);
            this.txbNumColors.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(92, 490);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(8, 8);
            this.btnGetInfo.TabIndex = 13;
            this.btnGetInfo.Text = "Get Order Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(63, 490);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 14;
            this.btnInfo.Text = "Get Order Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(63, 537);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.Size = new System.Drawing.Size(249, 72);
            this.txbResults.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 651);
            this.Controls.Add(this.txbResults);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txbNumColors);
            this.Controls.Add(this.lblNumColors);
            this.Controls.Add(this.cbxHasLogo);
            this.Controls.Add(this.txbUserText);
            this.Controls.Add(this.lblUserText);
            this.Controls.Add(this.gbxItemType);
            this.Controls.Add(this.txbNumberOfItems);
            this.Controls.Add(this.txbOrderNum);
            this.Controls.Add(this.lblNumberItems);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Logo Item Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxItemType.ResumeLayout(false);
            this.gbxItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblOrderNum;
        private Label lblNumberItems;
        private TextBox txbOrderNum;
        private TextBox txbNumberOfItems;
        private GroupBox gbxItemType;
        private RadioButton rbMug;
        private RadioButton rbPen;
        private RadioButton rbUSB;
        private Label lblUserText;
        private TextBox txbUserText;
        private CheckBox cbxHasLogo;
        private Label lblNumColors;
        private TextBox txbNumColors;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnGetInfo;
        private Button btnInfo;
        private TextBox txbResults;
    }
}