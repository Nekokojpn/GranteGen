using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GranteGen
{
    public partial class MainWindow : Window
    {
        #region デバッグ用メッセージ
        void a(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(debtext + "\r\n");
        }
        void a_ly()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("*" + "\r\n");
        }
        void a_event(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(debtext + "\r\n");
        }
        void a_method(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(debtext + "\r\n");
        }
        void a_script(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(debtext + "\r\n");
        }
        void a_error(string debtext)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(debtext + "\r\n");
        }
        #endregion
        #region System.IO
        /// <summary>
        /// System.IO.StreamWriterを用いて書き込みます。書き込み先のパスは変数pathの先の相対パスになります。0=成功, 1=失敗
        /// </summary>
        /// <param name="text"></param>
        /// <returns>0 or 1</returns>
        int write(string text,string filename)
        {
            //成功失敗問わずサブディレクトリを作成を試行する
            try
            {
                Directory.CreateDirectory(path + @"\" + System.IO.Path.GetDirectoryName(filename));
            }
            catch (Exception) { }
            try
            {
                using (StreamWriter sw = new StreamWriter(path + @"\" + filename))
                {
                    sw.Write(text);
                }
            }
            catch(Exception)
            {
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// System.IO.StreamReaderを用いて読み込みます。読み込み先のパスは変数pathの先の相対パスになります。
        /// </summary>
        /// <returns>fulltext</returns>
        string read(string filename)
        {
            string tmp;
            try
            {
                
                using (StreamReader sw = new StreamReader(path + @"\" + filename))
                {
                    tmp = sw.ReadToEnd();
                }
            }
            catch (Exception)
            {
                return "";
            }
            return tmp;
        }
        #endregion
    }
}
