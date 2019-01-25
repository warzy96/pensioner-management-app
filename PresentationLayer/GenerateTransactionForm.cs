using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;

namespace PresentationLayer
{
    public partial class GenerateTransactionForm : Form, IGenerateTransactionForm
    {
        public GenerateTransactionForm()
        {
            InitializeComponent();            
        }

        public bool ShowGenerateTransactionForm()
        {
            return ShowDialog() == DialogResult.OK;
        }
    }
}
