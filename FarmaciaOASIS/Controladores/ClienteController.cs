using FarmaciaOASIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaOASIS.Controladores
{
    class ClienteController
    {
        dbFarmaciaOASISEntities _db = new dbFarmaciaOASISEntities();

        public List<Cliente> Listar(string pBuscar)
        {
            return _db.Cliente.Where(x => x.Nombre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Cliente reg)
        {
            _db.Cliente.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Cliente reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(string pParametro)
        {
            var reg = _db.Cliente.Where(x => x.Ci == pParametro).FirstOrDefault();
            _db.Cliente.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Cliente> BuscarPorCI(string pCi)
        {
            return _db.Cliente.Where(x => x.Ci == pCi).ToList();
        }
        
    }
}
