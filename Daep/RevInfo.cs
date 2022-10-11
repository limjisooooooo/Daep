using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daep
{
    public class RevInfo
    {
        public static DataTable Dummy = new DataTable();
        public string revDate
        {
            get; set;
        }
        public string cmpyCode
        {
            get; set;
        }
        public string prodCode
        {
            get; set;
        }
        public int seq
        {
            get; set;
        }
        public int count
        {
            get; set;
        }
        public int amt
        {
            get; set;
        }
        public string tag
        {
            get; set;
        }
        public RevInfo() { 
        }
        public RevInfo(string cmpyCode, string prodCode)
        {
            this.cmpyCode = cmpyCode;
            this.prodCode = prodCode;
        }
        public RevInfo(string revDate, string cmpyCode, string prodCode, int seq, int amt, string tag)
        {
            this.revDate = revDate;
            this.cmpyCode = cmpyCode;
            this.prodCode = prodCode;
            this.seq = seq;
            this.amt = amt;
            this.tag = tag;
        }
        public static void getRevInfos(string sDate, string eDate, string cmpyCode, string prodCode)
        {
            string where = "";
            if (cmpyCode != "")
            {
                where += " AND r.CMPYCODE = @cmpyCode ";
            }
            if (prodCode != "")
            {
                where += " AND r.PRODCODE = @prodCode ";
            }
            string sql = " SELECT DATE_FORMAT(STR_TO_DATE(r.REVDATE, '%Y%m%d'), '%Y-%m-%d') 매출일자, c.CMPYCODE 사업자번호, c.CMPYNAME 상호, p.PRODCODE 품번, p.PRODNAME 품명, p.TYPE 차종, p.COLOR COLOR, p.STANDARD 규격, p.UNITFEE 단가, p.UNIT 단위, r.COUNT 수량, r.AMT 금액, r.TAG 비고, r.SEQ SEQ " +
                         " FROM revinfos r, prodcodes p, cmpycodes c " +
                         " WHERE r.CMPYCODE = c.CMPYCODE " +
                         " AND r.PRODCODE = p.PRODCODE " +
                         " AND (p.PRODCODE, p.HISTDATE) IN (SELECT PRODCODE, MAX(HISTDATE) " +
                         "                                  FROM prodcodes " +
                         "                                  WHERE histdate <= r.revdate " +
                         "                                  GROUP BY prodcode) " +
                         " AND r.REVDATE BETWEEN @sDate AND @eDate " + where +
                         " ORDER BY r.REVDATE, c.CMPYCODE, p.PRODCODE, r.SEQ";
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@sDate", sDate);
            pairs.Add("@eDate", eDate);
            pairs.Add("@cmpyCode", cmpyCode);
            pairs.Add("@prodCode", prodCode);
            dbWork.selectQry(sql, pairs, dbWork.ds, "REVINFOS");
        }

        public int insRevInfo()
        {
            string sql = " INSERT INTO REVINFOS VALUES (@revDate, @cmpyCode, @prodCode, REV_SEQ(@revDate, @cmpyCode, @prodCode), @count, @amt, @tag, SYSDATE()) ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@revDate", this.revDate);
            pairs.Add("@cmpyCode", this.cmpyCode);
            pairs.Add("@prodCode", this.prodCode);
            pairs.Add("@count", this.count);
            pairs.Add("@amt", this.amt);
            pairs.Add("@tag", this.tag);
            return dbWork.excuteQry(sql, pairs);
        }
        public int delRevInfo()
        {
            string sql = "DELETE FROM REVINFOS WHERE REVDATE = @revDate AND CMPYCODE = @cmpyCode AND PRODCODE = @prodCode AND SEQ = @seq ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@revDate", this.revDate);
            pairs.Add("@cmpyCode", this.cmpyCode);
            pairs.Add("@prodCode", this.prodCode);
            pairs.Add("@seq", this.seq);
            return dbWork.excuteQry(sql, pairs);
        }
        public int updRevInfo(RevInfo newRevInfo)
        {
            string sql = " UPDATE REVINFOS SET REVDATE = @newRevDate, CMPYCODE = @newCmpyCode, PRODCODE = @newProdCode, COUNT = @newCount, AMT = @newAmt, TAG = @newTag " +
                         " WHERE REVDATE = @revDate AND CMPYCODE = @cmpyCode AND PRODCODE = @prodCode AND SEQ = @seq ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@newRevDate", newRevInfo.revDate);
            pairs.Add("@newCmpyCode", newRevInfo.cmpyCode);
            pairs.Add("@newProdCode", newRevInfo.prodCode);
            pairs.Add("@newCount", newRevInfo.count);
            pairs.Add("@newAmt", newRevInfo.amt);
            pairs.Add("@newTag", newRevInfo.tag);
            pairs.Add("@revDate", this.revDate);
            pairs.Add("@cmpyCode", this.cmpyCode);
            pairs.Add("@prodCode", this.prodCode);
            pairs.Add("@seq", this.seq);
            return dbWork.excuteQry(sql, pairs);
        }
        public static void getRptData(List<RevInfo> revInfos)
        {
            string inParam = "";
            foreach(RevInfo revInfo in revInfos)
            {
                inParam += ",('" + revInfo.revDate + "', '" + revInfo.cmpyCode + "', '" + revInfo.prodCode + "', " + revInfo.seq.ToString() + ")";
            }
            inParam = inParam.Substring(1);
            string sql = " SELECT DATE_FORMAT(STR_TO_DATE(r.REVDATE, '%Y%m%d'), '%Y년 %m월 %d일') revDate, c.CMPYCODE cmpyCode, c.CMPYNAME cmpyName, c.ceo ceo, c.addr addr, c.type type, c.item item, p.PRODCODE prodCode, p.PRODNAME prodName, p.COLOR color, p.STANDARD standard, p.UNITFEE unitFee, p.UNIT unit, r.COUNT count, r.AMT amt, r.TAG tag, row_number() over (partition by r.revdate, r.cmpycode order by prodname) no " +
                         " FROM revinfos r, prodcodes p, cmpycodes c " +
                         " WHERE r.CMPYCODE = c.CMPYCODE " +
                         " AND r.PRODCODE = p.PRODCODE " +
                         " AND (p.PRODCODE, p.HISTDATE) IN (SELECT PRODCODE, MAX(HISTDATE) " +
                         "                                  FROM prodcodes " +
                         "                                  WHERE histdate <= r.revdate " +
                         "                                  GROUP BY prodcode) " +
                         " AND (r.REVDATE, r.CMPYCODE, r.PRODCODE, r.SEQ ) IN (" + inParam + ") " +
                         " ORDER BY r.REVDATE, c.CMPYCODE, p.PRODCODE, no";

            dbWork.selectQry(sql, null, dbWork.ds, "rptRev");
        }
    }
}
