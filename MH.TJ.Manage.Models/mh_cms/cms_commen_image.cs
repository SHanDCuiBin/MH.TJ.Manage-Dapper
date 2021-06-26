

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 质控图片上传信息表
    /// </summary>
    public class cms_commen_image
    {
        /// <summary>
        /// 质控图片上传信息表
        /// </summary>
        public cms_commen_image()
        {
        }

        /// <summary>
        /// 主键
        /// </summary>
        public System.String ID { get; set; }

        /// <summary>
        /// 上传人id
        /// </summary>
        public System.String SC_USER_ID { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public System.DateTime? SC_TIME { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public System.String IMAGE_URL { get; set; }

        /// <summary>
        /// 类型1质控2血球保养3生化保养4尿机保养5卫生6尿机质控 7机构需求模板
        /// </summary>
        public System.Int32? TYPE { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public System.String CAR_ID { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public System.String PLATE_NO { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public System.String ORG_ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String ORG_NAME { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public System.String REASON { get; set; }

        /// <summary>
        /// 上传人姓名
        /// </summary>
        public System.String SC_USER_NAME { get; set; }
    }
}