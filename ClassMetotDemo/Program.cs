using ClassMetotDemo;

CustomerManager customerManager = new CustomerManager();

Customer customer = new Customer()
{
    Id = 1,
    FirstName = "Yusufcan",
    LastName = "Adıgüzel",
    Address = "İstanbul"
};

customerManager.Add(customer);

customerManager.Delete(customer);

customerManager.UpdateAddress(customer, "Ankara");

customerManager.Get(customer);

