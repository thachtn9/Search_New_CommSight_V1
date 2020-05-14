using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_New_CommSight_V1
{
    public partial class frmWaitForm : Form
    {
        public Action Worker { get; set; }
        public frmWaitForm(Action action)
        {
            InitializeComponent();
            if(action == null)
            {
                throw new ArgumentNullException();
            }
            Worker = action;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(
                t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext()); 

        }
    }
}
