using Business.Abstract.Interfaces;
using Businesss.Abstract.Interfaces;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Entitiess.Abstract.Base;
using Entitiess.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;
using Windows.UI.Abstract.Interfaces;

namespace Windows.UI.Concrete.UseControls.Base
{
    public partial class BaseTablo : DevExpress.XtraEditors.XtraUserControl
    {
        private bool _isLoaded;
        private bool _tabloSablonKaydet;
        protected GridView Tablo;
        protected internal bool TableValueChanged;
        protected internal BaseEditForm OwnerForm;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;
        protected IList<long> ListeDisiTutulacakKayitlar;

        public BaseTablo()
        {
            InitializeComponent();
        }

        protected void EventLoad()
        {
            // Button Events
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;

            //Navigator Events
            insUpNavigator.controlNavigator1.ButtonClick += ControlNavigator1_ButtonClick;


            //Table Events
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.GotFocus += Tablo_GotFocus; // tabloya tıkladıgında tablo ile alakalı olan acıklamaları getiriyoruz.
            Tablo.LostFocus += Tablo_LostFocus1; // forma tıkladıgında dorm ile alakalı olan acıklamaları getırıyoruz.
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            Tablo.ColumnPositionChanged += Tablo_SablonChanged;
            Tablo.ColumnWidthChanged += Tablo_SablonChanged;
            Tablo.EndSorting += Tablo_SablonChanged;

        }

        private void SablonKaydet()
        {
            if (_tabloSablonKaydet)
                Tablo.TabloSablonKaydet(Tablo.ViewCaption);
        }

        private void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);
        }

        private void ButtonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected void ButonEnabledDurum(bool durum)
        {
            TableValueChanged = durum;
            OwnerForm.ButonEnabledDurum();
        }

        protected internal virtual bool HataliGiris() { return false; }

        protected virtual void Listele() { }

        protected virtual void HareketEkle() { }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;

            Tablo.GetRow<IBaseHareketEntity>().Delete = true;
            Tablo.RefreshDataSource();
            ButonEnabledDurum(true);
        }

        protected internal void Yukle()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButonEnabledDurum();
            insUpNavigator.controlNavigator1.NavigatableControl = Tablo.GridControl;
            SablonYukle();
            Listele();
            ButtonGizleGoster();
            Tablo_LostFocus(Tablo, EventArgs.Empty);
        }

        protected internal bool Kaydet()
        {
            insUpNavigator.controlNavigator1.Buttons.DoClick(insUpNavigator.controlNavigator1.Buttons.EndEdit);//row değer girildiğinde kaydete bastıgında girilen deger onaylanıp kayıt olması için

            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<IBaseHareketEntity>().Where(x => x.Update && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())//herhangi bir değer var ise
                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Eklenemedi.");
                    return false;
                }

            if (update.Any())//herhangi bir değer var ise
                if (!((IBaseHareketGenelBll)Bll).Update(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Güncellenemedi.");
                    return false;
                }

            if (delete.Any())//herhangi bir değer var ise
                if (!((IBaseHareketGenelBll)Bll).Delete(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Silinemedi.");
                    return false;
                }

            ButonEnabledDurum(false);
            return true;
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnHareketEkle)
                HareketEkle();
            else if (e.Item == btnHareketSil)
                HareketSil();

            Cursor.Current = DefaultCursor;
        }

        private void ControlNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == insUpNavigator.controlNavigator1.Buttons.Append)
                HareketEkle();
            else if (e.Button == insUpNavigator.controlNavigator1.Buttons.Remove)
                HareketSil();

            //Default Ayarlarını Devre Dışı Bırak
            if (e.Button == insUpNavigator.controlNavigator1.Buttons.Append || e.Button == insUpNavigator.controlNavigator1.Buttons.Remove)
                e.Handled = true;
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (!entity.Insert)
                entity.Update = true;

            ButonEnabledDurum(true);
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;

            btnHareketSil.Enabled = Tablo.RowCount > 0;

            e.SagMenuGoster(popupMenu);
        }

        private void Tablo_GotFocus(object sender, EventArgs e)
        {

            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

            OwnerForm.statusBarAciklama.Caption = ((ISatusBarAciklama)sender).StatusBarAciklama;
            OwnerForm.statusBarKisayol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisayol;
            OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisayolAciklama;
        }

        private void Tablo_LostFocus1(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)//Tabloda Yazma Durumuna Girilmişse
                        insUpNavigator.controlNavigator1.Buttons.DoClick(insUpNavigator.controlNavigator1.Buttons.CancelEdit);
                    else
                        OwnerForm.Close();
                    break;

                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    insUpNavigator.controlNavigator1.Buttons.DoClick(insUpNavigator.controlNavigator1.Buttons.EndEdit);
                    break;

                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;

                case Keys.Delete when e.Shift:
                    HareketSil();
                    break;

            }
        }

        protected virtual void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (OwnerForm == null) return;
            OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;

            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, null);

            else if (((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisayol != null)
            {
                OwnerForm.statusBarKisayol.Visibility = BarItemVisibility.Always;
                OwnerForm.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                OwnerForm.statusBarAciklama.Caption = ((ISatusBarAciklama)e.FocusedColumn).StatusBarAciklama;
                OwnerForm.statusBarKisayol.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisayol;
                OwnerForm.statusBarKisayolAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisayolAciklama;
            }

            else if (((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama != null)
                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;

        }

        private void Tablo_SablonChanged(object sender, EventArgs e)
        {
            _tabloSablonKaydet = true;
            SablonKaydet();
        }


    }
}
