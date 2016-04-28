﻿using System.Collections.Generic;
using GSharp.Graphic.Core;
using GSharp.Graphic.Holes;
using GSharp.Base.Cores;
using GSharp.Base.Objects;
using System;
using System.Windows.Media;

namespace GSharp.Graphic.Objects
{
    /// <summary>
    /// NumberBlock.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CustomVariableBlock : CustomBlock
    {
        public override GObject GObject
        {
            get
            {
                return null;
            }
        }

        public override List<GBase> GObjectList
        {
            get
            {
                return null;
            }
        }

        public CustomVariableBlock(Type type, Color color)
            : base(type)
        {
            InitializeComponent();

            // Set background color
            Background = new SolidColorBrush(color);

            // Init block
            InitializeBlock();
        }
    }
}
