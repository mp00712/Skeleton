using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockcollection
    {
        List<clsStock> mStockList = new List<clsStock>();

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


        public clsStock ThisStock { get; set; }


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
        }

    }