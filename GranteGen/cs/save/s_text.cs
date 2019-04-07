using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GranteGen
{
    public partial class MainWindow : Window
    {
        void s_text(Canvas childs)
        {
            List<string> definite_name = new List<string>();
            List<string> definite_text = new List<string>();
            List<string> definite_src = new List<string>();
            //Optimize maintext;
            foreach (var child in LogicalTreeHelper.GetChildren((DependencyObject)childs))
            {
                if (child is TextBox)//メインテキストだったら
                {
                    buf = ((TextBox)child).Text;
                    #region 構文解析
                    try
                    {
                        while (true)
                        {
                            if (buf == "#")
                            {
                                errdata += "テキストには何も入力されていません。スキップされます。" + Environment.NewLine;
                                break;
                            }
                            if (buf == "" || buf == "#")
                            {
                                a_event("構文解析が終了しました");
                                break;
                            }
                            Match mcc = Regex.Match(buf, "#(.+?)#", RegexOptions.Singleline);
                            Match matchcurrentname = Regex.Match(buf, "#(.+?)*\r\n");
                            if (!matchcurrentname.Success)
                            {
                                errdata += "構文が間違っています。";
                                break;
                            }
                            string currentname = matchcurrentname.ToString();
                            string maintext = "";
                            string src = "";
                            if (mcc.Success)//#~#マッチ?
                                maintext = mcc.ToString();
                            else
                                maintext = buf;

                            maintext = maintext.Replace(currentname, "").Replace("#", "");
                            Match m = Regex.Match(maintext, @"\[src(.+?)*=(.+?)*\]");

                            if (m.Success)
                            {
                                src = m.ToString();
                                maintext = maintext.Replace(src, "");
                            }
                            if (m.Success)
                                src = src.Replace(" ", "").Replace("[src=\"", "").Replace("\"]","");
                            currentname = currentname.Replace("#", "").Replace("\r\n", "");
                            definite_name.Add(currentname);
                            definite_text.Add(maintext);
                            definite_src.Add(src);
                            buf = buf.Remove(0, buf.IndexOf(maintext) + maintext.Length);

                        }

                        //1回でもtextboxみつかったらループを抜ける
                        break;
                    }
                    #endregion
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        errdata += "構文解析中にエラーが発生しました。"+ Environment.NewLine;
                    }
                }
            }
            //finally
            try
            {
                int index = 0;
                foreach (string sn in definite_name)
                {
                    string sm = definite_text.ElementAt(index);
                    string ss = definite_src.ElementAt(index);
                    string tmp = sm.Replace("\r\n", "&%NL");
                    if (tmp.IndexOf("&%NL") == 0)
                    {
                        tmp = tmp.Remove(0, 4);
                    }
                    if (tmp.LastIndexOf("&%NL") == tmp.Length - 4)
                    {
                        tmp = tmp.Remove(tmp.Length - 4);
                    }
                    ss = (ss != "") ? " src=\"" + ss+"\"" : "";
                    data += "<t name=\"" + sn+"\"" +ss +">" + tmp + "</t>" + Environment.NewLine;
                    index++;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
