# General Receipt

General Receipt from now would be referred to as App / app.

High level features
-------------------

App should 

 - Support multiple organizations
 - Support multiple users (authentication as well as authorization)
 - Support template based printing with configurable physical dimensions
 - Should work in a LAN environment with an option to make it web based
 - Have extensive reporting (daily / monthly / quarterly / annually)
 - Support back up
 - Have renewable license (subscription based)
 
Tech Stack
----------

 - WebAPI + Owin for hosting
 - C# / .NET 
 - SQLite with [WAL](http://www.sqlite.org/draft/wal.html) ?
 - All interactions with the app to be logged / audited. Consider using an event store?
 - Client side with Angularsjs or Reactjs
 
 
 

