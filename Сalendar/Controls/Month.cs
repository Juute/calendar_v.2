using System.Windows.Forms;

namespace Calendar.Controls
{
    public partial class Month : UserControl
    {
        public string NameMouth { get { return label8.Text; } set { label8.Text = value; } }
        public TableLayoutPanel TableMouth;

        public Month()
        {
            InitializeComponent();
            TableMouth = tableLayoutPanel1;
        }
    }
}
