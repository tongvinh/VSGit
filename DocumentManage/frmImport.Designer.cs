﻿namespace DocumentManage
{
    partial class frmImport
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHTThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTVanChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::DocumentManage.Properties.Resources.Actions_contact_new_icon__1_;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = global::DocumentManage.Properties.Resources.pencil_icon;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải Lại Dữ Liệu";
            this.btnReload.Id = 3;
            this.btnReload.ImageOptions.Image = global::DocumentManage.Properties.Resources.Button_Refresh_icon;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = global::DocumentManage.Properties.Resources.Close_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1285, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 552);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1285, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1285, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 512);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = global::DocumentManage.Properties.Resources.Bookmark_delete_icon;
            this.btnXoa.Name = "btnXoa";
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 40);
            this.gcData.MainView = this.gvData;
            this.gcData.MenuManager = this.barManager1;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1285, 512);
            this.gcData.TabIndex = 5;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDocument,
            this.colDocumentNumber,
            this.NoTK,
            this.colCoTK,
            this.colDate,
            this.colFromStore,
            this.colToStore,
            this.colDescription,
            this.colIDEmployee,
            this.colEmployeeName,
            this.colPartSent,
            this.colPersonSent,
            this.colSoHopDong,
            this.colSoPO,
            this.colHTThanhToan,
            this.colPTVanChuyen,
            this.colDVTien});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsBehavior.ReadOnly = true;
            this.gvData.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.gvData.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gvData.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvData.OptionsView.ShowAutoFilterRow = true;
            this.gvData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIDDocument, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvData.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gvData_CustomRowFilter);
            this.gvData.Click += new System.EventHandler(this.gvData_Click);
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
            // 
            // colIDDocument
            // 
            this.colIDDocument.Caption = "ID Document";
            this.colIDDocument.FieldName = "IDDocument";
            this.colIDDocument.Name = "colIDDocument";
            this.colIDDocument.Visible = true;
            this.colIDDocument.VisibleIndex = 0;
            this.colIDDocument.Width = 90;
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.Caption = "Document Number";
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.VisibleIndex = 1;
            this.colDocumentNumber.Width = 130;
            // 
            // NoTK
            // 
            this.NoTK.Caption = "No TK";
            this.NoTK.FieldName = "NoTK";
            this.NoTK.Name = "NoTK";
            // 
            // colCoTK
            // 
            this.colCoTK.Caption = "Co TK";
            this.colCoTK.FieldName = "CoTK";
            this.colCoTK.Name = "colCoTK";
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 99;
            // 
            // colFromStore
            // 
            this.colFromStore.Caption = "From";
            this.colFromStore.FieldName = "FromStore";
            this.colFromStore.Name = "colFromStore";
            this.colFromStore.Visible = true;
            this.colFromStore.VisibleIndex = 3;
            this.colFromStore.Width = 91;
            // 
            // colToStore
            // 
            this.colToStore.Caption = "To";
            this.colToStore.FieldName = "ToStore";
            this.colToStore.Name = "colToStore";
            this.colToStore.Visible = true;
            this.colToStore.VisibleIndex = 4;
            this.colToStore.Width = 81;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            this.colDescription.Width = 81;
            // 
            // colIDEmployee
            // 
            this.colIDEmployee.Caption = "ID Employee";
            this.colIDEmployee.FieldName = "IDEmployee";
            this.colIDEmployee.Name = "colIDEmployee";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Employee Name";
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 6;
            this.colEmployeeName.Width = 120;
            // 
            // colPartSent
            // 
            this.colPartSent.Caption = "Sales Department";
            this.colPartSent.FieldName = "PartSent";
            this.colPartSent.Name = "colPartSent";
            this.colPartSent.Visible = true;
            this.colPartSent.VisibleIndex = 8;
            this.colPartSent.Width = 109;
            // 
            // colPersonSent
            // 
            this.colPersonSent.Caption = "Buy At";
            this.colPersonSent.FieldName = "PersonSent";
            this.colPersonSent.Name = "colPersonSent";
            this.colPersonSent.Visible = true;
            this.colPersonSent.VisibleIndex = 7;
            this.colPersonSent.Width = 114;
            // 
            // colSoHopDong
            // 
            this.colSoHopDong.Caption = "Số HD";
            this.colSoHopDong.FieldName = "SoHD";
            this.colSoHopDong.Name = "colSoHopDong";
            this.colSoHopDong.Visible = true;
            this.colSoHopDong.VisibleIndex = 9;
            this.colSoHopDong.Width = 72;
            // 
            // colSoPO
            // 
            this.colSoPO.Caption = "Số PO";
            this.colSoPO.FieldName = "SoPO";
            this.colSoPO.Name = "colSoPO";
            this.colSoPO.Visible = true;
            this.colSoPO.VisibleIndex = 10;
            this.colSoPO.Width = 67;
            // 
            // colHTThanhToan
            // 
            this.colHTThanhToan.Caption = "HT ThanhToan";
            this.colHTThanhToan.FieldName = "HTThanhToan";
            this.colHTThanhToan.Name = "colHTThanhToan";
            this.colHTThanhToan.Visible = true;
            this.colHTThanhToan.VisibleIndex = 11;
            this.colHTThanhToan.Width = 79;
            // 
            // colPTVanChuyen
            // 
            this.colPTVanChuyen.Caption = "Vận Chuyển";
            this.colPTVanChuyen.FieldName = "PTVanChuyen";
            this.colPTVanChuyen.Name = "colPTVanChuyen";
            this.colPTVanChuyen.Visible = true;
            this.colPTVanChuyen.VisibleIndex = 12;
            this.colPTVanChuyen.Width = 69;
            // 
            // colDVTien
            // 
            this.colDVTien.Caption = "ĐV Tiền";
            this.colDVTien.FieldName = "DVTien";
            this.colDVTien.Name = "colDVTien";
            this.colDVTien.Visible = true;
            this.colDVTien.VisibleIndex = 13;
            this.colDVTien.Width = 65;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 552);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmImport";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDocument;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn NoTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCoTK;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFromStore;
        private DevExpress.XtraGrid.Columns.GridColumn colToStore;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartSent;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonSent;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPO;
        private DevExpress.XtraGrid.Columns.GridColumn colHTThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colPTVanChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colDVTien;
    }
}