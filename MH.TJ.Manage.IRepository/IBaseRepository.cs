using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : class, new()
    {
        #region 事务操作
        public IDbTransaction TranStart();
        public void TranRollBack(IDbTransaction tran);
        public void TranCommit(IDbTransaction tran);
        #endregion


        /// <summary>
        /// 删除单个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public bool Delete<T>(T obj, int year = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 删除实体列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public bool Delete<T>(IEnumerable<T> list, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 获取单个对象 id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public T Get<T>(string id, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 获取对象列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="sort"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="buffered"></param>
        /// <returns></returns>
        public IEnumerable<T> GetAll<T>(object predicate = null, int startyear = 0, int endyear = 0, IList<ISort> sort = null, IDbTransaction tran = null, int? commandTimeout = null, bool buffered = true) where T : class;

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="pagesize"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="buffered"></param>
        /// <returns></returns>
        public IEnumerable<T> GetPage<T>(object predicate, IList<ISort> sort, int page, int pagesize, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null, bool buffered = true) where T : class;

        /// <summary>
        /// 单实体插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public dynamic Insert<T>(T obj, int year = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 列表插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        public void Insert<T>(IEnumerable<T> list, int year = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 实体更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="ignoreAllKeyProperties"></param>
        /// <returns></returns>
        public bool Update<T>(T obj, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null, bool ignoreAllKeyProperties = true) where T : class;

        /// <summary>
        /// 实体集合更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="ignoreAllKeyProperties"></param>
        /// <returns></returns>
        public bool Update<T>(IEnumerable<T> list, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null, bool ignoreAllKeyProperties = true) where T : class;

        #region 自定义 SQL语句操作
        /// <summary>
        /// 自定义SQL语句查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="buffered"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public List<T> Query<T>(string sql, int startyear = 0, int endyear = 0, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="buffered"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns>受影响的行数</returns>
        public int Execute<T>(string sql, object param = null, int startyear = 0, int endyear = 0, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);
        #endregion
    }
}
