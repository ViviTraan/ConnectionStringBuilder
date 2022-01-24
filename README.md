# ConnectionStringBuilder
ConnectionStringBuilder is a NuGet Package which simplifies the building of different connection strings. Gone are the days where you have to worry about the formatting of the strings. In the package you will find options for Sql, MySQL, SQLite & MongoDB.

## Installation
Use the "Manage NuGet Packages" and search for "ConnectionStringBuilder" OR enter the text below in "Package Manager Console" to install the package.
```
Install-Package ConnectionStringBuilder -Version 1.0.0
```  

## Using ConnectionStringBuilder
After installation enter the code below at the top of your project: 
```
using ConnectionStringBuilder.Builder;
```

An example of how you could use the ConnStringBuilder to build a connection string for SqlServer:
```
var connectionstring = new ConnStringBuilder().SetServer("yourServerName").SetDatabase("yourDatabaseName").BuildSqlServer();
```
Now you can use the variable as an input instead of worrying about how you should format your connection string! 

## Authors:
- [Vivitraan](https://github.com/ViviTraan)

## License:
- [MIT](https://choosealicense.com/licenses/mit/)

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.
