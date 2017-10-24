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
            contactList.Add(new Contact() {
                Name = "Peter Pan",
                Number = 123 456 7890,
                Location = "Neverland"
            });

			contactList.Add(new Contact()
			{
				Name = "Tinker Bell",
				Number = 321 654 0987,
				Location = "Pixie Hollow"
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
            var cell = tableView.DequeueReusableCell("Book");

            var data = bookList[indexPath.Row];

            cell.TextLabel.Text = data.Name;

            return cell;
        }

    }

    public class Contact
    {
        public string Image; // Don't worry about this for now
        public string Name;
        public int Number;
        public string Location;
    }
}