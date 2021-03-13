# Eau Claire's Salon

#### An MVC application for a fictional salon owner to track employees/clients

#### By &copy; [Scott O'Neil](https://github.com/spnoneil), 3/12/2021

## Technologies Used

[![forthebadge](https://forthebadge.com/images/badges/made-with-crayons.svg)](https://forthebadge.com)

* _C# / .NET 5.0 SDK / ASP .NET Core_
* _HTML5_
* _CSS3 / Bootstrap 4.5_
* _VS Code 1.54.2_
* _Entity Framework Core 5.0_
* _MySQL/Workbench 8.0.19_

## Description
_A simple MVC page, created for Epicodus Coding School to practice/show knowledge of basic database management, utilizing various

## Setup/Installation Requirements

* _Clone/download from GitHub (unzip, if necessary)_
* _Open terminal, navigate to the `HairSalon` directory, inside the `HairSalon.Solution` root directory_
* _Still in the terminal, enter `dotnet restore`._
* _Next, enter `dotnet build`_
* _Then, enter `dotnet run`_
* _Finally, in browser of choice, navigate to `http://localhost:5000`_

### Database Setup


* _First, download MySQL Workbench [here](https://dev.mysql.com/downloads/workbench/)_
* _After a successful install and setup, in the Administration tab, hit "Data Import/Restore", followed by clicking "Import from Self-Contained File", and navigate to the included `scott_oneil.sql` dump structure file_
* _Click "Start Import"_
* _Next, in the root directory of `HairSalon.Solution`, create a file called `appsettings.json` and input the following:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=scott_oneil;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
  _with "YOUR-PASSWORD-HERE" being the password you set up with MySQL workbench._
* _Now you're ready to head back to that `http://localhost:5000` to view project_


Database, Visualized:

[![gyazo](https://i.gyazo.com/8805a9f93470fb303a550313c1ad3aa8.png)]

## Known Bugs

* _No known bugs_

## Future implementation
* _Add warning if deleting stylist with clients still attached_
* _Add client search functionality_
* _Add appointment functionality_
* _Add cost calculation_
* _Further styling / UI logic_

## License
_GPL_
## Contact Information

_Issues can be reported [here](https://github.com/spnoneil/HairSalon.Solution/issues/new) on GitHub_
