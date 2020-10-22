using System;
using UIKit;
using System.Data;

namespace XamariniOSDataTable
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		}

		partial void UIButton16_TouchUpInside(UIButton sender)
		{
			DataTable table = GetValue(txtValue1.Text, txtValue2.Text);
			foreach (DataRow row in table.Rows)
			{
				lblValue1.Text = row[0].ToString();
				lblValue2.Text = row[1].ToString();
			}
		}

		partial void UIButton11_TouchUpInside(UIButton sender)
		{
			DataTable table = GetValue(txtValue1.Text, txtValue2.Text);
			UIAlertView alert = new UIAlertView("Success", "Data has been Stored Successfully.", null, "Close", null);
			alert.Show();
		}

		/// Get the values form DataTable  
		public DataTable GetValue(string v1,string v2)
		{
			DataTable table = new DataTable();
			table.Columns.Add("Value1", typeof(string));
			table.Columns.Add("Value2", typeof(string));
			table.Rows.Add(v1, v2);
			return table;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
