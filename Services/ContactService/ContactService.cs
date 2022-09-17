using Dapper;
using Domain.Entitie;
using Npgsql;

namespace Services.ContactService;

public class ContactService{
    private string _connectionstring;
    public ContactService()
    {
        _connectionstring = "Server=127.0.0.1;Port=5432;Database=SQLConnectionLesson;User Id=postgres;Password=Ikromi8008;";

    }

    public int AddContact(Contact contact)
    {
        // Add contact to database
        using (NpgsqlConnection connection  = new NpgsqlConnection(_connectionstring))
        {
            connection.Open();
            string sql = $"INSERT INTO contact (name, phone, message) VALUES ('{contact.Name}', '{contact.Phone}', '{contact.Message}')";
            var response  = connection.Execute(sql);

            return response;
        }
        
    }

    public List<Contact> DeleteContacts()
    {
        throw new NotImplementedException();
    }

    public List<Contact> UpdateContacts()
    {
        throw new NotImplementedException();
    }

    public List<Contact> AddContact()
    {
        throw new NotImplementedException();
    }

    public List<Contact> GetContacts()
    {
        throw new NotImplementedException();
    }

    public int UpdateContact(Contact contact)
    {
        using (NpgsqlConnection connection  = new NpgsqlConnection(_connectionstring))
        {
            connection.Open();
            string sql = $"update contact set name = '{contact.Name}',phone = '{contact.Phone}',message = '{contact.Message}' where id = {contact.Id}";
            var response  = connection.Execute(sql);

            return response;
        }
}
 public int DeleteContact(int id)
    {
        using (NpgsqlConnection connection  = new NpgsqlConnection(_connectionstring))
        {
            connection.Open();
            string sql = $"delete from contact where id = {id}";
            var response  = connection.Execute(sql);

            return response;
        }
}
}