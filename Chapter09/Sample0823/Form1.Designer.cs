
namespace Sample0823
{
    partial class Form1
    {
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
            if (disposing && (components != null))
            {
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
            this.Jyou = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Exec = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Jyou
            // 
            this.Jyou.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Jyou.Location = new System.Drawing.Point(207, 12);
            this.Jyou.Multiline = true;
            this.Jyou.Name = "Jyou";
            this.Jyou.Size = new System.Drawing.Size(127, 53);
            this.Jyou.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "の";
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Value.Location = new System.Drawing.Point(12, 12);
            this.Value.Multiline = true;
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(127, 53);
            this.Value.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(340, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "乗";
            // 
            // Exec
            // 
            this.Exec.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Exec.Location = new System.Drawing.Point(408, 16);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(160, 52);
            this.Exec.TabIndex = 2;
            this.Exec.Text = "結果→";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.Exec_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Result.Location = new System.Drawing.Point(593, 16);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(184, 52);
            this.Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Jyou);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Jyou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.TextBox Result;
    }
}

