
namespace Linq薪資排序查詢_2_
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSortIncrease = new System.Windows.Forms.Button();
            this.btnSortDecrease = new System.Windows.Forms.Button();
            this.btnGreater30000 = new System.Windows.Forms.Button();
            this.btnSmaller30000 = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.員工薪資列表 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 162);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(167, 177);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSortIncrease
            // 
            this.btnSortIncrease.Location = new System.Drawing.Point(434, 133);
            this.btnSortIncrease.Name = "btnSortIncrease";
            this.btnSortIncrease.Size = new System.Drawing.Size(115, 23);
            this.btnSortIncrease.TabIndex = 2;
            this.btnSortIncrease.Text = "遞增排序";
            this.btnSortIncrease.UseVisualStyleBackColor = true;
            this.btnSortIncrease.Click += new System.EventHandler(this.btnSortIncrease_Click);
            // 
            // btnSortDecrease
            // 
            this.btnSortDecrease.Location = new System.Drawing.Point(434, 203);
            this.btnSortDecrease.Name = "btnSortDecrease";
            this.btnSortDecrease.Size = new System.Drawing.Size(115, 23);
            this.btnSortDecrease.TabIndex = 3;
            this.btnSortDecrease.Text = "遞減排序";
            this.btnSortDecrease.UseVisualStyleBackColor = true;
            this.btnSortDecrease.Click += new System.EventHandler(this.btnSortDecrease_Click);
            // 
            // btnGreater30000
            // 
            this.btnGreater30000.Location = new System.Drawing.Point(434, 243);
            this.btnGreater30000.Name = "btnGreater30000";
            this.btnGreater30000.Size = new System.Drawing.Size(115, 23);
            this.btnGreater30000.TabIndex = 4;
            this.btnGreater30000.Text = "大於30000";
            this.btnGreater30000.UseVisualStyleBackColor = true;
            this.btnGreater30000.Click += new System.EventHandler(this.btnGreater30000_Click);
            // 
            // btnSmaller30000
            // 
            this.btnSmaller30000.Location = new System.Drawing.Point(434, 284);
            this.btnSmaller30000.Name = "btnSmaller30000";
            this.btnSmaller30000.Size = new System.Drawing.Size(115, 23);
            this.btnSmaller30000.TabIndex = 5;
            this.btnSmaller30000.Text = "小於等於30000";
            this.btnSmaller30000.UseVisualStyleBackColor = true;
            this.btnSmaller30000.Click += new System.EventHandler(this.btnSmaller30000_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(434, 336);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(115, 23);
            this.btnAvg.TabIndex = 6;
            this.btnAvg.Text = "平均薪資";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // 員工薪資列表
            // 
            this.員工薪資列表.AutoSize = true;
            this.員工薪資列表.Location = new System.Drawing.Point(60, 92);
            this.員工薪資列表.Name = "員工薪資列表";
            this.員工薪資列表.Size = new System.Drawing.Size(97, 15);
            this.員工薪資列表.TabIndex = 7;
            this.員工薪資列表.Text = "員工薪資列表";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.員工薪資列表);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnSmaller30000);
            this.Controls.Add(this.btnGreater30000);
            this.Controls.Add(this.btnSortDecrease);
            this.Controls.Add(this.btnSortIncrease);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSortIncrease;
        private System.Windows.Forms.Button btnSortDecrease;
        private System.Windows.Forms.Button btnGreater30000;
        private System.Windows.Forms.Button btnSmaller30000;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Label 員工薪資列表;
    }
}

