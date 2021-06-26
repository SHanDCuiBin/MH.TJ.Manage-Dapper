
namespace MH.TJ.Manage.Models.health_info
{
    /// <summary>
    /// 健康体检  生化  质控结果信息表--记录生化质量结果数据
    /// </summary>
    public class mh_sh_qclog
    {
        /// <summary>
        /// 健康体检  生化  质控结果信息表--记录生化质量结果数据
        /// </summary>
        public mh_sh_qclog()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? Qc_Tjrq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_PosID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_Test_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_BatchID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? Qc_Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Qc_Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_Deviation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.SByte? Qc_Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_DayX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_DaySD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Print_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Cal_S1Abs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Cal_Factor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Cal_Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Cal_Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Cal_Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Qc_UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String create_user_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String org_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String car_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String up_msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String remark { get; set; }

        /// <summary>
        /// 0正常1报警2.失控
        /// </summary>
        public System.Int32? Qc_State { get; set; }

        /// <summary>
        /// 失控信息
        /// </summary>
        public System.String Qc_Error_Msg { get; set; }

        /// <summary>
        /// 报警信息
        /// </summary>
        public System.String Qc_Warning_Msg { get; set; }

        /// <summary>
        /// K值失控信息，如K值改变
        /// </summary>
        public System.String Qc_KErrror { get; set; }

        /// <summary>
        /// 定标天数
        /// </summary>
        public System.Int32? Cal_Day { get; set; }
    }
}