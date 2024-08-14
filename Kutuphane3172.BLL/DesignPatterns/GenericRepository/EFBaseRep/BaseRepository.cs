using Kutuphane3172.BLL.DesignPatterns.GenericRepository.IntRep;
using Kutuphane3172.BLL.DesignPatterns.SingletonPattern;
using Kutuphane3172.DAL.ContextClasses;
using Kutuphane3172.ENTITIES.Enums;
using Kutuphane3172.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.BLL.DesignPatterns.GenericRepository.EFBaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        KutuphaneContext _db;
        public BaseRepository()
        {
            _db = DBTool.DbInstance;
        }
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.DeletedDate = DateTime.Now;
            item.Status=DataStatus.Deleted;
            _db.SaveChanges();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);   
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetFirstDatas(int count = 1)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetLastDatas(int count = 1)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == DataStatus.Updated);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == DataStatus.Deleted);
        }

        public void Remove(T item, out string mesaj)
        {
            if (item.Status != DataStatus.Deleted )
            {
                mesaj = "Bu veriyi silmek için pasife çek";
                return;
            }
            mesaj = "Veri başarıyla silinmiştir";
            _db.Set<T>().Remove(item);
            _db.SaveChanges();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        public List<X> Select<X>(Expression<Func<T, X>> exp) where X : class
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.Status = DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T original = Find(item.ID);

            _db.Entry(original).CurrentValues.SetValues(item);            
            _db.SaveChanges();


        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }

        

        


    }
}
