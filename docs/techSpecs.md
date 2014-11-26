Tech Specs 
=========

Deployment
----------

 - Server - Windows machine with a good configuration with .NET 4.5 (min)
 - A single exe (GenR2Install) should install into \{ProgramFiles}\GenR2
 - \{GenR2}\Start.[exe/bat] should start the server on port:9000
 - Configure domain on LAN as necessary
 - User should be able to navigate to http:\\{domain}:{port} to start working
 - http:\\{domain}:{port} should show the welcome page along with login option
 
First time setup
----------------

User should login as Admin

As Admin

 - Set up organization(s)
 - Set up user(s)
 - Authorize user(s) access to organization(s)
 - Cannot generate receipts
 - Run reports on org / user
 - Do house keeping (Back up / starting & stopping the server etc)
 
Regular use
-----------
 
As User

 - Login 
 - Select org to work with
 - Generate receipts
 - Run reports
 - House keeping?

Receipt
-------

A receipt is issued to a customer on behalf of the organization.
Receipt typically has

 - A running reference number
 - Date on which the receipt was created
 - Date of printing?
 - Name / Address / Contact of the customer
 - List of [item, quantity, price (per unit), Amount, Tax?] Item can be anything. (No inventory management).
 - Customized printing (Org level header / footer etc)

