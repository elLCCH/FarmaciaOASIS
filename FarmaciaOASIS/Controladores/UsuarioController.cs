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

        public bool Autenticar(string pUser, string pPass) //metodo autenticar con parametro usuario y contraseña respectivamente
        {
            try
            {
                //en una var "res" donde usamos de la base de datos usando la tabla usuario donde x sea usado para uso de datos en tabla BD
                var res = _db.Usuario.Where(x => x.Cuenta == pUser && x.Contrasenia == pPass).SingleOrDefault(); //singleOrdefault mandará excepcion si existe mas de un usuario con lo mismos datos
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
        
        internal List<Usuario> ControlSesion(string pUser, string pPass)
        {
            return _db.Usuario.Where(x => x.Cuenta == pUser && x.Contrasenia == pPass).ToList();
        }
        
    }
}
