namespace CycNumExpress
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.changeBtn = new System.Windows.Forms.Button();
            this.cirNumTBox = new System.Windows.Forms.TextBox();
            this.fracTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(133, 230);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(130, 45);
            this.changeBtn.TabIndex = 0;
            this.changeBtn.Text = "转换";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.change);
            // 
            // cirNumTBox
            // 
            this.cirNumTBox.Location = new System.Drawing.Point(93, 79);
            this.cirNumTBox.Name = "cirNumTBox";
            this.cirNumTBox.Size = new System.Drawing.Size(222, 28);
            this.cirNumTBox.TabIndex = 1;
            // 
            // fracTBox
            // 
            this.fracTBox.Location = new System.Drawing.Point(93, 163);
            this.fracTBox.Name = "fracTBox";
            this.fracTBox.ReadOnly = true;
            this.fracTBox.Size = new System.Drawing.Size(222, 28);
            this.fracTBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "小数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "分数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fracTBox);
            this.Controls.Add(this.cirNumTBox);
            this.Controls.Add(this.changeBtn);
            this.Name = "Form1";
            this.Text = "循环小数表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.TextBox cirNumTBox;
        private System.Windows.Forms.TextBox fracTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

