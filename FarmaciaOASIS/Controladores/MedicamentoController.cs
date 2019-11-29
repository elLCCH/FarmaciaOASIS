using FarmaciaOASIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaOASIS.Controladores
{
    class MedicamentoController
    {
        dbFarmaciaOASISEntities _db = new dbFarmaciaOASISEntities();

        public List<Medicamento> Listar(string pBuscar)
        {
            return _db.Medicamento.Where(x => x.NomMed.Contains(pBuscar)).ToList();
            //return _db.Medicamento.).ToList();
        }
        public bool Insertar(Data.Medicamento reg)
        {
            _db.Medicamento.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Medicamento reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Medicamento.Where(x => x.CodMed == pParametro).FirstOrDefault();
            _db.Medicamento.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Medicamento> BuscarPorPK(int pCodMed)
        {
            return _db.Medicamento.Where(x => x.CodMed == pCodMed).ToList();
        }
        internal string ObtenerNombreMed(int pCodMed)
        {
            //return _db.Medicamento.Select(x=>x.NomMed)
            var Namemed = _db.Medicamento.Where(s => s.CodMed == pCodMed)
                          .Select(s => s.NomMed).ToString();
            return Namemed;
        }
    }
}
