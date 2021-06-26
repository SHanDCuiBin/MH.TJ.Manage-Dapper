

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 查体情况信息表 ----统计
    /// </summary>
    public class cms_tj_ctxx
    {
        /// <summary>
        /// 查体情况信息表 ----统计
        /// </summary>
        public cms_tj_ctxx()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public System.String taskId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public System.String ORG_ID { get; set; }

        /// <summary>
        /// 负责人ID号
        /// </summary>
        public System.String GC_USER_ID { get; set; }

        /// <summary>
        /// 体检日期
        /// </summary>
        public System.DateTime? TJRQ { get; set; }

        /// <summary>
        /// 1 老年人 2 儿童 幼儿园 3 中小学生 4 教师  5 职工 6  其他 
        /// </summary>
        public System.Int32? TJ_TYPE { get; set; }

        /// <summary>
        /// 上报时间
        /// </summary>
        public System.DateTime? COMMIT_TIME { get; set; }

        /// <summary>
        /// 报告状态信息id
        /// </summary>
        public System.String BG_STATE_ID { get; set; }

        /// <summary>
        /// 档案状态信息id
        /// </summary>
        public System.String DA_STATE_ID { get; set; }

        /// <summary>
        /// 上传状态信息id
        /// </summary>
        public System.String SC_STATE_ID { get; set; }

        /// <summary>
        /// 数据作废标记   0正常，1作废
        /// </summary>
        public System.Int32? INVALID_FLAG { get; set; }

        /// <summary>
        /// 报告/档案打印数量
        /// </summary>
        public System.Int32? BGDADY_COUNT { get; set; }

        /// <summary>
        /// 刷卡总人数
        /// </summary>
        public System.Int32? SK_COUNT { get; set; }

        /// <summary>
        /// 体检总人数
        /// </summary>
        public System.Int32? TJ_COUNT { get; set; }

        /// <summary>
        /// 未体检人数
        /// </summary>
        public System.Int32? WTJ_COUNT { get; set; }

        /// <summary>
        /// 规范人数
        /// </summary>
        public System.Int32? GF_COUNT { get; set; }

        /// <summary>
        /// 不规范人数
        /// </summary>
        public System.Int32? BGF_COUNT { get; set; }

        /// <summary>
        /// 收费人数
        /// </summary>
        public System.Int32? SF_COUNT { get; set; }

        /// <summary>
        /// 不收费人数
        /// </summary>
        public System.Int32? BSF_COUNT { get; set; }

        /// <summary>
        /// 自审已审数量
        /// </summary>
        public System.Int32? ZS_COUNT { get; set; }

        /// <summary>
        /// 自审时间
        /// </summary>
        public System.DateTime? ZS_QR_TIME { get; set; }

        /// <summary>
        /// 组审已审数量
        /// </summary>
        public System.Int32? ZZ_ZS_COUNT { get; set; }

        /// <summary>
        /// 组审人ID
        /// </summary>
        public System.String ZZ_USER_ID { get; set; }

        /// <summary>
        /// 组审人名称
        /// </summary>
        public System.String zz_user_name { get; set; }

        /// <summary>
        /// 组审时间
        /// </summary>
        public System.DateTime? ZZ_QR_TIME { get; set; }

        /// <summary>
        /// 医审已审数量
        /// </summary>
        public System.Int32? YY_YS_COUNT { get; set; }

        /// <summary>
        /// 医生审核时间
        /// </summary>
        public System.DateTime? YY_YS_TIME { get; set; }

        /// <summary>
        /// 审核医生
        /// </summary>
        public System.String YS_USER_NAME { get; set; }

        /// <summary>
        /// 确认医生审核负责人
        /// </summary>
        public System.String YYGC_USER_ID { get; set; }

        /// <summary>
        /// 申请打印时间
        /// </summary>
        public System.DateTime? SQDY_TIME { get; set; }

        /// <summary>
        /// 数据审核已审数量
        /// </summary>
        public System.Int32? SJ_SH_COUNT { get; set; }

        /// <summary>
        /// 数据审核时间
        /// </summary>
        public System.DateTime? SJ_QR_TIME { get; set; }

        /// <summary>
        /// 数据审核人
        /// </summary>
        public System.String SJ_USER_ID { get; set; }

        /// <summary>
        /// 数审人名称
        /// </summary>
        public System.String sj_user_name { get; set; }

        /// <summary>
        /// 制度内体检人数
        /// </summary>
        public System.Int32? ZDN_TJ_COUNT { get; set; }

        /// <summary>
        /// 糖化血球蛋白体检人数
        /// </summary>
        public System.Int32? TH_TJ_COUNT { get; set; }

        /// <summary>
        /// 肿瘤体检人数
        /// </summary>
        public System.Int32? ZL_TJ_COUNT { get; set; }

        /// <summary>
        /// 同型体检人数
        /// </summary>
        public System.Int32? TX_TJ_COUNT { get; set; }

        /// <summary>
        /// 血常规体检人数
        /// </summary>
        public System.Int32? XCG_TJ_COUNT { get; set; }

        /// <summary>
        /// 计划生育体检人数
        /// </summary>
        public System.Int32? JHSY_TJ_COUNT { get; set; }

        /// <summary>
        /// 精神病体检人数
        /// </summary>
        public System.Int32? JSB_TJ_COUNT { get; set; }

        /// <summary>
        /// 贫困户体检人数
        /// </summary>
        public System.Int32? PKH_TJ_COUNT { get; set; }

        /// <summary>
        /// 生化项目id
        /// </summary>
        public System.String SH_TJ_TYPE { get; set; }

        /// <summary>
        /// 生化体检人数
        /// </summary>
        public System.Int32? SH_TJ_COUNT { get; set; }

        /// <summary>
        /// B超检查人数
        /// </summary>
        public System.Int32? BC_TJ_COUNT { get; set; }

        /// <summary>
        /// 中医体检人数
        /// </summary>
        public System.Int32? ZYTZ_TJ_COUNT { get; set; }

        /// <summary>
        /// 备注信息，7天未打印原因
        /// </summary>
        public System.String BZ_MSG { get; set; }

        /// <summary>
        /// 预留
        /// </summary>
        public System.String RESERVED { get; set; }

        /// <summary>
        /// 报告申请人id
        /// </summary>
        public System.String BGapplyUserID { get; set; }

        /// <summary>
        /// 审核确认人id
        /// </summary>
        public System.String confirmUserId { get; set; }

        /// <summary>
        /// 审核确认日期
        /// </summary>
        public System.DateTime? confirmDate { get; set; }

        /// <summary>
        /// 档案申请人id
        /// </summary>
        public System.String DAapplyUserID { get; set; }

        /// <summary>
        /// 申请日期
        /// </summary>
        public System.DateTime? DAapplyDate { get; set; }

        /// <summary>
        /// 上报数据确认图片
        /// </summary>
        public System.String confirmImgPath { get; set; }

        /// <summary>
        /// 数据上报确认日期
        /// </summary>
        public System.DateTime? confirmImgDate { get; set; }

        /// <summary>
        /// 生化模板id
        /// </summary>
        public System.String SHMB_ID { get; set; }

        /// <summary>
        /// 血钾体检人数
        /// </summary>
        public System.Int32? XK_TJ_COUNT { get; set; }

        /// <summary>
        /// 血钠体检人数
        /// </summary>
        public System.Int32? NA_TJ_COUNT { get; set; }

        /// <summary>
        /// 血氯体检人数
        /// </summary>
        public System.Int32? CL_TJ_COUNT { get; set; }

        /// <summary>
        /// 乙肝五项体检人数
        /// </summary>
        public System.Int32? YG_TJ_COUNT { get; set; }

        /// <summary>
        /// 是否查体
        /// </summary>
        public System.Int32? is_check { get; set; }

        /// <summary>
        /// 报告打印任务是否分配： 0 未分配，1 已分配  2 已打印完成
        /// </summary>
        public System.Int32? is_distribute_bg { get; set; }

        /// <summary>
        /// 报告打印任务对应的责任人ID号
        /// </summary>
        public System.String responsible_bg { get; set; }

        /// <summary>
        /// 档案打印情况，0未打印，1已分配，2打印完成
        /// </summary>
        public System.Int32? is_distribute_da { get; set; }

        /// <summary>
        /// 档案打印任务对应的责任人ID号
        /// </summary>
        public System.String responsible_da { get; set; }

        /// <summary>
        /// 查体报告信息是否下载，0或null未下载，1已下载  2 已清除
        /// </summary>
        public System.String is_download_bg { get; set; }

        /// <summary>
        /// 查看档案信息是否下载，null或0未下载，1 已下载  2已清除
        /// </summary>
        public System.String is_download_da { get; set; }

        /// <summary>
        /// 补查标记0不是1补查
        /// </summary>
        public System.Int32 is_bc { get; set; }

        /// <summary>
        /// 是否已进行消息推送0.否1.是
        /// </summary>
        public System.Boolean is_msg_push { get; set; }

        /// <summary>
        /// 质控结果标记0通过1.报警2.失控
        /// </summary>
        public System.Int32? zk_color { get; set; }

        /// <summary>
        /// 质控信息首页展示
        /// </summary>
        public System.String zk_msg { get; set; }

        /// <summary>
        /// 定标信息首页展示
        /// </summary>
        public System.String db_msg { get; set; }

        /// <summary>
        /// 血球失控信息,分割
        /// </summary>
        public System.String xq_error_msg { get; set; }

        /// <summary>
        /// 生化失控信息，分隔
        /// </summary>
        public System.String sh_error_msg { get; set; }

        /// <summary>
        /// 生化报警信息，分隔
        /// </summary>
        public System.String sh_warning_msg { get; set; }

        /// <summary>
        /// 定标失控信息，分隔
        /// </summary>
        public System.String db_error_msg { get; set; }

        /// <summary>
        /// 生化质控具体项目及标记，ALT,1;TG,2;名称，状态0通过1.报警2.失控
        /// </summary>
        public System.String sh_name_state { get; set; }

        /// <summary>
        /// 报告快递发送时间
        /// </summary>
        public System.DateTime? sned_time { get; set; }

        /// <summary>
        /// 紧急打印：0 非紧急； 1 申请中；2 紧急
        /// </summary>
        public System.Int32? emergency_printing { get; set; }

        /// <summary>
        /// 钉钉审批id
        /// </summary>
        public System.String processInstanceId { get; set; }
    }
}