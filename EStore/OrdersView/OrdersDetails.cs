﻿using EStoreBusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore.OrdersView
{
    public partial class OrdersDetails : MetroFramework.Forms.MetroForm
    {
        public OrdersDetails(Order order)
        {
            InitializeComponent();
        }
    }
}