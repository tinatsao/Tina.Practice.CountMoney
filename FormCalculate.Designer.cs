namespace Tina.Practice.CountMoney
{
    partial class FormCalculate
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTotal.Location = new System.Drawing.Point(31, 31);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(77, 25);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "總金額:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTotal.Location = new System.Drawing.Point(107, 31);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(210, 34);
            this.textBoxTotal.TabIndex = 1;
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNumberOfPeople.Location = new System.Drawing.Point(51, 108);
            this.labelNumberOfPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(57, 25);
            this.labelNumberOfPeople.TabIndex = 2;
            this.labelNumberOfPeople.Text = "人數:";
            this.labelNumberOfPeople.UseMnemonic = false;
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPeople.Location = new System.Drawing.Point(107, 108);
            this.textBoxPeople.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(210, 34);
            this.textBoxPeople.TabIndex = 3;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTip.Location = new System.Drawing.Point(51, 185);
            this.labelTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(57, 25);
            this.labelTip.TabIndex = 2;
            this.labelTip.Text = "小費:";
            // 
            // textBoxTip
            // 
            this.textBoxTip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTip.Location = new System.Drawing.Point(107, 179);
            this.textBoxTip.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(210, 34);
            this.textBoxTip.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCalculate.Location = new System.Drawing.Point(217, 261);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 33);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "計算";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxResult.Location = new System.Drawing.Point(349, 31);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(376, 263);
            this.textBoxResult.TabIndex = 5;
            // 
            // FormCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 325);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxPeople);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelNumberOfPeople);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCalculate";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelNumberOfPeople;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

