namespace DateTimeSample {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.btNow = new System.Windows.Forms.Button();
            this.tbNowDisp = new System.Windows.Forms.TextBox();
            this.nudDayBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tbDayBeforeAfter = new System.Windows.Forms.TextBox();
            this.nudMonthBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUruu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBirthDays = new System.Windows.Forms.TextBox();
            this.btBirthDays = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btFireWrite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // btNow
            // 
            this.btNow.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNow.Location = new System.Drawing.Point(70, 88);
            this.btNow.Name = "btNow";
            this.btNow.Size = new System.Drawing.Size(152, 39);
            this.btNow.TabIndex = 0;
            this.btNow.Text = "現在時刻";
            this.btNow.UseVisualStyleBackColor = true;
            this.btNow.Click += new System.EventHandler(this.btNow_Click);
            // 
            // tbNowDisp
            // 
            this.tbNowDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNowDisp.Location = new System.Drawing.Point(228, 88);
            this.tbNowDisp.Name = "tbNowDisp";
            this.tbNowDisp.Size = new System.Drawing.Size(462, 39);
            this.tbNowDisp.TabIndex = 1;
            // 
            // nudDayBeforeAfter
            // 
            this.nudDayBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.nudDayBeforeAfter.Location = new System.Drawing.Point(428, 160);
            this.nudDayBeforeAfter.Name = "nudDayBeforeAfter";
            this.nudDayBeforeAfter.Size = new System.Drawing.Size(120, 39);
            this.nudDayBeforeAfter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label1.Location = new System.Drawing.Point(554, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "日";
            // 
            // btBefore
            // 
            this.btBefore.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.btBefore.Location = new System.Drawing.Point(364, 216);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(120, 38);
            this.btBefore.TabIndex = 4;
            this.btBefore.Text = "前";
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.btAfter.Location = new System.Drawing.Point(511, 216);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(120, 38);
            this.btAfter.TabIndex = 4;
            this.btAfter.Text = "後";
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click);
            // 
            // tbDayBeforeAfter
            // 
            this.tbDayBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayBeforeAfter.Location = new System.Drawing.Point(228, 278);
            this.tbDayBeforeAfter.Name = "tbDayBeforeAfter";
            this.tbDayBeforeAfter.Size = new System.Drawing.Size(462, 39);
            this.tbDayBeforeAfter.TabIndex = 1;
            // 
            // nudMonthBeforeAfter
            // 
            this.nudMonthBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.nudMonthBeforeAfter.Location = new System.Drawing.Point(228, 160);
            this.nudMonthBeforeAfter.Name = "nudMonthBeforeAfter";
            this.nudMonthBeforeAfter.Size = new System.Drawing.Size(120, 39);
            this.nudMonthBeforeAfter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label2.Location = new System.Drawing.Point(354, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ヶ月";
            // 
            // tbUruu
            // 
            this.tbUruu.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUruu.Location = new System.Drawing.Point(228, 323);
            this.tbUruu.Name = "tbUruu";
            this.tbUruu.Size = new System.Drawing.Size(462, 39);
            this.tbUruu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label3.Location = new System.Drawing.Point(79, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "誕生日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label7.Location = new System.Drawing.Point(312, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "生まれてから";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label8.Location = new System.Drawing.Point(749, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "日目です";
            // 
            // tbBirthDays
            // 
            this.tbBirthDays.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBirthDays.Location = new System.Drawing.Point(486, 543);
            this.tbBirthDays.Name = "tbBirthDays";
            this.tbBirthDays.Size = new System.Drawing.Size(257, 39);
            this.tbBirthDays.TabIndex = 1;
            // 
            // btBirthDays
            // 
            this.btBirthDays.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.btBirthDays.Location = new System.Drawing.Point(95, 531);
            this.btBirthDays.Name = "btBirthDays";
            this.btBirthDays.Size = new System.Drawing.Size(173, 62);
            this.btBirthDays.TabIndex = 4;
            this.btBirthDays.Text = "日数計算";
            this.btBirthDays.UseVisualStyleBackColor = true;
            this.btBirthDays.Click += new System.EventHandler(this.btBirthDays_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(718, 323);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(117, 39);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label9.Location = new System.Drawing.Point(79, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "閏年判定";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(280, 374);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btFireWrite
            // 
            this.btFireWrite.Location = new System.Drawing.Point(656, 424);
            this.btFireWrite.Name = "btFireWrite";
            this.btFireWrite.Size = new System.Drawing.Size(75, 23);
            this.btFireWrite.TabIndex = 7;
            this.btFireWrite.Text = "button1";
            this.btFireWrite.UseVisualStyleBackColor = true;
            this.btFireWrite.Click += new System.EventHandler(this.btFireWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 652);
            this.Controls.Add(this.btFireWrite);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btBirthDays);
            this.Controls.Add(this.btAfter);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMonthBeforeAfter);
            this.Controls.Add(this.nudDayBeforeAfter);
            this.Controls.Add(this.tbBirthDays);
            this.Controls.Add(this.tbUruu);
            this.Controls.Add(this.tbDayBeforeAfter);
            this.Controls.Add(this.tbNowDisp);
            this.Controls.Add(this.btNow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNow;
        private System.Windows.Forms.TextBox tbNowDisp;
        private System.Windows.Forms.NumericUpDown nudDayBeforeAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.TextBox tbDayBeforeAfter;
        private System.Windows.Forms.NumericUpDown nudMonthBeforeAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUruu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBirthDays;
        private System.Windows.Forms.Button btBirthDays;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btFireWrite;
    }
}

