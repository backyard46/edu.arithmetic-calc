namespace ArithmeticCalc
{
    partial class ArithmeticCalc
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.TextValue1 = new System.Windows.Forms.TextBox();
            this.TextValue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextAnswer = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSub = new System.Windows.Forms.Button();
            this.ButtonMult = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextValue1
            // 
            this.TextValue1.Location = new System.Drawing.Point(8, 8);
            this.TextValue1.Name = "TextValue1";
            this.TextValue1.Size = new System.Drawing.Size(96, 27);
            this.TextValue1.TabIndex = 0;
            // 
            // TextValue2
            // 
            this.TextValue2.Location = new System.Drawing.Point(200, 8);
            this.TextValue2.Name = "TextValue2";
            this.TextValue2.Size = new System.Drawing.Size(96, 27);
            this.TextValue2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // TextAnswer
            // 
            this.TextAnswer.Location = new System.Drawing.Point(328, 8);
            this.TextAnswer.Name = "TextAnswer";
            this.TextAnswer.Size = new System.Drawing.Size(96, 27);
            this.TextAnswer.TabIndex = 3;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(112, 5);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(80, 32);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "＋";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonSub
            // 
            this.ButtonSub.Location = new System.Drawing.Point(112, 40);
            this.ButtonSub.Name = "ButtonSub";
            this.ButtonSub.Size = new System.Drawing.Size(80, 32);
            this.ButtonSub.TabIndex = 5;
            this.ButtonSub.Text = "－";
            this.ButtonSub.UseVisualStyleBackColor = true;
            this.ButtonSub.Click += new System.EventHandler(this.ButtonSub_Click);
            // 
            // ButtonMult
            // 
            this.ButtonMult.Location = new System.Drawing.Point(112, 75);
            this.ButtonMult.Name = "ButtonMult";
            this.ButtonMult.Size = new System.Drawing.Size(80, 32);
            this.ButtonMult.TabIndex = 6;
            this.ButtonMult.Text = "×";
            this.ButtonMult.UseVisualStyleBackColor = true;
            this.ButtonMult.Click += new System.EventHandler(this.ButtonMult_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Location = new System.Drawing.Point(112, 110);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(80, 32);
            this.ButtonDiv.TabIndex = 7;
            this.ButtonDiv.Text = "÷";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // ArithmeticCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 150);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.ButtonMult);
            this.Controls.Add(this.ButtonSub);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextValue2);
            this.Controls.Add(this.TextValue1);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArithmeticCalc";
            this.Text = "算術演算サンプル";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextValue1;
        private System.Windows.Forms.TextBox TextValue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAnswer;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSub;
        private System.Windows.Forms.Button ButtonMult;
        private System.Windows.Forms.Button ButtonDiv;
    }
}

