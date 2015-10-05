using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
	public class BaseView : UserControl
	{
		private bool	_viewable=true;
		private object	_dataSource=null;
        private int _nMode = 0;

		public BaseView()
		{
			// Initialize
			InitializeComponent();
		}

		#region Public API
		public object DataSource
		{
			get { return _dataSource; }
			set
			{
				_dataSource = value;
				OnSetDataSource(_dataSource);
			}
		}

        public virtual bool Viewable
		{
			get { return _viewable; }
			set
			{
				_viewable = value;

				if (_viewable)
				{
					// Make visible
					this.Dock = DockStyle.Fill;
					this.Visible = true;
				}
				else
				{
					// Hide
					this.Visible = false;
					this.Dock = DockStyle.None;
					this.Location = new Point(0, 0);
					this.Size = new Size(100, 100);
				}
			}
		}

        public virtual void RefreshView()
        {
        }        
      
        public int EditMode
        {
            get { return _nMode; }
            set
            {
                _nMode = value;
            }
        }

        public virtual void PageSetup()
        {
            MessageBox.Show("Not yet implemented");
        }
        public virtual void PrintSheets()
        {
            MessageBox.Show("Not yet implemented");
        }
        public virtual void Print()
        {
            MessageBox.Show("Not yet implemented");
        }
        public virtual void PrintPreview()
        {
            MessageBox.Show("Not yet implemented");
        }
        public virtual void EditFunction(string szFunction)
        {
            MessageBox.Show("Not yet implemented");
        }
		#endregion

		#region Protected API
		protected virtual void OnSetDataSource(object dataSource) {}
		protected override void OnLoad(EventArgs e)
		{
			// Call base
			base.OnLoad(e);
		}
		#endregion

		#region Designer Generated
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // BaseView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Name = "BaseView";
            this.Size = new System.Drawing.Size(881, 663);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
