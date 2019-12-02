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

        internal List<Medicamento> ListarPorCodMed(int pCodMed)
        {
            return _db.Medicamento.Where(x => x.CodMed == pCodMed).ToList();
        }
        public bool VerificarMedicamentoRepetido(string pNomMed) //metodo autenticar con parametro usuario y contraseña respectivamente
        {
            try
            {
                //en una var "res" donde usamos de la base de datos usando la tabla usuario donde x sea usado para uso de datos en tabla BD
                var res = _db.Medicamento.Where(x => x.NomMed == pNomMed).SingleOrDefault(); //singleOrdefault mandará excepcion si existe mas de un usuario con lo mismos datos
                if (res != null) //si res es diferente de vacio
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
