namespace 时间日期处理工具
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DateTimeOffsetText = new TextBox();
            GetDateTimeOffset = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            GetUtcDateTimeCopyButton = new Button();
            GetUtcDateTimeButton = new Button();
            GetUtcDateTimeResult = new TextBox();
            GetUtcDateTimeSource = new TextBox();
            groupBox3 = new GroupBox();
            GetDateTimeCopyButton = new Button();
            GetDateTimeButton = new Button();
            GetDateTimeResult = new TextBox();
            GetDateTimeSource = new TextBox();
            groupBox4 = new GroupBox();
            ToSecondsTimeStampCopyButton = new Button();
            ToSecondsTimeStampButton = new Button();
            ToSecondsTimeStampResu = new TextBox();
            ToSecondsTimeStampSource = new TextBox();
            groupBox5 = new GroupBox();
            ToMillisecondsTimeStampCopyButtom = new Button();
            ToMillisecondsTimeStampButton = new Button();
            ToMillisecondsTimeStampResult = new TextBox();
            ToMillisecondsTimeStampSource = new TextBox();
            groupBox6 = new GroupBox();
            TimeSpanCopyButtom = new Button();
            TimeSpanButton = new Button();
            TimeSpanResult = new TextBox();
            TimeSpanSource = new TextBox();
            groupBox7 = new GroupBox();
            TimeStampBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            TimeStampResult = new TextBox();
            TimeStampBox1 = new TextBox();
            groupBox8 = new GroupBox();
            label2 = new Label();
            GetTimeNow = new TextBox();
            GetTimeNowButtom = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // DateTimeOffsetText
            // 
            DateTimeOffsetText.Location = new Point(92, 16);
            DateTimeOffsetText.Name = "DateTimeOffsetText";
            DateTimeOffsetText.Size = new Size(100, 23);
            DateTimeOffsetText.TabIndex = 0;
            // 
            // GetDateTimeOffset
            // 
            GetDateTimeOffset.Location = new Point(198, 16);
            GetDateTimeOffset.Name = "GetDateTimeOffset";
            GetDateTimeOffset.Size = new Size(85, 23);
            GetDateTimeOffset.TabIndex = 1;
            GetDateTimeOffset.Text = "获取时间戳";
            GetDateTimeOffset.UseVisualStyleBackColor = true;
            GetDateTimeOffset.Click += GetDateTimeOffset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 2;
            label1.Text = "获取时间戳：";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DateTimeOffsetText);
            groupBox1.Controls.Add(GetDateTimeOffset);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 52);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GetUtcDateTimeCopyButton);
            groupBox2.Controls.Add(GetUtcDateTimeButton);
            groupBox2.Controls.Add(GetUtcDateTimeResult);
            groupBox2.Controls.Add(GetUtcDateTimeSource);
            groupBox2.Location = new Point(16, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = " 时间戳转为+00:00时区 日期格式  yyyy/MM/dd HH:mm:ss";
            // 
            // GetUtcDateTimeCopyButton
            // 
            GetUtcDateTimeCopyButton.Location = new Point(142, 67);
            GetUtcDateTimeCopyButton.Name = "GetUtcDateTimeCopyButton";
            GetUtcDateTimeCopyButton.Size = new Size(96, 23);
            GetUtcDateTimeCopyButton.TabIndex = 3;
            GetUtcDateTimeCopyButton.Text = "复制到剪切板";
            GetUtcDateTimeCopyButton.UseVisualStyleBackColor = true;
            GetUtcDateTimeCopyButton.Click += GetUtcDateTimeCopyButton_Click;
            // 
            // GetUtcDateTimeButton
            // 
            GetUtcDateTimeButton.Location = new Point(142, 38);
            GetUtcDateTimeButton.Name = "GetUtcDateTimeButton";
            GetUtcDateTimeButton.Size = new Size(96, 23);
            GetUtcDateTimeButton.TabIndex = 2;
            GetUtcDateTimeButton.Text = "转换";
            GetUtcDateTimeButton.UseVisualStyleBackColor = true;
            GetUtcDateTimeButton.Click += GetUtcDateTimeButton_Click;
            // 
            // GetUtcDateTimeResult
            // 
            GetUtcDateTimeResult.Location = new Point(10, 71);
            GetUtcDateTimeResult.Name = "GetUtcDateTimeResult";
            GetUtcDateTimeResult.Size = new Size(100, 23);
            GetUtcDateTimeResult.TabIndex = 1;
            // 
            // GetUtcDateTimeSource
            // 
            GetUtcDateTimeSource.Location = new Point(10, 38);
            GetUtcDateTimeSource.Name = "GetUtcDateTimeSource";
            GetUtcDateTimeSource.Size = new Size(100, 23);
            GetUtcDateTimeSource.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(GetDateTimeCopyButton);
            groupBox3.Controls.Add(GetDateTimeButton);
            groupBox3.Controls.Add(GetDateTimeResult);
            groupBox3.Controls.Add(GetDateTimeSource);
            groupBox3.Location = new Point(16, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(297, 100);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "时间戳转为本地日期格式 yyyy/MM/dd HH:mm:ss";
            // 
            // GetDateTimeCopyButton
            // 
            GetDateTimeCopyButton.Location = new Point(142, 67);
            GetDateTimeCopyButton.Name = "GetDateTimeCopyButton";
            GetDateTimeCopyButton.Size = new Size(96, 23);
            GetDateTimeCopyButton.TabIndex = 3;
            GetDateTimeCopyButton.Text = "复制到剪切板";
            GetDateTimeCopyButton.UseVisualStyleBackColor = true;
            GetDateTimeCopyButton.Click += GetDateTimeCopyButton_Click;
            // 
            // GetDateTimeButton
            // 
            GetDateTimeButton.Location = new Point(142, 38);
            GetDateTimeButton.Name = "GetDateTimeButton";
            GetDateTimeButton.Size = new Size(96, 23);
            GetDateTimeButton.TabIndex = 2;
            GetDateTimeButton.Text = "转换";
            GetDateTimeButton.UseVisualStyleBackColor = true;
            GetDateTimeButton.Click += GetDateTimeButton_Click;
            // 
            // GetDateTimeResult
            // 
            GetDateTimeResult.Location = new Point(10, 71);
            GetDateTimeResult.Name = "GetDateTimeResult";
            GetDateTimeResult.Size = new Size(100, 23);
            GetDateTimeResult.TabIndex = 1;
            // 
            // GetDateTimeSource
            // 
            GetDateTimeSource.Location = new Point(10, 38);
            GetDateTimeSource.Name = "GetDateTimeSource";
            GetDateTimeSource.Size = new Size(100, 23);
            GetDateTimeSource.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ToSecondsTimeStampCopyButton);
            groupBox4.Controls.Add(ToSecondsTimeStampButton);
            groupBox4.Controls.Add(ToSecondsTimeStampResu);
            groupBox4.Controls.Add(ToSecondsTimeStampSource);
            groupBox4.Location = new Point(16, 338);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(297, 100);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "日期转时间戳 ， 精确到秒";
            // 
            // ToSecondsTimeStampCopyButton
            // 
            ToSecondsTimeStampCopyButton.Location = new Point(142, 67);
            ToSecondsTimeStampCopyButton.Name = "ToSecondsTimeStampCopyButton";
            ToSecondsTimeStampCopyButton.Size = new Size(96, 23);
            ToSecondsTimeStampCopyButton.TabIndex = 3;
            ToSecondsTimeStampCopyButton.Text = "复制到剪切板";
            ToSecondsTimeStampCopyButton.UseVisualStyleBackColor = true;
            ToSecondsTimeStampCopyButton.Click += ToSecondsTimeStampCopyButton_Click;
            // 
            // ToSecondsTimeStampButton
            // 
            ToSecondsTimeStampButton.Location = new Point(142, 38);
            ToSecondsTimeStampButton.Name = "ToSecondsTimeStampButton";
            ToSecondsTimeStampButton.Size = new Size(96, 23);
            ToSecondsTimeStampButton.TabIndex = 2;
            ToSecondsTimeStampButton.Text = "转换";
            ToSecondsTimeStampButton.UseVisualStyleBackColor = true;
            ToSecondsTimeStampButton.Click += ToSecondsTimeStampButton_Click;
            // 
            // ToSecondsTimeStampResu
            // 
            ToSecondsTimeStampResu.Location = new Point(10, 71);
            ToSecondsTimeStampResu.Name = "ToSecondsTimeStampResu";
            ToSecondsTimeStampResu.Size = new Size(100, 23);
            ToSecondsTimeStampResu.TabIndex = 1;
            // 
            // ToSecondsTimeStampSource
            // 
            ToSecondsTimeStampSource.Location = new Point(10, 38);
            ToSecondsTimeStampSource.Name = "ToSecondsTimeStampSource";
            ToSecondsTimeStampSource.Size = new Size(100, 23);
            ToSecondsTimeStampSource.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ToMillisecondsTimeStampCopyButtom);
            groupBox5.Controls.Add(ToMillisecondsTimeStampButton);
            groupBox5.Controls.Add(ToMillisecondsTimeStampResult);
            groupBox5.Controls.Add(ToMillisecondsTimeStampSource);
            groupBox5.Location = new Point(345, 84);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(297, 100);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "日期转时间戳 ， 精确到毫秒";
            // 
            // ToMillisecondsTimeStampCopyButtom
            // 
            ToMillisecondsTimeStampCopyButtom.Location = new Point(142, 67);
            ToMillisecondsTimeStampCopyButtom.Name = "ToMillisecondsTimeStampCopyButtom";
            ToMillisecondsTimeStampCopyButtom.Size = new Size(96, 23);
            ToMillisecondsTimeStampCopyButtom.TabIndex = 3;
            ToMillisecondsTimeStampCopyButtom.Text = "复制到剪切板";
            ToMillisecondsTimeStampCopyButtom.UseVisualStyleBackColor = true;
            ToMillisecondsTimeStampCopyButtom.Click += ToMillisecondsTimeStampCopyButtom_Click;
            // 
            // ToMillisecondsTimeStampButton
            // 
            ToMillisecondsTimeStampButton.Location = new Point(142, 38);
            ToMillisecondsTimeStampButton.Name = "ToMillisecondsTimeStampButton";
            ToMillisecondsTimeStampButton.Size = new Size(96, 23);
            ToMillisecondsTimeStampButton.TabIndex = 2;
            ToMillisecondsTimeStampButton.Text = "转换";
            ToMillisecondsTimeStampButton.UseVisualStyleBackColor = true;
            ToMillisecondsTimeStampButton.Click += ToMillisecondsTimeStampButton_Click;
            // 
            // ToMillisecondsTimeStampResult
            // 
            ToMillisecondsTimeStampResult.Location = new Point(10, 71);
            ToMillisecondsTimeStampResult.Name = "ToMillisecondsTimeStampResult";
            ToMillisecondsTimeStampResult.Size = new Size(100, 23);
            ToMillisecondsTimeStampResult.TabIndex = 1;
            // 
            // ToMillisecondsTimeStampSource
            // 
            ToMillisecondsTimeStampSource.Location = new Point(10, 38);
            ToMillisecondsTimeStampSource.Name = "ToMillisecondsTimeStampSource";
            ToMillisecondsTimeStampSource.Size = new Size(100, 23);
            ToMillisecondsTimeStampSource.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(TimeSpanCopyButtom);
            groupBox6.Controls.Add(TimeSpanButton);
            groupBox6.Controls.Add(TimeSpanResult);
            groupBox6.Controls.Add(TimeSpanSource);
            groupBox6.Location = new Point(345, 211);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(297, 100);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "计算一个时间戳与当前时间的间隔";
            // 
            // TimeSpanCopyButtom
            // 
            TimeSpanCopyButtom.Location = new Point(142, 67);
            TimeSpanCopyButtom.Name = "TimeSpanCopyButtom";
            TimeSpanCopyButtom.Size = new Size(96, 23);
            TimeSpanCopyButtom.TabIndex = 3;
            TimeSpanCopyButtom.Text = "复制到剪切板";
            TimeSpanCopyButtom.UseVisualStyleBackColor = true;
            TimeSpanCopyButtom.Click += TimeSpanCopyButtom_Click;
            // 
            // TimeSpanButton
            // 
            TimeSpanButton.Location = new Point(142, 38);
            TimeSpanButton.Name = "TimeSpanButton";
            TimeSpanButton.Size = new Size(96, 23);
            TimeSpanButton.TabIndex = 2;
            TimeSpanButton.Text = "转换";
            TimeSpanButton.UseVisualStyleBackColor = true;
            TimeSpanButton.Click += TimeSpanButton_Click;
            // 
            // TimeSpanResult
            // 
            TimeSpanResult.Location = new Point(10, 71);
            TimeSpanResult.Name = "TimeSpanResult";
            TimeSpanResult.Size = new Size(100, 23);
            TimeSpanResult.TabIndex = 1;
            // 
            // TimeSpanSource
            // 
            TimeSpanSource.Location = new Point(10, 38);
            TimeSpanSource.Name = "TimeSpanSource";
            TimeSpanSource.Size = new Size(100, 23);
            TimeSpanSource.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(TimeStampBox2);
            groupBox7.Controls.Add(button1);
            groupBox7.Controls.Add(button2);
            groupBox7.Controls.Add(TimeStampResult);
            groupBox7.Controls.Add(TimeStampBox1);
            groupBox7.Location = new Point(345, 338);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(297, 100);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            groupBox7.Text = "计算两个时间戳的间隔";
            // 
            // TimeStampBox2
            // 
            TimeStampBox2.Location = new Point(10, 42);
            TimeStampBox2.Name = "TimeStampBox2";
            TimeStampBox2.Size = new Size(100, 23);
            TimeStampBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(142, 67);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 3;
            button1.Text = "复制到剪切板";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 38);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 2;
            button2.Text = "转换";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TimeStampResult
            // 
            TimeStampResult.Location = new Point(10, 71);
            TimeStampResult.Name = "TimeStampResult";
            TimeStampResult.Size = new Size(100, 23);
            TimeStampResult.TabIndex = 1;
            // 
            // TimeStampBox1
            // 
            TimeStampBox1.Location = new Point(10, 22);
            TimeStampBox1.Name = "TimeStampBox1";
            TimeStampBox1.Size = new Size(100, 23);
            TimeStampBox1.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label2);
            groupBox8.Controls.Add(GetTimeNow);
            groupBox8.Controls.Add(GetTimeNowButtom);
            groupBox8.Location = new Point(345, 12);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(301, 52);
            groupBox8.TabIndex = 4;
            groupBox8.TabStop = false;
            groupBox8.Text = "获取当前时间";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 16);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 2;
            label2.Text = "获取当前时间：";
            // 
            // GetTimeNow
            // 
            GetTimeNow.Location = new Point(102, 16);
            GetTimeNow.Name = "GetTimeNow";
            GetTimeNow.Size = new Size(100, 23);
            GetTimeNow.TabIndex = 0;
            // 
            // GetTimeNowButtom
            // 
            GetTimeNowButtom.Location = new Point(210, 16);
            GetTimeNowButtom.Name = "GetTimeNowButtom";
            GetTimeNowButtom.Size = new Size(91, 23);
            GetTimeNowButtom.TabIndex = 1;
            GetTimeNowButtom.Text = "获取当前时间";
            GetTimeNowButtom.UseVisualStyleBackColor = true;
            GetTimeNowButtom.Click += GetTimeNowButtom_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox DateTimeOffsetText;
        private Button GetDateTimeOffset;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button GetUtcDateTimeCopyButton;
        private Button GetUtcDateTimeButton;
        private TextBox GetUtcDateTimeResult;
        private TextBox GetUtcDateTimeSource;
        private GroupBox groupBox3;
        private Button GetDateTimeCopyButton;
        private Button GetDateTimeButton;
        private TextBox GetDateTimeResult;
        private TextBox GetDateTimeSource;
        private GroupBox groupBox4;
        private Button ToSecondsTimeStampCopyButton;
        private Button ToSecondsTimeStampButton;
        private TextBox ToSecondsTimeStampResu;
        private TextBox ToSecondsTimeStampSource;
        private GroupBox groupBox5;
        private Button ToMillisecondsTimeStampCopyButtom;
        private Button ToMillisecondsTimeStampButton;
        private TextBox ToMillisecondsTimeStampResult;
        private TextBox ToMillisecondsTimeStampSource;
        private GroupBox groupBox6;
        private Button TimeSpanCopyButtom;
        private Button TimeSpanButton;
        private TextBox TimeSpanResult;
        private TextBox TimeSpanSource;
        private GroupBox groupBox7;
        private Button button1;
        private Button button2;
        private TextBox TimeStampResult;
        private TextBox TimeStampBox1;
        private GroupBox groupBox8;
        private Label label2;
        private TextBox GetTimeNow;
        private Button GetTimeNowButtom;
        private TextBox TimeStampBox2;
    }
}