using Foundation;
using System;
using UIKit;

namespace ContactList
{
    public partial class ContactTableViewCell : UITableViewCell
    {

		private Contact contactData;
		public Contact ContactData
		{
            get { return contactData; }
			set {
                contactData = value;

                contactImage.Image = UIImage.FromFile(contactData.ImagePath); ;
                labelName.Text = contactData.Name;
                labelNumber.Text = contactData.Number.ToString();

            }
		}

        public ContactTableViewCell (IntPtr handle) : base (handle)
        {
            
        }
    }
}