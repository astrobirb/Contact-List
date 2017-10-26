using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace ContactList
{
    public partial class ContactsTableViewController : UITableViewController
    {

        List<Contact> contactList;

        // Note to self: Remember to list AT LEAST 4 individuals
        public ContactsTableViewController (IntPtr handle) : base (handle)
        {
            contactList = new List<Contact>();

            // Currently only has placeholder info
            contactList.Add(new Contact()
            {
                Name = "Peter Pan",
                Number = 1234567890,
            });

			contactList.Add(new Contact()
			{
                Name = "Tinker Bell",
				Number = 1234567890,
			});

            contactList.Add(new Contact()
		    {
			    Name = "Captain Hook",
                Number = 1234567890,

			});

            contactList.Add(new Contact()
		    {
			    Name = "Wendy Darling",
                Number = 1234567890,

			});
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return contactList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Contact") as ContactTableViewCell;

            var data = contactList[indexPath.Row];

            cell.ContactData = data;

            return cell;
        }

    }

    public class Contact
    {
        public string ImagePath;
        public string Name;
        public int Number;
        public string Location;
    }
}