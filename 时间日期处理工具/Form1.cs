namespace 时间日期处理工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetDateTimeOffset_Click(object sender, EventArgs e)
        {
            DateTimeOffsetText.Text = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
            Clipboard.SetText(DateTimeOffsetText.Text);
        }

        private void GetTimeNowButtom_Click(object sender, EventArgs e)
        {
            GetTimeNow.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            Clipboard.SetText(GetTimeNow.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  时间戳转为+00:00时区 日期格式  yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <returns></returns>
        private void GetUtcDateTimeButton_Click(object sender, EventArgs e)
        {
            GetUtcDateTimeResult.Text = TimeTool.GetUtcDateTime(GetUtcDateTimeSource.Text).ToString();
        }
        private void GetUtcDateTimeCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetUtcDateTimeResult.Text);
        }

        /// <summary>
        ///  时间戳转为本地日期格式 yyyy/MM/dd HH:mm:ss
        /// </summary>
        private void GetDateTimeButton_Click(object sender, EventArgs e)
        {
            GetDateTimeResult.Text = TimeTool.GetDateTime(GetDateTimeSource.Text).ToString();
        }

        private void GetDateTimeCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetDateTimeResult.Text);
        }


        /// <summary>
        /// 日期转时间戳 ， 精确到秒
        /// </summary>
        /// <returns></returns>
        private void ToSecondsTimeStampButton_Click(object sender, EventArgs e)
        {
            try
            {
                ToSecondsTimeStampResu.Text = TimeTool.ToSecondsTimeStamp(Convert.ToDateTime(ToSecondsTimeStampSource.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("输入的时间格式不正确，请重新输入！");
                ToMillisecondsTimeStampSource.Text = "";
                return;
            }
        }

        private void ToSecondsTimeStampCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ToSecondsTimeStampResu.Text);
        }


        /// <summary>
        /// 日期转时间戳 ， 精确到毫秒
        /// </summary>
        /// <returns></returns>
        private void ToMillisecondsTimeStampButton_Click(object sender, EventArgs e)
        {
            try
            {
                ToMillisecondsTimeStampResult.Text = TimeTool.ToMillisecondsTimeStamp(Convert.ToDateTime(ToMillisecondsTimeStampSource.Text));
            }
            catch (FormatException)
            {
                ToMillisecondsTimeStampSource.Text = "";
                return;
            }

        }

        private void ToMillisecondsTimeStampCopyButtom_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ToMillisecondsTimeStampResult.Text);
        }

        /// <summary>
        /// 计算一个时间戳与当前时间的间隔
        /// </summary>
        private void TimeSpanButton_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan timeSpan = new TimeSpan(Convert.ToInt32(Convert.ToString(TimeSpanSource.Text)));
                TimeSpanResult.Text = TimeTool.GetTimeSpan(TimeSpanSource.Text).ToString();
            }
            catch (Exception)
            {
                TimeSpanSource.Text = "";
                TimeSpanResult.Text = "";
                return;
            }
        }

        private void TimeSpanCopyButtom_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TimeSpanResult.Text);
        }

        /// <summary>
        /// 计算两个时间戳的间隔
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TimeStampResult.Text = TimeTool.GetTwoTimeSpan(TimeStampBox1.Text, TimeStampBox2.Text).ToString();
            }
            catch (Exception)
            {
                TimeStampResult.Text = "";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TimeStampResult.Text);
        }
    }
}