using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daep
{
    public class CmpyCode
    {
        public CmpyCode() { }
        public CmpyCode(string cmpyCode, string cmpyName)
        {
            this.cmpyCode = cmpyCode;
            this.cmpyName = cmpyName;
        }
        public string cmpyCode { get; set; }
        public string cmpyName { get; set; }
        public string ceo { get; set; }
        public string addr { get; set; }
        public string cmpyType { get; set; }
        public string item { get; set; }
        public string type { get; set; }
        public static void getCmpyCodeAll()
        {
            string sql = " SELECT CMPYCODE 사업자번호, CMPYNAME 상호, CEO 대표, ADDR 사업장주소, CMPYTYPE 업태, ITEM 종목, TYPE 구분 FROM CMPYCODES ORDER BY CMPYCODE ";
            dbWork.selectQry(sql, null, dbWork.ds, "CMPYCODES");
        }
        public int insCmpyCode()
        {
            string sql = " INSERT INTO CMPYCODES VALUES (@cmpyCode, @cmpyName, @ceo, @addr, @cmpyType, @item, @type, SYSDATE()) ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@cmpyCode", this.cmpyCode);
            pairs.Add("@cmpyName", this.cmpyName);
            pairs.Add("@ceo", this.ceo);
            pairs.Add("@addr", this.addr);
            pairs.Add("@cmpyType", this.cmpyType);
            pairs.Add("@item", this.item);
            pairs.Add("@type", this.type);
            return dbWork.excuteQry(sql, pairs);            
        }        
        public int delCmpyCode()
        {

            string sql = "DELETE FROM CMPYCODES " +
                         "WHERE CMPYCODE = @cmpyCode";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@cmpyCode", this.cmpyCode);
            return dbWork.excuteQry(sql, pairs);
        }
        public int updCmpyCode(CmpyCode newCmpyCode)
        {
            string sql = "UPDATE CMPYCODES SET CMPYCODE = @newCmpycode, CMPYNAME = @newCmpyname, CEO = @newCeo, ADDR = @newAddr, CMPYTYPE = @newCmpyType, " +
                         "                     ITEM = @newItem, TYPE = @newType " +
                         "WHERE CMPYCODE = @cmpyCode";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@newCmpycode", newCmpyCode.cmpyCode);
            pairs.Add("@newCmpyname", newCmpyCode.cmpyName);
            pairs.Add("@newCeo", newCmpyCode.ceo);
            pairs.Add("@newAddr", newCmpyCode.addr);
            pairs.Add("@newCmpyType", newCmpyCode.cmpyType);
            pairs.Add("@newItem", newCmpyCode.item);
            pairs.Add("@newType", newCmpyCode.type);
            pairs.Add("@cmpyCode", this.cmpyCode);
            return dbWork.excuteQry(sql, pairs);
        }
    }
}
