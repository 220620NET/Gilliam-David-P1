using System.Data.SqlClient;
using DAO;
using Models;
using System.Collections.Generic;

namespace Services;

public class UserService
{
    UsersDAO useraccess = new UsersDAO();

    public List<Entries> CheckEntries() {
    	return entry.CheckEntries();
     
    }