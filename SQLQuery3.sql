CREATE TABLE Orders (
  order_id int IDENTITY(1,1) PRIMARY KEY,
  order_date date,
  Customer_id INT FOREIGN KEY (Customer_id) REFERENCES Customers(Customer_id),  -- Added Customer_id column
  Vehicle_id int FOREIGN KEY (vehicle_id) REFERENCES Vehicle(vehicle_id),
  Driver_id int FOREIGN KEY (Driver_id) REFERENCES Driver(Driver_id),
  pickup_location varchar(255),
  dropoff_location varchar(255)
);
