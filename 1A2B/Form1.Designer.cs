namespace _1A2B
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
            this.components = new System.ComponentModel.Container();
            this.answer_buttom = new System.Windows.Forms.Button();
            this.input_value = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Label();
            this.guess_button = new System.Windows.Forms.Button();
            this.angin_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Guess_richTextBox = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.難度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初級ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中級ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終極版未完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // answer_buttom
            // 
            this.answer_buttom.Location = new System.Drawing.Point(781, 429);
            this.answer_buttom.Margin = new System.Windows.Forms.Padding(4);
            this.answer_buttom.Name = "answer_buttom";
            this.answer_buttom.Size = new System.Drawing.Size(100, 29);
            this.answer_buttom.TabIndex = 0;
            this.answer_buttom.Text = "看答案";
            this.answer_buttom.UseVisualStyleBackColor = true;
            this.answer_buttom.Click += new System.EventHandler(this.answer_Click);
            // 
            // input_value
            // 
            this.input_value.Location = new System.Drawing.Point(345, 143);
            this.input_value.Margin = new System.Windows.Forms.Padding(4);
            this.input_value.Name = "input_value";
            this.input_value.Size = new System.Drawing.Size(132, 25);
            this.input_value.TabIndex = 2;
            this.input_value.TextChanged += new System.EventHandler(this.input_value_TextChanged);
            this.input_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_value_KeyPress);
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.show.Location = new System.Drawing.Point(703, 107);
            this.show.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(0, 48);
            this.show.TabIndex = 3;
            // 
            // guess_button
            // 
            this.guess_button.Enabled = false;
            this.guess_button.Location = new System.Drawing.Point(781, 218);
            this.guess_button.Margin = new System.Windows.Forms.Padding(4);
            this.guess_button.Name = "guess_button";
            this.guess_button.Size = new System.Drawing.Size(100, 29);
            this.guess_button.TabIndex = 4;
            this.guess_button.Text = "確定";
            this.guess_button.UseVisualStyleBackColor = true;
            this.guess_button.Click += new System.EventHandler(this.guess_button_Click);
            // 
            // angin_button
            // 
            this.angin_button.Location = new System.Drawing.Point(781, 311);
            this.angin_button.Margin = new System.Windows.Forms.Padding(4);
            this.angin_button.Name = "angin_button";
            this.angin_button.Size = new System.Drawing.Size(100, 29);
            this.angin_button.TabIndex = 5;
            this.angin_button.Text = "重玩";
            this.angin_button.UseVisualStyleBackColor = true;
            this.angin_button.Click += new System.EventHandler(this.angin_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(340, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Guess_richTextBox
            // 
            this.Guess_richTextBox.Location = new System.Drawing.Point(217, 201);
            this.Guess_richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guess_richTextBox.Name = "Guess_richTextBox";
            this.Guess_richTextBox.ReadOnly = true;
            this.Guess_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Guess_richTextBox.Size = new System.Drawing.Size(369, 407);
            this.Guess_richTextBox.TabIndex = 8;
            this.Guess_richTextBox.Text = "";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.難度ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(941, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 難度ToolStripMenuItem
            // 
            this.難度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初級ToolStripMenuItem,
            this.中級ToolStripMenuItem,
            this.終極版未完成ToolStripMenuItem});
            this.難度ToolStripMenuItem.Name = "難度ToolStripMenuItem";
            this.難度ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.難度ToolStripMenuItem.Text = "難度";
            // 
            // 初級ToolStripMenuItem
            // 
            this.初級ToolStripMenuItem.Name = "初級ToolStripMenuItem";
            this.初級ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.初級ToolStripMenuItem.Text = "初級";
            this.初級ToolStripMenuItem.Click += new System.EventHandler(this.初級ToolStripMenuItem_Click);
            // 
            // 中級ToolStripMenuItem
            // 
            this.中級ToolStripMenuItem.Name = "中級ToolStripMenuItem";
            this.中級ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.中級ToolStripMenuItem.Text = "中級";
            this.中級ToolStripMenuItem.Click += new System.EventHandler(this.中級ToolStripMenuItem_Click);
            // 
            // 終極版未完成ToolStripMenuItem
            // 
            this.終極版未完成ToolStripMenuItem.Name = "終極版未完成ToolStripMenuItem";
            this.終極版未完成ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.終極版未完成ToolStripMenuItem.Text = "終極版(未完成)";
            this.終極版未完成ToolStripMenuItem.Click += new System.EventHandler(this.終極版未完成ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 629);
            this.Controls.Add(this.Guess_richTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angin_button);
            this.Controls.Add(this.guess_button);
            this.Controls.Add(this.show);
            this.Controls.Add(this.input_value);
            this.Controls.Add(this.answer_buttom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "1A2B(第十組專題報告)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answer_buttom;
        private System.Windows.Forms.TextBox input_value;
        private System.Windows.Forms.Label show;
        private System.Windows.Forms.Button guess_button;
        private System.Windows.Forms.Button angin_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox Guess_richTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 難度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初級ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中級ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終極版未完成ToolStripMenuItem;
    }
}

