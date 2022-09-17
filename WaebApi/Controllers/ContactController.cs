using Domain.Entitie;
using Microsoft.AspNetCore.Mvc;
using Services.ContactService;

namespace WaebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private ContactService _contactService;
    public ContactController()
    {
        _contactService = new ContactService();
    }

    [HttpGet]
    public List<Contact> GetContacts(){
        return _contactService.GetContacts();
    }

    [HttpPost]
    public List<Contact> AddContact(Contact contact){
        return _contactService.AddContact();
    }

    [HttpPut]
    public List<Contact> UpdateContacts(Contact contact){
        return _contactService.UpdateContacts();
    }

    [HttpDelete]
    public List<Contact> DeleteContacts(Contact contact){
        return _contactService.DeleteContacts();
    }
}
