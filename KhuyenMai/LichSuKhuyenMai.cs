﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.KhuyenMai
{
    public partial class LichSuKhuyenMai : UserControl
    {
        db_flowerDataContext fs = new db_flowerDataContext();
        public LichSuKhuyenMai()
        {
            InitializeComponent();
        }

        void load_LichSuDungKhuyenMai()
        {
            var tblpromo_used = from pu in fs.promotion_usages
                                select pu;
            dgrvLichsudung.DataSource = tblpromo_used;
        }

        private void frmLichSuDungKhuyenMai_Load(object sender, EventArgs e)
        {
            load_LichSuDungKhuyenMai();
        }
    }
}
