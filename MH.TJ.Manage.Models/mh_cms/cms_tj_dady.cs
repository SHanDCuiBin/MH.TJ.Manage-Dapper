

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 体检档案打印信息表
    /// </summary>
    public class cms_tj_dady
    {
        /// <summary>
        /// 体检档案打印信息表
        /// </summary>
        public cms_tj_dady()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 查体信息表ID号
        /// </summary>
        public System.String TJ_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? IS_BD { get; set; }

        /// <summary>
        /// 档案上传打印表ID号
        /// </summary>
        public System.String DASC_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String BD_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String FASTMAILID { get; set; }

        /// <summary>
        /// 档案是否可打印 1.true 2.false
        /// </summary>
        public System.Int32? KDY_FLAG { get; set; }

        /// <summary>
        /// 确认人姓名
        /// </summary>
        public System.String KDY_QRR_USER_ID { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        public System.DateTime? KDY_QR_TIME { get; set; }

        /// <summary>
        /// 档案打印份数
        /// </summary>
        public System.Int32? DY_COUNT { get; set; }

        /// <summary>
        /// 档案打印人姓名
        /// </summary>
        public System.String DYR_USER_ID { get; set; }

        /// <summary>
        /// 档案打印时间
        /// </summary>
        public System.DateTime? DY_TIME { get; set; }

        /// <summary>
        /// 打印是否合格标记 1.合格 2.不合格
        /// </summary>
        public System.Int32? DY_SFHG_FLAG { get; set; }

        /// <summary>
        /// 确认份数
        /// </summary>
        public System.Int32? QR_COUNT { get; set; }

        /// <summary>
        /// 异常份数
        /// </summary>
        public System.Int32? YC_COUNT { get; set; }

        /// <summary>
        /// 合格确认人
        /// </summary>
        public System.String HG_QRR_USER_ID { get; set; }

        /// <summary>
        /// 合格确认时间
        /// </summary>
        public System.DateTime? HG_QR_TIME { get; set; }

        /// <summary>
        /// 打印不通过原因
        /// </summary>
        public System.String DY_BTG_REASON { get; set; }

        /// <summary>
        /// 发送方式 1.当面 2.快递
        /// </summary>
        public System.Int32? SEND_FS { get; set; }

        /// <summary>
        /// 交接人姓名
        /// </summary>
        public System.String SEND_JJR_USER_ID { get; set; }

        /// <summary>
        /// 发送交接时间
        /// </summary>
        public System.DateTime? SEND_JJ_TIME { get; set; }

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
        /// 确认份数
        /// </summary>
        public System.Int32? JS_QR_COUNT { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        public System.DateTime? YY_JS_TIME { get; set; }

        /// <summary>
        /// 当面,医院接收人
        /// </summary>
        public System.String YY_JSR_NAME { get; set; }

        /// <summary>
        /// 接收是否合格 1.合格 2.不合格
        /// </summary>
        public System.Int32? JS_QR_SFHG_FLAG { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String RESERVED { get; set; }

        /// <summary>
        /// 档案档案是否完成 1.true 2.false
        /// </summary>
        public System.Int32? DYSFWC_FLAG { get; set; }

        /// <summary>
        /// 档案是否发送1.是 2.否
        /// </summary>
        public System.Int32? SEND_FLAG { get; set; }

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
        /// 可打印确认人
        /// </summary>
        public System.String KDY_QRR_USER_NAME { get; set; }

        /// <summary>
        /// 打印人
        /// </summary>
        public System.String DYR_USER_NAME { get; set; }

        /// <summary>
        /// 打印合格确认人
        /// </summary>
        public System.String HG_QRR_USER_NAME { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public System.String SEND_JJR_USER_NAME { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public System.String JS_QRR_USER_NAME { get; set; }

        /// <summary>
        /// 发送标记
        /// </summary>
        public System.String FS_BIAO_JI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String CD_ID { get; set; }

        /// <summary>
        /// 交接人id，不为空时确认交接
        /// </summary>
        public System.String DM_JJR_USER_ID { get; set; }

        /// <summary>
        /// 交接人name
        /// </summary>
        public System.String DM_JJR_USER_NAME { get; set; }

        /// <summary>
        /// 当面交接时间
        /// </summary>
        public System.DateTime? DM_JJ_TIME { get; set; }

        /// <summary>
        /// 交接标记 0未，1已
        /// </summary>
        public System.Int32? DM_JJ_FLAG { get; set; }
    }
}