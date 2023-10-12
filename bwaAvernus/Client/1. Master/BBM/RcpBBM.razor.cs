global using DevExpress.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Pantheon.Client.Controls;

namespace bwaAvernus._1._Master
{
    public partial class RcpBBM : ConMaster_1<uimT0BBM, svcBBM>
    {
        public IGrid GrdHargaBBM { get; set; } 
        public DxFormLayoutItem FliBBM { get; set; }
        public DxFormLayoutItem FliKeterangan { get; set; }
        public DxFormLayoutItem FliHarga { get; set; }

        public DxTextBox TxbBBM { get; set; }
        public DxTextBox TxbKeterangan { get; set; }
        public DxTextBox TxbAlias { get; set; }
        //public DxSpinEdit<decimal?> SpeHarga { get; set; }

        public uimT4HargaBBM DataHarga = new();
        public IList<dynamic> DtGrdHargaBBM { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();

        }
        
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }

        #region Rekapitulasi

        public override async void ProsesSeleksiData(object data)
        {
            base.ProsesSeleksiData(data);
        }
        #endregion

        #region Detil
        public override async Task ProsesMuat_Detil()
        {

            /*ListSpe.AddRange(new BaseSpe[] {
            new BaseSpe() { Spe = SpeHarga, Wajib = true } });*/
            ListTxb.AddRange(new BaseTxb[] {
            new BaseTxb() { Txb = TxbBBM, Wajib = true } });
            await base.ProsesMuat_Detil();
        }

        public void OnItemUpdating(string fieldName, object newValue)
        {
            if (fieldName == nameof(DtRekapitulasi_Terseleksi.BBM))
            {

            }
        }

        private async void OnHargaValueChanged(decimal? harga)
        {
            
        }
        #endregion

        #region Navigasi
        public override async void ProsesUpdateDatabase()
        {
            base.ProsesUpdateDatabase();
        }

        public override void CtmNavigasiShortcut_Press(KeyboardEventArgs e)
        {
            base.CtmNavigasiShortcut_Press(e);
        }
        #endregion


    }
}
