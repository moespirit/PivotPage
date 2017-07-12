﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Yinyue200.Controls.PivotPage
{
    public class ScrollViewExpand:ScrollView
    {
        public event EventHandler BeginScroll;
        public event EventHandler EndScroll;
        public void OnBeginScroll()
        {
            BeginScroll?.Invoke(this,null);
        }
        public void OnEndScroll()
        {
            EndScroll?.Invoke(this, null);
        }
        
    }
}
