using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PRADExamen.Models;
using System.Threading.Tasks;

namespace PRADExamen.Controllers
{
    public class Database
    {
        readonly SQLiteAsyncConnection dbconexion;


        public Database(string dbpath)
        {
            dbconexion = new SQLiteAsyncConnection(dbpath);


            dbconexion.CreateTableAsync<Contactos>();
        }

        internal void AddContactos(Views.PageContent contactos)
        {
            throw new NotImplementedException();
        }



        public Task<List<Contactos>> ObtenerListaContactos()
        {
            return dbconexion.Table<Contactos>().ToListAsync();
        }


        //OPERACIONES CRUD-CREATE, READ, UPDATE, DELETE
        //INSERT, SELECT, UPDATE, DELETE

        //CREATE-UPDATE

        public Task<int> AddContactos(Contactos contactos)
        {
            if (contactos.Id != 0)
            {


                return dbconexion.UpdateAsync(contactos);
            }
            else
            {
                return dbconexion.InsertAsync(contactos);
            }
        }


        public Task<Contactos> ObtenerContactos(int pid)
        {
            return dbconexion.Table<Contactos>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }


        public Task<int> DelContactos(Contactos contactos)
        {
            return dbconexion.DeleteAsync(contactos);
        }
    }
}

