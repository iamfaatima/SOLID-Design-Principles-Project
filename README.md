# SOLID-Design-Principles-Project
Car Rental App based on .Net windows form. It implements all 5 SOLID design principles. 
Introduction to the application:
My windows-form based Car Rental App help the users place their booking order on the app for either Cars or Bikes. It also gives them information on the details of the vehicle (if they want) before renting. Both Cars and Bikes have different options like Kia Sportage, Mercedes, Touring, Cruiser etc.  


![image](https://user-images.githubusercontent.com/70031321/180241623-1f006fc4-f7c5-424d-a04b-dcf73a31b643.png)



Implementation of SOLID principles:
S (Single Responsibility Principle) – Every class(Kia, Limousine, Sports etc) are performing their one and own respective functionalities of showing feature details.
  

O (Open-Closed Principle) – The interface IVehicle is extended by ICar and IBike, and further cars and bikes are implementing ICar and IBike as required. Hence for this principle my app is closed for modification and open for extension. If any new car or bike need to be added in future, we just need to make its new class and implement it from ICar or IBike.

L (Liskov substitution principle) – To achieve this, I need to implement all functions in my interface. To avoid implementing functions that are not needed in child classes, I did interface segregation. This way objects of a superclass will be replaceable with objects of its subclasses without breaking the application. Interface segregation is defined below.























I (Interface segregation principle) – Instead of making one general purpose interface of Vehicles, I made different client specific interfaces for Cars and Bikes. 


























D (Dependency Inversion Principle) – Since we have not learned dependency injections yet, I implemented Factory design pattern to achieve this. Instead of using multiple if else to create objects of required class, I used a Factory class and a factory method to reduce coupling. 

 
