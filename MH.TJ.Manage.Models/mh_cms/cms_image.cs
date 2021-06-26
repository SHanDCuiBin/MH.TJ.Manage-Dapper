

namespace MH.TJ.Manage.Models.mh_cms
{
    /// <summary>
    /// 需求模板、上报数据确认表 图片
    /// </summary>
    public class cms_image
    {
        /// <summary>
        /// 需求模板、上报数据确认表 图片
        /// </summary>
        public cms_image()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public System.String id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String orgid { get; set; }

        /// <summary>
        /// 查体任务Id
        /// </summary>
        public System.String taskid { get; set; }

        /// <summary>
        /// 查体类型 1 老年人 2 儿童 幼儿园 3 中小学生 4 教师  5 职工 6  其他 
        /// </summary>
        public System.String checktype { get; set; }

        /// <summary>
        /// 图片类别 1需求模板照片  2数据上报确认照片
        /// </summary>
        public System.String type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String years { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String imagepath { get; set; }

        /// <summary>
        /// 是否作废 0上传  1作废  2确认
        /// </summary>
        public System.Int32? isdelelte { get; set; }

        /// <summary>
        /// 需求模板组Id
        /// </summary>
        public System.String unitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String createrId { get; set; }

        /// <summary>
        /// 审核人Id
        /// </summary>
        public System.String checkUserId { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public System.DateTime? createDate { get; set; }

        /// <summary>
        /// 审核日期
        /// </summary>
        public System.DateTime? checkDate { get; set; }
    }
}