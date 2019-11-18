using FarmaciaOASIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaOASIS.Controladores
{
    class FacturaController
    {
        dbFarmaciaOASISEntities _db = new dbFarmaciaOASISEntities();

        //public List<Factura> Listar(string pBuscar)
        //{
        //   // return _db.Factura.Where(x => x.Nombre.Contains(pBuscar)).ToList();
        //}
        public bool Insertar(Data.Factura reg)
        {
            _db.Factura.Add(reg);
            _db.SaveChanges();
            return true;
        }
        //public bool Modificar(Data.Factura reg)
        //{
        //    _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
        //    return _db.SaveChanges() > 0;
        //}
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Factura.Where(x => x.NoFactura == pParametro).FirstOrDefault();
            _db.Factura.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        //internal List<Factura> BuscarPorCI(string pCi)
        //{
        //    return _db.Factura.Where(x => x.Ci == pCi).ToList();
        //}
    }
}
