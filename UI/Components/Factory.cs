﻿using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: LiveSplit.UI.Components.ComponentFactory(typeof(LiveSplit.UI.Components.Factory))]

namespace LiveSplit.UI.Components
{
    public class Factory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "LiveSplit Server"; }
        }

        public string Description
        {
            get { return ""; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
           return new Component();
        }

        public string UpdateName
        {
            get { return ""; }
        }

        public string UpdateURL
        {
            get { return "http://livesplit.org/update/"; }
        }

        public Version Version
        {
            get { return new Version(); }
        }

        public string XMLURL
        {
            get { return "http://livesplit.org/update/Components/noupdates.xml"; }
        }    
    }
}
