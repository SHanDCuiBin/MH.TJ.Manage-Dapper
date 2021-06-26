

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 补打申请
    /// </summary>
    public class cms_tj_bd
    {
        /// <summary>
        /// 补打申请
        /// </summary>
        public cms_tj_bd()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 补打类型 1.报告 2.档案
        /// </summary>
        public System.Int32? TYPE { get; set; }

        /// <summary>
        /// 1 老年人 2 儿童 幼儿园 3 中小学生 4 教师  5 职工 6  其他 
        /// </summary>
        public System.Int32? TJ_TYPE { get; set; }

        /// <summary>
        /// 体检ID号
        /// </summary>
        public System.String ORG_ID { get; set; }

        /// <summary>
        /// 补打份数/人数
        /// </summary>
        public System.Int32? BD_COUNT { get; set; }

        /// <summary>
        /// 补打原因ID
        /// </summary>
        public System.String BD_REASON_ID { get; set; }

        /// <summary>
        /// 补打的原因
        /// </summary>
        public System.String BD_REASON { get; set; }

        /// <summary>
        /// 补打申请时间
        /// </summary>
        public System.DateTime? BD_SQ_TIME { get; set; }

        /// <summary>
        /// 补打申请人ID号
        /// </summary>
        public System.String BD_SQ_USER_ID { get; set; }

        /// <summary>
        /// 补打申请人
        /// </summary>
        public System.String BD_SQ_USER_NAME { get; set; }

        /// <summary>
        /// 数据确认时间
        /// </summary>
        public System.DateTime? SJ_QR_TIME { get; set; }

        /// <summary>
        /// 数据审核确认打印用户ID
        /// </summary>
        public System.String SJ_USER_ID { get; set; }

        /// <summary>
        /// 数据审核确认人
        /// </summary>
        public System.String SJ_USER_NAME { get; set; }

        /// <summary>
        /// 档案打印时间
        /// </summary>
        public System.DateTime? DY_TIME { get; set; }

        /// <summary>
        /// 档案打印人姓名
        /// </summary>
        public System.String DYR_USER_ID { get; set; }

        /// <summary>
        /// 打印人
        /// </summary>
        public System.String DYR_USER_NAME { get; set; }

        /// <summary>
        /// 合格确认时间
        /// </summary>
        public System.DateTime? HG_QR_TIME { get; set; }

        /// <summary>
        /// 合格确认人
        /// </summary>
        public System.String HG_QRR_USER_ID { get; set; }

        /// <summary>
        /// 打印合格确认人
        /// </summary>
        public System.String HG_QRR_USER_NAME { get; set; }

        /// <summary>
        /// 发送方式 1.当面 2.快递
        /// </summary>
        public System.Int32? SEND_FS { get; set; }

        /// <summary>
        /// 是否发送标记 1.已发送 2未发送
        /// </summary>
        public System.Int32? SEND_FLAG { get; set; }

        /// <summary>
        /// 发送交接时间
        /// </summary>
        public System.DateTime? SEND_TIME { get; set; }

        /// <summary>
        /// 交接人姓名
        /// </summary>
        public System.String SEND_USER_ID { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public System.String SEND_USER_NAME { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public System.String KDDH { get; set; }

        /// <summary>
        /// 快递名称
        /// </summary>
        public System.String KDMC { get; set; }

        /// <summary>
        /// 快递接收人名称
        /// </summary>
        public System.String KDJSR_NAME { get; set; }

        /// <summary>
        /// 接收人电话
        /// </summary>
        public System.String JSR_PHONE_NAMBER { get; set; }

        /// <summary>
        /// 接收地址
        /// </summary>
        public System.String JS_ADDRESS { get; set; }

        /// <summary>
        /// 确认人
        /// </summary>
        public System.String JS_QRR_USER_ID { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public System.String JS_QRR_USER_NAME { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        public System.DateTime? YY_JS_TIME { get; set; }

        /// <summary>
        /// 当面,医院接收人
        /// </summary>
        public System.String YY_JSR_NAME { get; set; }

        /// <summary>
        /// 接收份数
        /// </summary>
        public System.Int32? YY_JS_COUNT { get; set; }

        /// <summary>
        /// 接收是否合格 1.合格 2.不合格
        /// </summary>
        public System.Int32? JS_QR_SFHG_FLAG { get; set; }

        /// <summary>
        /// 报告接收状态 1.确认  2.未确认
        /// </summary>
        public System.Int32? JS_STATE { get; set; }

        /// <summary>
        /// 接收签字照片
        /// </summary>
        public System.String IMG_URL { get; set; }

        /// <summary>
        /// 预计时间
        /// </summary>
        public System.DateTime? YJ_TIME { get; set; }

        /// <summary>
        /// 快递信息时间
        /// </summary>
        public System.DateTime? KD_TIME { get; set; }

        /// <summary>
        /// 快递状态信息
        /// </summary>
        public System.String STATION { get; set; }

        /// <summary>
        /// 发送标记
        /// </summary>
        public System.String FS_BIAO_JI { get; set; }

        /// <summary>
        /// 当面交接时间
        /// </summary>
        public System.DateTime? DM_JJ_TIME { get; set; }

        /// <summary>
        /// 交接人id，不为空时确认交接
        /// </summary>
        public System.String DM_JJR_USER_ID { get; set; }

        /// <summary>
        /// 交接人name
        /// </summary>
        public System.String DM_JJR_USER_NAME { get; set; }

        /// <summary>
        /// 交接标记 0未，1已
        /// </summary>
        public System.Int32? DM_JJ_FLAG { get; set; }

        /// <summary>
        /// 状态ID
        /// </summary>
        public System.String STATE_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String RESERVED { get; set; }
    }
}