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
            }
		}

        public ContactTableViewCell (IntPtr handle) : base (handle)
        {
            
        }
    }
}