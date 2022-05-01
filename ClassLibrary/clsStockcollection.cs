using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockcollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }

            set
            {
                mStockList = value;
            }
        }


        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }
            


        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }

        public clsStockcollection()
        {
                Int32 Index = 0;
                Int32 RecordCount = 0;
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_tblStock_SelectAll");
                RecordCount = DB.Count;
                while (Index < RecordCount)
                {
                    clsStock AnStock = new clsStock();
                    AnStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["StockAvailability"]);
                    AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                    AnStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                    AnStock.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                    AnStock.TotalPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalPrice"]);
                    AnStock.RestockDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RestockDate"]);
                    mStockList.Add(AnStock);
                    Index++;
                }

            }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@ItemQuantity", mThisStock.ItemQuantity);
            DB.AddParameter("@TotalPrice", mThisStock.TotalPrice);
            DB.AddParameter("@RestockDate", mThisStock.RestockDate);
            DB.AddParameter("@StockAvailability", mThisStock.Active);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@ItemQuantity", mThisStock.ItemQuantity);
            DB.AddParameter("@TotalPrice", mThisStock.TotalPrice);
            DB.AddParameter("@RestockDate", mThisStock.RestockDate);
            DB.AddParameter("@StockAvailability", mThisStock.Active);

            DB.Execute("sproc_tblStock_Update");

        }
    }

    }