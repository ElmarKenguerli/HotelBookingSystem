using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamnandi_Hotel.Bookings;
using Phumla_Kamnandi_Hotel.Guests;

namespace Phumla_Kamnandi_Hotel.DatabaseLayer
{
    class GuestDB : DB
    {
        private string table = "Guests";
        private string sqlLocal = "SELECT * FROM Guests";
        private Collection<Guest> guests;

        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }

        private void AddToCollection(string table)
        {
            DataRow myRow = null;
            Guest aGuest;
            foreach (DataRow myRow_loop in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loop;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aGuest = new Guest();
                    aGuest.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    aGuest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    aGuest.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                    aGuest.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    aGuest.Deposit = Convert.ToDouble(myRow["Deposit"]);
                    guests.Add(aGuest);
                }
            }
        }

        private void AddToRow(DataRow row, Guest guest, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                row["GuestID"] = guest.GuestID;
            }

            row["Name"] = guest.Name;
            row["Address"] = guest.Address;
            row["Phone"] = guest.Phone;
            row["Deposit"] = guest.Deposit;
        }

        private int FindRow(Guest guest, string table)
        {
            int rowIndex = 0;
            DataRow row;
            int returnValue = -1;
            foreach (DataRow myRow_loop in dsMain.Tables[table].Rows)
            {
                row = myRow_loop;
                if (!(row.RowState == DataRowState.Deleted))
                {
                    if (guest.GuestID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        public void ChangeDataSet(Guest guest, DB.DBOperation operation)
        {
            DataRow row = null;
            string dataTable = table;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    row = dsMain.Tables[dataTable].NewRow();
                    AddToRow(row, guest, operation);
                    dsMain.Tables[dataTable].Rows.Add(row);
                    break;
                case DB.DBOperation.Edit:
                    row = dsMain.Tables[dataTable].Rows[FindRow(guest, dataTable)];
                    AddToRow(row, guest, operation);
                    break;
                case DB.DBOperation.Delete:
                    row = dsMain.Tables[dataTable].Rows[FindRow(guest, dataTable)];
                    row.Delete();
                    break;
            }
        }

        private void Build_INSERT_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Deposit", SqlDbType.Money, 8, "Deposit");
            daMain.InsertCommand.Parameters.Add(param);
        }
        private void Build_UPDATE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Deposit", SqlDbType.Money, 8, "Deposit");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }
        private void Build_DELETE_Parameters()
        {
            SqlParameter param;
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command()
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Guests (GuestID, Name, Address, Phone, Deposit) VALUES (@GuestID, @Name, @Address, @Phone, @Deposit)", cnMain);
            Build_INSERT_Parameters();
        }
        private void Create_UPDATE_Command()
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Guests SET GuestID =@GuestID, Name =@Name, Address =@Address, Phone =@Phone, Deposit =@Deposit " + "WHERE GuestID =@GuestID", cnMain);
            Build_UPDATE_Parameters();
        }
        private string Create_DELETE_Command()
        {
            string errorString = null;
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Guests WHERE GuestID = @GuestID", cnMain);
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }
        public bool UpdateDataSource()
        {
            bool success = true;
            Create_INSERT_Command();
            Create_UPDATE_Command();
            Create_DELETE_Command();
            success = UpdateDataSource(sqlLocal, table);

            return success;

        }

        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal, table);
            AddToCollection(table);

        }
    }
}
