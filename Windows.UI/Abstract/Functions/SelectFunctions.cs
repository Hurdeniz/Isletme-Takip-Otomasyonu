using Entities.Concrete;
using Entitiess.Concrete;
using Entitiess.Dto;
using Model.Enums;
using Model.Show;
using System;
using System.ComponentModel;
using Windows.UI.Abstract.Show;
using Windows.UI.Concrete.Forms.GrupForms;
using Windows.UI.Concrete.Forms.IlceForms;
using Windows.UI.Concrete.Forms.IlForms;
using Windows.UI.Concrete.Forms.IsletmeForms;
using Windows.UI.Concrete.Forms.IsletmeKullanici;
using Windows.UI.Concrete.Forms.IsletmeSahibiForms;
using Windows.UI.Concrete.Forms.PompaForms;
using Windows.UI.Concrete.Forms.SevkiyatForms;
using Windows.UI.Concrete.Forms.UrunIsletmeForms;
using Windows.UI.Concrete.UseControls.Controls;

namespace Windows.UI.Abstract.Functions
{
    public class SelectFunctions : IDisposable
    {
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private KartTuru _kartTuru;

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }
        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "btnEditIl":

                    {
                        var entity = (Il)ShowListForm<IlListForm>.ShowDialogListForm(KartTuru.Il, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;

                case "btnEditIlce":

                    {
                        var entity = (Ilce)ShowListForm<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;
                case "btnGrupKod":
                    {
                        var entity = (GrupKod)ShowListForm<GrupListForm>.ShowDialogListForm(KartTuru.Grup, _btnEdit.Id, GrupKodTuru.GrupKod, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GrupKodAdi;
                        }
                    }
                    break;

                case "btnEditPompaDurum":

                    {
                        var entity = (Pompa)ShowListForm<PompaListForm>.ShowDialogListForm(KartTuru.Pompa, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.PompaAdi;
                        }
                    }
                    break;

                case "btnEditIsletme":
                    {
                        var entity = (IsletmeL)ShowListForm<IsletmeListForm>.ShowDialogListForm(KartTuru.Isletme, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IsletmeAdi;
                        }
                    }
                    break;
                case "btnEditIsletmeKullanici":
                    {
                        var entity = (IsletmeKullaniciKisi)ShowListForm<IsletmeKullaniciListForm>.ShowDialogListForm(KartTuru.KullaniciKisi, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KullaniciKisiAdiSoyadi;
                        }
                    }
                    break;
                case "btnEditIsletmeSahibi":
                    {
                        var entity = (IsletmeSahibi)ShowListForm<IsletmeSahibiListForm>.ShowDialogListForm(KartTuru.IsletmeSahibi, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.AdiSoyadi;
                        }
                    }
                    break;

                case "btnEditGeldigiYer":
                    {
                        var entity = (UrunIsletmeL)ShowListForm<UrunIsletmeListForm>.ShowDialogListForm(KartTuru.UrunIsletme, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.UrunIsletmeAdi;
                        }
                    }
                    break;

            }
            

        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
