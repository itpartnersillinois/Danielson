# IT Partners README.MD file

## Summary: 

## Production location:

Currently, none.

## Development location: 

Currently, none. We do development on local machines.

## How to deploy to production/development: 

## How to set up locally: 

## Notes (error logging, external tools, links, etc.): 

Information about EF Core Tools:

Make sure the Danielson is set up as the startup project before running the commands below:

``Add-Migration -Name {migration name} -Context FormContext -Project Danielson.Data``

``Update-Database -Context FormContext``

If you run into the issue "The certificate chain was issued by an authority that is not trusted.", then add **TrustServerCertificate=True** to the connection string.

For the application login, please run the following:

``Update-Database -Context ApplicationDbContext``

Note that the Danielson tables are all built with a [danielson] schema. The ApplicationDbContext tables all start with AspNet.

## Updating the form

The form template information is built as a .NET document outside of the database. This is because the form template is fixed for all forms, and adding it to the database seemed like a lot of unneeded complexity.

You can edit these in Danielson.Data/Domains section, under DomainList. 