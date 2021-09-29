
namespace Exercise11 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btReadLine = new System.Windows.Forms.Button();
            this.btReadLines = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btButton
            // 
            this.btButton.Location = new System.Drawing.Point(48, 34);
            this.btButton.Name = "btButton";
            this.btButton.Size = new System.Drawing.Size(106, 46);
            this.btButton.TabIndex = 0;
            this.btButton.Text = "開く";
            this.btButton.UseVisualStyleBackColor = true;
            this.btButton.Click += new System.EventHandler(this.btButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(192, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "キーワード";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(194, 61);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(180, 19);
            this.tbKeyword.TabIndex = 2;
            // 
            // btReadLine
            // 
            this.btReadLine.Location = new System.Drawing.Point(424, 34);
            this.btReadLine.Name = "btReadLine";
            this.btReadLine.Size = new System.Drawing.Size(105, 46);
            this.btReadLine.TabIndex = 3;
            this.btReadLine.Text = "readline";
            this.btReadLine.UseVisualStyleBackColor = true;
            this.btReadLine.Click += new System.EventHandler(this.btReadLine_Click);
            // 
            // btReadLines
            // 
            this.btReadLines.Location = new System.Drawing.Point(578, 34);
            this.btReadLines.Name = "btReadLines";
            this.btReadLines.Size = new System.Drawing.Size(141, 24);
            this.btReadLines.TabIndex = 4;
            this.btReadLines.Text = "readlines";
            this.btReadLines.UseVisualStyleBackColor = true;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(98, 129);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(597, 19);
            this.tbOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btReadLines);
            this.Controls.Add(this.btReadLine);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btReadLine;
        private System.Windows.Forms.Button btReadLines;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

