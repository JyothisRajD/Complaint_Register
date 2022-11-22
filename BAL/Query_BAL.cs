using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace application_nest.BAL
{
    public class Query_BAL
    {
        DAL.Query_DAL queryDal = new DAL.Query_DAL();
        private int _queryId;
        private int _productId;
        private int _userId;
        private string _query;
        private string _queryReply;



        public int QueryId
        {
            get { return _queryId; }
            set { _queryId = value; }
        }
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Query
        {
            get { return _query; }
            set
            {
                _query = value;
            }
        }

        public string QueryReply
        {
            get { return _queryReply; }
            set
            {
                _queryReply = value;
            }
        }

        public int InsertQuery()
        {
            return queryDal.InsertQuerys(this);
        }

        public DataTable ViewAllQuery()
        {
            return queryDal.ViewAllQuerys();
        }

        public int GiveReply()
        {
            return queryDal.GiveReplyDetails(this);
        }

        public DataTable ViewSpecificQuery()
        {
            return queryDal.ViewSpecificQueryDetails(this);
        }

        public DataTable UserViewSpecificQuery()
        {
            return queryDal.UserViewSpecificQueryDetails(this);
        }

        public int Insertingquery()
        {
            return queryDal.Insertqry(this);
        }
    }
}