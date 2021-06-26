

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 报告打印信息表
    /// </summary>
    public class cms_tj_bgdy
    {
        /// <summary>
        /// 报告打印信息表
        /// </summary>
        public cms_tj_bgdy()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 是否是补打的标记 1.true 2.false
        /// </summary>
        public System.UInt32? IS_BD { get; set; }

        /// <summary>
        /// 查体信息表ID号
        /// </summary>
        public System.String TJ_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String FASTMAILID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String BD_ID { get; set; }

        /// <summary>
        /// 打印份数
        /// </summary>
        public System.Int32? PRINT_COUNT { get; set; }

        /// <summary>
        /// 打印人ID
        /// </summary>
        public System.String PRINT_USER_ID { get; set; }

        /// <summary>
        /// 打印时间
        /// </summary>
        public System.DateTime? PRINT_TIME { get; set; }

        /// <summary>
        /// 打印是否合格 1.合格 2.不合格
        /// </summary>
        public System.Int32? HG_FLAG { get; set; }

        /// <summary>
        /// 数据处理对报告打印数量核实 1.符合 2.不符合
        /// </summary>
        public System.Int32? COUNT_FLAG { get; set; }

        /// <summary>
        /// 确认份数
        /// </summary>
        public System.Int32? QR_COUNT { get; set; }

        /// <summary>
        /// 异常份数
        /// </summary>
        public System.Int32? YC_COUNT { get; set; }

        /// <summary>
        /// 数据处理确认人名字ID
        /// </summary>
        public System.String DATA_QRR_USER_ID { get; set; }

        /// <summary>
        /// 数据处理确认时间
        /// </summary>
        public System.DateTime? DATA_QR_TIME { get; set; }

        /// <summary>
        /// 报告在数据处理不通过原因
        /// </summary>
        public System.String DATA_BTG_REASON { get; set; }

        /// <summary>
        /// 发送方式 1.当面 2.快递
        /// </summary>
        public System.Int32? SEND_FS { get; set; }

        /// <summary>
        /// 是否发送标记 1.已发送 2未发送
        /// </summary>
        public System.Int32? SEND_FLAG { get; set; }

        /// <summary>
        /// 发送人姓名
        /// </summary>
        public System.String FSR_USER_ID { get; set; }

        /// <summary>
        /// 报告发送时间
        /// </summary>
        public System.DateTime? SEND_TIME { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public System.String KDDH { get; set; }

        /// <summary>
        /// 快递名称
        /// </summary>
        public System.String DKMC { get; set; }

        /// <summary>
        /// 快递接受人名称
        /// </summary>
        public System.String KDJSR_NAME { get; set; }

        /// <summary>
        /// 接收人电话
        /// </summary>
        public System.String JSR_PHONE_NUMBER { get; set; }

        /// <summary>
        /// 接收地址
        /// </summary>
        public System.String JS_ADDRESS { get; set; }

        /// <summary>
        /// 报告接收状态 1.确认  2.未确认
        /// </summary>
        public System.Int32? JS_STATE { get; set; }

        /// <summary>
        /// 确认人ID
        /// </summary>
        public System.String JS_QRR_USER_ID { get; set; }

        /// <summary>
        /// 接收时间
        /// </summary>
        public System.DateTime? YY_JS_TIME { get; set; }

        /// <summary>
        /// 医院接收人
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
        /// 
        /// </summary>
        public System.String RESERVED { get; set; }

        /// <summary>
        /// 打印完成标记1.完成2.待打印
        /// </summary>
        public System.Int32? DY_COMPLETE_FLAG { get; set; }

        /// <summary>
        /// 接收签字照片
        /// </summary>
        public System.String IMG_URL { get; set; }

        /// <summary>
        /// 预计时间
        /// </summary>
        public System.DateTime? YJ_TIME { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public System.DateTime? KD_TIME { get; set; }

        /// <summary>
        /// 快递状态信息
        /// </summary>
        public System.String STATION { get; set; }

        /// <summary>
        /// 打印人姓名
        /// </summary>
        public System.String PRINT_USER_NAME { get; set; }

        /// <summary>
        /// 数据处理确认人姓名
        /// </summary>
        public System.String DATA_QRR_USER_NAME { get; set; }

        /// <summary>
        /// 发送人姓名
        /// </summary>
        public System.String FSR_USER_NAME { get; set; }

        /// <summary>
        /// 接收确认人姓名
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
        /// 当面交接人id,不为空时确认交接
        /// </summary>
        public System.String DM_JJR_USER_ID { get; set; }

        /// <summary>
        /// 当面交接人姓名
        /// </summary>
        public System.String DM_JJR_USER_NAME { get; set; }

        /// <summary>
        /// 当面交接时间
        /// </summary>
        public System.DateTime? DM_JJ_TIME { get; set; }

        /// <summary>
        /// 当面交接标记 0未 1已
        /// </summary>
        public System.Int32? DM_JJ_FLAG { get; set; }
    }
}