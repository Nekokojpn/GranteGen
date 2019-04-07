using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GranteGen
{  
    public partial class MainWindow:Window
    {
        void addToCanvas(Canvas canvas,Button insbtn)
        {
            if (isInsertionMode == false)
            {
                _scene_stack.Children.Add(insbtn);
                _scene_stack.Children.Add(canvas);
            }
            else if(isInsertionMode == true)
            {
                isInsertionMode = false;
                navigate_null();
                _scene_stack.Children.Insert(insertionNum, insbtn);
                _scene_stack.Children.Insert(insertionNum+1, canvas);
            }
            
        }
    }
}
