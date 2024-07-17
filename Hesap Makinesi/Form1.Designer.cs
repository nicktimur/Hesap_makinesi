namespace Hesap_Makinesi
{
    partial class HesapMakinesi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainScreen = new System.Windows.Forms.TextBox();
            this.PrevScreen = new System.Windows.Forms.TextBox();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_comma = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_bracket_on = new System.Windows.Forms.Button();
            this.btn_bracked_off = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainScreen
            // 
            this.mainScreen.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainScreen.Location = new System.Drawing.Point(26, 70);
            this.mainScreen.MaxLength = 16;
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.ReadOnly = true;
            this.mainScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainScreen.Size = new System.Drawing.Size(452, 50);
            this.mainScreen.TabIndex = 0;
            this.mainScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PrevScreen
            // 
            this.PrevScreen.Enabled = false;
            this.PrevScreen.Location = new System.Drawing.Point(265, 42);
            this.PrevScreen.Name = "PrevScreen";
            this.PrevScreen.ReadOnly = true;
            this.PrevScreen.Size = new System.Drawing.Size(213, 22);
            this.PrevScreen.TabIndex = 1;
            this.PrevScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_seven
            // 
            this.btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_seven.Location = new System.Drawing.Point(26, 243);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(75, 72);
            this.btn_seven.TabIndex = 2;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_8.Location = new System.Drawing.Point(147, 243);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 72);
            this.btn_8.TabIndex = 3;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_9.Location = new System.Drawing.Point(265, 243);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 72);
            this.btn_9.TabIndex = 4;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_mul
            // 
            this.btn_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mul.Location = new System.Drawing.Point(382, 243);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(75, 72);
            this.btn_mul.TabIndex = 5;
            this.btn_mul.Text = "x";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_four
            // 
            this.btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_four.Location = new System.Drawing.Point(26, 347);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(75, 72);
            this.btn_four.TabIndex = 6;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_five
            // 
            this.btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_five.Location = new System.Drawing.Point(147, 347);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(75, 72);
            this.btn_five.TabIndex = 7;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_six
            // 
            this.btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_six.Location = new System.Drawing.Point(265, 347);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(75, 72);
            this.btn_six.TabIndex = 8;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_minus.Location = new System.Drawing.Point(382, 347);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 72);
            this.btn_minus.TabIndex = 9;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_one
            // 
            this.btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_one.Location = new System.Drawing.Point(26, 452);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(75, 72);
            this.btn_one.TabIndex = 10;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_two.Location = new System.Drawing.Point(147, 452);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(75, 72);
            this.btn_two.TabIndex = 11;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_three
            // 
            this.btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_three.Location = new System.Drawing.Point(265, 452);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(75, 72);
            this.btn_three.TabIndex = 12;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_plus.Location = new System.Drawing.Point(382, 452);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 72);
            this.btn_plus.TabIndex = 13;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_zero.Location = new System.Drawing.Point(147, 555);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(75, 72);
            this.btn_zero.TabIndex = 15;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_comma
            // 
            this.btn_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_comma.Location = new System.Drawing.Point(265, 555);
            this.btn_comma.Name = "btn_comma";
            this.btn_comma.Size = new System.Drawing.Size(75, 72);
            this.btn_comma.TabIndex = 16;
            this.btn_comma.Text = ".";
            this.btn_comma.UseVisualStyleBackColor = true;
            this.btn_comma.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_equal.Location = new System.Drawing.Point(382, 555);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 72);
            this.btn_equal.TabIndex = 17;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_div.Location = new System.Drawing.Point(382, 146);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 72);
            this.btn_div.TabIndex = 18;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_ac
            // 
            this.btn_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ac.Location = new System.Drawing.Point(26, 146);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(75, 72);
            this.btn_ac.TabIndex = 21;
            this.btn_ac.Text = "AC";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_bracket_on
            // 
            this.btn_bracket_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bracket_on.Location = new System.Drawing.Point(147, 146);
            this.btn_bracket_on.Name = "btn_bracket_on";
            this.btn_bracket_on.Size = new System.Drawing.Size(75, 72);
            this.btn_bracket_on.TabIndex = 22;
            this.btn_bracket_on.UseVisualStyleBackColor = true;
            this.btn_bracket_on.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_bracked_off
            // 
            this.btn_bracked_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bracked_off.Location = new System.Drawing.Point(265, 146);
            this.btn_bracked_off.Name = "btn_bracked_off";
            this.btn_bracked_off.Size = new System.Drawing.Size(75, 72);
            this.btn_bracked_off.TabIndex = 23;
            this.btn_bracked_off.UseVisualStyleBackColor = true;
            this.btn_bracked_off.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_return.Location = new System.Drawing.Point(26, 555);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 72);
            this.btn_return.TabIndex = 24;
            this.btn_return.Text = "⏎";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 657);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_bracked_off);
            this.Controls.Add(this.btn_bracket_on);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_comma);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.PrevScreen);
            this.Controls.Add(this.mainScreen);
            this.Name = "HesapMakinesi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainScreen;
        private System.Windows.Forms.TextBox PrevScreen;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_comma;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Button btn_bracket_on;
        private System.Windows.Forms.Button btn_bracked_off;
        private System.Windows.Forms.Button btn_return;
    }
}

