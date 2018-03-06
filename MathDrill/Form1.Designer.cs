namespace MathDrill
{
    partial class MathDrill
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
            this.label1 = new System.Windows.Forms.Label();
            this.InBox = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MondaiLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minus_type = new System.Windows.Forms.RadioButton();
            this.plus_type = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thirty_questions = new System.Windows.Forms.RadioButton();
            this.twenty_questions = new System.Windows.Forms.RadioButton();
            this.ten_questions = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "答え";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InBox
            // 
            this.InBox.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InBox.Location = new System.Drawing.Point(94, 241);
            this.InBox.Name = "InBox";
            this.InBox.Size = new System.Drawing.Size(65, 29);
            this.InBox.TabIndex = 2;
            this.InBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InBox_KeyPress);
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(184, 134);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutBox.Size = new System.Drawing.Size(100, 136);
            this.OutBox.TabIndex = 3;
            // 
            // StartBtn
            // 
            this.StartBtn.AutoSize = true;
            this.StartBtn.Location = new System.Drawing.Point(16, 103);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(105, 28);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "開始";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MondaiLbl
            // 
            this.MondaiLbl.BackColor = System.Drawing.Color.White;
            this.MondaiLbl.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MondaiLbl.Location = new System.Drawing.Point(27, 134);
            this.MondaiLbl.Name = "MondaiLbl";
            this.MondaiLbl.Size = new System.Drawing.Size(105, 73);
            this.MondaiLbl.TabIndex = 5;
            this.MondaiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minus_type);
            this.groupBox1.Controls.Add(this.plus_type);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 33);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "タイプ";
            // 
            // minus_type
            // 
            this.minus_type.AutoSize = true;
            this.minus_type.Location = new System.Drawing.Point(68, 11);
            this.minus_type.Name = "minus_type";
            this.minus_type.Size = new System.Drawing.Size(56, 16);
            this.minus_type.TabIndex = 1;
            this.minus_type.Text = "引き算";
            this.minus_type.UseVisualStyleBackColor = true;
            // 
            // plus_type
            // 
            this.plus_type.AutoSize = true;
            this.plus_type.Checked = true;
            this.plus_type.Location = new System.Drawing.Point(6, 11);
            this.plus_type.Name = "plus_type";
            this.plus_type.Size = new System.Drawing.Size(56, 16);
            this.plus_type.TabIndex = 0;
            this.plus_type.TabStop = true;
            this.plus_type.Text = "足し算";
            this.plus_type.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thirty_questions);
            this.groupBox2.Controls.Add(this.twenty_questions);
            this.groupBox2.Controls.Add(this.ten_questions);
            this.groupBox2.Location = new System.Drawing.Point(16, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "問題数";
            // 
            // thirty_questions
            // 
            this.thirty_questions.AutoSize = true;
            this.thirty_questions.Location = new System.Drawing.Point(111, 18);
            this.thirty_questions.Name = "thirty_questions";
            this.thirty_questions.Size = new System.Drawing.Size(47, 16);
            this.thirty_questions.TabIndex = 4;
            this.thirty_questions.Text = "30問";
            this.thirty_questions.UseVisualStyleBackColor = true;
            // 
            // twenty_questions
            // 
            this.twenty_questions.AutoSize = true;
            this.twenty_questions.Location = new System.Drawing.Point(58, 18);
            this.twenty_questions.Name = "twenty_questions";
            this.twenty_questions.Size = new System.Drawing.Size(47, 16);
            this.twenty_questions.TabIndex = 3;
            this.twenty_questions.Text = "20問";
            this.twenty_questions.UseVisualStyleBackColor = true;
            // 
            // ten_questions
            // 
            this.ten_questions.AutoSize = true;
            this.ten_questions.Checked = true;
            this.ten_questions.Location = new System.Drawing.Point(6, 18);
            this.ten_questions.Name = "ten_questions";
            this.ten_questions.Size = new System.Drawing.Size(47, 16);
            this.ten_questions.TabIndex = 2;
            this.ten_questions.TabStop = true;
            this.ten_questions.Text = "10問";
            this.ten_questions.UseVisualStyleBackColor = true;
            // 
            // MathDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MondaiLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.InBox);
            this.Controls.Add(this.label1);
            this.Name = "MathDrill";
            this.Text = "算数ドリル";
            this.Load += new System.EventHandler(this.MathDrill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label MondaiLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton minus_type;
        private System.Windows.Forms.RadioButton plus_type;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton thirty_questions;
        private System.Windows.Forms.RadioButton twenty_questions;
        private System.Windows.Forms.RadioButton ten_questions;

    }
}

