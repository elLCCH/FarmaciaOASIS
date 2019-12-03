using FarmaciaOASIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaOASIS.Controladores
{
    class ProveedorController
    {
        dbFarmaciaOASISEntities _db = new dbFarmaciaOASISEntities();

        public List<Proveedor> Listar(string pBuscar)
        {
            return _db.Proveedor.Where(x => x.Nombre.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Proveedor reg)
        {
            _db.Proveedor.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Proveedor reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Proveedor.Where(x => x.CodProv == pParametro).FirstOrDefault();
            _db.Proveedor.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Proveedor> BuscarPorPK(int pCodProv)
        {
            return _db.Proveedor.Where(x => x.CodProv == pCodProv).ToList();
        }
        
        internal List<Proveedor> ObtenerIdProvPorNombre(string pNombreProv)
        {
            return _db.Proveedor.Where(x => x.Nombre == pNombreProv).ToList();
            //return _db.Proveedor.Where(x => x.Nombre.Contains(pNombreProv)).ToList();
        }
    }
}
