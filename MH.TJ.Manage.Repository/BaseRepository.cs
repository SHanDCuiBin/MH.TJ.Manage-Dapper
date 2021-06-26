



using Dapper;
using DapperExtensions;
using log4net;
using MH.TJ.Manage.IRepository;
using MH.TJ.Manage.Utility._Constant;
using MH.TJ.Manage.Utility._DapperExtentions;
using MH.TJ.Manage.Utility._DESEncrypt;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MH.TJ.Manage.Repository
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly ILog _log = LogManager.GetLogger("NETCoreRepository", typeof(BaseRepository<TEntity>));

        private Database Connection = null;

        public BaseRepository(BunissDataBaseEmum baseType = BunissDataBaseEmum.healthInfoDB)
        {
            if (baseType == BunissDataBaseEmum.healthInfoDB)
            {
                var con = DbConnectionInfo.connList.Find(d => d.bunissDataBaseEmum == baseType && d.connId == baseType.ToString() + DateTime.Now.Year);
                Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
            }
            else
            {
                var con = DbConnectionInfo.connList.Find(d => d.bunissDataBaseEmum == baseType);
                Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
            }

            //日志
            Log(baseType.ToString());
        }

        /* ------------------------------------------------------------------------------
         *     【注意】：                                                               *
         *    1、可选择传输年份的方法。只用于 health_info 数据库，其他的数据库 没有必要 *
         *    2、默认为空或传输年份不在范围内，则默认当前年份                           *
        --------------------------------------------------------------------------------*/

        #region 事务操作
        public IDbTransaction TranStart()
        {
            if (Connection.Connection.State == ConnectionState.Closed)
                Connection.Connection.Open();
            return Connection.Connection.BeginTransaction();
        }
        public void TranRollBack(IDbTransaction tran)
        {
            tran.Rollback();
            if (Connection.Connection.State == ConnectionState.Open)
                tran.Connection.Close();
        }
        public void TranCommit(IDbTransaction tran)
        {
            tran.Commit();
            if (Connection.Connection.State == ConnectionState.Open)
                tran.Connection.Close();
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
        public bool Delete<T>(T obj, int year = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class
        {
            if (year >= 2015 && year <= DateTime.Now.Year)
            {
                var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + year);
                if (con == null)
                {
                    return false;
                }
                Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
                return Connection.Delete(obj, tran, commandTimeout);
            }
            else
            {
                return Connection.Delete(obj, tran, commandTimeout);
            }
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
        public bool Delete<T>(IEnumerable<T> list, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class
        {
            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                bool result = false;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return false;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
                    result = Connection.Delete(list, tran, commandTimeout);
                    if (!result)
                    {
                        break;
                    }
                }
                return result;
            }
            else
            {
                return Connection.Delete(list, tran, commandTimeout);
            }
        }

        /// <summary>
        /// 获取单个对象 id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public T Get<T>(string id, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class
        {
            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                T result = null;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return null;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);

                    result = Connection.Get<T>(id, tran, commandTimeout);
                    if (result != null)
                    {
                        break;
                    }
                }

                return result;
            }
            else
            {
                return Connection.Get<T>(id, tran, commandTimeout);
            }
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
        public IEnumerable<T> GetAll<T>(object predicate = null, int startyear = 0, int endyear = 0, IList<ISort> sort = null, IDbTransaction tran = null, int? commandTimeout = null, bool buffered = true) where T : class
        {
            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                IEnumerable<T> result = null;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return null;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);

                    var list = Connection.GetList<T>(predicate, sort, tran, commandTimeout, buffered);
                    if (result != null)
                    {
                        result = result.Concat(list);
                    }
                    else
                    {
                        result = list;
                    }
                }
                return result;
            }
            else
            {
                return Connection.GetList<T>(predicate, sort, tran, commandTimeout, buffered);
            }

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
        public IEnumerable<T> GetPage<T>(object predicate, IList<ISort> sort, int page, int pagesize, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null, bool buffered = true) where T : class
        {

            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                IEnumerable<T> result = null;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return null;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);

                    var list = Connection.GetPage<T>(predicate, sort, page, pagesize, tran, commandTimeout, buffered);
                    if (result != null)
                    {
                        result = result.Concat(list);
                    }
                    else
                    {
                        result = list;
                    }
                }
                return result;
            }
            else
            {
                return Connection.GetPage<T>(predicate, sort, page, pagesize, tran, commandTimeout, buffered);
            }
        }

        /// <summary>
        /// 单实体插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public dynamic Insert<T>(T obj, int year = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class
        {
            if (year >= 2015 && year <= DateTime.Now.Year)
            {
                var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + year);
                if (con == null)
                {
                    return false;
                }
                Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
                dynamic result = Connection.Insert(obj, tran, commandTimeout);
                return result;
            }
            else
            {
                return Connection.Insert(obj, tran, commandTimeout);
            }
        }

        /// <summary>
        /// 列表插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="tran"></param>
        /// <param name="commandTimeout"></param>
        public void Insert<T>(IEnumerable<T> list, int year = 0, IDbTransaction tran = null, int? commandTimeout = null) where T : class
        {
            if (year >= 2015 && year <= DateTime.Now.Year)
            {
                var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + year);
                if (con == null)
                {
                    return;
                }
                Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
                Connection.Insert(list, tran, commandTimeout);
            }
            else
            {
                Connection.Insert(list, tran, commandTimeout);
            }

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
        public bool Update<T>(T obj, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null, bool ignoreAllKeyProperties = true) where T : class
        {
            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                bool result = false;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return false;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
                    result = Connection.Update(obj, tran, commandTimeout, ignoreAllKeyProperties);
                    if (!result)
                    {
                        break;
                    }
                }
                return result;
            }
            else
            {
                return Connection.Update(obj, tran, commandTimeout, ignoreAllKeyProperties);
            }
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
        public bool Update<T>(IEnumerable<T> list, int startyear = 0, int endyear = 0, IDbTransaction tran = null, int? commandTimeout = null, bool ignoreAllKeyProperties = true) where T : class
        {
            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                bool result = false;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return false;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);
                    result = Connection.Update(list, tran, commandTimeout, ignoreAllKeyProperties);
                    if (!result)
                    {
                        break;
                    }
                }
                return result;
            }
            else
            {
                return Connection.Update(list, tran, commandTimeout, ignoreAllKeyProperties);
            }

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
        public List<T> Query<T>(string sql, int startyear = 0, int endyear = 0, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                IEnumerable<T> result = null;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return null;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);

                    var res = Connection.Connection.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType);
                    if (result != null)
                    {
                        result = result.Concat(res);
                    }
                    else
                    {
                        result = res.ToList();
                    }
                }

                return result.ToList();
            }
            else
            {
                return Connection.Connection.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType).ToList();
            }
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
        public int Execute<T>(string sql, object param = null, int startyear = 0, int endyear = 0, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            if (startyear >= 2015 && endyear <= DateTime.Now.Year)
            {
                int result = 0;
                for (int i = endyear; i >= startyear; i--)
                {
                    var con = DbConnectionInfo.connList.Find(d => d.connId == BunissDataBaseEmum.healthInfoDB.ToString() + i);
                    if (con == null)
                    {
                        return 0;
                    }
                    Connection = DbConnectionFactory.CreateConnection(con.connsctionstring, con.databaseType);

                    result += Connection.Connection.Execute(sql, param, transaction, commandTimeout, commandType);
                }
                return result;
            }
            else
            {
                return Connection.Connection.Execute(sql, param, transaction, commandTimeout, commandType);
            }

        }
        #endregion


        public void Dispose()
        {
            if (Connection != null)
            {
                Connection.Dispose();
            }
        }
        #region 日志
        private void Log(string connection)
        {
            Task.Run(() =>
                {

                });
        }
        #endregion

    }
}