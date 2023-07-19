namespace WinApp.Core.InterFace
{
    public interface IBaseInterface<T> where T : class
    {
        T Get(int id); //select * from tablo ismi where id

        IEnumerable<T> GetAll(); //select * from tablo ismi

        int Create(T model);

        bool Update(T model);

        bool Delete(int id);
    }
}
