using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daep
{
    
    public class ProdCode
    {
        public string histDate { get; set; }
        public string prodCode { get; set; }
        public string prodName { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public string standard { get; set; }
        public string unitFee { get; set; }
        public string unit { get; set; }
        public ProdCode() { }

        public ProdCode(string histDate, string prodCode, string prodName)
        {
            this.histDate = histDate;
            this.prodCode = prodCode;
            this.prodName = prodName;
        }
        public static void getProdCodeLatestAll()
        {
            string sql = "SELECT STR_TO_DATE(HISTDATE, '%Y%m%d') 적용일, PRODCODE 품번, PRODNAME 품명, TYPE 차종, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                         "FROM PRODCODES " +
                         "WHERE (PRODCODE, HISTDATE) IN (SELECT PRODCODE, MAX(HISTDATE)" +
                         "                               FROM PRODCODES" +
                         "                               GROUP BY PRODCODE)" +
                         "ORDER BY PRODCODE";
            dbWork.selectQry(sql, null, dbWork.ds, "PRODCODES");
        }
        public static void getProdCodeHistAll()
        {
            string sql = "SELECT STR_TO_DATE(HISTDATE, '%Y%m%d') 적용일, PRODCODE 품번, PRODNAME 품명, TYPE 차종, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                         "FROM PRODCODES " +
                         "ORDER BY PRODCODE, HISTDATE";
            dbWork.selectQry(sql, null, dbWork.ds, "PRODCODEHIST");
        }
        public static void getProdCodeHistWithProdCode(string prodCode)
        {
            string sql = " SELECT STR_TO_DATE(HISTDATE, '%Y%m%d') 적용일, PRODCODE 품번, PRODNAME 품명, TYPE 차종, COLOR, STANDARD 규격, UNITFEE 단가, UNIT 단위 " +
                         " FROM PRODCODES " +
                         " WHERE PRODCODE = @prodCode " +
                         " ORDER BY PRODCODE, HISTDATE ";
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@prodCode", prodCode);
            dbWork.selectQry(sql, pairs, dbWork.ds, "PRODCODEHIST");
        }
        public int insProdCode()
        {
            string sql = "INSERT INTO PRODCODES VALUES (@histDate, @prodCode, @prodName, @type, @color, @standard, @unitFee, @unit, SYSDATE())";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@histDate", this.histDate);
            pairs.Add("@prodCode", this.prodCode);
            pairs.Add("@prodName", this.prodName);
            pairs.Add("@type", this.type);
            pairs.Add("@color", this.color);
            pairs.Add("@standard", this.standard);
            pairs.Add("@unitFee", this.unitFee);
            pairs.Add("@unit", this.unit);
            return dbWork.excuteQry(sql, pairs);
        }
        public int delProdCode()
        {

            string sql = " DELETE FROM PRODCODES " +
                         " WHERE HISTDATE = @histDate AND PRODCODE = @prodCode ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@histDate", this.histDate);
            pairs.Add("@prodCode", this.prodCode);
            return dbWork.excuteQry(sql, pairs);
        }
        public int updProdCode(ProdCode newProdCode)
        {
            string sql = "UPDATE PRODCODES SET HISTDATE = @newHistDate, PRODCODE = @newProdCode, PRODNAME = @newProdName, TYPE = @newType, COLOR = @newColor, " +
                         "                     STANDARD = @newStandard, UNITFEE = @newUnitFee, UNIT = @newUnit " +
                         "WHERE HISTDATE = @histDate AND PRODCODE = @prodCode";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@newHistDate", newProdCode.histDate);
            pairs.Add("@newProdCode", newProdCode.prodCode);
            pairs.Add("@newProdName", newProdCode.prodName);
            pairs.Add("@newType", newProdCode.type);
            pairs.Add("@newColor", newProdCode.color);
            pairs.Add("@newStandard", newProdCode.standard);
            pairs.Add("@newUnitFee", newProdCode.unitFee);
            pairs.Add("@newUnit", newProdCode.unit);
            pairs.Add("@histDate", this.histDate);
            pairs.Add("@prodCode", this.prodCode);
            return dbWork.excuteQry(sql, pairs);
        }
    }
}
