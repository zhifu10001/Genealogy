﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子族谱管理系统
{
    public partial class 族谱管理界面 : Form
    {
        public 族谱管理界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("保存成功！", "温馨提示");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改成功！", "温馨提示");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认删除族谱吗？", "温馨提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
        }

        private void 族谱号_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
