using FarmaciaOASIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaOASIS.Controladores
{
    class DetalleFacturaController
    {
        dbFarmaciaOASISEntities _db = new dbFarmaciaOASISEntities();

        
        public bool Insertar(Data.DetalleFactura reg)
        {
            _db.DetalleFactura.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.DetalleFactura reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.DetalleFactura.Where(x => x.Numero == pParametro).FirstOrDefault();
            _db.DetalleFactura.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<DetalleFactura> Listar(int pNoFactura)
        {
            return _db.DetalleFactura.Where(x => x.NoFactura == pNoFactura).ToList();
        }
        internal List<DetalleFactura> ListarTodo()
        {
            return _db.DetalleFactura.Select(x => x).OrderByDescending(y=>y.NoFactura).ToList();
        }
       
    }
}
