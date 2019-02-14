using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool kontrol;
            Mutex mutex = new Mutex(true, "WinForm", out kontrol); //Örnek Mutex nesnesi oluşturalım. 
            if (kontrol == false)
            {
                if (args.Length == 0)
                {
                    return;
                }
                if (args[0] == "bunuyap")
                {
                    NativeMethods.PostMessage(
               (IntPtr)NativeMethods.HWND_BROADCAST,
               NativeMethods.BUNUYAP,
               IntPtr.Zero,
               IntPtr.Zero);
                    return;
                }
                else if (args[0] == "sunuyap")
                {
                    NativeMethods.PostMessage(
               (IntPtr)NativeMethods.HWND_BROADCAST,
               NativeMethods.YADABUNU,
               IntPtr.Zero,
               IntPtr.Zero);
                    return;
                }
                else if (args[0] == "butonabas")
                {
                    NativeMethods.PostMessage(
               (IntPtr)NativeMethods.HWND_BROADCAST,
               NativeMethods.BUTONABAS,
               IntPtr.Zero,
               IntPtr.Zero);
                    return;
                }
                return;
            }
               
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            GC.KeepAlive(mutex);

        }
        internal class NativeMethods
        {
            public const int HWND_BROADCAST = 0xffff;
            
            public static readonly int BUNUYAP = RegisterWindowMessage("BUNUYAP");
            public static readonly int YADABUNU = RegisterWindowMessage("YADABUNU");
            public static readonly int BUTONABAS = RegisterWindowMessage("BUTONABAS");
            [DllImport("user32")]
            public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
            [DllImport("user32")]
            public static extern int RegisterWindowMessage(string message);
        }
    }
}
