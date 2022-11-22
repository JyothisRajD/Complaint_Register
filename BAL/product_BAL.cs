using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace application_nest.BAL
{
    public class product_BAL
    {
        DAL.product_DAL objpro = new DAL.product_DAL();
        private int _pro_id;
        private string _product;
        private string _comp;
        private string _uid;
        private string _qry;
    
        public int proid
        {
            get
            {
                return _pro_id;
            }
            set
            { _pro_id = value; }
        }
        public string product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
            }
        }

        public string usrid
        {
            get
            {
                return _uid;
            }
            set
            {
                _uid = value;
            }
        }

        public string Compl
        {
            get { 
                return _comp; 
            }

            set { 
               _comp = value;
            }
        }

        public string qry
        {
            get { return _qry; }

            set { _qry = value; }
        }

        public object Insert()
        {
            return objpro.Insert(this);
        }

        public int ProdComp()
        {
            return objpro.Complaints(this);
        }
        public DataTable GetProduct()
        {
            return objpro.GetProductDetails();
        }

        public int UpdateProducts()
        {
            return objpro.UpdateProductDetails(this);
        }

        public int DeleteProducts()
        {
            return objpro.DeleteProductDetails(this);
        }
    }
}