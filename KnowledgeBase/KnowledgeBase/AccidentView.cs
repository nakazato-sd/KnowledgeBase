using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase
{
    public partial class AccidentView : Form
    {
        AccidentController controller = null;
        public AccidentView()
        {
            InitializeComponent();
            controller = new AccidentController();
            this.accidentModelBindingSource.DataSource = new AccidentModel("11", "22", "33", "44");
        }

        private void save_Click(object sender, EventArgs e)
        {
            controller.Save((AccidentModel)this.accidentModelBindingSource.DataSource);

        }

        private void load_Click(object sender, EventArgs e)
        {
            this.accidentModelBindingSource.DataSource = controller.Load();
        }
    }
}
