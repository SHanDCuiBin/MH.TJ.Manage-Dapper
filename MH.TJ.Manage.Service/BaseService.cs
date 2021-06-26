using DapperExtensions;
using MH.TJ.Manage.IRepository;
using MH.TJ.Manage.IService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        protected IBaseRepository<TEntity> _iBaseRepository;


        #region 事务操作
        public IDbTransaction TranStart()
        {
            return _iBaseRepository.TranStart();
        }
        public void TranRollBack(IDbTransaction tran)
        {
            _iBaseRepository.TranRollBack(tran);
        }
        public void TranCommit(IDbTransaction tran)
        {
            _iBaseRepository.TranCommit(tran);
        }
        #endregion

        /// <summary>
        /// 删除单个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="year">数据库年份（可选）</param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public virtual bool Delete<T>(T obj, int year = 0, IDbTransaction tran = null) where T : class
        {
            return _iBaseRepository.Delete<T>(obj, year, tran);
        }

        /// <summary>
        ///  删除实体列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="startyear">数据库开始年份（可选）</param>
        /// <param name="endyear">数据库结束年份（可选）</param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public virtual bool Delete<T>(IEnumerable<T> list, int startyear = 0, int endyear = 0, IDbTransaction tran = null) where T : class
        {
            return _iBaseRepository.Delete<T>(list, startyear, endyear, tran);
        }

        /// <summary>
        /// 获取单个对象 id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public virtual T Get<T>(string id, int startyear = 0, int endyear = 0, IDbTransaction tran = null) where T : class
        {
            return _iBaseRepository.Get<T>(id, startyear, endyear, tran);
        }

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
        public virtual IEnumerable<T> GetAll<T>(object predicate = null, int startyear = 0, int endyear = 0, IList<ISort> sort = null, IDbTransaction tran = null) where T : class
        {
            return _iBaseRepository.GetAll<T>(predicate, startyear, endyear, sort, tran);
        }

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
        public virtual IEnumerable<T> GetPage<T>(object predicate, IList<ISort> sort, int page, int pagesize, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null, bool buffered = true) where T : class
        {
            return _iBaseRepository.GetPage<T>(predicate, sort, page, pagesize, startyear, endyear, tran);
        }

        /// <summary>
        /// 单实体插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public virtual dynamic Insert<T>(T obj, int year = 0, IDbTransaction tran = null) where T : class
        {
            return _iBaseRepository.Insert<T>(obj, year, tran);
        }

        /// <summary>
        /// 列表插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        public virtual void Insert<T>(IEnumerable<T> list, int year = 0, IDbTransaction tran = null) where T : class
        {
            _iBaseRepository.Insert<T>(list, year, tran);
        }

        /// <summary>
        /// 实体更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="ignoreAllKeyProperties"></param>
        /// <returns></returns>
        public virtual bool Update<T>(T obj, int startyear = 0, int endyear = 0, IDbTransaction tran = null) where T : class
        {
            return _iBaseRepository.Update<T>(obj, startyear, endyear, tran);
        }

        /// <summary>
        /// 实体集合更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="ignoreAllKeyProperties"></param>
        /// <returns></returns>
        public virtual bool Update<T>(IEnumerable<T> list, int startyear = 0, int endyear = 0, IDbTransaction tran = null) where T : class
        {
            return _iBaseRepository.Update<T>(list, startyear, endyear, tran);
        }

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
        public virtual List<T> Query<T>(string sql, int startyear = 0, int endyear = 0, object param = null, IDbTransaction transaction = null)
        {
            return _iBaseRepository.Query<T>(sql, startyear, endyear, param, transaction);
        }

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
        public virtual int Execute<T>(string sql, object param = null, int startyear = 0, int endyear = 0, IDbTransaction transaction = null)
        {
            return _iBaseRepository.Execute<T>(sql, param, startyear, endyear, transaction);
        }
        #endregion

    }
}