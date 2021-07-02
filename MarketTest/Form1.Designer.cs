
namespace MarketTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxItem = new System.Windows.Forms.ListBox();
            this.cboxItem = new System.Windows.Forms.ComboBox();
            this.lbThing = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.cboxRate = new System.Windows.Forms.ComboBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btn = new System.Windows.Forms.Button();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxErrorMsg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxItem
            // 
            this.lboxItem.FormattingEnabled = true;
            this.lboxItem.ItemHeight = 12;
            this.lboxItem.Location = new System.Drawing.Point(23, 19);
            this.lboxItem.Name = "lboxItem";
            this.lboxItem.Size = new System.Drawing.Size(417, 256);
            this.lboxItem.TabIndex = 0;
            // 
            // cboxItem
            // 
            this.cboxItem.FormattingEnabled = true;
            this.cboxItem.Location = new System.Drawing.Point(481, 36);
            this.cboxItem.Name = "cboxItem";
            this.cboxItem.Size = new System.Drawing.Size(147, 20);
            this.cboxItem.TabIndex = 1;
            // 
            // lbThing
            // 
            this.lbThing.AutoSize = true;
            this.lbThing.Location = new System.Drawing.Point(484, 21);
            this.lbThing.Name = "lbThing";
            this.lbThing.Size = new System.Drawing.Size(29, 12);
            this.lbThing.TabIndex = 2;
            this.lbThing.Text = "물건";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(484, 74);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(41, 12);
            this.lbDiscount.TabIndex = 3;
            this.lbDiscount.Text = "할인률";
            // 
            // cboxRate
            // 
            this.cboxRate.FormattingEnabled = true;
            this.cboxRate.Location = new System.Drawing.Point(481, 89);
            this.cboxRate.Name = "cboxRate";
            this.cboxRate.Size = new System.Drawing.Size(147, 20);
            this.cboxRate.TabIndex = 4;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(484, 130);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(29, 12);
            this.lbCount.TabIndex = 5;
            this.lbCount.Text = "개수";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(481, 154);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(147, 21);
            this.numCount.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(481, 208);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(147, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "담기";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(23, 281);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(242, 21);
            this.tboxResult.TabIndex = 8;
            // 
            // tboxErrorMsg
            // 
            this.tboxErrorMsg.Location = new System.Drawing.Point(23, 324);
            this.tboxErrorMsg.Name = "tboxErrorMsg";
            this.tboxErrorMsg.Size = new System.Drawing.Size(604, 21);
            this.tboxErrorMsg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 375);
            this.Controls.Add(this.tboxErrorMsg);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.cboxRate);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbThing);
            this.Controls.Add(this.cboxItem);
            this.Controls.Add(this.lboxItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxItem;
        private System.Windows.Forms.ComboBox cboxItem;
        private System.Windows.Forms.Label lbThing;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.ComboBox cboxRate;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxErrorMsg;
    }
}

