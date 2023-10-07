using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Data
{
    public class BookingDB:DB
    {
        #region  Data members        
        private string table1 = "Guests";
        private string sqlLocal1 = "SELECT * FROM Guests";
        private string table2 = "Reservation";
        private string sqlLocal2 = "SELECT * FROM Reservation";
        private string table3 = "Room";
        private string sqlLocal3 = "SELECT * FROM Room";

        private Collection<Guest> guests;
        private Collection<Reservation> reservations;
        private Collection<Room> rooms;
        #endregion

        #region Property Methods
        public Collection<Guest> AllGuests { get { return guests; } }
        public Collection<Reservation> AllReservations { get {  return reservations; } }
        public Collection<Room> AllRooms { get { return rooms; } }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            guests = new Collection<Guest>();
            reservations = new Collection<Reservation>();
            rooms = new Collection<Room>();

            FillDataSet(sqlLocal1, table1);
            AddToCollection(table1);
            FillDataSet(sqlLocal2, table2);
            AddToCollection(table2);
            FillDataSet(sqlLocal3, table3);
            AddToCollection(table3);
        }
        #endregion

        #region Utility methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void AddToCollection(string table)
        {
            DataRow myRow = null;
            Guest guest;
            Room room;
            Reservation res;

            //Iterate through each row in the specified table
            foreach (DataRow aRow in dsMain.Tables[table].Rows)
            {
                myRow = aRow;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //switch for each collection
                    switch(table)
                    {
                        case "Guests":
                            guest = new Guest();
                            guest.GuestID = Convert.ToString(myRow["ID"]).TrimEnd();
                            guest.FirstName = Convert.ToString(myRow["First Name"]).TrimEnd();
                            guest.LastName = Convert.ToString(myRow["Last Name"]).TrimEnd();
                            guest.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                            guest.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                            guests.Add(guest);
                            break;
                        case "Room":
                            room = new Room();
                            room.RoomNumber = Convert.ToString(myRow["Room Number"]).TrimEnd();
                            room.setRoomType(Convert.ToString(myRow["Room Type"]).TrimEnd());
                            room.Price = Convert.ToDecimal(myRow["Price"]);
                            room.IsAvailable = Convert.ToBoolean(myRow["isAvailable"]);
                            rooms.Add(room);
                            break;
                        case "Reservation":
                            res = new Reservation();
                            res.ReferenceNumber = Convert.ToString(myRow["Reference Number"]).TrimEnd();
                            res.BGuest.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                            res.BRoom.RoomNumber = Convert.ToString(myRow["Room Number"]).TrimEnd();
                            res.CheckIn = Convert.ToDateTime(myRow["Check In"]);
                            res.CheckOut = Convert.ToDateTime(myRow["Check Out"]);
                            res.TotalPrice = Convert.ToDecimal(myRow["Total Price"]);
                            res.Status = Convert.ToString(myRow["status"]).TrimEnd();
                            reservations.Add(res);
                            break;
                    }
                }
            }
        }

        private void FillRow(DataRow aRow, Object obj)
        {
            Guest guest;
            Room room;
            Reservation res;

            if (obj is Guest)
            {
                guest = (Guest)obj;
                aRow["ID"] = guest.GuestID;
                aRow["First Name"] = guest.FirstName;
                aRow["Last Name"] = guest.LastName;
                aRow["Phone"] = guest.Phone;
                aRow["Email"] = guest.Email;
            }
            else if (obj is Room)
            {
                room = (Room)obj;
                aRow["Room Number"] = room.RoomNumber;
                aRow["Room Type"] = room.getRoomType.ToString();
                aRow["Price"] = room.Price;
                aRow["isAvailable"] = room.IsAvailable ? 1 : 0;
            }
            else if (obj is Reservation)
            {
                res = (Reservation)obj;
                aRow["Reference Number"] = res.ReferenceNumber;
                aRow["GuestID"] = res.BGuest.GuestID;
                aRow["Room Number"] = res.BRoom.RoomNumber;
                aRow["Check In"] = res.CheckIn;
                aRow["Check Out"] = res.CheckOut;
                aRow["Total Price"] = res.TotalPrice;
                aRow["Status"] = res.Status;
            }
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Object obj)
        {
            DataRow aRow = null;
            string table = "";
            if (obj is Guest)
            {
                table = table1;
            }
            else if (obj is Reservation)
            {
                table = table2;
            }
            else if (obj is Room)
            {
                table = table3;
            }

            aRow = dsMain.Tables[table].NewRow();
            FillRow(aRow, obj);
            dsMain.Tables[table].Rows.Add(aRow);
        }

        private void Build_INSERT_Parameters(Object obj)
        {
            if (obj is Guest)
            {
                SqlParameter param = default(SqlParameter);

                param = new SqlParameter("@ID", SqlDbType.NVarChar, 10, "ID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 30, "First Name");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@LastName", SqlDbType.NVarChar, 20, "Last Name");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar, 30, "Email");
                daMain.InsertCommand.Parameters.Add(param);
            }
            else if (obj is Reservation)
            {
                SqlParameter param = default (SqlParameter);

                param = new SqlParameter("@RefNumber", SqlDbType.NVarChar, 10, "Reference Number");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 10, "Room Number");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@CheckIn", SqlDbType.Date, 15, "Check In");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@CheckOut", SqlDbType.Date, 15, "Check Out");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@TotalPrice", SqlDbType.Money, 8, "Total Price");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Status", SqlDbType.NVarChar, 20, "Status");
                daMain.InsertCommand.Parameters.Add(param);
            }
            else if (obj is Room)
            {
                SqlParameter param = default(SqlParameter);

                param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 10, "Room Number");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 15, "Room Type");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Price", SqlDbType.Money, 8, "Price");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Available", SqlDbType.Bit, 1, "isAvailable");
                daMain.InsertCommand.Parameters.Add(param);
            }
        }

        private void Create_INSERT_Command(Object obj)
        {
            if (obj is Guest)
            {
                daMain.InsertCommand = new SqlCommand("INSERT into Guests (ID, [First Name], [Last Name], Phone, Email) VALUES (@ID, @FirstName, @LastName, @Phone, @Email)", cnMain);
            }
            else if (obj is Reservation)
            {
                daMain.InsertCommand = new SqlCommand("INSERT into Reservation ([Reference Number], GuestID, [Room Number], [Check In], [Check Out], [Total Price], Status) VALUES (@RefNumber, @GuestID, @RoomNumber, @CheckIn, @CheckOut, @TotalPrice, @Status)", cnMain);
            }
            else if (obj is Room)
            {
                daMain.InsertCommand = new SqlCommand("INSERT into Room ([Room Number], [Room Type], Price, isAvailable) VALUES (@RoomNumber, @RoomType, @Pricr, @Available)", cnMain);
            }
            Build_INSERT_Parameters(obj);
        }

        private void Build_UPDATE_Parameters(Object obj)
        {
            if (obj is Guest)
            {
                SqlParameter param = default(SqlParameter);

                param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 30, "First Name");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@LastName", SqlDbType.NVarChar, 20, "Last Name");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar, 30, "Email");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 10, "ID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.InsertCommand.Parameters.Add(param);
            }
            else if (obj is Reservation)
            {
                SqlParameter param = default(SqlParameter);

                param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 10, "Room Number");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@CheckIn", SqlDbType.Date, 15, "Check In");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@CheckOut", SqlDbType.Date, 15, "Check Out");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@TotalPrice", SqlDbType.Money, 8, "Total Price");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Status", SqlDbType.NVarChar, 20, "Status");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Original_RefNumber", SqlDbType.NVarChar, 10, "Reference Number");
                param.SourceVersion = DataRowVersion.Original;
                daMain.InsertCommand.Parameters.Add(param);

            }
            else if (obj is Room)
            {
                SqlParameter param = default(SqlParameter);

                param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 15, "Room Type");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Price", SqlDbType.Money, 8, "Price");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Available", SqlDbType.Bit, 1, "isAvailable");
                param.SourceVersion = DataRowVersion.Current;
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@Original_RoomNumber", SqlDbType.NVarChar, 10, "Room Number");
                param.SourceVersion = DataRowVersion.Original;
                daMain.InsertCommand.Parameters.Add(param);

            }
        }

        private void Create_UPDATE_Command(Object obj)
        {
            if (obj is Guest)
            {
                daMain.UpdateCommand = new SqlCommand("UPDATE Guests SET [First Name]=@FirstName, [Last Name]=@LastName, Phone=@Phone, Email=@Email WHERE ID=@Orignal_ID", cnMain);
            }
            else if (obj is Reservation)
            {
                daMain.UpdateCommand = new SqlCommand("UPDATE Reservation SET GuestID=@GuestID, [Room Number]=@RoomNumber, [Check In]=@CheckIn, [Check Out]=@CheckOut, [Total Price]=@TotalPrice, Status=@Status WHERE [Reference Number]=@Original_RefNumber", cnMain);
            }
            else if (obj is Room)
            {
                daMain.UpdateCommand = new SqlCommand("UPDATE Room SET [Room Type]=@RoomType, Price=@Price, isAvailable=@Available WHERE [Room Number]=@Original_RoomNumber", cnMain);
            }
            Build_UPDATE_Parameters(obj);
        }

        public bool UpdateDataSource(Object obj)
        {
            bool success = true;
            Create_INSERT_Command(obj);
            Create_UPDATE_Command(obj);
            if (obj is Guest)
            {
                success = UpdateDataSource(dsMain, table1);
            }
            if (obj is Reservation)
            {
                success = UpdateDataSource(dsMain, table2);
            }
            if (obj is Room)
            {
                success = UpdateDataSource(dsMain, table3);
            }
            return success;
        }
        #endregion
    }
}
