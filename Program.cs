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
        /// �풓�A�v���Ƃ��ă^�X�N�g���C�A�C�R����\������
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