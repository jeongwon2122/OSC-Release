
namespace X32OCSControl
{
    partial class FrmLinkEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLinkEditor));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsX32ChannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colindex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchannel_group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchannel_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsX32ChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.clsX32ChannelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 583);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsX32ChannelBindingSource
            // 
            this.clsX32ChannelBindingSource.DataSource = typeof(X32OSCControl.Data.clsX32Channel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colindex,
            this.colchannel_group,
            this.colchannel_name,
            this.colIsChecked});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "열 헤더를 여기에 끌어다 놓으면 해당 열로 그룹화됩니다.";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colindex
            // 
            this.colindex.FieldName = "index";
            this.colindex.Name = "colindex";
            this.colindex.OptionsColumn.AllowEdit = false;
            this.colindex.OptionsColumn.AllowFocus = false;
            this.colindex.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colindex.Visible = true;
            this.colindex.VisibleIndex = 0;
            this.colindex.Width = 76;
            // 
            // colchannel_group
            // 
            this.colchannel_group.FieldName = "channel_group";
            this.colchannel_group.Name = "colchannel_group";
            this.colchannel_group.OptionsColumn.AllowEdit = false;
            this.colchannel_group.OptionsColumn.AllowFocus = false;
            this.colchannel_group.Visible = true;
            this.colchannel_group.VisibleIndex = 1;
            this.colchannel_group.Width = 242;
            // 
            // colchannel_name
            // 
            this.colchannel_name.FieldName = "channel_name";
            this.colchannel_name.Name = "colchannel_name";
            this.colchannel_name.OptionsColumn.AllowEdit = false;
            this.colchannel_name.OptionsColumn.AllowFocus = false;
            this.colchannel_name.Visible = true;
            this.colchannel_name.VisibleIndex = 2;
            this.colchannel_name.Width = 284;
            // 
            // colIsChecked
            // 
            this.colIsChecked.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.colIsChecked.AppearanceHeader.Options.UseForeColor = true;
            this.colIsChecked.FieldName = "IsChecked";
            this.colIsChecked.Name = "colIsChecked";
            this.colIsChecked.Visible = true;
            this.colIsChecked.VisibleIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(581, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "저장";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(681, 601);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "닫기";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLinkEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(778, 636);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridControl1);
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "FrmLinkEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "순서 채널 음소거 설정";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsX32ChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colindex;
        private DevExpress.XtraGrid.Columns.GridColumn colchannel_group;
        private DevExpress.XtraGrid.Columns.GridColumn colchannel_name;
        private System.Windows.Forms.BindingSource clsX32ChannelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIsChecked;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}