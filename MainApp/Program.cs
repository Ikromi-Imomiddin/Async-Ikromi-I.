using Domain.Entitie;
using Services.ContactService;


var contactService = new ContactService();

var contact = new Contact(){
 Id=2,
 Name = "Ikromi",
 Phone = "123456789",
 Message = "hello"
};

var response = contactService.DeleteContact(2);

if(response==1){
    System.Console.WriteLine("Contact added");
}
else
System.Console.WriteLine("Contact not added");