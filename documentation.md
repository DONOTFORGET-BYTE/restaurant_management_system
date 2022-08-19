Documentation

Controllers

AccountController
this controller handles the login and registration process 
this login and registration is required to save a user records of reservations and orders 
and also for the admin to manage the app 

the controller evalutes password ,email and restaurant_id match 
if the 3 match the user will be logged in 
else some errors will be reported 

AdminOrderController
this controller manages the views and methods to manage CRUD on orders 
admin has the ablility to delete an order, create an order and assign it to a customer 
admin has the ability to edit an order 

AdminReservationController
this controller manages the views and methods to manage CRUD on reservations 
admin has the ablility to delete a reservation, create a reservation and assign it to a customer 
admin has the ability to edit a reservation

CustomersController
this controller manages the views and methods to manage CRUD on customers
admin has the ablility to delete a customer, create a customer and to edit a customer

OrderController
this controller manages the views and methods to manage CRUD on orders for a user
the views do not display all the columns for the user order but via admin side the view has no limit
user has the ability to place many orders 
order are free entry text
user has the ability to perform crud operations on orders 

ReservationController
this controller manages the views and methods to manage CRUD on reservations for a user
the views do not display all the columns for the user reservations but via admin side the view has no limit
user has the ability to place many reservations
each reservation has a single reservation status 
user has the ability to perform crud operations on reservation

RestaurantController
this controller manages the views and methods to manage CRUD on restaurants
admin has the ability to add restaurants
admin has the ability to perform crud operations on restaurants

Models 
customer class defines the get and set methods for the columns in the customer table
order class defines the get and set methods for the columns in the order table
reservation class defines the get and set methods for the columns in the reservation table
restaurant class defines the get and set methods for the columns in the restaurant table

Views
Account view defines the ui for the login and registration page 
Admin Order view defines the ui for the list, edit ,details, create and delete pages
Admin Reservation view defines the ui for the list, edit ,details, create and delete pages
Customers view defines the ui for the list, edit ,details, create and delete pages
Restaurant view defines the ui for the list, edit ,details, create and delete pages
Order view defines the ui for the list, edit ,details, create and delete pages
Reservation view defines the ui for the list, edit ,details, create and delete pages
Shared contains the layout file which is responsible for the navigation system and what to disply based on states i.e logged in as admin ,logged in as user ,not logger in .
the tabs available will vary 

Linq
DataClasses1.dbml defines the tables used in the application