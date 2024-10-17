using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E94106012_pracitce8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database1DataSet61.屬性_克制屬性_被克制屬性”中。您可以根据需要移动或移除它。
            this.屬性_克制屬性_被克制屬性TableAdapter3.Fill(this.database1DataSet61.屬性_克制屬性_被克制屬性);
            // TODO: 这行代码将数据加载到表“database1DataSet61.招式_屬性_威力”中。您可以根据需要移动或移除它。
            this.招式_屬性_威力TableAdapter1.Fill(this.database1DataSet61.招式_屬性_威力);
            // TODO: 这行代码将数据加载到表“database1DataSet61.寶可夢_招式”中。您可以根据需要移动或移除它。
            this.寶可夢_招式TableAdapter1.Fill(this.database1DataSet61.寶可夢_招式);
            // TODO: 这行代码将数据加载到表“database1DataSet6.屬性_克制屬性_被克制屬性”中。您可以根据需要移动或移除它。
            this.屬性_克制屬性_被克制屬性TableAdapter3.Fill(this.database1DataSet6.屬性_克制屬性_被克制屬性);
            // TODO: 这行代码将数据加载到表“database1DataSet6.招式_屬性_威力”中。您可以根据需要移动或移除它。
            this.招式_屬性_威力TableAdapter1.Fill(this.database1DataSet6.招式_屬性_威力);
            // TODO: 这行代码将数据加载到表“database1DataSet6.寶可夢_招式”中。您可以根据需要移动或移除它。
            this.寶可夢_招式TableAdapter1.Fill(this.database1DataSet6.寶可夢_招式);
            // TODO: 这行代码将数据加载到表“database1DataSet4.屬性_克制屬性_被克制屬性”中。您可以根据需要移动或移除它。


        }

        private void 寶可夢招式BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
