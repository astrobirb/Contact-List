// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ContactList
{
    [Register ("DetailsViewController")]
    partial class DetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgContactImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelContactLocation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelContactName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelContactNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgContactImage != null) {
                imgContactImage.Dispose ();
                imgContactImage = null;
            }

            if (labelContactLocation != null) {
                labelContactLocation.Dispose ();
                labelContactLocation = null;
            }

            if (labelContactName != null) {
                labelContactName.Dispose ();
                labelContactName = null;
            }

            if (labelContactNumber != null) {
                labelContactNumber.Dispose ();
                labelContactNumber = null;
            }
        }
    }
}