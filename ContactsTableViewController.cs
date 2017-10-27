using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace ContactList
{
    public partial class ContactsTableViewController : UITableViewController
    {

        List<Contact> contactList;

        public ContactsTableViewController (IntPtr handle) : base (handle)
        {
            contactList = new List<Contact>();

            contactList.Add(new Contact()
            {
                Name = "Mom",
                Number = 4033992588,
                Location = "Calgary, AB, Canada",
                ImagePath = "Images/mom.jpg"
            });

			contactList.Add(new Contact()
			{
                Name = "Dad",
				Number = 4038053508,
                Location = "Calgary, AB, Canada",
                ImagePath = "Images/dad.jpg"
			});

            contactList.Add(new Contact()
		    {
			    Name = "Home phone",
                Number = 5873196599,
                Location = "Calgary, AB, Canada",
                ImagePath = "Images/home phone.jpg"
			});

            contactList.Add(new Contact()
		    {
			    Name = "Mikha",
                Number = 4037961567,
                Location = "Calgary, AB, Canada",
                ImagePath = "Images/mikha.jpg"
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

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetailsSegue")
            {
                var navigationController = segue.DestinationViewController as DetailsViewController;

                if (navigationController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = contactList[rowPath.Row];
                    navigationController.selectedContact = selectedData;
                }
            }
        }

    }

    public class Contact
    {
        public string ImagePath;
        public string Name;
        public long Number;
        public string Location;
    }
}