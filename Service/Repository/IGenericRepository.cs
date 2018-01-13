using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repository
{
    public interface IGenericRepository<T> where T: class
    {

        //FONKSİYON PROTOTİPLERİOLUŞTURULUR
        void Insert(T item);
        T Get();
        List<T> GetAll();
        void Update(T item);
        void Delete(T item);
    }
}
