using FarmaciaOASIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaOASIS.Controladores
{
    class UsuarioController
    {
        dbFarmaciaOASISEntities _db = new dbFarmaciaOASISEntities();

        public List<Usuario> Listar(string pBuscar)
        {
            return _db.Usuario.Where(x => x.Nombre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Usuario reg)
        {
            _db.Usuario.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Usuario reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(string pParametro)
        {
            var reg = _db.Usuario.Where(x => x.Cuenta == pParametro).FirstOrDefault();
            _db.Usuario.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Usuario> BuscarPorPK(string pCuenta)
        {
            return _db.Usuario.Where(x => x.Cuenta == pCuenta).ToList();
        }
    }
}
