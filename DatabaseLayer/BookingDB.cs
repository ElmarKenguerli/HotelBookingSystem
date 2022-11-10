using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_Hotel.Bookings;
using Phumla_Kamnandi_Hotel.ViewLayer;

namespace Phumla_Kamnandi_Hotel.DatabaseLayer
{
    class BookingDB : DB
    {
        private string table = "Bookings";
        private string sqlLocal = "SELECT * FROM Bookings";
        private Collection<Booking> bookings;
        public Booking booking;
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
            AddToCollection(table);

        }
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        private void AddToCollection(string table)
        {
            DataRow myRow = null;
            foreach (DataRow myRow_loop in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loop;
                if (!(myRow.RowState == DataRowState.Deleted))
                {

                    booking = new Booking();
                    booking.BookingID = Convert.ToString(myRow["BookingID"]).TrimEnd();
                    booking.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    booking.SignInDate = Convert.ToDateTime(myRow["SignInDate"]);
                    booking.SignOutDate = Convert.ToDateTime(myRow["SignOutDate"]);
                    booking.Rate = Convert.ToDouble(myRow["Rate"]);
                    booking.RoomID = Convert.ToString(myRow["RoomID"]).TrimEnd();
                    booking.DepositPaid = Convert.ToString(myRow["DepositPaid"]).TrimEnd();
                    bookings.Add(booking);
                }
            }
        }
        private void AddToRow(DataRow row, Booking booking, DB.DBOperation operation)
        {
            //DateTime date;
            if (operation == DB.DBOperation.Add)
            {
                row["BookingID"] = booking.BookingID;
                row["GuestID"] = booking.GuestID;

            }
            row["SignInDate"] = booking.SignInDate.Date;
            row["SignOutDate"] = booking.SignOutDate.Date;
            row["Rate"] = booking.Rate;
            row["RoomID"] = booking.RoomID;
            row["DepositPaid"] = booking.DepositPaid;
        }

        private int FindRow(Booking booking, string table)
        {
            int rowIndex = 0;
            DataRow row;
            int returnValue = -1;
            foreach (DataRow myRow_loop in dsMain.Tables[table].Rows)
            {
                row = myRow_loop;
                if (!(row.RowState == DataRowState.Deleted))
                {
                    if (booking.BookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        public void ChangeDataSet(Booking booking, DB.DBOperation operation)
        {
            DataRow row = null;
            string dataTable = table;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    row = dsMain.Tables[dataTable].NewRow();
                    AddToRow(row, booking, operation);
                    dsMain.Tables[dataTable].Rows.Add(row);
                    break;
                case DB.DBOperation.Edit:
                    row = dsMain.Tables[dataTable].Rows[FindRow(booking, dataTable)];
                    AddToRow(row, booking, operation);
                    break;
                case DB.DBOperation.Delete:
                    row = dsMain.Tables[dataTable].Rows[FindRow(booking, dataTable)];
                    row.Delete();
                    break;
            }
        }

        private void Build_INSERT_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SignInDate", SqlDbType.DateTime, 4, "SignInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SignOutDate", SqlDbType.DateTime, 4, "SignOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Rate", SqlDbType.Money, 8, "Rate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 10, "RoomID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.NVarChar, 10, "DepositPaid");
            daMain.InsertCommand.Parameters.Add(param);
        }
        private void Build_UPDATE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 10, "RoomID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@SignInDate", SqlDbType.DateTime, 4, "SignInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@SignOutDate", SqlDbType.DateTime, 4, "SignOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Rate", SqlDbType.Money, 8, "Rate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.NVarChar, 10, "DepositPaid");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }
        private void Build_DELETE_Parameters()
        {
            SqlParameter param;
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command()
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Bookings (BookingID, GuestID, SignInDate, SignOutDate, Rate, RoomID, DepositPaid) VALUES (@BookingID, @GuestID, @SignInDate, @SignOutDate, @Rate, @RoomID, @DepositPaid)", cnMain);
            Build_INSERT_Parameters();
            //daMain.InsertCommand.ExecuteNonQuery();
        }
        private void Create_UPDATE_Command()
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Bookings SET BookingID = @BookingID, GuestID = @GuestID, SignInDate =@SignInDate, SignOutDate = @SignOutDate, Rate = @Rate, RoomID = @RoomID, DepositPaid = @DepositPaid " + "WHERE BookingID =@BookingID", cnMain);
            Build_UPDATE_Parameters();
            //daMain.UpdateCommand.ExecuteNonQuery();
        }
        private string Create_DELETE_Command()
        {
            string errorString = null;
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Bookings WHERE BookingID = @BookingID", cnMain);
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            //daMain.DeleteCommand.ExecuteNonQuery();
            return errorString;
        }
        public bool UpdateDataSource()
        {
            bool success = true;// = true;
            Create_INSERT_Command();
            Create_UPDATE_Command();
            Create_DELETE_Command();
            //searchDate(date.setUpRoomsForm(),booking);
            success = UpdateDataSource(sqlLocal, table);

            return success;

        }
    }
}
