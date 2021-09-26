# _Pierre's Bakery Sales Tracker_

#### By _**Carlos Urquiza**_

#### _Web application that allows a business owner to keep track of their vendors and associated orders._

## Technologies Used

* _C#_
* _MVC_
* _Razor View Engine_
* _RESTful Routing_
* _.NET 5.0_
* _MSTest_
* _Git_

## Description

_This application has the following functionality:_

* _Uses Razor View Engine to display information on each page._
* _Creates a Vendor class. This class includes properties for the vendor's name, a description of the vendor and a List of Orders belonging to the vendor._
* _Creates an Order class. This class includes properties for the title, the description, the price and date._
* _The homepage of the application (localhost:5000/) has a splash page that welcomes Pierre and provides them with a link to a Vendors page._
* _The vendors page contains a link to a page presenting Pierre with a form they can fill out to create a new Vendor. After the form is submitted, the new Vendor object is saved into a static List and Pierre is routed back to the homepage._
* _Pierre is able to click a Vendor's name and go to a new page that displays all of that Vendor's orders._
* _Pierre is provided with a link to a page presenting them with a form to create a new Order for a particular Vendor._
* _All functionality for the Models are tested using MSTest._

## Setup/Installation Requirements

* **Before taking the following installation steps, ensure you have [C#, .NET](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net) and [dotnet script](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-dotnet-script) installed on your computer.** 

* _Clone this repository._ 
* _Open your terminal._
* _Navigate to the directory (such as your Desktop) where you want the cloned directory._
* _Type `git clone` and paste the URL you copied._
* _Press Enter._

`To run tests:`

* _Navigate to `SalesTracker.Tests` by running `cd SalesTracker.Tests`._
* _Run `dotnet restore` to retrieve and install the packages we listed in `.csproj`._
* _Run `dotnet test`._

`To run the application:`

* _Navigate to `SalesTracker` by running `cd SalesTracker`._
* _Run `dotnet restore` to retrieve and install the packages we listed in `.csproj`._
* _Run `dotnet run`._
* _View application via `http://localhost:5000`_

## Known Bugs

* _No known bugs._

## License

MIT License

Copyright (c) 2021 Carlos Urquiza

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Contact Information

_Feel free to contact me at webquiza@gmail.com with any questions regarding this webpage._