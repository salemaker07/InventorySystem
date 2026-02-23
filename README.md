# InventorySystem
A task given for my Internship at Assal Tech 
---------------------------------------------
Project: Simple Inventory System
Store product details and stock counts.
Add, delete, and update inventory items.
Use a JSON file for data storage.
Apply encapsulation, interfaces, and file I/O principles.
 
Requirements
Design the system (file structure, operations).
Implement using C# Console Application.
Push the code to a GitHub repository in a sub-branch.
Create a pull request to the master branch.
Ensure clean and readable code.

———————————————————————————————————
This report is created to help manage and organize the work flow of this task.

Techs to be used

Software: VS Code, GitHub.
Languages and other techs: C#_Console , JSON, GIT
———————————————————————————————————
V 1.0

At this version, I aim to start neglecting OOP, the aim is to make a working code, then after I will refine my code and apply OOP principles after making sure that the code is working smoothly.

File structure:

 Class Product: this class hold the properties of product 
 (ID, NAME, QUANTITY, PRICE)

 Class InventoryServices: 
 (ADD, DELETE, UPDATE, GET PRODUCTS, SAVE TO NEW FILE, LOAD FROM EXISTING FILE)
 
 Main: using while loop to keep the program running
 _______________________________________________________________________________________________________

V2.0

In this version All OOP principles where applied, Code have been rewritten to be cleaner, bugs were fixed, bellow work have been done

Console.WriteLine and Console.ReadLine were used so much, therefore, a class called ConsoleHelper were invented to make the code more readable.

Interface was invented to make sure that the class follow the blueprint

Overloading was used in the function UpdateProduct.

ID is not allowed to be repeated, this problem is fixed in this version
Non existing ID can not be deleted and a notification is send to user.
Non existing ID can not be Updated and the user asked to update another ID.
Ask for confirmation before deleting item 
and so more.


 





