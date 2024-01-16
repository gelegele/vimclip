namespace vimclip
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            CreateTasktrayIcon();
            Application.Run(new Form1());
        }

        /// <summary>
        /// 常駐アプリとしてタスクトレイアイコンを表示する
        /// </summary>
        private static void CreateTasktrayIcon()
        {
            var icon = new NotifyIcon();
            icon.Icon = new Icon("Icon.ico");
            icon.Text = "vimclip";
            icon.Visible = true;
        }
    }
}