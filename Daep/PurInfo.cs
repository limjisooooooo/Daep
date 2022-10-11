using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daep
{
    public class PurInfo
    {
        public static DataTable Dummy = new DataTable();
        public string purDate
        {
            get; set;
        }
        public string cmpyCode
        {
            get; set;
        }
        public string resCode
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
        public PurInfo()
        {
        }
        public PurInfo(string cmpyCode, string resCode)
        {
            this.cmpyCode = cmpyCode;
            this.resCode = resCode;
        }
        public PurInfo(string purDate, string cmpyCode, string resCode, int seq, int amt, string tag)
        {
            this.purDate = purDate;
            this.cmpyCode = cmpyCode;
            this.resCode = resCode;
            this.seq = seq;
            this.amt = amt;
            this.tag = tag;
        }
        public static void getPurInfos(string sDate, string eDate, string cmpyCode, string resCode)
        {
            string where = "";
            if (cmpyCode != "")
            {
                where += " AND p.CMPYCODE = @cmpyCode ";
            }
            if (resCode != "")
            {
                where += " AND p.RESCODE = @resCode ";
            }
            string sql = " SELECT DATE_FORMAT(STR_TO_DATE(p.PURDATE, '%Y%m%d'), '%Y-%m-%d') 매입일자, c.CMPYCODE 사업자번호, c.CMPYNAME 상호, r.RESCODE 품번, r.RESNAME 품명, r.CREATOR 제조처, r.COLOR COLOR, r.STANDARD 규격, r.UNITFEE 단가, r.UNIT 단위, p.COUNT 수량, p.AMT 금액, p.TAG 비고, p.SEQ SEQ " +
                         " FROM purinfos p, rescodes r, cmpycodes c " +
                         " WHERE p.CMPYCODE = c.CMPYCODE " +
                         " AND p.RESCODE = r.RESCODE " +
                         " AND (r.RESCODE, r.HISTDATE) IN (SELECT RESCODE, MAX(HISTDATE) " +
                         "                                  FROM rescodes " +
                         "                                  WHERE histdate <= p.purdate " +
                         "                                  GROUP BY rescode) " +
                         " AND p.PURDATE BETWEEN @sDate AND @eDate " + where +
                         " ORDER BY p.PURDATE, c.CMPYCODE, r.RESCODE, p.SEQ";
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@sDate", sDate);
            pairs.Add("@eDate", eDate);
            pairs.Add("@cmpyCode", cmpyCode);
            pairs.Add("@resCode", resCode);
            dbWork.selectQry(sql, pairs, dbWork.ds, "PURINFOS");
        }

        public int insPurInfo()
        {
            string sql = " INSERT INTO PURINFOS VALUES (@purDate, @cmpyCode, @resCode, PUR_SEQ(@revDate, @cmpyCode, @resCode), @count, @amt, @tag, SYSDATE()) ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@purDate", this.purDate);
            pairs.Add("@cmpyCode", this.cmpyCode);
            pairs.Add("@resCode", this.resCode);
            pairs.Add("@count", this.count);
            pairs.Add("@amt", this.amt);
            pairs.Add("@tag", this.tag);
            return dbWork.excuteQry(sql, pairs);
        }
        public int delPurInfo()
        {
            string sql = "DELETE FROM PURINFOS WHERE PURDATE = @purDate AND CMPYCODE = @cmpyCode AND RESCODE = @resCode AND SEQ = @seq ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@purDate", this.purDate);
            pairs.Add("@cmpyCode", this.cmpyCode);
            pairs.Add("@resCode", this.resCode);
            pairs.Add("@seq", this.seq);
            return dbWork.excuteQry(sql, pairs);
        }
        public int updPurInfo(PurInfo newPurInfo)
        {
            string sql = " UPDATE PURINFOS SET PURDATE = @newPurDate, CMPYCODE = @newCmpyCode, RESCODE = @newResCode, COUNT = @newCount, AMT = @newAmt, TAG = @newTag " +
                         " WHERE PURDATE = @purDate AND CMPYCODE = @cmpyCode AND RESCODE = @resCode AND SEQ = @seq ";

            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@newPurDate", newPurInfo.purDate);
            pairs.Add("@newCmpyCode", newPurInfo.cmpyCode);
            pairs.Add("@newResCode", newPurInfo.resCode);
            pairs.Add("@newCount", newPurInfo.count);
            pairs.Add("@newAmt", newPurInfo.amt);
            pairs.Add("@newTag", newPurInfo.tag);
            pairs.Add("@purDate", this.purDate);
            pairs.Add("@cmpyCode", this.cmpyCode);
            pairs.Add("@resCode", this.resCode);
            pairs.Add("@seq", this.seq);
            return dbWork.excuteQry(sql, pairs);
        }
        public static void getRptData(List<PurInfo> purInfos)
        {
            string inParam = "";
            foreach (PurInfo purInfo in purInfos)
            {
                inParam += ",('" + purInfo.purDate + "', '" + purInfo.cmpyCode + "', '" + purInfo.resCode + "', " + purInfo.seq.ToString() + ")";
            }
            inParam = inParam.Substring(1);
            string sql = " SELECT DATE_FORMAT(STR_TO_DATE(p.PURDATE, '%Y%m%d'), '%Y년 %m월 %d일') purDate, c.CMPYCODE cmpyCode, c.CMPYNAME cmpyName, c.ceo ceo, c.addr addr, c.type type, c.item item, r.RESCODE resCode, r.RESNAME resName, r.COLOR color, r.STANDARD standard, r.UNITFEE unitFee, r.UNIT unit, p.COUNT count, p.AMT amt, p.TAG tag, row_number() over (partition by p.purdate, p.cmpycode order by resname) no " +
             " FROM purinfos p, rescodes r, cmpycodes c " +
             " WHERE p.CMPYCODE = c.CMPYCODE " +
             " AND p.RESCODE = r.RESCODE " +
             " AND (r.RESCODE, r.HISTDATE) IN (SELECT RESCODE, MAX(HISTDATE) " +
             "                                  FROM rescodes " +
             "                                  WHERE histdate <= p.purdate " +
             "                                  GROUP BY rescode) " +
             " AND (p.PURDATE, p.CMPYCODE, p.RESCODE, p.SEQ ) IN (" + inParam + ") " +
             " ORDER BY p.PURDATE, p.CMPYCODE, p.RESCODE, no";

            dbWork.selectQry(sql, null, dbWork.ds, "rptPur");
        }
    }
}
