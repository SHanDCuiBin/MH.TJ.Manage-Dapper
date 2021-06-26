

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 档案上传信息表
    /// </summary>
    public class cms_tj_dasc
    {
        /// <summary>
        /// 档案上传信息表
        /// </summary>
        public cms_tj_dasc()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 体检表ID号
        /// </summary>
        public System.String TJ_ID { get; set; }

        /// <summary>
        /// 是否移库 1.true 2.false
        /// </summary>
        public System.Int32? SFYK_FLAG { get; set; }

        /// <summary>
        /// 移库数量
        /// </summary>
        public System.Int32? YK_COUNT { get; set; }

        /// <summary>
        /// 移库负责人ID
        /// </summary>
        public System.String YKFZR_USER_ID { get; set; }

        /// <summary>
        /// 移库时间
        /// </summary>
        public System.DateTime? YK_TIME { get; set; }

        /// <summary>
        /// 是否补全 1.是 2.否
        /// </summary>
        public System.Int32? SFBQ_FLAG { get; set; }

        /// <summary>
        /// 补全人
        /// </summary>
        public System.String BQR_USER_ID { get; set; }

        /// <summary>
        /// 补全确认时间
        /// </summary>
        public System.DateTime? BQQR_TIME { get; set; }

        /// <summary>
        /// 是否上传 1.是 2.否
        /// </summary>
        public System.Int32? UP_FLAG { get; set; }

        /// <summary>
        /// 操作人数
        /// </summary>
        public System.Int32? SC_COUNT { get; set; }

        /// <summary>
        /// 操作成功人数
        /// </summary>
        public System.Int32? SC_SUCCESS_COUNT { get; set; }

        /// <summary>
        /// 操作失败人数
        /// </summary>
        public System.Int32? SC_FAIL_COUNT { get; set; }

        /// <summary>
        /// 上传失败原因
        /// </summary>
        public System.String FAILE_REASON { get; set; }

        /// <summary>
        /// 上传人姓名
        /// </summary>
        public System.String UP_USER_ID { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public System.DateTime? UP_TIME { get; set; }

        /// <summary>
        /// 上传是否合格 1.是 2.否
        /// </summary>
        public System.Int32? UP_HG_FLAG { get; set; }

        /// <summary>
        /// 医院沟通人
        /// </summary>
        public System.String YYGTR_USER_ID { get; set; }

        /// <summary>
        /// 沟通时间
        /// </summary>
        public System.DateTime? YYGT_TIME { get; set; }

        /// <summary>
        /// 接收签字照片
        /// </summary>
        public System.String IMG_URL { get; set; }

        /// <summary>
        /// 上传确认情况 1.确认 2.未确认
        /// </summary>
        public System.Int32? YYQRQK { get; set; }

        /// <summary>
        /// 医院确认人
        /// </summary>
        public System.String YYQRR_NAME { get; set; }

        /// <summary>
        /// 医院确认时间
        /// </summary>
        public System.DateTime? YYQR_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String RESERVED { get; set; }

        /// <summary>
        /// 沟通确认人姓名
        /// </summary>
        public System.String YYGTR_USER_NAME { get; set; }

        /// <summary>
        /// 状态 0失败  1成功  2不上传
        /// </summary>
        public System.Int32? status { get; set; }
    }
}