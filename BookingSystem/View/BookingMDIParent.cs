﻿using BookingSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem.View
{
    public partial class BookingMDIParent : Form
    {
        private int childFormNumber = 0;
        MakeBookingForm makeBookingForm;
        NewGuestForm newGuestForm;
        BookingListForm bookingListForm;
        RoomOccupancyReportForm roomOccupancyReportForm;
        BookingController bookCtrl;

        public BookingMDIParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            bookCtrl = new BookingController();
        }

        #region ToolStrip Menus
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion

        #region ToolStrip Reservation
        private void createNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (makeBookingForm == null)
            {
                CreateMakeBookingForm();
            }
            if (makeBookingForm.makeBookingFormClosed)
            {
                CreateMakeBookingForm();
            }
            makeBookingForm.Show();
        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newGuestForm == null)
            {
                CreateNewGuestForm();
            }
            if (newGuestForm.newGuestFormClosed)
            {
                CreateNewGuestForm();
            }
            newGuestForm.Show();
        }

        private void changeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookingListForm == null)
            {
                CreateBookingListForm();
            }
            if (bookingListForm.bookingListFormClosed)
            {
                CreateBookingListForm();
            }
            bookingListForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (roomOccupancyReportForm == null)
            {
                CreateReportForm();
            }
            if (roomOccupancyReportForm.reportFormClosed)
            {
                CreateReportForm();
            }
            roomOccupancyReportForm.Show();
        }
        #endregion

        #region Create a New ChildForm
        private void CreateMakeBookingForm()
        {
            makeBookingForm = new MakeBookingForm(bookCtrl);
            makeBookingForm.MdiParent = this;
            makeBookingForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateNewGuestForm()
        {
            newGuestForm = new NewGuestForm(bookCtrl);
            newGuestForm.MdiParent = this;
            newGuestForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateBookingListForm()
        {
            bookingListForm = new BookingListForm();
            bookingListForm.MdiParent = this;
            bookingListForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateReportForm()
        {
            roomOccupancyReportForm = new RoomOccupancyReportForm();
            roomOccupancyReportForm.MdiParent = this;
            roomOccupancyReportForm.StartPosition = FormStartPosition.CenterParent;
        }
        #endregion
    }
}
