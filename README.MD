# IT Partners README.MD file

## Summary: 

## Production location:

CoTE Web Server.

## Development location: 

Currently, none. We do development on local machines. Data might be stored in a local database or on the Test SQL Database.

## How to deploy to production/development: 

## How to set up locally:

1. Go to the test instance of the COTE Portal. Find what you need and click on the "Edit" button.
2. Run the following SQL statement to get the GUID `SELECT TOP 50 [Guid],[Email],[Role],[StudentEvaluationId],[Username],[LastUpdated] FROM [CTE].[danielson].[User] ORDER BY LastUpdated DESC`
3. Go to /Account/LoginPassthrough/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx, inserting the GUID.


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

## Updates to the form answers

### September 2026
The final summary’s form responses were updated to reflect revised wording in the evaluations. Because validation of the summary’s possible responses is loosely enforced, the change required modifying only `FinalAnswerGenerator.cs`. Previous evaluations remain compatible by displaying their existing responses stored in the database, while new responses will use the revised wording.
