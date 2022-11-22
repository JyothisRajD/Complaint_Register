using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace application_nest.BAL
{
        public class complaint_BAL
        {
            DAL.complaint_DAL complaintdal = new DAL.complaint_DAL();
            private int _complaintId;
            private int _productId;
            private int _userId;
            private string _complaint;
            private string _complaintDate;
            private string _complaintStatus;
            private string _fromDate;
            private string _toDate;
            private string _query;

            public int ComplaintId
            {
                get { return _complaintId; }
                set { _complaintId = value; }
            }
            public int ProductId
            {
                set { _productId = value; }
                get { return _productId; }
            }
            public int UserId
            {
                get { return _userId; }
                set { _userId = value; }
            }

            public string Complaint
            {
                get { return _complaint; }
                set { _complaint = value; }
            }

            public string query
            {
                get { return _query; }
                set { _query = value; }
            }

        public string ComplaintDate
            {
                get { return _complaintDate; }
                set
                {
                    _complaintDate = value;
                }
            }
            public string ComplaintStatus
            {
                get { return _complaintStatus; }
                set
                {
                    _complaintStatus = value;
                }
            }

            public string Day
            {
                get { return _fromDate; }
                set { _fromDate = value; }
            }

            public string Today
            {
                get { return _toDate; }
                set { _toDate = value; }
            }

            public int InsertingComplaints()
            {
                return complaintdal.InsertComplaint(this);
            }

            public int Insertingquery()
            {
                return complaintdal.Insertqry(this);
            }

            public DataTable ViewAllComplaints()
            {
                return complaintdal.ViewAllComplaint(this);
            }

            public DataTable ViewDateComplaints()
            {
                return complaintdal.ViewDateComplaint(this);
            }
        
            public DataTable viewcomplaints()
            {
                return complaintdal.ViewComplaintDetails(this);
            }

            public DataTable Userviewcomplaint()
            {
                return complaintdal.UserViewComplaintDetails(this);
            }

            public int UpdateCompl()
            {
                    return complaintdal.UpdateComplaint(this);
                }
    }
}