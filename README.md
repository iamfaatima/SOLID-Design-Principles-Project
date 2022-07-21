# SOLID-Design-Principles-Project
Car Rental App based on .Net windows form. It implements all 5 SOLID design principles. 
Introduction to the application:
My windows-form based Car Rental App help the users place their booking order on the app for either Cars or Bikes. It also gives them information on the details of the vehicle (if they want) before renting. Both Cars and Bikes have different options like Kia Sportage, Mercedes, Touring, Cruiser etc.  


![image](https://user-images.githubusercontent.com/70031321/180241623-1f006fc4-f7c5-424d-a04b-dcf73a31b643.png)
![image](https://user-images.githubusercontent.com/70031321/180241814-115d4df8-ce07-4c62-95d8-7050ce4b18b9.png)
![image](https://user-images.githubusercontent.com/70031321/180241855-d6a09f7c-ef99-439f-93a4-b7940d8a6d6b.png)
![image](https://user-images.githubusercontent.com/70031321/180241879-a3762417-8ca0-4c07-a25e-56cd736a7e15.png)



Implementation of SOLID principles:
S (Single Responsibility Principle) – Every class(Kia, Limousine, Sports etc) are performing their one and own respective functionalities of showing feature details.
  ![image](https://user-images.githubusercontent.com/70031321/180241919-1115b1ac-642d-4ca3-998a-5f75111c00f1.png)
![image](https://user-images.githubusercontent.com/70031321/180241946-49f268b2-565d-46bf-b75b-c1298f579543.png)


O (Open-Closed Principle) – The interface IVehicle is extended by ICar and IBike, and further cars and bikes are implementing ICar and IBike as required. Hence for this principle my app is closed for modification and open for extension. If any new car or bike need to be added in future, we just need to make its new class and implement it from ICar or IBike.

L (Liskov substitution principle) – To achieve this, I need to implement all functions in my interface. To avoid implementing functions that are not needed in child classes, I did interface segregation. This way objects of a superclass will be replaceable with objects of its subclasses without breaking the application. Interface segregation is defined below.

I (Interface segregation principle) – Instead of making one general purpose interface of Vehicles, I made different client specific interfaces for Cars and Bikes. 

![image](https://user-images.githubusercontent.com/70031321/180241985-174259a8-0490-40ee-a009-6acfba37656e.png)


![image](https://user-images.githubusercontent.com/70031321/180242033-c51fa039-ff92-4316-b6c6-6ba7c56ff80f.png)

![image](https://user-images.githubusercontent.com/70031321/180242057-a9c3593a-2432-4b58-a9c0-19d032d0c8bc.png)

D (Dependency Inversion Principle) – Since we have not learned dependency injections yet, I implemented Factory design pattern to achieve this. Instead of using multiple if else to create objects of required class, I used a Factory class and a factory method to reduce coupling. 

 ![image](https://user-images.githubusercontent.com/70031321/180242109-179f8f76-79ac-4e73-ac14-155b5a8022bd.png)

