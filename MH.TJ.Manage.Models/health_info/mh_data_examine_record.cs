
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 
    /// </summary>
    public class mh_data_examine_record
    {
        /// <summary>
        /// 
        /// </summary>
        public mh_data_examine_record()
        {
        }

        /// <summary>
        /// 主键编码
        /// </summary>
        public System.String Id { get; set; }

        /// <summary>
        /// 儿童、老年人体检信息管理，主键编码
        /// </summary>
        public System.String Physical_Id { get; set; }

        /// <summary>
        /// 体检类型0：老年人，1：儿童
        /// </summary>
        public System.Int32? Physical_Type { get; set; }

        /// <summary>
        /// 逻辑删除。0：新增数据（可用），1：数据恢复（不可用）
        /// </summary>
        public System.Int32? Del_Flag { get; set; }

        /// <summary>
        /// null/0未查  1 正常  2 异常 ----心电图
        /// </summary>
        public System.Int32? Cardiogram_flag { get; set; }

        /// <summary>
        /// 心电图异常   存储机器结论
        /// </summary>
        public System.String Cardiogram_error { get; set; }

        /// <summary>
        /// 心电图结论   医生异常指导
        /// </summary>
        public System.String Cardiogram_conclusion { get; set; }

        /// <summary>
        /// 心电图 审核医生
        /// </summary>
        public System.String Doctor_name { get; set; }

        /// <summary>
        /// 回退原因
        /// </summary>
        public System.String Cause { get; set; }

        /// <summary>
        /// null/0 未审核  1审核通过   2 审核不通过 3 医生不审核（医生不审核可以移库）
        /// </summary>
        public System.Int32? status { get; set; }

        /// <summary>
        /// 责任医生---医院审核医生姓名和责任医生
        /// </summary>
        public System.String zrys { get; set; }
    }
}