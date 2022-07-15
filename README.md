# Pierres Bakery

#### By _**Alex Shevlin**_  

#### _A console application that allows users to see the price of pastries, accounting for discounts._  

---

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Technology Requirements](#technology-requirements)  
[Setup and Installation](#setupinstallation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)  
[Contact Info](#contact-information)  
[Tests](#tests)**

---

## Technologies Used

* _C#_
* _.NET 5.0_
* _MS Test_
* _Markdown_

---
## Description

_This C# application uses namespaces, classes, auto-implemented properties and Test Driven Development to create a cart for a fake bakery. The user can enter how many "bread" and "pastry" items they would like to purchase and are returned a total cost. A single "bread" costs $5 and has a buy 2 get 1 free discount. A single "pastry" costs 10, with no special discounts._

---

## Technology Requirements

* Download and install **[.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)**  
* Download and instal a code text editor. This project was set up with **[VS Code](https://code.visualstudio.com/)**

---

## Setup/Installation Requirements

* Install *`Microsoft .NET SDK`*
* Place files in a folder named `PierresBakery.Solution`
    <pre>PierresBakery.Solution
    ├── PierresBakery
    └── PierresBakery.Tests</pre>
<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>PierresBakery.Solution
   ├── <strong>PierresBakeryName</strong>
   └── PierresBakery.Tests</pre>

Run ```$ dotnet run``` in the console
</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>PierresBakery.Solution
    ├── PierresBakery
    └── <strong>PierresBakery.Tests</strong></pre>

Run ```$ dotnet test``` in the console

</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _Any known issues_
* _should go here_

---

## License

[GNU](/LICENSE-GNU)

Copyright (c) 2022 Alex Shevlin

## Contact Information

* Alex Shevlin <alexshevlin1@gmail.com>

----

### **Tests**

  #### *Cart Tests*

<table>
  <tr>
    <th>Describe</th>
    <th>Code</th>
    <th>Expected Output</th>
  </tr>
  <tr>
    <td>take input and return.</td>
    <td>Cart newCart = new Cart(0, 0, 0, 0);</td>
    <td>newCart.BreadAmount == 0;</td>
  </tr>
</table>

#### *Bread Tests*

<table>
  <tr>
    <th>Describe</th>
    <th>Code</th>
    <th>Expected Output</th>
  </tr>
  <tr>
    <td>take amount and return.</td>
    <td>Bread newBread = new Bread("5");</td>
    <td>newBread.Amount == 5;</td>
  </tr>
  <tr>
    <td>take amount and return discount.</td>
    <td>
      Bread newBread = new Bread("3");
    <br>
      int discount = newBread.GetDiscount();
    </td>
    <td>discount == 5;</td>
  </tr>
  <tr>
    <td>take amount and return discounted price</td>
    <td>
      Bread newBread = new Bread("3");
    <br>
      newBread.GetPrice();
    </td>
    <td>newBread.Price == 10;</td>
  </tr>
</table>

#### *Pastry Tests*

<table>
  <tr>
    <th>Describe</th>
    <th>Code</th>
    <th>Expected Output</th>
  </tr>
  <tr>
    <td>take amount and return</td>
    <td>Pastry newPastry = new Pastry("5");</td>
    <td>newPastry.Amount == 5;</td>
  </tr>
  <tr>
    <td>take amount and return price</td>
    <td>
      Pastry newPastry = new Pastry("1");
    <br>
      int price = (2);
    <br>
      newPastry.GetPrice();
    </td>
    <td>newPastry.Price == price;</td>
  </tr>
  <tr>
    <td>take amount and return discount</td>
    <td>
      Pastry newPastry = new Pastry("3");
    <br>
      int discount = newPastry.GetDiscount();
    </td>
    <td>discount == 1;</td>
  </tr>
  <tr>
    <td>take amount and return discounted price</td>
    <td>
      Pastry newPastry = new Pastry("5");
    <br>
      newPastry.GetPrice();
    <br>
      int price = (5 * 2) - ((5 -(5 % 3))/ 3);
    </td>
    <td>newPastry.Price == price;</td>
  </tr>
  </table>
