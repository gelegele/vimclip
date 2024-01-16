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
            // To prevent double startup
            Mutex mutex = new Mutex(false, "vimclip");
            if (!mutex.WaitOne(0, false))
            {
                return;
            }

            ApplicationConfiguration.Initialize();
            CreateTasktrayIcon();
            Application.Run(new Form1());
        }

        /// <summary>
        /// Show tasktray icon as a background app
        /// </summary>
        private static void CreateTasktrayIcon()
        {
            var icon = new NotifyIcon();
            icon.Icon = new Icon("Icon.ico");
            icon.Text = "vimclip";
            icon.ContextMenuStrip = CreateTasktrayContextMenu();
            icon.Visible = true;
        }

        /// <summary>
        /// Create context menu on tasktray
        /// </summary>
        /// <returns></returns>
        private static ContextMenuStrip CreateTasktrayContextMenu()
        {
            var menu = new ContextMenuStrip();
            menu.Items.Add("Exit", null, (s, e) => {
                Application.Exit();
            });
            return menu;
        }
    }
}