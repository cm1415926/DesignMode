﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05简单工厂
{
    public class PieChart : IChartable
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图....");
        }
        public void Display()
        {
            Console.WriteLine("显示柱状图....");
        }
    }
}
