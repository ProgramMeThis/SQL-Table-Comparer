# SQL Table Comparer
This application lets users compare two SQL Server tables. They can be on the same or different servers. The user defines two different connections with the DatabaseConnectionProperties form, picks the two tables from the drop down menu and then runs the comparison. The application will list out all of the fields in each table on the two datagridviews and then will compare the two and color code the datagridviews. 

If the whole field doesn't exist in the other table then that whole row becomes red. Otherwise, it will only color code the individual cell  of the attribute that is different. The application currently compares the following attributes: Maximum Length, Data Type, Is Nullable, Numeric Precision and DateTime Precision.



# Forms
## TableComparer
<img src="https://user-images.githubusercontent.com/52602914/61587061-22b82800-ab48-11e9-9c99-92e86e6d48b6.png" width="400" height="300">

## DatabaseConnectionProperties
<img src="https://user-images.githubusercontent.com/52602914/61587068-4a0ef500-ab48-11e9-9e4a-49613baf4bd1.png" width="400" height="300">
