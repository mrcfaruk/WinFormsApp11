using System.Data;
using WinApp.Core.InterFace;
using WinFormsApp11.Core.Repository;
using WinFormsApp11.Models;

namespace WinFormsapp11.Bussiness
{
    public class UrunManager : IUrun
    {
        private readonly IUrun _repo;

        public UrunManager()
        {
            _repo = new UrunRepository();
        }

      
        public Urun Get(int id)
        {
            //SELECT * FROM Urun WHERE Id = 1;
            return _repo.Get(id);
        }

        public IEnumerable<Urun> GetAll()
        {
            return _repo.GetAll();
        }

        public int Create(Urun model)
        {
            return _repo.Create(model);
        }

        public bool Update(Urun model)
        {
            return _repo.Update(model);
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        
      
    }
}
