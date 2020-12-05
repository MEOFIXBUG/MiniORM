
using System.Collections.Generic;
using System.Data;

namespace MiniORM.Core
{
    public class DbSet<TEntity> where TEntity : class
    {
        string table = typeof(TEntity).Name;
        private DataSet dataSet;
        private DataTable mainTable;
        //string sqlQuery ;
        public DbSet()
        {
            //sqlQuery = $"SELECT * FROM {table}";
            dataSet = new DataSet();
            mainTable = new DataTable();
        }
        public void Include(string includeProperties)
        {

        }
        public TEntity ToEntity()
        {
            return null;
        }
        public IEnumerable<TEntity> ToList()
        {
            return null;
        }
        public TEntity Find(int id)
        {
            return null;
        }
        public TEntity Attach(TEntity entity)
        {
            return null;
        }
        public bool Delete(TEntity entity)
        {
            return false;
        }
        public bool Delete(int id)
        {
            return false;
        }
    }
}
