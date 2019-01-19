﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FBXDesigns
{
    class ElementsClass
    {
        List<Shape> Tables = new List<Shape>();
        Control ctrl = null;
        Point absolute_offset;
        public ElementsClass(Control parent, Point abs_offset)
        {
            absolute_offset = abs_offset;
            ctrl = parent;
        }
        public DesignTableClass AddTable()
        {
           return AddTable(false);            
        }
        public DesignTableClass AddTable(bool show)
        {
            DesignTableClass tb = new DesignTableClass(ctrl,"test",show);
            Tables.Add(tb);
            return tb;

        }
    }
}
