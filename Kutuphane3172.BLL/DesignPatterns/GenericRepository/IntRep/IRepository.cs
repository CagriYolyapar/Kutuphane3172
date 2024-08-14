using Kutuphane3172.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {

        //List Commands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        //Modify Commands

        void Add(T item);
        void Delete(T item);
        void Update(T item);
        void Remove(T item, out string mesaj);

        //Linq Commands

        #region LinqNotlari
        //_db.Products.Where(x => x.UnitPrice < 20).ToList();

        //Argümanın birinci kısmı verdiginiz kelimenin veya harfin hangi tipi temsil edecegidir (x =>)

        //İkinci kısım(x.UnitPrice < 20) 1. kısım olarak gelen yapının hangi işlemlere maruz kalacagını belirten  , bu işlemin tipini söyleyen kısımdır

        //    x => 
        //    x.UnitPrice < 20 


        //T , bool

        //Expression<Func<T,bool>>                    

        //x => x.UnitPrice < 20 
        #endregion

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);
        List<X> Select<X>(Expression<Func<T, X>> exp) where X : class;

        //Find
        T Find(int id);
        //Last Datas
        List<T> GetLastDatas(int count = 1);
        //First Datas
        List<T> GetFirstDatas(int count = 1);












    }
}
