# Connecting to databases in C# (Debian based linux)



### <b> Installing MySQL server in linux</b>
To install mySQL server on linux, you need to run the following commands in the terminal:
```
sudo apt-get update

sudo apt-get install mysql-server -y
```

After installation, run the following command to use mysql:

```
sudo mysql
```

### <b> Creating a database</b>
To create a database, run the following command in the terminal:
```
CREATE DATABASE database_name;
```

### <b>ADO.NET installation</b>
- ADO.NET is a .NET Framework component and is not available natively on Linux.
- To connect to a MySQL database in C# on Linux, you can use either the Mono.Data.MySqlClient library or the MySql.Data library from MySQL Connector/NET.
- Here we will use the MySql.Data library from MySQL Connector/NET which is a fully managed ADO.NET driver for MySQL.
```
dotnet add package MySql.Data
```
