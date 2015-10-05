using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq; 
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS.Views
{
    public partial class RoutingView : BaseView
    {
        bool bLockMode = false;
        bool bEditMode = false;
        int nEditIndex = 0;

        public RoutingView()
        {
            InitializeComponent();
            this.titleStrip1.HeaderText.Text = "Routing";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;
            bLockMode = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                SplashScreen.SetStatus("Loading Routing Module", false);
                this.routeViewTableAdapter.FillBy(this.mMSDataSet.RouteView, "Main");
                this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);
                routeViewDataGridView.Sort(routeViewDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);                
                CustTypeCheckBox_CheckedChanged(null, null);

               
            }
        }
        public override void RefreshView()
        {
            String szRouteName = "Main";

            if (FilterComboBox.SelectedItem != null)
            {
                szRouteName = FilterComboBox.Text.ToString();
                this.routeViewTableAdapter.FillBy(this.mMSDataSet.RouteView, szRouteName);
                routeViewDataGridView.Sort(routeViewDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

                if (szRouteName == "FourStep") FourStepCheckBox.Enabled = true;
                else FourStepCheckBox.Enabled = false;

                CustTypeCheckBox_CheckedChanged(null, null);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            routeViewDataGridView.Sort(routeViewDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);     
        }

        private void reNumberButton_Click(object sender, EventArgs e)
        {
            try
            {
                ReNumberRoute();
            }
            catch (Exception exe)
            {
                MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "RoutingView");
            }
        }

        public void ReNumberRoute()
        {
            routeViewDataGridView.Sort(routeViewDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);     

            int rowIndex = 100;
            System.Windows.Forms.MMS.Data.MMSDataSet.RouteDataTable myRouteDataTable = new System.Windows.Forms.MMS.Data.MMSDataSet.RouteDataTable();
            string szRouteName = FilterComboBox.Text.ToString();
            routeTableAdapter.FillByRouteOrdered(myRouteDataTable, szRouteName);
            foreach (DataRow routerow in myRouteDataTable.Rows)
            {
                string strRouteID = routerow["RouteID"].ToString();
                //string strRouteOrder = routerow["RouteOrder"].ToString();
                //int RouteOrder = Convert.ToInt32(strRouteOrder);

                int RouteID = Convert.ToInt32(strRouteID);
                this.routeTableAdapter.UpdateRouteOrder(rowIndex, RouteID);
                rowIndex += 100;
            }
            RefreshView();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshView();
        }
        private void MapItButton_Click(object sender, EventArgs e)
        {
            string szAddress = "";
            string szCity = "";
            string szState = "";
            MapDialog dlg = new MapDialog();

            foreach (DataGridViewRow row in routeViewDataGridView.SelectedRows)
            {
                szAddress = row.Cells[5].Value.ToString();
                szCity = row.Cells[6].Value.ToString();
                szState = row.Cells[7].Value.ToString();
                szAddress = szAddress + " ," + szCity + " ," + szState;
                dlg.AddLocation(szAddress);
            }

            dlg.ShowDialog();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete the Selected Job?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string routeID = this.routeViewDataGridView.SelectedCells[0].Value.ToString();
                int nIndex = this.routeViewDataGridView.CurrentRow.Index;

                if (this.routeViewDataGridView.RowCount == 1)
                    this.routeViewDataGridView.CurrentCell = null;
                else if (nIndex >= this.routeViewDataGridView.RowCount - 1)
                    this.routeViewDataGridView.CurrentCell = this.routeViewDataGridView.Rows[nIndex - 1].Cells[1];
                else
                    this.routeViewDataGridView.CurrentCell = this.routeViewDataGridView.Rows[nIndex + 1].Cells[1];
                this.routeTableAdapter.DeleteRoute(Convert.ToInt32(routeID));

                RefreshView();  //Andy - must change to remove row only in the grid
                MMSUtility.PlayAcceptSound();
            }
        }

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        private void routeViewDataGridView_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = routeViewDataGridView.DoDragDrop(
                    routeViewDataGridView.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void routeViewDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = routeViewDataGridView.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;
                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                e.Y - (dragSize.Height / 2)),
                dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;

        }

        private void routeViewDataGridView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void routeViewDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = routeViewDataGridView.PointToClient(new Point(e.X, e.Y));
            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = routeViewDataGridView.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                MoveRowEntryOrder(rowIndexFromMouseDown, rowIndexOfItemUnderMouseToDrop);                
            }

        }

        private void MoveRowEntryOrder(int fromRow, int toRow)
        {
            if (fromRow == toRow) return;

            int rowMax = routeViewDataGridView.Rows.Count - 1;
            if (toRow > rowMax) toRow = rowMax;
            if (toRow < 0) toRow = 0;

            if (fromRow < toRow)
            {                
                DataGridViewRow dataGridViewRow = routeViewDataGridView.Rows[fromRow];
                dataGridViewRow.Cells[1].Value = toRow;
                int routeID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());

                for (int i = fromRow+1; i <= toRow; i++)
                {
                    dataGridViewRow = routeViewDataGridView.Rows[i];
                    dataGridViewRow.Cells[1].Value = i-1;
                    int rID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                    this.routeTableAdapter.UpdateRouteOrder(i-1, rID);
                }

                this.routeTableAdapter.UpdateRouteOrder(toRow, routeID);
            } 
            else //fromRow > toRow
            {/*
                DataGridViewRow dataGridViewRow = routeViewDataGridView.Rows[fromRow];
                dataGridViewRow.Cells[1].Value = toRow;
                int routeID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                

                for (int i = toRow; i < fromRow; i++)
                {
                    dataGridViewRow = routeViewDataGridView.Rows[i];
                    dataGridViewRow.Cells[1].Value = i + 1;
                    int rID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                    this.routeTableAdapter.UpdateRouteOrder(i+1, rID);
                }

                this.routeTableAdapter.UpdateRouteOrder(toRow, routeID);
               */
                DataGridViewRow dataGridViewRow = routeViewDataGridView.Rows[fromRow];
                dataGridViewRow.Cells[1].Value = toRow;
                int routeID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());


                for (int i = fromRow-1; i >= toRow; i--)
                {
                    dataGridViewRow = routeViewDataGridView.Rows[i];
                    dataGridViewRow.Cells[1].Value = i + 1;
                    int rID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                    this.routeTableAdapter.UpdateRouteOrder(i + 1, rID);
                }

                this.routeTableAdapter.UpdateRouteOrder(toRow, routeID);


            }

            routeViewDataGridView.Sort(routeViewDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            routeViewDataGridView.CurrentCell = routeViewDataGridView.Rows[toRow].Cells[1];
            routeViewDataGridView.Rows[toRow].Selected = true;
        }

        private void moveUpToolStripButton_Click(object sender, EventArgs e)
        {
            int index = routeViewDataGridView.CurrentRow.Index;            
            MoveRowEntryOrder(index, index-1);                

        }

        private void moveDownToolStripButton_Click(object sender, EventArgs e)
        {
            int index = routeViewDataGridView.CurrentRow.Index;
            MoveRowEntryOrder(index, index+1);                

        }

        private void moveUpNexToolStripButton_Click(object sender, EventArgs e)
        {
            int index = routeViewDataGridView.CurrentRow.Index;
            MoveRowEntryOrder(index, index - 10);                

        }

        private void moveDownNextToolStripButton_Click(object sender, EventArgs e)
        {
            int index = routeViewDataGridView.CurrentRow.Index;
            MoveRowEntryOrder(index, index + 10);                
        }

        private void CustTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string szFilter = "Active = 'True'";
            if (CustTypeCheckBox.Checked)
            {
                szFilter += " AND GroupType = 'Current'";

            }

            string szRouteName = FilterComboBox.Text.ToString();
            if ((szRouteName == "FourStep")&&(FourStepCheckBox.Checked))
            {
                szFilter += " AND FourStepType = 'True'";
            }

            routeViewBindingSource.Filter = szFilter;
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            bLockMode = true;

        }

        private void routeViewDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (nEditIndex < 0) return;
            //DataGridViewRow dataGridViewRow = routeViewDataGridView.Rows[e.RowIndex];
  
            //DataGridViewRow dataGridViewRow = routeViewDataGridView.CurrentRow;      
            //int rID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
            //int Route = Convert.ToInt32(dataGridViewRow.Cells[1].Value.ToString());
            //this.routeTableAdapter.UpdateRouteOrder(Route, rID);
            //bEditMode = false;
        }

        private void routeViewDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (bEditMode)
            {
                //routeViewBindingSource.EndEdit();
                //routeViewDataGridView_CellEndEdit(null, null);
            }
        }

        private void routeViewDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           //nEditIndex = routeViewDataGridView.CurrentRow.Index;
           bEditMode = true;
        }

        private void routeViewDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (bEditMode)
            {
                DataGridViewRow dataGridViewRow = routeViewDataGridView.CurrentRow;
                int rID = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
                int Route = Convert.ToInt32(dataGridViewRow.Cells[1].Value.ToString());
                this.routeTableAdapter.UpdateRouteOrder(Route, rID);
                bEditMode = false;
            }

        }

    }
}
