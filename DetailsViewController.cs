using Foundation;
using System;
using UIKit;

namespace ContactList
{
    public partial class DetailsViewController : UIViewController
    {

        public Contact selectedContact;

        public DetailsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            imgContactImage.Image = UIImage.FromFile(selectedContact.ImagePath);
            labelContactName.Text = selectedContact.Name;
            labelContactNumber.Text = selectedContact.Number.ToString();
            labelContactLocation.Text = selectedContact.Location;
        }
    }
}