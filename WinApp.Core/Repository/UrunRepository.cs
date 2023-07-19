using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;
using WinApp.Core;
using WinApp.Core.InterFace;
using WinFormsApp11.Models;

namespace WinFormsApp11.Core.Repository
{
    public class UrunRepository : DatabaseConnection, IUrun
    {
        public int Create(Urun model)
        {
            using (IDbConnection conn = GetConnection)
            {
                int id = (int)conn.Insert(model);
                return id;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using(IDbConnection conn = GetConnection)
                {
                    Urun urun = conn.Get<Urun>(id);
                    urun.Durum = -1;
                    conn.Update(urun);
                    return true;
                }
                
            }
            catch
            {
                return false;
            }
        }

        public Urun Get(int id)
        {
            using (IDbConnection connection = GetConnection)
            {
                // SELECT * FROM Urun WHERE Id = 5;
                Urun urun = connection.Get<Urun>(id);
                return urun;
            }
        }

        public IEnumerable<Urun> GetAll()
        {
            using (IDbConnection conn = GetConnection)
            {
                DynamicParameters param = new();
                param.Add("@Durum", -1);
                string query = "SELECT * FROM Urun WHERE Durum != @Durum";

                IEnumerable<Urun> urunler = conn.Query<Urun>(query, param);
                return urunler;
            }
        }

        public bool Update(Urun model)
        {


            try
            {
                using (IDbConnection conn = GetConnection)
                    conn.Update(model);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
