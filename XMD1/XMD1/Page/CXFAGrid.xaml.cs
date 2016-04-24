using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XMD1.Page
{
    /// <summary>
    /// 动态生成查询列
    /// </summary>
    public partial class CXFAGrid : ContentPage
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CXFAGrid()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            #region 数据
            //绑定数据列
            string Json = "[{\"QUERYRESULT_GUID\":\"e38808ec-e077-42a1-861e-ab034e3eae9e\",\"PAGE_REGISTER_GUID\":\"55ead1ca-6db2-4085-bc4f-8e48c1fe3b99\",\"PATTERN_GUID\":\"93ed2478-efd2-43aa-b3d4-20706d7a7d7b\",\"ATTRIBUTE_CODE\":\"PLANT_NO\",\"COLUMN_KEY\":\"PLANT_NO\",\"LANGUAGE_KEY\":\"806be893-805a-48b3-be25-1ac2869c7b3f\",\"LANGUAGE_VALUE\":\"工厂\",\"RESULT_TYPE\":\"01\",\"RESULT_URL\":null,\"COLUMN_WIDTH\":\"80\",\"COLUMN_ALIGN\":\"Left\",\"RESULT_ORDER\":1,\"BUFFER1\":null,\"BUFFER2\":null,\"BUFFER3\":null,\"BUFFER4\":null,\"BUFFER5\":null,\"ID\":null,\"ENABLEFLAG\":\"Y\",\"REMARK\":null,\"CREATEDATE\":\"\\/Date(1460550320000+0800)\\/\",\"CREATEBY\":\"bcsupport\",\"LASTUPDATEDATE\":\"\\/Date(1460550329000+0800)\\/\",\"LASTUPDATEBY\":\"bcsupport\",\"DB_TYPE\":\"\",\"ORACLE_SQL\":null,\"SQL_SERVER_SQL\":null,\"LANGUAGETYPE\":null,\"QPSQL\":null,\"PRIMARYKEY_ID\":null,\"ESCAPE_KEY\":\"\"},{\"QUERYRESULT_GUID\":\"cfd3d6e7-1114-49fa-8d31-b2a4139ca4bf\",\"PAGE_REGISTER_GUID\":\"55ead1ca-6db2-4085-bc4f-8e48c1fe3b99\",\"PATTERN_GUID\":\"93ed2478-efd2-43aa-b3d4-20706d7a7d7b\",\"ATTRIBUTE_CODE\":\"LOCATION_NO\",\"COLUMN_KEY\":\"LOCATION_NO\",\"LANGUAGE_KEY\":\"8b6797d3-43c0-4c5b-926b-3ae35045bfa6\",\"LANGUAGE_VALUE\":\"仓库\",\"RESULT_TYPE\":\"01\",\"RESULT_URL\":null,\"COLUMN_WIDTH\":\"80\",\"COLUMN_ALIGN\":\"Left\",\"RESULT_ORDER\":2,\"BUFFER1\":null,\"BUFFER2\":null,\"BUFFER3\":null,\"BUFFER4\":null,\"BUFFER5\":null,\"ID\":null,\"ENABLEFLAG\":\"Y\",\"REMARK\":null,\"CREATEDATE\":\"\\/Date(1460550320000+0800)\\/\",\"CREATEBY\":\"bcsupport\",\"LASTUPDATEDATE\":\"\\/Date(1460550338000+0800)\\/\",\"LASTUPDATEBY\":\"bcsupport\",\"DB_TYPE\":\"\",\"ORACLE_SQL\":null,\"SQL_SERVER_SQL\":null,\"LANGUAGETYPE\":null,\"QPSQL\":null,\"PRIMARYKEY_ID\":null,\"ESCAPE_KEY\":\"\"},{\"QUERYRESULT_GUID\":\"71c8493c-6277-4ad2-adbe-b8408c779bb7\",\"PAGE_REGISTER_GUID\":\"55ead1ca-6db2-4085-bc4f-8e48c1fe3b99\",\"PATTERN_GUID\":\"93ed2478-efd2-43aa-b3d4-20706d7a7d7b\",\"ATTRIBUTE_CODE\":\"BIN_NO\",\"COLUMN_KEY\":\"BIN_NO\",\"LANGUAGE_KEY\":\"494decd4-0b57-462f-bcd5-a8a3c7d8b87d\",\"LANGUAGE_VALUE\":\"BIN_NO\",\"RESULT_TYPE\":\"01\",\"RESULT_URL\":null,\"COLUMN_WIDTH\":\"60\",\"COLUMN_ALIGN\":\"Left\",\"RESULT_ORDER\":3,\"BUFFER1\":null,\"BUFFER2\":null,\"BUFFER3\":null,\"BUFFER4\":null,\"BUFFER5\":null,\"ID\":null,\"ENABLEFLAG\":\"Y\",\"REMARK\":null,\"CREATEDATE\":\"\\/Date(1460550320000+0800)\\/\",\"CREATEBY\":\"bcsupport\",\"LASTUPDATEDATE\":\"\\/Date(1460550344000+0800)\\/\",\"LASTUPDATEBY\":\"bcsupport\",\"DB_TYPE\":\"\",\"ORACLE_SQL\":null,\"SQL_SERVER_SQL\":null,\"LANGUAGETYPE\":null,\"QPSQL\":null,\"PRIMARYKEY_ID\":null,\"ESCAPE_KEY\":\"\"},{\"QUERYRESULT_GUID\":\"b2d3ad0e-369c-4a02-b252-8f8ecc2551ea\",\"PAGE_REGISTER_GUID\":\"55ead1ca-6db2-4085-bc4f-8e48c1fe3b99\",\"PATTERN_GUID\":\"93ed2478-efd2-43aa-b3d4-20706d7a7d7b\",\"ATTRIBUTE_CODE\":\"WAREHOUSE_NO\",\"COLUMN_KEY\":\"WAREHOUSE_NO\",\"LANGUAGE_KEY\":\"aedbbef6-1b4c-4994-a71c-f494b8ca1994\",\"LANGUAGE_VALUE\":\"仓库编号\",\"RESULT_TYPE\":\"01\",\"RESULT_URL\":null,\"COLUMN_WIDTH\":\"80\",\"COLUMN_ALIGN\":\"Left\",\"RESULT_ORDER\":4,\"BUFFER1\":null,\"BUFFER2\":null,\"BUFFER3\":null,\"BUFFER4\":null,\"BUFFER5\":null,\"ID\":null,\"ENABLEFLAG\":\"Y\",\"REMARK\":null,\"CREATEDATE\":\"\\/Date(1460550321000+0800)\\/\",\"CREATEBY\":\"bcsupport\",\"LASTUPDATEDATE\":\"\\/Date(1460550350000+0800)\\/\",\"LASTUPDATEBY\":\"bcsupport\",\"DB_TYPE\":\"\",\"ORACLE_SQL\":null,\"SQL_SERVER_SQL\":null,\"LANGUAGETYPE\":null,\"QPSQL\":null,\"PRIMARYKEY_ID\":null,\"ESCAPE_KEY\":\"\"},{\"QUERYRESULT_GUID\":\"742fe78b-e78e-40a0-ab5f-6a360b6f30ab\",\"PAGE_REGISTER_GUID\":\"55ead1ca-6db2-4085-bc4f-8e48c1fe3b99\",\"PATTERN_GUID\":\"93ed2478-efd2-43aa-b3d4-20706d7a7d7b\",\"ATTRIBUTE_CODE\":\"IS_LOCK\",\"COLUMN_KEY\":\"IS_LOCK\",\"LANGUAGE_KEY\":\"e377aba5-b89a-4556-be25-48ff5aebc5ff\",\"LANGUAGE_VALUE\":\"是否锁定\",\"RESULT_TYPE\":\"01\",\"RESULT_URL\":null,\"COLUMN_WIDTH\":\"60\",\"COLUMN_ALIGN\":\"Left\",\"RESULT_ORDER\":5,\"BUFFER1\":null,\"BUFFER2\":null,\"BUFFER3\":null,\"BUFFER4\":null,\"BUFFER5\":null,\"ID\":null,\"ENABLEFLAG\":\"Y\",\"REMARK\":null,\"CREATEDATE\":\"\\/Date(1460550321000+0800)\\/\",\"CREATEBY\":\"bcsupport\",\"LASTUPDATEDATE\":\"\\/Date(1460550355000+0800)\\/\",\"LASTUPDATEBY\":\"bcsupport\",\"DB_TYPE\":\"\",\"ORACLE_SQL\":null,\"SQL_SERVER_SQL\":null,\"LANGUAGETYPE\":null,\"QPSQL\":null,\"PRIMARYKEY_ID\":null,\"ESCAPE_KEY\":\"\"}]";

            #endregion 
        }
    }

    public class QP_QUERYRESULT
    {
        public QP_QUERYRESULT() { }

        public string ATTRIBUTE_CODE { get; set; }
        public string BUFFER1 { get; set; }
        public string BUFFER2 { get; set; }
        public string BUFFER3 { get; set; }
        public string BUFFER4 { get; set; }
        public string BUFFER5 { get; set; }
        public string COLUMN_ALIGN { get; set; }
        public string COLUMN_KEY { get; set; }
        public string COLUMN_WIDTH { get; set; }
        public string LANGUAGE_KEY { get; set; }
        public string LANGUAGE_VALUE { get; set; }
        public string PAGE_REGISTER_GUID { get; set; }
        public string PATTERN_GUID { get; set; }
        public string QUERYRESULT_GUID { get; set; }
        public int RESULT_ORDER { get; set; }
        public string RESULT_TYPE { get; set; }
        public string RESULT_URL { get; set; }
    }
}
