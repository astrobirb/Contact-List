using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace ContactList
{
    public partial class ContactsTableViewController : UITableViewController
    {
        
        List<Contact> contactList; //this will be the list containing all contacts' info

        public ContactsTableViewController (IntPtr handle) : base (handle)
        {
            contactList = new List<Contact>();

            contactList.Add(new Contact()
            {
                Name = "Mom",
                Number = 4033992588,
                Location = "Calgary, AB, Canada",
                ImagePath = "Images/mom.jpg" //all images used are pictures of birds resembling my pets
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
        //counts the number of rows - NumberOfSections and RowsInSection go hand in hand
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return contactList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) //displays each contact's info onto the rows (name and number only)
        {
            var cell = tableView.DequeueReusableCell("Contact") as ContactTableViewCell;

            var data = contactList[indexPath.Row];

            cell.ContactData = data;

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender) //displays full info - activated when a contact is selected
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

    public class Contact //defines parts of the contact's info
    {
        public string ImagePath;
        public string Name;
        public long Number;
        public string Location;
    }
}