// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSDataTable
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblValue1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblValue2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtValue1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtValue2 { get; set; }

        [Action ("UIButton11_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton11_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton16_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton16_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (lblValue1 != null) {
                lblValue1.Dispose ();
                lblValue1 = null;
            }

            if (lblValue2 != null) {
                lblValue2.Dispose ();
                lblValue2 = null;
            }

            if (txtValue1 != null) {
                txtValue1.Dispose ();
                txtValue1 = null;
            }

            if (txtValue2 != null) {
                txtValue2.Dispose ();
                txtValue2 = null;
            }
        }
    }
}