using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Chart.UC
{
    public partial class Testing : UserControl
    {
        private Button button1;
        private Label label1;

        public Testing()
        {
            InitializeComponent();

            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange( new object[] {"Item 1","Item 2","Item 3","Item 4"});
        }
    }
}
