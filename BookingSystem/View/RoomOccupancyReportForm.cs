using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.View
{
    public partial class RoomOccupancyReportForm : Form
    {
        #region Data Members
        private BookingController bookCtrl;
        private Collection<Room> rooms;
        private DateTime start;
        private DateTime end;
        public bool reportFormClosed = false;
        #endregion

        #region Constructors
        public RoomOccupancyReportForm()
        {
            InitializeComponent();
            bookCtrl = new BookingController();
        }

        public RoomOccupancyReportForm(BookingController bookCtrl)
        {
            InitializeComponent();
            this.bookCtrl = bookCtrl;
        }
        #endregion

        #region Utility Methods
        private void PopulateTextBoxes()
        {
            start = startDTP.Value;
            end = endDTP.Value;
            TimeSpan diff = end - start;
            int days = diff.Days + 1;

            rooms = bookCtrl.AllRooms;
            //Room Number
            R1TB.Text = rooms[0].RoomNumber;
            R2TB.Text = rooms[1].RoomNumber;
            R3TB.Text = rooms[2].RoomNumber;
            R4TB.Text = rooms[3].RoomNumber;
            R5TB.Text = rooms[4].RoomNumber;
            R6TB.Text = rooms[5].RoomNumber;
            R7TB.Text = rooms[6].RoomNumber;
            R8TB.Text = rooms[7].RoomNumber;
            //Occupancy days
            R1occTB.Text = rooms[0].RoomOccupancy(bookCtrl.AllReservations, start, end).ToString();
            textBox10.Text = rooms[1].RoomOccupancy(bookCtrl.AllReservations, start, end).ToString();
            textBox11.Text = rooms[2].RoomOccupancy(bookCtrl.AllReservations,start, end).ToString();
            textBox12.Text = rooms[3].RoomOccupancy(bookCtrl.AllReservations, start, end).ToString();
            textBox13.Text = rooms[4].RoomOccupancy(bookCtrl.AllReservations, start, end).ToString();
            textBox14.Text = rooms[5].RoomOccupancy(bookCtrl.AllReservations, start, end).ToString();
            textBox15.Text = rooms[6].RoomOccupancy(bookCtrl.AllReservations, start, end).ToString();
            textBox16.Text = rooms[7].RoomOccupancy(bookCtrl.AllReservations, start, end).ToString();
            //Days
            textBox17.Text = days.ToString();
            textBox18.Text = days.ToString();
            textBox19.Text = days.ToString();
            textBox20.Text = days.ToString();
            textBox21.Text = days.ToString();
            textBox22.Text = days.ToString();
            textBox23.Text = days.ToString();
            textBox24.Text = days.ToString();
            //Percentage
            textBox1.Text = Math.Round(decimal.Parse(R1occTB.Text) * 100 / decimal.Parse(textBox17.Text), 2).ToString() + "%";
            textBox2.Text = Math.Round(decimal.Parse(textBox10.Text) * 100 / decimal.Parse(textBox18.Text),2).ToString() + "%";
            textBox3.Text = Math.Round(decimal.Parse(textBox11.Text) * 100 / decimal.Parse(textBox19.Text), 2).ToString() + "%";
            textBox4.Text = Math.Round(decimal.Parse(textBox12.Text) * 100 / decimal.Parse(textBox20.Text), 2).ToString() + "%";
            textBox5.Text = Math.Round(decimal.Parse(textBox13.Text) * 100 / decimal.Parse(textBox21.Text), 2).ToString() + "%";
            textBox6.Text = Math.Round(decimal.Parse(textBox14.Text) * 100 / decimal.Parse(textBox22.Text), 2).ToString() + "%";
            textBox7.Text = Math.Round(decimal.Parse(textBox15.Text) * 100 / decimal.Parse(textBox23.Text), 2).ToString() + "%";
            textBox8.Text = Math.Round(decimal.Parse(textBox16.Text) * 100 / decimal.Parse(textBox24.Text), 2).ToString() + "%";
        }

        private void ShowAll(bool value)
        {
            label1.Visible = value;
            label2.Visible = value;
            label3.Visible = value;
            label4.Visible = value;
            label5.Visible = value;
            R1TB.Visible = value;
            R2TB.Visible = value;
            R3TB.Visible = value;
            R4TB.Visible = value;
            R5TB.Visible = value;
            R6TB.Visible = value;
            R7TB.Visible = value;
            R8TB.Visible = value;
            textBox17.Visible = value;
            textBox18.Visible = value;
            textBox19.Visible = value;
            textBox20.Visible = value;
            textBox21.Visible = value;
            textBox22.Visible = value;
            textBox23.Visible = value;
            textBox24.Visible = value;
            R1occTB.Visible = value;
            textBox10.Visible = value;
            textBox11.Visible = value;
            textBox12.Visible = value;
            textBox13.Visible = value;
            textBox14.Visible = value;
            textBox15.Visible = value;
            textBox16.Visible = value;
            textBox1.Visible = value;
            textBox2.Visible = value;
            textBox3.Visible = value;
            textBox4.Visible = value;
            textBox5.Visible = value;
            textBox6.Visible = value;
            textBox7.Visible = value;
            textBox8.Visible = value;
        }
        #endregion

        #region Form Events
        private void RoomOccupancyReportForm_Load(object sender, EventArgs e)
        {
            ShowAll(false);
            startDTP.Value = DateTime.Today;
            endDTP.Value = startDTP.Value.AddDays(1);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ShowAll(true);
            PopulateTextBoxes();

        }

        private void startDTP_ValueChanged(object sender, EventArgs e)
        {
            if (startDTP.Value >= endDTP.Value)
            {
                endDTP.Value = startDTP.Value.AddDays(1);
            }
        }

        private void endDTP_ValueChanged(object sender, EventArgs e)
        {
            if (endDTP.Value <= startDTP.Value)
            {
                endDTP.Value = startDTP.Value.AddDays(1);
            }
        }
        private void RoomOccupancyReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportFormClosed = true;
        }
        #endregion


    }
}
