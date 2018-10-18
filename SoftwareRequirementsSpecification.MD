# Software Requirements Specification - Food Inventory Tracker

## Functional

### Entering items

*EI1* The system shall support user-input of items.

*EI2* User input for individual entries(ref: EI1) will contain, at a minimum,: item name, expiration date, quantity, and storage location.

*EI3* Upon user input of an item entry, if entry does not meet minimum entry requirements (ref: EI2) the system will reject the entry.

*EI4* Upon entry of an item with an expiration date that is before the entry date, the System shall reject the entry.

*EI5* Upon rejection of an entry (ref: EI3, EI4), the system will alert the user with an output message describing the reason for rejection.

*EI6* Upon user input of an entry with an item name, expiration date, and storage location identical to another entry that was entered on the same day, the system will alert the user with prompt the user for confirmation.

*EI7* The confirmation message (ref: EI6) will display the current and previous entries' fields and the time(s) that the previous entry/entries were input.

*EI8* Upon user input when entering an item, if the item name is identical to an item that has been entered in the past, the system will automatically populate the current entry's fields (ref: RI2)) (per user confirmation) with those of the previous entry, excluding the following fields: expiration date, storage location, and quantity.

*EI9* The system will support additional optional fields for entries with the following labels of 'manufacturer name', 'price', and 'storage temperature range.'

### Displaying items

*DI1* The system shall support display of the user's inventory (**Inventory Display (InD)**) in the form of a table, with individual rows corresponding to individual entries.

*DI2* Rows within InD (ref: DI1) will contain fields for: item name, expiration date, entry date, quantity, storage location, manufacturer name, price, and storage temperature range.

*DI3* The InD will support report generation in PDF format.

*DI4* Report generation (ref: DI3) will allow the user to include/exclude all fields and to sort the values of the fields.

*DI5* The system shall support a display of the user's expired entries, along with entries that will expire within a time period defined by the user.



### Removing Items

*RI1* The system shall support the user removing item entries from the inventory.

*RI2* Upon deletion of an entry, the system shall retain data related to the item type corresponding to the fields item name, manufacturer name, price, and temperature range.

*RI3* Upon user request for item removal (ref: RI1), the system will prompt the user to specify the quantity to be removed.

*RI4* Upon user request for item removal, if the amount specified to be removed exceeds the quantity of the entry (ref: RI3), the system will remove the entry from InD.

### Tracking expiration

*TE1* Upon meeting a point in time equal to the expiration date of an item entry (ref EI2), the system will list in red the number of expired items as a message viewable from the main page (ref: Layout).

*TE2* Upon meeting a point in time equal to 30 days prior to the expiration date of an item entry (ref EI2), the system will list in red the number of items expiring before 30 days as a message viewable from the main page (ref: Layout) and separate from the expired items message (ref: TE1).

## Non-functional

### Platform

The system will be accessible as a web page.

### Users

*USER1* The system will support multiple users.

*USER2* The system will operate on and display only data associated only with the logged on user.

*USER3* User passwords will be stored as hashes.

### Layout

After login, the system layout will originate from a main page from which the user may access all features.



