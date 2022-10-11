using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daep
{
    public class ResCode
    {
        public string histDate { get; set; }
        public string resCode { get; set; }
        public string resName { get; set; }
        public string creator { get; set; }
        public string color { get; set; }
        public string standard { get; set; }
        public string unitFee { get; set; }
        public string unit { get; set; }
        public ResCode()
        {
        }
        public ResCode(string histDate, string resCode, string resName)
        {
            this.histDate = histDate;
            this.resCode = resCode;
            this.resName = resName;
        }
        public static void getResCodeLatestAll()
        {
            string sql = "SELECT STR_TO_DATE(HISTDATE, '%Y%m%d') 적용일, RESCODE 품번, RESNAME 품명, CREATOR 제조처, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                         "FROM RESCODES " +
                         "WHERE (RESCODE, HISTDATE) IN (SELECT RESCODE, MAX(HISTDATE)" +
                         "                              FROM RESCODES" +
                         "                              GROUP BY RESCODE)" +
                         "ORDER BY RESCODE";
            dbWork.selectQry(sql, null, dbWork.ds, "RESCODES");
        }
        public static void getResCodeHistAll()
        {
            string sql = "SELECT STR_TO_DATE(HISTDATE, '%Y%m%d') 적용일, RESCODE 품번, RESNAME 품명, CREATOR 제조처, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                         "FROM RESCODES " +
                         "ORDER BY RESCODE, HISTDATE";
            dbWork.selectQry(sql, null, dbWork.ds, "RESCODEHIST");
        }
        public static void getResCodeHistWithResCode(string resCode)
        {
            string sql = " SELECT STR_TO_DATE(HISTDATE, '%Y%m%d') 적용일, RESCODE 품번, RESNAME 품명, CREATOR 제조처, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                         " FROM RESCODES " +
                         " WHERE RESCODE = @resCode " +
                         " ORDER BY RESCODE, HISTDATE ";
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@resCode", resCode);
            dbWork.selectQry(sql, pairs, dbWork.ds, "RESCODEHIST");
        }
        public int insResCode()
        {
            string sql = "INSERT INTO RESCODES VALUES (@histDate, @resCode, @resName, @creator, @color, @standard, @unitFee, @unit, SYSDATE())";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@histDate", this.histDate);
            pairs.Add("@resCode", this.resCode);
            pairs.Add("@resName", this.resName);
            pairs.Add("@creator", this.creator);
            pairs.Add("@color", this.color);
            pairs.Add("@standard", this.standard);
            pairs.Add("@unitFee", this.unitFee);
            pairs.Add("@unit", this.unit);
            return dbWork.excuteQry(sql, pairs);
        }
        public int delResCode()
        {

            string sql = " DELETE FROM RESCODES " +
                         " WHERE HISTDATE = @histDate AND RESCODE = @resCode ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@histDate", this.histDate);
            pairs.Add("@resCode", this.resCode);
            return dbWork.excuteQry(sql, pairs);
        }
        public int updResCode(ResCode newResCode)
        {
            string sql = "UPDATE RESCODES SET HISTDATE = @newHistDate, RESCODE = @newResCode, RESNAME = @newResName, CREATOR = @newCreator, COLOR = @newColor, " +
                         "                     STANDARD = @newStandard, UNITFEE = @newUnitFee, UNIT = @newUnit " +
                         "WHERE HISTDATE = @histDate AND RESCODE = @resCode";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@newHistDate", newResCode.histDate);
            pairs.Add("@newResCode", newResCode.resCode);
            pairs.Add("@newResName", newResCode.resName);
            pairs.Add("@newCreator", newResCode.creator);
            pairs.Add("@newColor", newResCode.color);
            pairs.Add("@newStandard", newResCode.standard);
            pairs.Add("@newUnitFee", newResCode.unitFee);
            pairs.Add("@newUnit", newResCode.unit);
            pairs.Add("@histDate", this.histDate);
            pairs.Add("@resCode", this.resCode);
            return dbWork.excuteQry(sql, pairs);
        }
    }
}
