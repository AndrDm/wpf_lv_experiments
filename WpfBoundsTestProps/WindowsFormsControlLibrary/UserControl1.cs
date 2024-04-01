using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class UserControl1: UserControl
    {
		// Private data member that backs the EndColor property.  
		private Color myborderColor = Color.LimeGreen;
		// The Category attribute tells the designer to display  
		// it in the Flash grouping.
		// The Description attribute provides a description of  
		// the property.
		[
		Category("Flash"),
		Description("The ending color of the bar.")
		]

		public Color MyBorderColor
		{
			get { return myborderColor; }
			set {
				myborderColor = value;
				label1.ForeColor = value;
				//UserControl1.MyColorProperty = value;
				//if (baseBackground != null && showGradient){
				//	baseBackground.Dispose();
				//	baseBackground = null;
				//}
				// The Invalidate method calls the OnPaint method, which redraws
				// the control.  
				Invalidate();
			}
		}

		public UserControl1()
        {
            InitializeComponent();
        }

		private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}
	}
}
